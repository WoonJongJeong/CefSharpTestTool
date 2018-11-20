namespace TestTool.WinForms
{
	partial class TgManager
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
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtGroupNo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtGroupName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// chkUseYn
			// 
			this.chkUseYn.AutoSize = true;
			this.chkUseYn.Location = new System.Drawing.Point(91, 109);
			this.chkUseYn.Name = "chkUseYn";
			this.chkUseYn.Size = new System.Drawing.Size(15, 14);
			this.chkUseYn.TabIndex = 45;
			this.chkUseYn.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(285, 253);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(66, 33);
			this.btnCancel.TabIndex = 40;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(203, 253);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(66, 33);
			this.btnSave.TabIndex = 41;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(91, 178);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(260, 52);
			this.txtDescription.TabIndex = 31;
			// 
			// txtOrderBy
			// 
			this.txtOrderBy.Location = new System.Drawing.Point(91, 137);
			this.txtOrderBy.Name = "txtOrderBy";
			this.txtOrderBy.Size = new System.Drawing.Size(88, 21);
			this.txtOrderBy.TabIndex = 32;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(17, 178);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 12);
			this.label7.TabIndex = 35;
			this.label7.Text = "Description";
			// 
			// txtPlanName
			// 
			this.txtPlanName.Enabled = false;
			this.txtPlanName.Location = new System.Drawing.Point(91, 34);
			this.txtPlanName.Name = "txtPlanName";
			this.txtPlanName.Size = new System.Drawing.Size(260, 21);
			this.txtPlanName.TabIndex = 33;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 12);
			this.label6.TabIndex = 36;
			this.label6.Text = "Order By";
			// 
			// txtPlanNo
			// 
			this.txtPlanNo.BackColor = System.Drawing.SystemColors.Window;
			this.txtPlanNo.Location = new System.Drawing.Point(98, 4);
			this.txtPlanNo.Name = "txtPlanNo";
			this.txtPlanNo.Size = new System.Drawing.Size(59, 21);
			this.txtPlanNo.TabIndex = 34;
			this.txtPlanNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtPlanNo.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 12);
			this.label5.TabIndex = 38;
			this.label5.Text = "Group";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(163, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 12);
			this.label4.TabIndex = 39;
			this.label4.Text = "Group No";
			this.label4.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 12);
			this.label1.TabIndex = 39;
			this.label1.Text = "Plan No";
			this.label1.Visible = false;
			// 
			// txtGroupNo
			// 
			this.txtGroupNo.BackColor = System.Drawing.SystemColors.Window;
			this.txtGroupNo.Location = new System.Drawing.Point(228, 4);
			this.txtGroupNo.Name = "txtGroupNo";
			this.txtGroupNo.Size = new System.Drawing.Size(59, 21);
			this.txtGroupNo.TabIndex = 34;
			this.txtGroupNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtGroupNo.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 12);
			this.label2.TabIndex = 38;
			this.label2.Text = "Plan";
			// 
			// txtGroupName
			// 
			this.txtGroupName.Location = new System.Drawing.Point(91, 77);
			this.txtGroupName.Name = "txtGroupName";
			this.txtGroupName.Size = new System.Drawing.Size(260, 21);
			this.txtGroupName.TabIndex = 33;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 12);
			this.label3.TabIndex = 38;
			this.label3.Text = "Use ";
			// 
			// TgManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 300);
			this.Controls.Add(this.chkUseYn);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtOrderBy);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtGroupName);
			this.Controls.Add(this.txtPlanName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtGroupNo);
			this.Controls.Add(this.txtPlanNo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Name = "TgManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Group";
			this.Load += new System.EventHandler(this.TpManager_Load);
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
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGroupNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGroupName;
		private System.Windows.Forms.Label label3;
	}
}