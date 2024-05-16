
namespace MovieListCompn
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unmatchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreReleasesParadisusisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.firstListLabel = new System.Windows.Forms.Label();
            this.secondListLabel = new System.Windows.Forms.Label();
            this.firstListBrowseButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.secondListBrowseButton = new System.Windows.Forms.Button();
            this.firstListTextBox = new System.Windows.Forms.TextBox();
            this.secondListTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "exe";
            this.openFileDialog.Filter = "Txt Files (.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem,
                                    this.optionsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(384, 24);
            this.mainMenuStrip.TabIndex = 51;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.toolStripSeparator,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.alwaysOnTopToolStripMenuItem,
                                    this.matchesToolStripMenuItem,
                                    this.unmatchedToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // matchesToolStripMenuItem
            // 
            this.matchesToolStripMenuItem.Checked = true;
            this.matchesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            this.matchesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.matchesToolStripMenuItem.Text = "Matches";
            // 
            // unmatchedToolStripMenuItem
            // 
            this.unmatchedToolStripMenuItem.Name = "unmatchedToolStripMenuItem";
            this.unmatchedToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.unmatchedToolStripMenuItem.Text = "&Unmatched";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.moreReleasesParadisusisToolStripMenuItem,
                                    this.originalThreadDonationCodercomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // moreReleasesParadisusisToolStripMenuItem
            // 
            this.moreReleasesParadisusisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moreReleasesParadisusisToolStripMenuItem.Image")));
            this.moreReleasesParadisusisToolStripMenuItem.Name = "moreReleasesParadisusisToolStripMenuItem";
            this.moreReleasesParadisusisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.moreReleasesParadisusisToolStripMenuItem.Text = "More releases @ Paradisus.is";
            this.moreReleasesParadisusisToolStripMenuItem.Click += new System.EventHandler(this.OnMoreReleasesParadisusisToolStripMenuItemClick);
            // 
            // originalThreadDonationCodercomToolStripMenuItem
            // 
            this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
            this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
            this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
            this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
            // 
            // sourceCodeGithubcomToolStripMenuItem
            // 
            this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
            this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
            this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.statusTextToolStripStatusLabel,
                                    this.statusValueToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 184);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(384, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 50;
            // 
            // statusTextToolStripStatusLabel
            // 
            this.statusTextToolStripStatusLabel.Name = "statusTextToolStripStatusLabel";
            this.statusTextToolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusTextToolStripStatusLabel.Text = "Status:";
            // 
            // statusValueToolStripStatusLabel
            // 
            this.statusValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusValueToolStripStatusLabel.Name = "statusValueToolStripStatusLabel";
            this.statusValueToolStripStatusLabel.Size = new System.Drawing.Size(61, 17);
            this.statusValueToolStripStatusLabel.Text = "collection";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPanel.Controls.Add(this.firstListLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.secondListLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.firstListBrowseButton, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.processButton, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.secondListBrowseButton, 1, 3);
            this.mainTableLayoutPanel.Controls.Add(this.firstListTextBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.secondListTextBox, 0, 3);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(384, 160);
            this.mainTableLayoutPanel.TabIndex = 52;
            // 
            // firstListLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.firstListLabel, 2);
            this.firstListLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstListLabel.Location = new System.Drawing.Point(3, 0);
            this.firstListLabel.Name = "firstListLabel";
            this.firstListLabel.Size = new System.Drawing.Size(378, 25);
            this.firstListLabel.TabIndex = 1;
            this.firstListLabel.Text = "&First list:";
            this.firstListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondListLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.secondListLabel, 2);
            this.secondListLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondListLabel.Location = new System.Drawing.Point(3, 60);
            this.secondListLabel.Name = "secondListLabel";
            this.secondListLabel.Size = new System.Drawing.Size(378, 25);
            this.secondListLabel.TabIndex = 3;
            this.secondListLabel.Text = "&Second list:";
            this.secondListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstListBrowseButton
            // 
            this.firstListBrowseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstListBrowseButton.Location = new System.Drawing.Point(352, 28);
            this.firstListBrowseButton.Name = "firstListBrowseButton";
            this.firstListBrowseButton.Size = new System.Drawing.Size(29, 29);
            this.firstListBrowseButton.TabIndex = 2;
            this.firstListBrowseButton.Text = "...";
            this.firstListBrowseButton.UseVisualStyleBackColor = true;
            this.firstListBrowseButton.Click += new System.EventHandler(this.OnFirstListBrowseButtonClick);
            // 
            // processButton
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.processButton, 2);
            this.processButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.processButton.ForeColor = System.Drawing.Color.Red;
            this.processButton.Location = new System.Drawing.Point(3, 123);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(378, 34);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "&Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.OnProcessButtonClick);
            // 
            // secondListBrowseButton
            // 
            this.secondListBrowseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondListBrowseButton.Location = new System.Drawing.Point(352, 88);
            this.secondListBrowseButton.Name = "secondListBrowseButton";
            this.secondListBrowseButton.Size = new System.Drawing.Size(29, 29);
            this.secondListBrowseButton.TabIndex = 4;
            this.secondListBrowseButton.Text = "...";
            this.secondListBrowseButton.UseVisualStyleBackColor = true;
            this.secondListBrowseButton.Click += new System.EventHandler(this.OnSecondListBrowseButtonClick);
            // 
            // firstListTextBox
            // 
            this.firstListTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstListTextBox.Location = new System.Drawing.Point(3, 28);
            this.firstListTextBox.Name = "firstListTextBox";
            this.firstListTextBox.Size = new System.Drawing.Size(343, 24);
            this.firstListTextBox.TabIndex = 1;
            // 
            // secondListTextBox
            // 
            this.secondListTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondListTextBox.Location = new System.Drawing.Point(3, 88);
            this.secondListTextBox.Name = "secondListTextBox";
            this.secondListTextBox.Size = new System.Drawing.Size(343, 24);
            this.secondListTextBox.TabIndex = 3;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Txt Files (.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 206);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieList-compn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox secondListTextBox;
        private System.Windows.Forms.TextBox firstListTextBox;
        private System.Windows.Forms.Button secondListBrowseButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button firstListBrowseButton;
        private System.Windows.Forms.Label secondListLabel;
        private System.Windows.Forms.Label firstListLabel;
        private System.Windows.Forms.ToolStripMenuItem unmatchedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel statusValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusTextToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreReleasesParadisusisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
