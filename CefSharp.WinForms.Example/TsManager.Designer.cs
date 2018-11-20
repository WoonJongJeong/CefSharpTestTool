namespace TestTool.WinForms
{
	partial class TsManager
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
			this.components = new System.ComponentModel.Container();
			this.treeMenuGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmnAddGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.treeMenuCase = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmnCaseAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cmnEditGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnRemoveGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlTsBody = new System.Windows.Forms.Panel();
			this.btnDevTool = new System.Windows.Forms.Button();
			this.btnRunTest = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tvTestCase = new System.Windows.Forms.TreeView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnTestPlan = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cmbTestPlan = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.treeMenuCaseEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmnEditCase = new System.Windows.Forms.ToolStripMenuItem();
			this.cmnRemoveCase = new System.Windows.Forms.ToolStripMenuItem();
			this.treeMenuGroup.SuspendLayout();
			this.treeMenuCase.SuspendLayout();
			this.pnlTsBody.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.treeMenuCaseEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeMenuGroup
			// 
			this.treeMenuGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnAddGroup});
			this.treeMenuGroup.Name = "treeMenu";
			this.treeMenuGroup.Size = new System.Drawing.Size(134, 26);
			this.treeMenuGroup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeMenu_MouseUp);
			// 
			// cmnAddGroup
			// 
			this.cmnAddGroup.Name = "cmnAddGroup";
			this.cmnAddGroup.Size = new System.Drawing.Size(133, 22);
			this.cmnAddGroup.Text = "Add Group";
			this.cmnAddGroup.Click += new System.EventHandler(this.cmnAddGroup_Click);
			// 
			// treeMenuCase
			// 
			this.treeMenuCase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnCaseAdd,
            this.toolStripSeparator1,
            this.cmnEditGroup,
            this.cmnRemoveGroup});
			this.treeMenuCase.Name = "treeMenu";
			this.treeMenuCase.Size = new System.Drawing.Size(155, 76);
			// 
			// cmnCaseAdd
			// 
			this.cmnCaseAdd.Name = "cmnCaseAdd";
			this.cmnCaseAdd.Size = new System.Drawing.Size(154, 22);
			this.cmnCaseAdd.Text = "Add Case";
			this.cmnCaseAdd.Click += new System.EventHandler(this.cmnCaseAdd_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
			// 
			// cmnEditGroup
			// 
			this.cmnEditGroup.Name = "cmnEditGroup";
			this.cmnEditGroup.Size = new System.Drawing.Size(154, 22);
			this.cmnEditGroup.Text = "Edit Group";
			this.cmnEditGroup.Click += new System.EventHandler(this.cmnEditGroup_Click);
			// 
			// cmnRemoveGroup
			// 
			this.cmnRemoveGroup.Name = "cmnRemoveGroup";
			this.cmnRemoveGroup.Size = new System.Drawing.Size(154, 22);
			this.cmnRemoveGroup.Text = "Remove Group";
			this.cmnRemoveGroup.Click += new System.EventHandler(this.cmnRemoveGroup_Click);
			// 
			// pnlTsBody
			// 
			this.pnlTsBody.BackColor = System.Drawing.SystemColors.Control;
			this.pnlTsBody.Controls.Add(this.btnDevTool);
			this.pnlTsBody.Controls.Add(this.btnRunTest);
			this.pnlTsBody.Controls.Add(this.label2);
			this.pnlTsBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlTsBody.Location = new System.Drawing.Point(3, 48);
			this.pnlTsBody.Name = "pnlTsBody";
			this.pnlTsBody.Padding = new System.Windows.Forms.Padding(3);
			this.pnlTsBody.Size = new System.Drawing.Size(327, 24);
			this.pnlTsBody.TabIndex = 17;
			// 
			// btnDevTool
			// 
			this.btnDevTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDevTool.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnDevTool.Location = new System.Drawing.Point(170, 1);
			this.btnDevTool.Name = "btnDevTool";
			this.btnDevTool.Size = new System.Drawing.Size(74, 23);
			this.btnDevTool.TabIndex = 26;
			this.btnDevTool.Text = "Dev";
			this.btnDevTool.UseVisualStyleBackColor = true;
			this.btnDevTool.Click += new System.EventHandler(this.btnDevTool_Click);
			// 
			// btnRunTest
			// 
			this.btnRunTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRunTest.Location = new System.Drawing.Point(250, 1);
			this.btnRunTest.Name = "btnRunTest";
			this.btnRunTest.Size = new System.Drawing.Size(74, 23);
			this.btnRunTest.TabIndex = 25;
			this.btnRunTest.Text = "▶";
			this.btnRunTest.UseVisualStyleBackColor = true;
			this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "Test Case";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.tvTestCase, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.pnlTsBody, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 662);
			this.tableLayoutPanel1.TabIndex = 22;
			// 
			// tvTestCase
			// 
			this.tvTestCase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvTestCase.Location = new System.Drawing.Point(0, 75);
			this.tvTestCase.Margin = new System.Windows.Forms.Padding(0);
			this.tvTestCase.Name = "tvTestCase";
			this.tvTestCase.Size = new System.Drawing.Size(333, 587);
			this.tvTestCase.TabIndex = 0;
			this.tvTestCase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeMenu_MouseUp);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(327, 39);
			this.panel1.TabIndex = 18;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnTestPlan, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(327, 29);
			this.tableLayoutPanel2.TabIndex = 27;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(44, 24);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 12);
			this.label1.TabIndex = 23;
			this.label1.Text = "Plan";
			// 
			// btnTestPlan
			// 
			this.btnTestPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTestPlan.Location = new System.Drawing.Point(250, 3);
			this.btnTestPlan.Name = "btnTestPlan";
			this.btnTestPlan.Size = new System.Drawing.Size(74, 23);
			this.btnTestPlan.TabIndex = 24;
			this.btnTestPlan.Text = "Plan";
			this.btnTestPlan.UseVisualStyleBackColor = true;
			this.btnTestPlan.Click += new System.EventHandler(this.btnTestPlan_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.cmbTestPlan);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(53, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(191, 24);
			this.panel3.TabIndex = 1;
			// 
			// cmbTestPlan
			// 
			this.cmbTestPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbTestPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTestPlan.FormattingEnabled = true;
			this.cmbTestPlan.Location = new System.Drawing.Point(0, 3);
			this.cmbTestPlan.Name = "cmbTestPlan";
			this.cmbTestPlan.Size = new System.Drawing.Size(185, 20);
			this.cmbTestPlan.TabIndex = 25;
			this.cmbTestPlan.SelectedIndexChanged += new System.EventHandler(this.cmbTestPlan_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(327, 10);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			// 
			// treeMenuCaseEdit
			// 
			this.treeMenuCaseEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnEditCase,
            this.cmnRemoveCase});
			this.treeMenuCaseEdit.Name = "treeMenu";
			this.treeMenuCaseEdit.Size = new System.Drawing.Size(147, 48);
			// 
			// cmnEditCase
			// 
			this.cmnEditCase.Name = "cmnEditCase";
			this.cmnEditCase.Size = new System.Drawing.Size(146, 22);
			this.cmnEditCase.Text = "Edit Case";
			this.cmnEditCase.Click += new System.EventHandler(this.cmnEditCase_Click);
			// 
			// cmnRemoveCase
			// 
			this.cmnRemoveCase.Name = "cmnRemoveCase";
			this.cmnRemoveCase.Size = new System.Drawing.Size(146, 22);
			this.cmnRemoveCase.Text = "Remove Case";
			this.cmnRemoveCase.Click += new System.EventHandler(this.cmnRemoveCase_Click);
			// 
			// TsManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 662);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "TsManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manager";
			this.Load += new System.EventHandler(this.TsManager_Load);
			this.treeMenuGroup.ResumeLayout(false);
			this.treeMenuCase.ResumeLayout(false);
			this.pnlTsBody.ResumeLayout(false);
			this.pnlTsBody.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.treeMenuCaseEdit.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip treeMenuGroup;
		private System.Windows.Forms.ToolStripMenuItem cmnAddGroup;
		private System.Windows.Forms.ContextMenuStrip treeMenuCase;
		private System.Windows.Forms.ToolStripMenuItem cmnCaseAdd;
		private System.Windows.Forms.Panel pnlTsBody;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnTestPlan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbTestPlan;
		private System.Windows.Forms.TreeView tvTestCase;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cmnEditGroup;
		private System.Windows.Forms.ToolStripMenuItem cmnRemoveGroup;
		private System.Windows.Forms.ContextMenuStrip treeMenuCaseEdit;
		private System.Windows.Forms.ToolStripMenuItem cmnEditCase;
		private System.Windows.Forms.ToolStripMenuItem cmnRemoveCase;
		private System.Windows.Forms.Button btnRunTest;
		private System.Windows.Forms.Button btnDevTool;
	}
}