namespace TestTool.WinForms
{
	partial class TpManager
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tbMain = new System.Windows.Forms.TabControl();
			this.tbpCodeList = new System.Windows.Forms.TabPage();
			this.dgPlan = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtKeyword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbpCodeEdit = new System.Windows.Forms.TabPage();
			this.chkUseYn = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dtPlan = new System.Windows.Forms.DateTimePicker();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtOrderBy = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPlanName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPlanNo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.colPlanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPlanDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUseYn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescript = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbMain.SuspendLayout();
			this.tbpCodeList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPlan)).BeginInit();
			this.panel1.SuspendLayout();
			this.tbpCodeEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbMain
			// 
			this.tbMain.Controls.Add(this.tbpCodeList);
			this.tbMain.Controls.Add(this.tbpCodeEdit);
			this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbMain.Location = new System.Drawing.Point(0, 0);
			this.tbMain.Margin = new System.Windows.Forms.Padding(0);
			this.tbMain.Name = "tbMain";
			this.tbMain.SelectedIndex = 0;
			this.tbMain.Size = new System.Drawing.Size(800, 456);
			this.tbMain.TabIndex = 6;
			// 
			// tbpCodeList
			// 
			this.tbpCodeList.Controls.Add(this.dgPlan);
			this.tbpCodeList.Controls.Add(this.panel1);
			this.tbpCodeList.Location = new System.Drawing.Point(4, 22);
			this.tbpCodeList.Margin = new System.Windows.Forms.Padding(0);
			this.tbpCodeList.Name = "tbpCodeList";
			this.tbpCodeList.Size = new System.Drawing.Size(792, 430);
			this.tbpCodeList.TabIndex = 0;
			this.tbpCodeList.Text = "List";
			this.tbpCodeList.UseVisualStyleBackColor = true;
			// 
			// dgPlan
			// 
			this.dgPlan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlanNo,
            this.colPlanName,
            this.colPlanDt,
            this.colUseYn,
            this.colOrderBy,
            this.colDescript});
			this.dgPlan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgPlan.Location = new System.Drawing.Point(0, 59);
			this.dgPlan.MultiSelect = false;
			this.dgPlan.Name = "dgPlan";
			this.dgPlan.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgPlan.RowTemplate.Height = 23;
			this.dgPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPlan.Size = new System.Drawing.Size(792, 371);
			this.dgPlan.TabIndex = 1;
			this.dgPlan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlan_CellDoubleClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnNew);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.txtKeyword);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 59);
			this.panel1.TabIndex = 0;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(794, 14);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(694, 14);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 23);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(601, 14);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtKeyword
			// 
			this.txtKeyword.Location = new System.Drawing.Point(403, 16);
			this.txtKeyword.Name = "txtKeyword";
			this.txtKeyword.Size = new System.Drawing.Size(192, 21);
			this.txtKeyword.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(338, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "Keyword:";
			// 
			// tbpCodeEdit
			// 
			this.tbpCodeEdit.Controls.Add(this.chkUseYn);
			this.tbpCodeEdit.Controls.Add(this.label8);
			this.tbpCodeEdit.Controls.Add(this.dtPlan);
			this.tbpCodeEdit.Controls.Add(this.panel2);
			this.tbpCodeEdit.Controls.Add(this.btnCancel);
			this.tbpCodeEdit.Controls.Add(this.btnSave);
			this.tbpCodeEdit.Controls.Add(this.txtDescription);
			this.tbpCodeEdit.Controls.Add(this.txtOrderBy);
			this.tbpCodeEdit.Controls.Add(this.label7);
			this.tbpCodeEdit.Controls.Add(this.txtPlanName);
			this.tbpCodeEdit.Controls.Add(this.label6);
			this.tbpCodeEdit.Controls.Add(this.txtPlanNo);
			this.tbpCodeEdit.Controls.Add(this.label2);
			this.tbpCodeEdit.Controls.Add(this.label5);
			this.tbpCodeEdit.Controls.Add(this.label4);
			this.tbpCodeEdit.Location = new System.Drawing.Point(4, 22);
			this.tbpCodeEdit.Margin = new System.Windows.Forms.Padding(0);
			this.tbpCodeEdit.Name = "tbpCodeEdit";
			this.tbpCodeEdit.Size = new System.Drawing.Size(792, 430);
			this.tbpCodeEdit.TabIndex = 1;
			this.tbpCodeEdit.Text = "Edit";
			this.tbpCodeEdit.UseVisualStyleBackColor = true;
			// 
			// chkUseYn
			// 
			this.chkUseYn.AutoSize = true;
			this.chkUseYn.Location = new System.Drawing.Point(108, 219);
			this.chkUseYn.Name = "chkUseYn";
			this.chkUseYn.Size = new System.Drawing.Size(15, 14);
			this.chkUseYn.TabIndex = 30;
			this.chkUseYn.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(30, 220);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 12);
			this.label8.TabIndex = 29;
			this.label8.Text = "Use YN";
			// 
			// dtPlan
			// 
			this.dtPlan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtPlan.Location = new System.Drawing.Point(104, 143);
			this.dtPlan.Name = "dtPlan";
			this.dtPlan.Size = new System.Drawing.Size(88, 21);
			this.dtPlan.TabIndex = 28;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 29);
			this.panel2.TabIndex = 27;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(413, 295);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 24;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(328, 295);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 24;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(104, 256);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(384, 21);
			this.txtDescription.TabIndex = 13;
			// 
			// txtOrderBy
			// 
			this.txtOrderBy.Location = new System.Drawing.Point(104, 181);
			this.txtOrderBy.Name = "txtOrderBy";
			this.txtOrderBy.Size = new System.Drawing.Size(116, 21);
			this.txtOrderBy.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 256);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 12);
			this.label7.TabIndex = 18;
			this.label7.Text = "Description";
			// 
			// txtPlanName
			// 
			this.txtPlanName.Location = new System.Drawing.Point(104, 103);
			this.txtPlanName.Name = "txtPlanName";
			this.txtPlanName.Size = new System.Drawing.Size(299, 21);
			this.txtPlanName.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(23, 181);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 12);
			this.label6.TabIndex = 20;
			this.label6.Text = "Order By";
			// 
			// txtPlanNo
			// 
			this.txtPlanNo.BackColor = System.Drawing.SystemColors.Window;
			this.txtPlanNo.Enabled = false;
			this.txtPlanNo.Location = new System.Drawing.Point(104, 67);
			this.txtPlanNo.Name = "txtPlanNo";
			this.txtPlanNo.Size = new System.Drawing.Size(116, 21);
			this.txtPlanNo.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 12);
			this.label2.TabIndex = 21;
			this.label2.Text = "Date";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 12);
			this.label5.TabIndex = 21;
			this.label5.Text = "Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 12);
			this.label4.TabIndex = 22;
			this.label4.Text = "No";
			// 
			// colPlanNo
			// 
			this.colPlanNo.DataPropertyName = "ts_plan_no";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.colPlanNo.DefaultCellStyle = dataGridViewCellStyle2;
			this.colPlanNo.HeaderText = "No";
			this.colPlanNo.Name = "colPlanNo";
			this.colPlanNo.ReadOnly = true;
			// 
			// colPlanName
			// 
			this.colPlanName.DataPropertyName = "ts_plan_nm";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.colPlanName.DefaultCellStyle = dataGridViewCellStyle3;
			this.colPlanName.HeaderText = "Plan";
			this.colPlanName.Name = "colPlanName";
			this.colPlanName.ReadOnly = true;
			this.colPlanName.Width = 300;
			// 
			// colPlanDt
			// 
			this.colPlanDt.DataPropertyName = "ts_plan_dt";
			this.colPlanDt.HeaderText = "Plan Date";
			this.colPlanDt.Name = "colPlanDt";
			this.colPlanDt.ReadOnly = true;
			// 
			// colUseYn
			// 
			this.colUseYn.DataPropertyName = "use_yn";
			this.colUseYn.FillWeight = 80F;
			this.colUseYn.HeaderText = "Use Yn";
			this.colUseYn.Name = "colUseYn";
			this.colUseYn.ReadOnly = true;
			this.colUseYn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colUseYn.Width = 80;
			// 
			// colOrderBy
			// 
			this.colOrderBy.DataPropertyName = "order_by";
			this.colOrderBy.HeaderText = "Order by";
			this.colOrderBy.Name = "colOrderBy";
			this.colOrderBy.ReadOnly = true;
			// 
			// colDescript
			// 
			this.colDescript.DataPropertyName = "description";
			this.colDescript.HeaderText = "Description";
			this.colDescript.Name = "colDescript";
			this.colDescript.ReadOnly = true;
			this.colDescript.Width = 250;
			// 
			// TpManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 456);
			this.Controls.Add(this.tbMain);
			this.Name = "TpManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Test Plan";
			this.Load += new System.EventHandler(this.TpManager_Load);
			this.tbMain.ResumeLayout(false);
			this.tbpCodeList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPlan)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tbpCodeEdit.ResumeLayout(false);
			this.tbpCodeEdit.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tbMain;
		private System.Windows.Forms.TabPage tbpCodeList;
		private System.Windows.Forms.DataGridView dgPlan;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtKeyword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tbpCodeEdit;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtOrderBy;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPlanName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPlanNo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtPlan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkUseYn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPlanNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPlanName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPlanDt;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUseYn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOrderBy;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescript;
	}
}