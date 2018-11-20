namespace TestTool.WinForms
{
	partial class frmCode
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtKeyword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbCodeMain = new System.Windows.Forms.TabControl();
			this.tbpCodeList = new System.Windows.Forms.TabPage();
			this.dgCodeList = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmbGroup = new System.Windows.Forms.ComboBox();
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbpCodeEdit = new System.Windows.Forms.TabPage();
			this.txtKeyValue = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtKeyCode = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.chkUseYn = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtOrderBy = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbParent = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCategoryNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colParentCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKeyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colKeyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUseYn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescript = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbCodeMain.SuspendLayout();
			this.tbpCodeList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCodeList)).BeginInit();
			this.panel1.SuspendLayout();
			this.tbpCodeEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtKeyword
			// 
			this.txtKeyword.Location = new System.Drawing.Point(397, 16);
			this.txtKeyword.Name = "txtKeyword";
			this.txtKeyword.Size = new System.Drawing.Size(192, 21);
			this.txtKeyword.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(332, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "Keyword:";
			// 
			// tbCodeMain
			// 
			this.tbCodeMain.Controls.Add(this.tbpCodeList);
			this.tbCodeMain.Controls.Add(this.tbpCodeEdit);
			this.tbCodeMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbCodeMain.Location = new System.Drawing.Point(0, 0);
			this.tbCodeMain.Name = "tbCodeMain";
			this.tbCodeMain.SelectedIndex = 0;
			this.tbCodeMain.Size = new System.Drawing.Size(1069, 585);
			this.tbCodeMain.TabIndex = 4;
			// 
			// tbpCodeList
			// 
			this.tbpCodeList.Controls.Add(this.dgCodeList);
			this.tbpCodeList.Controls.Add(this.panel1);
			this.tbpCodeList.Location = new System.Drawing.Point(4, 22);
			this.tbpCodeList.Margin = new System.Windows.Forms.Padding(0);
			this.tbpCodeList.Name = "tbpCodeList";
			this.tbpCodeList.Size = new System.Drawing.Size(1061, 559);
			this.tbpCodeList.TabIndex = 0;
			this.tbpCodeList.Text = "List";
			this.tbpCodeList.UseVisualStyleBackColor = true;
			// 
			// dgCodeList
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCodeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgCodeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgCodeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategory,
            this.colCategoryNm,
            this.colParentCd,
            this.colCode,
            this.colName,
            this.colKeyCode,
            this.colKeyValue,
            this.colUseYn,
            this.colOrderBy,
            this.colDescript});
			this.dgCodeList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgCodeList.Location = new System.Drawing.Point(0, 59);
			this.dgCodeList.MultiSelect = false;
			this.dgCodeList.Name = "dgCodeList";
			this.dgCodeList.ReadOnly = true;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCodeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgCodeList.RowTemplate.Height = 23;
			this.dgCodeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgCodeList.Size = new System.Drawing.Size(1061, 500);
			this.dgCodeList.TabIndex = 1;
			this.dgCodeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCodeList_CellDoubleClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.cmbGroup);
			this.panel1.Controls.Add(this.btnAddCategory);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnNew);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.txtKeyword);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1061, 59);
			this.panel1.TabIndex = 0;
			// 
			// cmbGroup
			// 
			this.cmbGroup.FormattingEnabled = true;
			this.cmbGroup.Location = new System.Drawing.Point(62, 16);
			this.cmbGroup.Name = "cmbGroup";
			this.cmbGroup.Size = new System.Drawing.Size(219, 20);
			this.cmbGroup.TabIndex = 5;
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Location = new System.Drawing.Point(287, 14);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(31, 23);
			this.btnAddCategory.TabIndex = 4;
			this.btnAddCategory.Text = "N";
			this.btnAddCategory.UseVisualStyleBackColor = true;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(794, 14);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(703, 14);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 23);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(613, 14);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "Group:";
			// 
			// tbpCodeEdit
			// 
			this.tbpCodeEdit.Controls.Add(this.cmbParent);
			this.tbpCodeEdit.Controls.Add(this.label11);
			this.tbpCodeEdit.Controls.Add(this.txtKeyValue);
			this.tbpCodeEdit.Controls.Add(this.label10);
			this.tbpCodeEdit.Controls.Add(this.txtKeyCode);
			this.tbpCodeEdit.Controls.Add(this.label9);
			this.tbpCodeEdit.Controls.Add(this.panel2);
			this.tbpCodeEdit.Controls.Add(this.chkUseYn);
			this.tbpCodeEdit.Controls.Add(this.btnCancel);
			this.tbpCodeEdit.Controls.Add(this.btnSave);
			this.tbpCodeEdit.Controls.Add(this.cmbCategory);
			this.tbpCodeEdit.Controls.Add(this.txtDescription);
			this.tbpCodeEdit.Controls.Add(this.txtOrderBy);
			this.tbpCodeEdit.Controls.Add(this.label7);
			this.tbpCodeEdit.Controls.Add(this.txtName);
			this.tbpCodeEdit.Controls.Add(this.label8);
			this.tbpCodeEdit.Controls.Add(this.label6);
			this.tbpCodeEdit.Controls.Add(this.txtCode);
			this.tbpCodeEdit.Controls.Add(this.label5);
			this.tbpCodeEdit.Controls.Add(this.label3);
			this.tbpCodeEdit.Controls.Add(this.label4);
			this.tbpCodeEdit.Location = new System.Drawing.Point(4, 22);
			this.tbpCodeEdit.Name = "tbpCodeEdit";
			this.tbpCodeEdit.Padding = new System.Windows.Forms.Padding(3);
			this.tbpCodeEdit.Size = new System.Drawing.Size(1061, 559);
			this.tbpCodeEdit.TabIndex = 1;
			this.tbpCodeEdit.Text = "Edit";
			this.tbpCodeEdit.UseVisualStyleBackColor = true;
			// 
			// txtKeyValue
			// 
			this.txtKeyValue.Location = new System.Drawing.Point(113, 242);
			this.txtKeyValue.Name = "txtKeyValue";
			this.txtKeyValue.Size = new System.Drawing.Size(299, 21);
			this.txtKeyValue.TabIndex = 29;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(35, 245);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 12);
			this.label10.TabIndex = 30;
			this.label10.Text = "Value";
			// 
			// txtKeyCode
			// 
			this.txtKeyCode.Location = new System.Drawing.Point(113, 206);
			this.txtKeyCode.Name = "txtKeyCode";
			this.txtKeyCode.Size = new System.Drawing.Size(116, 21);
			this.txtKeyCode.TabIndex = 29;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(35, 209);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(27, 12);
			this.label9.TabIndex = 30;
			this.label9.Text = "Key";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1055, 29);
			this.panel2.TabIndex = 28;
			// 
			// chkUseYn
			// 
			this.chkUseYn.AutoSize = true;
			this.chkUseYn.Location = new System.Drawing.Point(113, 315);
			this.chkUseYn.Name = "chkUseYn";
			this.chkUseYn.Size = new System.Drawing.Size(15, 14);
			this.chkUseYn.TabIndex = 11;
			this.chkUseYn.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(422, 387);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(337, 387);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(113, 68);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(299, 20);
			this.cmbCategory.TabIndex = 9;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(113, 348);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(384, 21);
			this.txtDescription.TabIndex = 6;
			// 
			// txtOrderBy
			// 
			this.txtOrderBy.Location = new System.Drawing.Point(113, 275);
			this.txtOrderBy.Name = "txtOrderBy";
			this.txtOrderBy.Size = new System.Drawing.Size(116, 21);
			this.txtOrderBy.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(35, 351);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 12);
			this.label7.TabIndex = 8;
			this.label7.Text = "Description";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(113, 170);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(299, 21);
			this.txtName.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(35, 316);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 12);
			this.label8.TabIndex = 8;
			this.label8.Text = "Use YN";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(35, 278);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 12);
			this.label6.TabIndex = 8;
			this.label6.Text = "Order By";
			// 
			// txtCode
			// 
			this.txtCode.Enabled = false;
			this.txtCode.Location = new System.Drawing.Point(113, 134);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(116, 21);
			this.txtCode.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "Category";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "Code";
			// 
			// cmbParent
			// 
			this.cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbParent.FormattingEnabled = true;
			this.cmbParent.Location = new System.Drawing.Point(113, 100);
			this.cmbParent.Name = "cmbParent";
			this.cmbParent.Size = new System.Drawing.Size(299, 20);
			this.cmbParent.TabIndex = 32;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(34, 103);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(41, 12);
			this.label11.TabIndex = 31;
			this.label11.Text = "Parent";
			// 
			// colCategory
			// 
			this.colCategory.DataPropertyName = "category_cd";
			this.colCategory.HeaderText = "Category";
			this.colCategory.Name = "colCategory";
			this.colCategory.ReadOnly = true;
			this.colCategory.Visible = false;
			// 
			// colCategoryNm
			// 
			this.colCategoryNm.DataPropertyName = "category_nm";
			this.colCategoryNm.HeaderText = "Category";
			this.colCategoryNm.Name = "colCategoryNm";
			this.colCategoryNm.ReadOnly = true;
			this.colCategoryNm.Width = 250;
			// 
			// colParentCd
			// 
			this.colParentCd.DataPropertyName = "parent_nm";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.colParentCd.DefaultCellStyle = dataGridViewCellStyle2;
			this.colParentCd.HeaderText = "Parent";
			this.colParentCd.Name = "colParentCd";
			this.colParentCd.ReadOnly = true;
			this.colParentCd.Width = 200;
			// 
			// colCode
			// 
			this.colCode.DataPropertyName = "common_cd";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.colCode.DefaultCellStyle = dataGridViewCellStyle3;
			this.colCode.HeaderText = "Code";
			this.colCode.Name = "colCode";
			this.colCode.ReadOnly = true;
			this.colCode.Visible = false;
			// 
			// colName
			// 
			this.colName.DataPropertyName = "common_nm";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.colName.DefaultCellStyle = dataGridViewCellStyle4;
			this.colName.HeaderText = "Code Name";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			this.colName.Width = 300;
			// 
			// colKeyCode
			// 
			this.colKeyCode.DataPropertyName = "key_cd";
			this.colKeyCode.HeaderText = "Key";
			this.colKeyCode.Name = "colKeyCode";
			this.colKeyCode.ReadOnly = true;
			// 
			// colKeyValue
			// 
			this.colKeyValue.DataPropertyName = "key_val";
			this.colKeyValue.HeaderText = "Value";
			this.colKeyValue.Name = "colKeyValue";
			this.colKeyValue.ReadOnly = true;
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
			this.colDescript.Width = 200;
			// 
			// frmCode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 585);
			this.Controls.Add(this.tbCodeMain);
			this.Name = "frmCode";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Common Code";
			this.Load += new System.EventHandler(this.frmCode_Load);
			this.tbCodeMain.ResumeLayout(false);
			this.tbpCodeList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgCodeList)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tbpCodeEdit.ResumeLayout(false);
			this.tbpCodeEdit.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtKeyword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tbCodeMain;
		private System.Windows.Forms.TabPage tbpCodeList;
		private System.Windows.Forms.DataGridView dgCodeList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage tbpCodeEdit;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cmbGroup;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtOrderBy;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox chkUseYn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnAddCategory;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtKeyValue;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtKeyCode;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cmbParent;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryNm;
		private System.Windows.Forms.DataGridViewTextBoxColumn colParentCd;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKeyCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colKeyValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUseYn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOrderBy;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescript;
	}
}