
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MovieFileLibrary;

namespace MovieListCompn
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
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

            /* Set lists */

            // Set first list
            List<string> firstList = new List<string>(File.ReadAllLines(this.firstListTextBox.Text));

            // Set second list
            List<string> secondList = new List<string>(File.ReadAllLines(this.secondListTextBox.Text));

            // Set first list movies
            List<string> firstListMovies = new List<string>();

            // Set second list movies
            List<string> secondListMovies = new List<string>();

            /* Populate with movies */

            // Set movie detector
            var detector = new MovieDetector();

            // Populate first list movies
            for (int i = 0; i < firstList.Count; i++)
            {
                // Add matching movie
                firstListMovies.Add(detector.GetInfo(firstList[i]).Title);
            }

            // Populate second list movies
            for (int i = 0; i < secondList.Count; i++)
            {
                // Add matching movie
                secondListMovies.Add(detector.GetInfo(secondList[i]).Title);
            }

            /* Matches */

            // Matches list
            var matchesList = new List<string>();

            // Check if must process matches
            if (this.matchesToolStripMenuItem.Checked)
            {

            }
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

        }

        /// <summary>
        /// Handles the more releases paradisusis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMoreReleasesParadisusisToolStripMenuItemClick(object sender, EventArgs e)
        {

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
