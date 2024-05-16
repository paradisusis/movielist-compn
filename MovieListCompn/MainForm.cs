
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MovieFileLibrary;

namespace MovieListCompn
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MovieListCompn.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Clear text boxes
            this.firstListTextBox.Clear();
            this.secondListTextBox.Clear();

            // Reset status
            this.statusValueToolStripStatusLabel.Text = "collection";
        }

        /// <summary>
        /// Handles the process button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnProcessButtonClick(object sender, EventArgs e)
        {
            // Check first list
            if (this.firstListTextBox.Text.Length == 0 || !File.Exists(this.firstListTextBox.Text))
            {
                // Focus
                this.firstListTextBox.Focus();

                // Halt flow
                return;
            }

            // Check second list
            if (this.secondListTextBox.Text.Length == 0 || !File.Exists(this.secondListTextBox.Text))
            {
                // Focus
                this.secondListTextBox.Focus();

                // Halt flow
                return;
            }

            // If nothing must be processed, exit
            if (!this.matchesToolStripMenuItem.Checked && !this.unmatchedToolStripMenuItem.Checked)
            {
                // Halt flow
                return;
            }

            // Advise and disable
            this.statusValueToolStripStatusLabel.Text = "processing...";
            this.processButton.Enabled = false;

            /* Set MofileFile lists */

            // Set first list movie files
            List<MovieFile> firstList = new List<MovieFile>();

            // Set second list movies
            List<MovieFile> secondList = new List<MovieFile>();

            /* Populate with movies */

            // Set movie detector
            var detector = new MovieDetector();

            // Populate first list
            foreach (var moviePath in File.ReadAllLines(this.firstListTextBox.Text))
            {
                // Add movie file
                firstList.Add(detector.GetInfo(moviePath));
            }

            // Populate second list
            foreach (var moviePath in File.ReadAllLines(this.secondListTextBox.Text))
            {
                // Add movie file
                secondList.Add(detector.GetInfo(moviePath));
            }

            /* Post processing */

            // TODO Remove prepended year from first list [DRY, function]
            for (int i = 0; i < firstList.Count; i++)
            {
                // Set title words list
                var titleWords = new List<string>(firstList[i].Title.Split(' '));

                // Check if there are 2+ words and first one is numeric
                if (titleWords.Count > 0 && int.TryParse(titleWords[0], out _))
                {
                    // Remove first word
                    titleWords.RemoveAt(0);

                    // Update title
                    firstList[i].Title = string.Join(" ", titleWords);
                }
            }

            // TODO Remove prepended year from second list [DRY, function]
            for (int i = 0; i < secondList.Count; i++)
            {
                // Set title words list
                var titleWords = new List<string>(secondList[i].Title.Split(' '));

                // Check if there are 2+ words and first one is numeric
                if (titleWords.Count > 0 && int.TryParse(titleWords[0], out _))
                {
                    // Remove second word
                    titleWords.RemoveAt(0);

                    // Update title
                    secondList[i].Title = string.Join(" ", titleWords);
                }
            }

            //#
            /*var movieTitles = new List<string>();

            foreach (var movie in firstList)
            {
                movieTitles.Add(movie.Title);
            }

            File.WriteAllLines("firstList.txt", movieTitles);

            movieTitles.Clear();

            foreach (var movie in firstList)
            {
                movieTitles.Add(movie.Title);
            }

            File.WriteAllLines("secondList.txt", movieTitles);*/

            /* Set matches */

            // Collect the matches
            var matchesCollection = firstList.Where(y => secondList.Any(z => z.Title.ToLowerInvariant() == y.Title.ToLowerInvariant()));

            // The matches (sorted) dictionary
            var matchesDictionary = new SortedDictionary<string, string>();

            // Populate matches dictionary
            foreach (var movieMatch in matchesCollection)
            {
                // Lowercase title
                string titleLc = movieMatch.Title.ToLowerInvariant();

                // Collect first list matches
                var firstListMatches = firstList.Where(x => x.Title.ToLower() == titleLc);

                // Collect second list matches
                var secondListMatches = secondList.Where(x => x.Title.ToLower() == titleLc);

                // Check it's unique
                if (!matchesDictionary.ContainsKey(titleLc))
                {
                    // Add current movie to dictionary
                    matchesDictionary.Add(movieMatch.Title.ToLowerInvariant(), $"{movieMatch.Title}{Environment.NewLine}First list:{Environment.NewLine}{string.Join(Environment.NewLine, firstListMatches.Select(f => f.Path).ToList())}{Environment.NewLine}Second list:{Environment.NewLine}{string.Join(Environment.NewLine, secondListMatches.Select(s => s.Path).ToList())}");
                }
            }

            // Check if must process matches
            if (this.matchesToolStripMenuItem.Checked)
            {
                // Empty file name
                this.saveFileDialog.FileName = "MovieList-matches.txt";

                // Open save file dialog
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
                {
                    try
                    {
                        // Save to disk
                        File.WriteAllText(this.saveFileDialog.FileName, string.Join($"{Environment.NewLine}{Environment.NewLine}", matchesDictionary.Values));
                    }
                    catch (Exception exception)
                    {
                        // Inform user
                        MessageBox.Show($"Error when saving to \"{Path.GetFileName(this.saveFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Check if must process unmatched
            if (this.unmatchedToolStripMenuItem.Checked)
            {
                // Empty file name
                this.saveFileDialog.FileName = "MovieList-unmatched.txt";

                // Open save file dialog
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
                {
                    // Unmatched collection
                    string unmatchedCollection = string.Empty;

                    // First unmatched list
                    var firstUnmatchedList = new List<string>();

                    // TODO Compare against matched dictionary [Logic can be improved]
                    foreach (var movie in firstList)
                    {
                        // Check for a match
                        if (!matchesDictionary.ContainsKey(movie.Title.ToLowerInvariant()))
                        {
                            // Add to unmatched list
                            firstUnmatchedList.Add(movie.Path);
                        }
                    }

                    // Check there are unmatched items
                    if (firstUnmatchedList.Count > 0)
                    {
                        // Sort unmatched list
                        firstUnmatchedList.Sort();

                        // Add to unmatched collection
                        unmatchedCollection = $"First list:{Environment.NewLine}";
                        unmatchedCollection += string.Join(Environment.NewLine, firstUnmatchedList);
                    }

                    // Second unmatched list
                    var secondUnmatchedList = new List<string>();

                    // TODO Compare against matched dictionary [Logic can be improved]
                    foreach (var movie in secondList)
                    {
                        // Check for a match
                        if (!matchesDictionary.ContainsKey(movie.Title.ToLowerInvariant()))
                        {
                            // Add to unmatched list
                            secondUnmatchedList.Add(movie.Path);
                        }
                    }

                    // Check there are unmatched items
                    if (secondUnmatchedList.Count > 0)
                    {
                        // Sort unmatched list
                        secondUnmatchedList.Sort();

                        // Add to unmatched collection
                        unmatchedCollection += $"{(firstUnmatchedList.Count > 0 ? $"{Environment.NewLine}{Environment.NewLine}" : string.Empty)}Second list:{Environment.NewLine}";
                        unmatchedCollection += string.Join(Environment.NewLine, secondUnmatchedList);
                    }

                    try
                    {
                        // Save to disk
                        File.WriteAllText(this.saveFileDialog.FileName, unmatchedCollection);
                    }
                    catch (Exception exception)
                    {
                        // Inform user
                        MessageBox.Show($"Error when saving to \"{Path.GetFileName(this.saveFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            // Advise and enable
            this.statusValueToolStripStatusLabel.Text = "processed";
            this.processButton.Enabled = true;
        }

        /// <summary>
        /// Handles the first list browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFirstListBrowseButtonClick(object sender, EventArgs e)
        {
            // Reset file name
            this.openFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileName.Length > 0)
            {
                // Set the file into text box
                this.firstListTextBox.Text = this.openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Handles the second list browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSecondListBrowseButtonClick(object sender, EventArgs e)
        {
            // Reset file name
            this.openFileDialog.FileName = string.Empty;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileName.Length > 0)
            {
                // Set the file into text box
                this.secondListTextBox.Text = this.openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the more releases paradisusis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMoreReleasesParadisusisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our site's releases portal
            Process.Start("https://paradisus.is/releases/");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=54168.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/paradisusis/movielist-compn");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
