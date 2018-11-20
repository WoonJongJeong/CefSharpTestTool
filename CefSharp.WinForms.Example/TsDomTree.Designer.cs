namespace TestTool.WinForms
{
	partial class TsDomTree
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
			this.tvDomTree = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// tvDomTree
			// 
			this.tvDomTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvDomTree.Location = new System.Drawing.Point(0, 0);
			this.tvDomTree.Margin = new System.Windows.Forms.Padding(0);
			this.tvDomTree.Name = "tvDomTree";
			this.tvDomTree.Size = new System.Drawing.Size(461, 385);
			this.tvDomTree.TabIndex = 1;
			// 
			// TsDomTree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 385);
			this.Controls.Add(this.tvDomTree);
			this.Name = "TsDomTree";
			this.Text = "TsDomTree";
			this.Load += new System.EventHandler(this.TsDomTree_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView tvDomTree;
	}
}