namespace TestTool.WinForms
{
	partial class frmCaegory
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tbpCodeEdit = new System.Windows.Forms.TabPage();
			this.chkUseYn = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtOrderBy = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnNew = new System.Windows.Forms.Button();
			this.txtKeyword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbpCodeList = new System.Windows.Forms.TabPage();
			this.tbCodeMain = new System.Windows.Forms.TabControl();
			this.dgCategory = new System.Windows.Forms.DataGridView();
			this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUseYn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescript = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbpCodeEdit.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tbpCodeList.SuspendLayout();
			this.tbCodeMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCategory)).BeginInit();
			this.SuspendLayout();
			// 
			// tbpCodeEdit
			// 
			this.tbpCodeEdit.Controls.Add(this.panel2);
			this.tbpCodeEdit.Controls.Add(this.chkUseYn);
			this.tbpCodeEdit.Controls.Add(this.btnCancel);
			this.tbpCodeEdit.Controls.Add(this.btnSave);
			this.tbpCodeEdit.Controls.Add(this.txtDescription);
			this.tbpCodeEdit.Controls.Add(this.txtOrderBy);
			this.tbpCodeEdit.Controls.Add(this.label7);
			this.tbpCodeEdit.Controls.Add(this.txtName);
			this.tbpCodeEdit.Controls.Add(this.label8);
			this.tbpCodeEdit.Controls.Add(this.label6);
			this.tbpCodeEdit.Controls.Add(this.txtCode);
			this.tbpCodeEdit.Controls.Add(this.label5);
			this.tbpCodeEdit.Controls.Add(this.label4);
			this.tbpCodeEdit.Location = new System.Drawing.Point(4, 22);
			this.tbpCodeEdit.Margin = new System.Windows.Forms.Padding(0);
			this.tbpCodeEdit.Name = "tbpCodeEdit";
			this.tbpCodeEdit.Size = new System.Drawing.Size(908, 517);
			this.tbpCodeEdit.TabIndex = 1;
			this.tbpCodeEdit.Text = "Edit";
			this.tbpCodeEdit.UseVisualStyleBackColor = true;
			// 
			// chkUseYn
			// 
			this.chkUseYn.AutoSize = true;
			this.chkUseYn.Location = new System.Drawing.Point(101, 178);
			this.chkUseYn.Name = "chkUseYn";
			this.chkUseYn.Size = new System.Drawing.Size(15, 14);
			this.chkUseYn.TabIndex = 25;
			this.chkUseYn.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(328, 252);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 24;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(104, 214);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(384, 21);
			this.txtDescription.TabIndex = 13;
			// 
			// txtOrderBy
			// 
			this.txtOrderBy.Location = new System.Drawing.Point(104, 141);
			this.txtOrderBy.Name = "txtOrderBy";
			this.txtOrderBy.Size = new System.Drawing.Size(116, 21);
			this.txtOrderBy.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 214);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 12);
			this.label7.TabIndex = 18;
			this.label7.Text = "Description";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(104, 103);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(299, 21);
			this.txtName.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(23, 179);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 12);
			this.label8.TabIndex = 19;
			this.label8.Text = "Use YN";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(23, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 12);
			this.label6.TabIndex = 20;
			this.label6.Text = "Order By";
			// 
			// txtCode
			// 
			this.txtCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtCode.Enabled = false;
			this.txtCode.Location = new System.Drawing.Point(104, 67);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(116, 21);
			this.txtCode.TabIndex = 16;
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
			this.label4.Size = new System.Drawing.Size(35, 12);
			this.label4.TabIndex = 22;
			this.label4.Text = "Code";
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
			this.panel1.Size = new System.Drawing.Size(908, 59);
			this.panel1.TabIndex = 0;
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
			// tbpCodeList
			// 
			this.tbpCodeList.Controls.Add(this.dgCategory);
			this.tbpCodeList.Controls.Add(this.panel1);
			this.tbpCodeList.Location = new System.Drawing.Point(4, 22);
			this.tbpCodeList.Margin = new System.Windows.Forms.Padding(0);
			this.tbpCodeList.Name = "tbpCodeList";
			this.tbpCodeList.Size = new System.Drawing.Size(908, 517);
			this.tbpCodeList.TabIndex = 0;
			this.tbpCodeList.Text = "List";
			this.tbpCodeList.UseVisualStyleBackColor = true;
			// 
			// tbCodeMain
			// 
			this.tbCodeMain.Controls.Add(this.tbpCodeList);
			this.tbCodeMain.Controls.Add(this.tbpCodeEdit);
			this.tbCodeMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbCodeMain.Location = new System.Drawing.Point(0, 0);
			this.tbCodeMain.Margin = new System.Windows.Forms.Padding(0);
			this.tbCodeMain.Name = "tbCodeMain";
			this.tbCodeMain.SelectedIndex = 0;
			this.tbCodeMain.Size = new System.Drawing.Size(916, 543);
			this.tbCodeMain.TabIndex = 5;
			// 
			// dgCategory
			// 
			this.dgCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategory,
            this.colName,
            this.colUseYn,
            this.colOrderBy,
            this.colDescript});
			this.dgCategory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgCategory.Location = new System.Drawing.Point(0, 59);
			this.dgCategory.MultiSelect = false;
			this.dgCategory.Name = "dgCategory";
			this.dgCategory.ReadOnly = true;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgCategory.RowTemplate.Height = 23;
			this.dgCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgCategory.Size = new System.Drawing.Size(908, 458);
			this.dgCategory.TabIndex = 1;
			this.dgCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategory_CellDoubleClick);
			// 
			// colCategory
			// 
			this.colCategory.DataPropertyName = "category_cd";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.colCategory.DefaultCellStyle = dataGridViewCellStyle6;
			this.colCategory.HeaderText = "Code";
			this.colCategory.Name = "colCategory";
			this.colCategory.ReadOnly = true;
			// 
			// colName
			// 
			this.colName.DataPropertyName = "category_nm";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.colName.DefaultCellStyle = dataGridViewCellStyle7;
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			this.colName.Width = 300;
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
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(413, 252);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 24;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(908, 29);
			this.panel2.TabIndex = 27;
			// 
			// frmCaegory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(916, 543);
			this.Controls.Add(this.tbCodeMain);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCaegory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Category Code";
			this.Load += new System.EventHandler(this.frmCaegory_Load);
			this.tbpCodeEdit.ResumeLayout(false);
			this.tbpCodeEdit.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tbpCodeList.ResumeLayout(false);
			this.tbCodeMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgCategory)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tbpCodeEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.TextBox txtKeyword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tbpCodeList;
		private System.Windows.Forms.TabControl tbCodeMain;
		private System.Windows.Forms.CheckBox chkUseYn;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtOrderBy;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUseYn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOrderBy;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescript;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel panel2;
	}
}