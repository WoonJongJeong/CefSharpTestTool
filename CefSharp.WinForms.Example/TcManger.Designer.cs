namespace TestTool.WinForms
{
	partial class TcManager
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
			this.chkUseYn = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtOrderBy = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPlanName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPlanNo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtGroupNo = new System.Windows.Forms.TextBox();
			this.txtGroupName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCaseNo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCaseName = new System.Windows.Forms.TextBox();
			this.cmbTestType = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtElementID = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbEventType = new System.Windows.Forms.ComboBox();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCheckString = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbCheckType = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtCheckTimeout = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// chkUseYn
			// 
			this.chkUseYn.AutoSize = true;
			this.chkUseYn.Location = new System.Drawing.Point(109, 365);
			this.chkUseYn.Name = "chkUseYn";
			this.chkUseYn.Size = new System.Drawing.Size(15, 14);
			this.chkUseYn.TabIndex = 45;
			this.chkUseYn.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(442, 492);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(81, 36);
			this.btnCancel.TabIndex = 40;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(355, 492);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(81, 36);
			this.btnSave.TabIndex = 41;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(109, 434);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(414, 52);
			this.txtDescription.TabIndex = 31;
			// 
			// txtOrderBy
			// 
			this.txtOrderBy.Location = new System.Drawing.Point(109, 393);
			this.txtOrderBy.Name = "txtOrderBy";
			this.txtOrderBy.Size = new System.Drawing.Size(68, 21);
			this.txtOrderBy.TabIndex = 32;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(30, 434);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 12);
			this.label7.TabIndex = 35;
			this.label7.Text = "Description";
			// 
			// txtPlanName
			// 
			this.txtPlanName.BackColor = System.Drawing.Color.White;
			this.txtPlanName.Enabled = false;
			this.txtPlanName.Location = new System.Drawing.Point(149, 3);
			this.txtPlanName.Name = "txtPlanName";
			this.txtPlanName.Size = new System.Drawing.Size(74, 21);
			this.txtPlanName.TabIndex = 33;
			this.txtPlanName.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 396);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 12);
			this.label6.TabIndex = 36;
			this.label6.Text = "Order By";
			// 
			// txtPlanNo
			// 
			this.txtPlanNo.BackColor = System.Drawing.SystemColors.Window;
			this.txtPlanNo.Location = new System.Drawing.Point(84, 3);
			this.txtPlanNo.Name = "txtPlanNo";
			this.txtPlanNo.Size = new System.Drawing.Size(59, 21);
			this.txtPlanNo.TabIndex = 34;
			this.txtPlanNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtPlanNo.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(229, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 12);
			this.label4.TabIndex = 39;
			this.label4.Text = "Group No";
			this.label4.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 12);
			this.label1.TabIndex = 39;
			this.label1.Text = "Plan No";
			this.label1.Visible = false;
			// 
			// txtGroupNo
			// 
			this.txtGroupNo.BackColor = System.Drawing.SystemColors.Window;
			this.txtGroupNo.Location = new System.Drawing.Point(294, 3);
			this.txtGroupNo.Name = "txtGroupNo";
			this.txtGroupNo.Size = new System.Drawing.Size(59, 21);
			this.txtGroupNo.TabIndex = 34;
			this.txtGroupNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtGroupNo.Visible = false;
			// 
			// txtGroupName
			// 
			this.txtGroupName.BackColor = System.Drawing.Color.White;
			this.txtGroupName.Location = new System.Drawing.Point(359, 3);
			this.txtGroupName.Name = "txtGroupName";
			this.txtGroupName.Size = new System.Drawing.Size(116, 21);
			this.txtGroupName.TabIndex = 33;
			this.txtGroupName.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 365);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 12);
			this.label3.TabIndex = 38;
			this.label3.Text = "Use ";
			// 
			// txtCaseNo
			// 
			this.txtCaseNo.BackColor = System.Drawing.SystemColors.Window;
			this.txtCaseNo.Location = new System.Drawing.Point(444, 36);
			this.txtCaseNo.Name = "txtCaseNo";
			this.txtCaseNo.Size = new System.Drawing.Size(59, 21);
			this.txtCaseNo.TabIndex = 46;
			this.txtCaseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtCaseNo.Visible = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(417, 39);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(21, 12);
			this.label8.TabIndex = 47;
			this.label8.Text = "No";
			this.label8.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(30, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 12);
			this.label9.TabIndex = 38;
			this.label9.Text = "Case";
			// 
			// txtCaseName
			// 
			this.txtCaseName.Location = new System.Drawing.Point(109, 36);
			this.txtCaseName.Name = "txtCaseName";
			this.txtCaseName.Size = new System.Drawing.Size(302, 21);
			this.txtCaseName.TabIndex = 33;
			// 
			// cmbTestType
			// 
			this.cmbTestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTestType.FormattingEnabled = true;
			this.cmbTestType.Location = new System.Drawing.Point(109, 78);
			this.cmbTestType.Name = "cmbTestType";
			this.cmbTestType.Size = new System.Drawing.Size(179, 20);
			this.cmbTestType.TabIndex = 48;
			this.cmbTestType.SelectedIndexChanged += new System.EventHandler(this.cmbTestType_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(30, 81);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(34, 12);
			this.label10.TabIndex = 38;
			this.label10.Text = "Type";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(30, 123);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(66, 12);
			this.label11.TabIndex = 38;
			this.label11.Text = "Element ID";
			// 
			// txtElementID
			// 
			this.txtElementID.Location = new System.Drawing.Point(109, 117);
			this.txtElementID.Name = "txtElementID";
			this.txtElementID.Size = new System.Drawing.Size(302, 21);
			this.txtElementID.TabIndex = 33;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(30, 158);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(36, 12);
			this.label12.TabIndex = 38;
			this.label12.Text = "Event";
			// 
			// cmbEventType
			// 
			this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEventType.FormattingEnabled = true;
			this.cmbEventType.Location = new System.Drawing.Point(109, 155);
			this.cmbEventType.Name = "cmbEventType";
			this.cmbEventType.Size = new System.Drawing.Size(185, 20);
			this.cmbEventType.TabIndex = 48;
			// 
			// txtValue
			// 
			this.txtValue.Location = new System.Drawing.Point(109, 193);
			this.txtValue.Multiline = true;
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(414, 72);
			this.txtValue.TabIndex = 49;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(30, 199);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(37, 12);
			this.label13.TabIndex = 50;
			this.label13.Text = "Value";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 327);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 50;
			this.label2.Text = "Check";
			// 
			// txtCheckString
			// 
			this.txtCheckString.Location = new System.Drawing.Point(109, 321);
			this.txtCheckString.Name = "txtCheckString";
			this.txtCheckString.Size = new System.Drawing.Size(414, 21);
			this.txtCheckString.TabIndex = 49;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 288);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 12);
			this.label5.TabIndex = 38;
			this.label5.Text = "CheckType";
			// 
			// cmbCheckType
			// 
			this.cmbCheckType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCheckType.FormattingEnabled = true;
			this.cmbCheckType.Location = new System.Drawing.Point(109, 285);
			this.cmbCheckType.Name = "cmbCheckType";
			this.cmbCheckType.Size = new System.Drawing.Size(185, 20);
			this.cmbCheckType.TabIndex = 48;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(343, 291);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(51, 12);
			this.label14.TabIndex = 38;
			this.label14.Text = "Timeout";
			// 
			// txtCheckTimeout
			// 
			this.txtCheckTimeout.Location = new System.Drawing.Point(413, 288);
			this.txtCheckTimeout.Name = "txtCheckTimeout";
			this.txtCheckTimeout.Size = new System.Drawing.Size(81, 21);
			this.txtCheckTimeout.TabIndex = 32;
			this.txtCheckTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(500, 293);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(23, 12);
			this.label15.TabIndex = 38;
			this.label15.Text = "ms";
			// 
			// TcManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 546);
			this.Controls.Add(this.txtCheckString);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtValue);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.cmbCheckType);
			this.Controls.Add(this.cmbEventType);
			this.Controls.Add(this.cmbTestType);
			this.Controls.Add(this.txtCaseNo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.chkUseYn);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtCheckTimeout);
			this.Controls.Add(this.txtOrderBy);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtElementID);
			this.Controls.Add(this.txtCaseName);
			this.Controls.Add(this.txtGroupName);
			this.Controls.Add(this.txtPlanName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtGroupNo);
			this.Controls.Add(this.txtPlanNo);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Name = "TcManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Test Case";
			this.Load += new System.EventHandler(this.TcManager_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkUseYn;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtOrderBy;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPlanName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPlanNo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGroupNo;
		private System.Windows.Forms.TextBox txtGroupName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCaseNo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCaseName;
		private System.Windows.Forms.ComboBox cmbTestType;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtElementID;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cmbEventType;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCheckString;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbCheckType;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtCheckTimeout;
		private System.Windows.Forms.Label label15;
	}
}