using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTool.Controller;
using TestTool.DAO;

namespace TestTool.WinForms
{
	public partial class frmCaegory : Form
	{

		CommonCodeController controller;
		List<CommonCategory> categoryList = null;

		public frmCaegory()
		{
			InitializeComponent();

			controller = new CommonCodeController();
		}

		private void frmCaegory_Load(object sender, EventArgs e)
		{
			GetCategoryList();
		}

		void GetCategoryList()
		{
			string keyword = txtKeyword.Text;

			categoryList = controller.SelectCommonCategory(keyword);
			dgCategory.DataSource = categoryList;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			tbCodeMain.SelectedIndex = 1;
		}

		// Code 삭제
		private void btnDelete_Click(object sender, EventArgs e)
		{
			//행선택 확인
			if (dgCategory.SelectedRows.Count == 0)
			{
				MessageBox.Show("삭제할 행을 선택하세요.");
			}

			DialogResult dialog = MessageBox.Show("선택한 행을 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo);

			if (dialog == DialogResult.No) return;
			
			CommonCategory category = getSelectCategory(dgCategory.SelectedRows[0].Index);

			if (category != null)
			{
				int result = controller.DeleteCommonCategory(category);

				if (result > 0)
				{
					//Data 재조회
					GetCategoryList();

					MessageBox.Show("선택한 행을 삭제했습니다.");

					
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			//Data 재조회
			GetCategoryList();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			CommonCategory category = new CommonCategory();

			category.category_cd = txtCode.Text == "" ? 0 : int.Parse(txtCode.Text);
			category.category_nm = txtName.Text;
			category.description = txtDescription.Text;
			category.use_yn = chkUseYn.Checked ? "Y" : "N";
			category.order_by = int.Parse(txtOrderBy.Text);

			int result = controller.SaveCommonCategory(category);

			MessageBox.Show("Saved Category Code.");

			//Data 재조회
			GetCategoryList();

			tbCodeMain.SelectedIndex = 0;
		}

		private void dgCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			CommonCategory category = new CommonCategory();

			category = getSelectCategory(e.RowIndex);

			if (category != null)
			{
				//Data 조회
				txtCode.Text = category.category_cd.ToString();
				txtName.Text = category.category_nm;
				txtOrderBy.Text = category.order_by.ToString();
				txtDescription.Text = category.description;
				chkUseYn.Checked = category.use_yn == "Y" ? true : false;


				tbCodeMain.SelectedIndex = 1;
			}
			else
			{
				MessageBox.Show("오류입니다.");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			tbCodeMain.SelectedIndex = 0;
		}

		CommonCategory getSelectCategory(int row)
		{
			if (dgCategory.SelectedRows.Count == 0)
			{
				return null;
			}

			List<CommonCategory> list = (List<CommonCategory>)dgCategory.DataSource;

			int col = dgCategory.Columns["colCategory"].Index;

			int category_cd = (int)dgCategory.Rows[row].Cells[col].Value;

			var query = from cat in list
						where cat.category_cd == category_cd
						select cat;

			try
			{
				return query.First();
			}
			catch
			{
				return null;
			}
			
		}
	}
}
