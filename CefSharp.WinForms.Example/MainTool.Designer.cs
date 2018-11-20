namespace TestTool.WinForms
{
	partial class MainTool
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnGroupFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnTestPlan = new System.Windows.Forms.ToolStripMenuItem();
			this.mnGroupTest = new System.Windows.Forms.ToolStripMenuItem();
			this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnGroupAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.mnAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.statusLabel = new System.Windows.Forms.Label();
			this.outputLabel = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.backButton = new System.Windows.Forms.ToolStripButton();
			this.forwardButton = new System.Windows.Forms.ToolStripButton();
			this.urlTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.goButton = new System.Windows.Forms.ToolStripButton();
			this.mangeCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnCategoryCode = new System.Windows.Forms.ToolStripMenuItem();
			this.mnCommonCode = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnGroupFile,
            this.mnGroupTest,
            this.mnGroupAbout});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnGroupFile
			// 
			this.mnGroupFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTestPlan,
            this.mangeCodeToolStripMenuItem});
			this.mnGroupFile.Name = "mnGroupFile";
			this.mnGroupFile.Size = new System.Drawing.Size(37, 20);
			this.mnGroupFile.Text = "File";
			// 
			// mnTestPlan
			// 
			this.mnTestPlan.Name = "mnTestPlan";
			this.mnTestPlan.Size = new System.Drawing.Size(180, 22);
			this.mnTestPlan.Text = "Test Plan";
			this.mnTestPlan.Click += new System.EventHandler(this.mnTestPlan_Click);
			// 
			// mnGroupTest
			// 
			this.mnGroupTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.endToolStripMenuItem});
			this.mnGroupTest.Name = "mnGroupTest";
			this.mnGroupTest.Size = new System.Drawing.Size(40, 20);
			this.mnGroupTest.Text = "Test";
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
			// 
			// endToolStripMenuItem
			// 
			this.endToolStripMenuItem.Name = "endToolStripMenuItem";
			this.endToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
			this.endToolStripMenuItem.Text = "End";
			this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
			// 
			// mnGroupAbout
			// 
			this.mnGroupAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAbout});
			this.mnGroupAbout.Name = "mnGroupAbout";
			this.mnGroupAbout.Size = new System.Drawing.Size(52, 20);
			this.mnGroupAbout.Text = "About";
			// 
			// mnAbout
			// 
			this.mnAbout.Name = "mnAbout";
			this.mnAbout.Size = new System.Drawing.Size(107, 22);
			this.mnAbout.Text = "About";
			this.mnAbout.Click += new System.EventHandler(this.mnAbout_Click);
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.statusLabel);
			this.toolStripContainer.ContentPanel.Controls.Add(this.outputLabel);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(800, 401);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.LeftToolStripPanelVisible = false;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.RightToolStripPanelVisible = false;
			this.toolStripContainer.Size = new System.Drawing.Size(800, 426);
			this.toolStripContainer.TabIndex = 1;
			this.toolStripContainer.Text = "toolStripContainer1";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusLabel.Location = new System.Drawing.Point(0, 377);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 12);
			this.statusLabel.TabIndex = 1;
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.outputLabel.Location = new System.Drawing.Point(0, 389);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(0, 12);
			this.outputLabel.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.urlTextBox,
            this.goButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 0;
			// 
			// backButton
			// 
			this.backButton.Enabled = false;
			this.backButton.Image = global::CefSharp.WinForms.Example.Properties.Resources.nav_left_green;
			this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(23, 22);
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// forwardButton
			// 
			this.forwardButton.Enabled = false;
			this.forwardButton.Image = global::CefSharp.WinForms.Example.Properties.Resources.nav_right_green;
			this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.forwardButton.Name = "forwardButton";
			this.forwardButton.Size = new System.Drawing.Size(23, 22);
			this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
			// 
			// urlTextBox
			// 
			this.urlTextBox.AutoSize = false;
			this.urlTextBox.Name = "urlTextBox";
			this.urlTextBox.Size = new System.Drawing.Size(500, 25);
			this.urlTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urlTextBox_KeyUp);
			// 
			// goButton
			// 
			this.goButton.Image = global::CefSharp.WinForms.Example.Properties.Resources.nav_plain_green;
			this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.goButton.Name = "goButton";
			this.goButton.Size = new System.Drawing.Size(42, 22);
			this.goButton.Text = "Go";
			// 
			// mangeCodeToolStripMenuItem
			// 
			this.mangeCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCategoryCode,
            this.mnCommonCode});
			this.mangeCodeToolStripMenuItem.Name = "mangeCodeToolStripMenuItem";
			this.mangeCodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mangeCodeToolStripMenuItem.Text = "Manage Code";
			// 
			// mnCategoryCode
			// 
			this.mnCategoryCode.Name = "mnCategoryCode";
			this.mnCategoryCode.Size = new System.Drawing.Size(180, 22);
			this.mnCategoryCode.Text = "Category Code";
			this.mnCategoryCode.Click += new System.EventHandler(this.mnCategoryCode_Click);
			// 
			// mnCommonCode
			// 
			this.mnCommonCode.Name = "mnCommonCode";
			this.mnCommonCode.Size = new System.Drawing.Size(180, 22);
			this.mnCommonCode.Text = "Common Code";
			this.mnCommonCode.Click += new System.EventHandler(this.mnCommonCode_Click);
			// 
			// MainTool
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStripContainer);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainTool";
			this.Text = "Test Tool";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ContentPanel.PerformLayout();
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnGroupFile;
		private System.Windows.Forms.ToolStripMenuItem mnGroupTest;
		private System.Windows.Forms.ToolStripMenuItem mnTestPlan;
		private System.Windows.Forms.ToolStripMenuItem mnGroupAbout;
		private System.Windows.Forms.ToolStripMenuItem mnAbout;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton backButton;
		private System.Windows.Forms.ToolStripButton forwardButton;
		private System.Windows.Forms.ToolStripTextBox urlTextBox;
		private System.Windows.Forms.ToolStripButton goButton;
		private System.Windows.Forms.ToolStripMenuItem mangeCodeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnCategoryCode;
		private System.Windows.Forms.ToolStripMenuItem mnCommonCode;
	}
}