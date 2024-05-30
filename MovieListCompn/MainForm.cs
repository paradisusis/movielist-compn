﻿// <copyright file="MainForm.cs" company="Paradisus.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace MovieListCompn
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Windows.Forms;
    using MovieFileLibrary;
    using ParadisusIs;

    /// <summary>
    /// MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MovieListCompn.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            /* Set icons */

            // Set associated icon 
            this.associatedIcon = this.Icon;
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

            // Reset tabs
            this.ResetTabPages();

            // Reset status
            this.statusValueToolStripStatusLabel.Text = "collection";

            // Focus first list
            this.firstListTextBox.Focus();
        }

        /// <summary>
        /// Handles the save tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            /* Matches */

            // Check there's something to save
            if (this.matchesRichTextBox.TextLength > 0)
            {
                // Empty file name
                this.saveFileDialog.FileName = "MovieList-matches.txt";

                // Open save file dialog
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
                {
                    try
                    {
                        // Save to disk
                        File.WriteAllText(this.saveFileDialog.FileName, this.matchesRichTextBox.Text);
                    }
                    catch (Exception exception)
                    {
                        // Inform user
                        MessageBox.Show($"Error when saving to \"{Path.GetFileName(this.saveFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            /* Unmatched */

            // Check there's something to save
            if (this.unmatchedRichTextBox.TextLength > 0)
            {
                // Empty file name
                this.saveFileDialog.FileName = "MovieList-unmatched.txt";

                // Open save file dialog
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
                {
                    try
                    {
                        // Save to disk
                        File.WriteAllText(this.saveFileDialog.FileName, this.unmatchedRichTextBox.Text);
                    }
                    catch (Exception exception)
                    {
                        // Inform user
                        MessageBox.Show($"Error when saving to \"{Path.GetFileName(this.saveFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            /* Collisions */

            // Check there's something to save
            if (this.collisionsRichTextBox.TextLength > 0)
            {
                // Empty file name
                this.saveFileDialog.FileName = "MovieList-collisions.txt";

                // Open save file dialog
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
                {
                    try
                    {
                        // Save to disk
                        File.WriteAllText(this.saveFileDialog.FileName, this.collisionsRichTextBox.Text);
                    }
                    catch (Exception exception)
                    {
                        // Inform user
                        MessageBox.Show($"Error when saving to \"{Path.GetFileName(this.saveFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Resets the tab pages.
        /// </summary>
        private void ResetTabPages()
        {
            // Reset tab text
            this.matchesTabPage.Text = "Matches";
            this.unmatchedTabPage.Text = "Unmatched";
            this.collisionsTabPage.Text = "Collisions";

            // Reset text boxes
            this.matchesRichTextBox.ResetText();
            this.unmatchedRichTextBox.ResetText();
            this.collisionsRichTextBox.ResetText();
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
            if ((this.firstListTextBox.Text == this.secondListTextBox.Text) || (!this.matchesToolStripMenuItem.Checked && !this.unmatchedToolStripMenuItem.Checked && !this.collisionsToolStripMenuItem.Checked))
            {
                // Halt flow
                return;
            }

            // Reset tab pages
            this.ResetTabPages();

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
                // Check for empty
                if (moviePath.Length == 0)
                {
                    // Skip iteration
                    continue;
                }

                // Add movie file
                firstList.Add(detector.GetInfo(moviePath));
            }

            // Populate second list
            foreach (var moviePath in File.ReadAllLines(this.secondListTextBox.Text))
            {
                // Check for empty
                if (moviePath.Length == 0)
                {
                    // Skip iteration
                    continue;
                }

                // Add movie file
                secondList.Add(detector.GetInfo(moviePath));
            }

            /** Pre-processing **/

            /* List caching */

            // Set first list cache
            List<string> firstListCache = new List<string>(firstList.Select(x => x.Title).ToList<string>());

            // Set second list cache
            List<string> secondListCache = new List<string>(secondList.Select(x => x.Title).ToList<string>());

            /* Folding and stripping punctuation */

            // TODO Process first list [Single pass]
            for (int i = 0; i < firstList.Count; i++)
            {
                // Fold current foreign characters to ascii and strip punctuation
                firstList[i].Title = new string(firstList[i].Title.FoldToASCII().Where(c => !char.IsPunctuation(c)).ToArray());

                // TODO DRY it with a function
                string tempTitle = firstList[i].Title;
                char[] tempTitlePunctuation = tempTitle.Where(Char.IsPunctuation).Distinct().ToArray();
                IEnumerable<string> tempTitleWords = tempTitle.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim(tempTitlePunctuation));

                // Set processed string into title
                firstList[i].Title = string.Join(" ", tempTitleWords);
            }

            // TODO Process second list [Single pass]
            for (int i = 0; i < secondList.Count; i++)
            {
                // Fold current foreign characters to ascii and strip punctuation
                secondList[i].Title = new string(secondList[i].Title.FoldToASCII().Where(c => !char.IsPunctuation(c)).ToArray());

                // TODO DRY it with a function
                string tempTitle = secondList[i].Title;
                char[] tempTitlePunctuation = tempTitle.Where(Char.IsPunctuation).Distinct().ToArray();
                IEnumerable<string> tempTitleWords = tempTitle.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim(tempTitlePunctuation));

                // Set processed string into title
                secondList[i].Title = string.Join(" ", tempTitleWords);
            }

            /* Prepended year */

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

            /* Lowercase all titles */

            // First list
            foreach (var item in firstList)
            {
                // Set lowercase title
                item.Title = item.Title.ToLowerInvariant();
            }

            // Second list
            foreach (var item in secondList)
            {
                // Set lowercase title
                item.Title = item.Title.ToLowerInvariant();
            }

            /* Remove function words */

            // Set the function words list
            List<string> functionWordsList = new List<string>() { "a", "an", "the", "this", "that", "these", "those", "my", "your", "their", "our", "some", "many", "few", "all", "and", "but", "or", "so", "because", "although", "in", "of", "on", "with", "by", "at", "over", "under", "he", "she", "it", "they", "we", "you", "me", "him", "her", "is", "am", "are", "was", "were", "has", "have", "had", "can", "could", "may", "might", "shall", "should", "will", "would", "must", "who", "what", "when", "where", "why", "how" };

            // Remove function words on first list
            for (int i = 0; i < firstList.Count; i++)
            {
                // Set title words list
                var titleWords = new List<string>(firstList[i].Title.Split(' '));

                // Check there are 2+ words 
                if (titleWords.Count < 2)
                {
                    // Skip iteration
                    continue;
                }

                // TODO Remove function words [Can improve logic]
                var tempTitleWords = titleWords.Except(functionWordsList);

                // Check there are words left
                if (tempTitleWords.Count() > 1)
                {
                    // Update title
                    firstList[i].Title = string.Join(" ", tempTitleWords);
                }
            }

            // Remove function words on second list
            for (int i = 0; i < secondList.Count; i++)
            {
                // Set title words list
                var titleWords = new List<string>(secondList[i].Title.Split(' '));

                // Check there are 2+ words 
                if (titleWords.Count < 2)
                {
                    // Skip iteration
                    continue;
                }

                // TODO Remove function words [Can improve logic]
                var tempTitleWords = titleWords.Except(functionWordsList);

                // Check there are words left
                if (tempTitleWords.Count() > 1)
                {
                    // Update title
                    secondList[i].Title = string.Join(" ", tempTitleWords);
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

            /* Set title cache dictionaries */

            // Set first title cache
            var firstTitleCacheDictionary = new Dictionary<string, string>();

            // Iterate first list
            for (int i = 0; i < firstList.Count; i++)
            {
                // Check if it's not present
                if (!firstTitleCacheDictionary.ContainsKey(firstList[i].Title))
                {
                    // Add title to cache
                    firstTitleCacheDictionary.Add(firstList[i].Title, firstListCache[i]);
                }
            }

            /*// Set second title cache
            var secondTitleCacheDictionary = new Dictionary<string, string>();

            // Iterate second list
            for (int i = 0; i < secondList.Count; i++)
            {
                // Check if it's not present
                if (!secondTitleCacheDictionary.ContainsKey(secondList[i].Title))
                {
                    // Add title to cache
                    secondTitleCacheDictionary.Add(secondList[i].Title, secondListCache[i]);
                }
            }*/

            /* Set matches collection */

            // Collect the matches
            var matchesCollection = firstList.Where(y => secondList.Any(z => z.Title.ToLowerInvariant() == y.Title.ToLowerInvariant()));

            // The matches (sorted) dictionary
            var matchesDictionary = new SortedDictionary<string, string>();

            // The collisions (sorted) dictionary
            var collisionsDictionary = new SortedDictionary<string, string>();

            // Populate matches dictionary
            foreach (var movieMatch in matchesCollection)
            {
                // TODO Lowercase title [Already lowercase from latest change, improve]
                string titleLc = movieMatch.Title.ToLowerInvariant();

                // Collect first list matches
                var firstListMatches = firstList.Where(x => x.Title.ToLower() == titleLc);

                // Collect second list matches
                var secondListMatches = secondList.Where(x => x.Title.ToLower() == titleLc);

                // Movie string
                string movieString = $"{firstTitleCacheDictionary[movieMatch.Title]}{Environment.NewLine}First list:{Environment.NewLine}{string.Join(Environment.NewLine, firstListMatches.Select(f => f.Path).ToList())}{Environment.NewLine}Second list:{Environment.NewLine}{string.Join(Environment.NewLine, secondListMatches.Select(s => s.Path).ToList())}";

                // Check it's unique
                if (!matchesDictionary.ContainsKey(titleLc))
                {
                    // Add current movie to dictionary
                    matchesDictionary.Add(titleLc, movieString);

                    // Check for collisions
                    if (firstListMatches.Count() > 1 || secondListMatches.Count() > 1)
                    {
                        // Add to collisions dictionary
                        collisionsDictionary.Add(firstTitleCacheDictionary[movieMatch.Title], movieString);
                    }
                }
            }

            // Check if must process matches
            if (this.matchesToolStripMenuItem.Checked)
            {
                // Check for matches
                if (matchesDictionary.Count > 0)
                {
                    // Set into text box 
                    this.matchesRichTextBox.Text = string.Join($"{Environment.NewLine}{Environment.NewLine}", matchesDictionary.Values);

                    // Update count in tab
                    this.matchesTabPage.Text = $"Matches ({matchesDictionary.Count})";
                }

                /*// Empty file name
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
                }*/
            }

            // Check if must process unmatched
            if (this.unmatchedToolStripMenuItem.Checked)
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

                // Set unmatched total
                int unmatchedTotal = firstUnmatchedList.Count + secondUnmatchedList.Count;

                // TODO Check there are unmatched items to display [Sum in variable, DRY]
                if (unmatchedTotal > 0)
                {
                    // Set into text box
                    this.unmatchedRichTextBox.Text = unmatchedCollection;

                    // Update count in tab
                    this.unmatchedTabPage.Text = $"Unmatched ({unmatchedTotal})";
                }
            }

            // Check if must process collisions
            if (this.collisionsToolStripMenuItem.Checked)
            {
                // Check for collisions
                if (collisionsDictionary.Count > 0)
                {
                    // Set into text box 
                    this.collisionsRichTextBox.Text = string.Join($"{Environment.NewLine}{Environment.NewLine}", collisionsDictionary.Values);

                    // Update count in tab
                    this.collisionsTabPage.Text = $"Collisions ({collisionsDictionary.Count})";
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
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"MovieFileLibrary by Peyman Mohammadi - MIT License{Environment.NewLine}" +
                $"https://github.com/moviecollection/movie-file-library/{Environment.NewLine}{Environment.NewLine}" +
                $"List icon set by Clker-Free-Vector-Images - Pixabay Content License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/list-bullet-points-items-one-two-27221/{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}";

            // Prepend sponsors
            licenseText = $"RELEASE SUPPORTERS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler (mouser){Environment.NewLine}* compn{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for:compn{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #149, Week #22 @ May 28, 2024",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
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
