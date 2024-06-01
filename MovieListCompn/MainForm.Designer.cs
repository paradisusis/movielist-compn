
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
        	this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.unmatchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.collisionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
        	this.mainTabControl = new System.Windows.Forms.TabControl();
        	this.matchesTabPage = new System.Windows.Forms.TabPage();
        	this.matchesRichTextBox = new System.Windows.Forms.RichTextBox();
        	this.unmatchedTabPage = new System.Windows.Forms.TabPage();
        	this.unmatchedRichTextBox = new System.Windows.Forms.RichTextBox();
        	this.collisionsTabPage = new System.Windows.Forms.TabPage();
        	this.collisionsRichTextBox = new System.Windows.Forms.RichTextBox();
        	this.fuzzyMatchesCheckBox = new System.Windows.Forms.CheckBox();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.fuzzyAlgorithmComboBox = new System.Windows.Forms.ComboBox();
        	this.fuzzyAlgorithmNumericUpDown = new System.Windows.Forms.NumericUpDown();
        	this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.mainTableLayoutPanel.SuspendLayout();
        	this.mainTabControl.SuspendLayout();
        	this.matchesTabPage.SuspendLayout();
        	this.unmatchedTabPage.SuspendLayout();
        	this.collisionsTabPage.SuspendLayout();
        	this.tableLayoutPanel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.fuzzyAlgorithmNumericUpDown)).BeginInit();
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
        	        	        	this.openToolStripMenuItem,
        	        	        	this.toolStripSeparator,
        	        	        	this.saveToolStripMenuItem,
        	        	        	this.saveAsToolStripMenuItem,
        	        	        	this.toolStripSeparator1,
        	        	        	this.printToolStripMenuItem,
        	        	        	this.printPreviewToolStripMenuItem,
        	        	        	this.toolStripSeparator3,
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
        	this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        	this.newToolStripMenuItem.Text = "&New";
        	this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// openToolStripMenuItem
        	// 
        	this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
        	this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        	this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
        	this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        	this.openToolStripMenuItem.Text = "&Open";
        	this.openToolStripMenuItem.Visible = false;
        	// 
        	// toolStripSeparator
        	// 
        	this.toolStripSeparator.Name = "toolStripSeparator";
        	this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
        	// 
        	// saveToolStripMenuItem
        	// 
        	this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
        	this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        	this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        	this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        	this.saveToolStripMenuItem.Text = "&Save";
        	this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveToolStripMenuItemClick);
        	// 
        	// saveAsToolStripMenuItem
        	// 
        	this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        	this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        	this.saveAsToolStripMenuItem.Text = "Save &As";
        	this.saveAsToolStripMenuItem.Visible = false;
        	// 
        	// toolStripSeparator1
        	// 
        	this.toolStripSeparator1.Name = "toolStripSeparator1";
        	this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
        	this.toolStripSeparator1.Visible = false;
        	// 
        	// printToolStripMenuItem
        	// 
        	this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
        	this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.printToolStripMenuItem.Name = "printToolStripMenuItem";
        	this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
        	this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        	this.printToolStripMenuItem.Text = "&Print";
        	this.printToolStripMenuItem.Visible = false;
        	// 
        	// printPreviewToolStripMenuItem
        	// 
        	this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
        	this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
        	this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        	this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
        	this.printPreviewToolStripMenuItem.Visible = false;
        	// 
        	// toolStripSeparator3
        	// 
        	this.toolStripSeparator3.Name = "toolStripSeparator3";
        	this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// optionsToolStripMenuItem
        	// 
        	this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.alwaysOnTopToolStripMenuItem,
        	        	        	this.matchesToolStripMenuItem,
        	        	        	this.unmatchedToolStripMenuItem,
        	        	        	this.collisionsToolStripMenuItem});
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
        	this.matchesToolStripMenuItem.Text = "&Matches";
        	// 
        	// unmatchedToolStripMenuItem
        	// 
        	this.unmatchedToolStripMenuItem.Checked = true;
        	this.unmatchedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.unmatchedToolStripMenuItem.Name = "unmatchedToolStripMenuItem";
        	this.unmatchedToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
        	this.unmatchedToolStripMenuItem.Text = "&Unmatched";
        	// 
        	// collisionsToolStripMenuItem
        	// 
        	this.collisionsToolStripMenuItem.Checked = true;
        	this.collisionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.collisionsToolStripMenuItem.Name = "collisionsToolStripMenuItem";
        	this.collisionsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
        	this.collisionsToolStripMenuItem.Text = "&Collisions";
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
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 490);
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
        	this.mainTableLayoutPanel.Controls.Add(this.processButton, 0, 7);
        	this.mainTableLayoutPanel.Controls.Add(this.secondListBrowseButton, 1, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.firstListTextBox, 0, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.secondListTextBox, 0, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.mainTabControl, 0, 4);
        	this.mainTableLayoutPanel.Controls.Add(this.fuzzyMatchesCheckBox, 0, 5);
        	this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 6);
        	this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
        	this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        	this.mainTableLayoutPanel.RowCount = 8;
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        	this.mainTableLayoutPanel.Size = new System.Drawing.Size(384, 466);
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
        	this.processButton.Location = new System.Drawing.Point(3, 429);
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
        	// mainTabControl
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.mainTabControl, 2);
        	this.mainTabControl.Controls.Add(this.matchesTabPage);
        	this.mainTabControl.Controls.Add(this.unmatchedTabPage);
        	this.mainTabControl.Controls.Add(this.collisionsTabPage);
        	this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTabControl.Location = new System.Drawing.Point(3, 123);
        	this.mainTabControl.Name = "mainTabControl";
        	this.mainTabControl.SelectedIndex = 0;
        	this.mainTabControl.Size = new System.Drawing.Size(378, 240);
        	this.mainTabControl.TabIndex = 5;
        	// 
        	// matchesTabPage
        	// 
        	this.matchesTabPage.Controls.Add(this.matchesRichTextBox);
        	this.matchesTabPage.Location = new System.Drawing.Point(4, 22);
        	this.matchesTabPage.Name = "matchesTabPage";
        	this.matchesTabPage.Padding = new System.Windows.Forms.Padding(3);
        	this.matchesTabPage.Size = new System.Drawing.Size(370, 214);
        	this.matchesTabPage.TabIndex = 0;
        	this.matchesTabPage.Text = "Matches";
        	this.matchesTabPage.UseVisualStyleBackColor = true;
        	// 
        	// matchesRichTextBox
        	// 
        	this.matchesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.matchesRichTextBox.Location = new System.Drawing.Point(3, 3);
        	this.matchesRichTextBox.Name = "matchesRichTextBox";
        	this.matchesRichTextBox.Size = new System.Drawing.Size(364, 208);
        	this.matchesRichTextBox.TabIndex = 0;
        	this.matchesRichTextBox.Text = "";
        	// 
        	// unmatchedTabPage
        	// 
        	this.unmatchedTabPage.Controls.Add(this.unmatchedRichTextBox);
        	this.unmatchedTabPage.Location = new System.Drawing.Point(4, 22);
        	this.unmatchedTabPage.Name = "unmatchedTabPage";
        	this.unmatchedTabPage.Padding = new System.Windows.Forms.Padding(3);
        	this.unmatchedTabPage.Size = new System.Drawing.Size(370, 214);
        	this.unmatchedTabPage.TabIndex = 1;
        	this.unmatchedTabPage.Text = "Unmatched";
        	this.unmatchedTabPage.UseVisualStyleBackColor = true;
        	// 
        	// unmatchedRichTextBox
        	// 
        	this.unmatchedRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.unmatchedRichTextBox.Location = new System.Drawing.Point(3, 3);
        	this.unmatchedRichTextBox.Name = "unmatchedRichTextBox";
        	this.unmatchedRichTextBox.Size = new System.Drawing.Size(364, 208);
        	this.unmatchedRichTextBox.TabIndex = 0;
        	this.unmatchedRichTextBox.Text = "";
        	// 
        	// collisionsTabPage
        	// 
        	this.collisionsTabPage.Controls.Add(this.collisionsRichTextBox);
        	this.collisionsTabPage.Location = new System.Drawing.Point(4, 22);
        	this.collisionsTabPage.Name = "collisionsTabPage";
        	this.collisionsTabPage.Padding = new System.Windows.Forms.Padding(3);
        	this.collisionsTabPage.Size = new System.Drawing.Size(370, 214);
        	this.collisionsTabPage.TabIndex = 2;
        	this.collisionsTabPage.Text = "Collisions";
        	this.collisionsTabPage.UseVisualStyleBackColor = true;
        	// 
        	// collisionsRichTextBox
        	// 
        	this.collisionsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.collisionsRichTextBox.Location = new System.Drawing.Point(3, 3);
        	this.collisionsRichTextBox.Name = "collisionsRichTextBox";
        	this.collisionsRichTextBox.Size = new System.Drawing.Size(364, 208);
        	this.collisionsRichTextBox.TabIndex = 0;
        	this.collisionsRichTextBox.Text = "";
        	// 
        	// fuzzyMatchesCheckBox
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.fuzzyMatchesCheckBox, 2);
        	this.fuzzyMatchesCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.fuzzyMatchesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.fuzzyMatchesCheckBox.Location = new System.Drawing.Point(3, 366);
        	this.fuzzyMatchesCheckBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
        	this.fuzzyMatchesCheckBox.Name = "fuzzyMatchesCheckBox";
        	this.fuzzyMatchesCheckBox.Size = new System.Drawing.Size(378, 25);
        	this.fuzzyMatchesCheckBox.TabIndex = 6;
        	this.fuzzyMatchesCheckBox.Text = "Fuzzy matches";
        	this.fuzzyMatchesCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.fuzzyMatchesCheckBox.UseVisualStyleBackColor = true;
        	this.fuzzyMatchesCheckBox.CheckedChanged += new System.EventHandler(this.OnFuzzyMatchesCheckBoxCheckedChanged);
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 3;
        	this.mainTableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.tableLayoutPanel1.Controls.Add(this.fuzzyAlgorithmComboBox, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.fuzzyAlgorithmNumericUpDown, 2, 0);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 394);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 1;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 29);
        	this.tableLayoutPanel1.TabIndex = 7;
        	// 
        	// fuzzyAlgorithmComboBox
        	// 
        	this.fuzzyAlgorithmComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.fuzzyAlgorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.fuzzyAlgorithmComboBox.Enabled = false;
        	this.fuzzyAlgorithmComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
        	this.fuzzyAlgorithmComboBox.FormattingEnabled = true;
        	this.fuzzyAlgorithmComboBox.Location = new System.Drawing.Point(3, 3);
        	this.fuzzyAlgorithmComboBox.Name = "fuzzyAlgorithmComboBox";
        	this.fuzzyAlgorithmComboBox.Size = new System.Drawing.Size(273, 26);
        	this.fuzzyAlgorithmComboBox.TabIndex = 7;
        	// 
        	// fuzzyAlgorithmNumericUpDown
        	// 
        	this.fuzzyAlgorithmNumericUpDown.Enabled = false;
        	this.fuzzyAlgorithmNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
        	this.fuzzyAlgorithmNumericUpDown.Increment = new decimal(new int[] {
        	        	        	5,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.fuzzyAlgorithmNumericUpDown.Location = new System.Drawing.Point(287, 3);
        	this.fuzzyAlgorithmNumericUpDown.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.fuzzyAlgorithmNumericUpDown.Name = "fuzzyAlgorithmNumericUpDown";
        	this.fuzzyAlgorithmNumericUpDown.Size = new System.Drawing.Size(88, 24);
        	this.fuzzyAlgorithmNumericUpDown.TabIndex = 8;
        	this.fuzzyAlgorithmNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	this.fuzzyAlgorithmNumericUpDown.Value = new decimal(new int[] {
        	        	        	75,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	// 
        	// saveFileDialog
        	// 
        	this.saveFileDialog.Filter = "Txt Files (.txt)|*.txt|All Files (*.*)|*.*";
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(384, 512);
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
        	this.mainTabControl.ResumeLayout(false);
        	this.matchesTabPage.ResumeLayout(false);
        	this.unmatchedTabPage.ResumeLayout(false);
        	this.collisionsTabPage.ResumeLayout(false);
        	this.tableLayoutPanel1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.fuzzyAlgorithmNumericUpDown)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.NumericUpDown fuzzyAlgorithmNumericUpDown;
        private System.Windows.Forms.ComboBox fuzzyAlgorithmComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox fuzzyMatchesCheckBox;
        private System.Windows.Forms.RichTextBox collisionsRichTextBox;
        private System.Windows.Forms.RichTextBox unmatchedRichTextBox;
        private System.Windows.Forms.TabPage collisionsTabPage;
        private System.Windows.Forms.RichTextBox matchesRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem collisionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabPage unmatchedTabPage;
        private System.Windows.Forms.TabPage matchesTabPage;
        private System.Windows.Forms.TabControl mainTabControl;
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
