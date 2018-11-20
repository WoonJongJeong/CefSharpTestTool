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
	public partial class frmCode : Form
	{
		CommonCodeController controller;
		List<CommonCategory> categoryList = null;
		List<CommonCode> codeList = null;

		public frmCode()
		{
			InitializeComponent();

			controller = new CommonCodeController();
		}

		private void frmCode_Load(object sender, EventArgs e)
		{
			//Common Code
			SearchCommonCode();

			categoryList = controller.SelectCommonCategory("");

			cmbGroup.DisplayMember = "category_nm";
			cmbGroup.ValueMember = "category_cd";
			cmbGroup.DataSource = categoryList;

			cmbCategory.DisplayMember = "category_nm";
			cmbCategory.ValueMember = "category_cd";
			cmbCategory.DataSource = categoryList;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			SearchCommonCode();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			//Control 입력값 초기화
			InitializeControl();

			//Tab 선택
			tbCodeMain.SelectedIndex = 1;
		}

		void SearchCommonCode()
		{
			string common_nm = txtKeyword.Text;

			//Data Grid 
			codeList = controller.SelectCommonCode(common_nm);

			dgCodeList.DataSource = codeList;

			//Parent common code설정
			cmbParent.DisplayMember = "common_nm";
			cmbParent.ValueMember = "common_cd";
			cmbParent.DataSource = codeList;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (cmbCategory.SelectedValue == null || (int)cmbCategory.SelectedValue == 0)
			{
				MessageBox.Show("Category를 선택하세요.");
				return;
			}

			CommonCode code = new CommonCode();

			code.common_cd = txtCode.Text == "" ? 0 :int.Parse(txtCode.Text);
			code.common_nm = txtName.Text;
			code.key_cd = txtKeyCode.Text;
			code.key_val = txtKeyValue.Text;
			code.category_cd = (int)cmbCategory.SelectedValue;
			code.use_yn = chkUseYn.Checked ? "Y" : "N";
			code.order_by = txtOrderBy.Text == "" ? 0 : int.Parse(txtOrderBy.Text);
			code.parent_cd = cmbParent.SelectedValue != null ? int.Parse(cmbParent.SelectedValue.ToString()) : 0;
			code.description = txtDescription.Text;

			int result = controller.SaveCommonCode(code);

			if (result > 0)
			{
				//목록 재조회
				SearchCommonCode();

				//목록 탭으로 이동
				tbCodeMain.SelectedIndex = 0;

				MessageBox.Show("저장했습니다.");
			}
			else
			{
				MessageBox.Show("저장 시 오류가 발생했습니다.");
			}

		}


		private void dgCodeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return; //Header click

			List<CommonCode> List = (List<CommonCode>)dgCodeList.DataSource;
			CommonCode code =List[e.RowIndex];

			//선택한 Grid값 확인
			cmbCategory.SelectedValue = code.category_cd;
			cmbParent.SelectedValue = code.parent_cd;

			txtCode.Text = code.common_cd.ToString();
			txtName.Text = code.common_nm;
			txtKeyCode.Text = code.key_cd;
			txtKeyValue.Text = code.key_val;
			chkUseYn.Checked = code.use_yn == "Y" ? true : false;
			txtOrderBy.Text = code.order_by.ToString();
			txtDescription.Text = code.description;

			//Edit 탭 선택
			tbCodeMain.SelectedIndex = 1;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgCodeList.SelectedRows.Count == 0)
			{
				MessageBox.Show("삭제 할 행을 선택하세요.");
				return;
			}

			DialogResult dialog = MessageBox.Show("선택한 행을 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo);

			if (dialog == DialogResult.No) return;

			CommonCode code= getSelectCode(dgCodeList.SelectedRows[0].Index);

			if (code != null)
			{
				int result = controller.DeleteCommonCode(code);

				if (result > 0)
				{
					//Data 재조회
					SearchCommonCode();

					MessageBox.Show("선택한 행을 삭제했습니다.");
				}
			}

		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{
			//Category관리 창 Open
			frmCaegory formCategory = new frmCaegory();
			formCategory.ShowDialog (this);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			tbCodeMain.SelectedIndex = 0;
		}

		CommonCode getSelectCode(int row)
		{
			if (dgCodeList.SelectedRows.Count == 0)
			{
				return null;
			}

			List<CommonCode> list = (List<CommonCode>)dgCodeList.DataSource;

			int col = dgCodeList.Columns["colCode"].Index;

			int common_cd = (int)dgCodeList.Rows[row].Cells[col].Value;

			var query = from cd in list
						where cd.common_cd == common_cd
						select cd;

			try
			{
				return query.First();
			}
			catch
			{
				return null;
			}
		}

		void InitializeControl()
		{
			//cmbCategory.SelectedIndex 
			txtCode.Text = "";
			txtName.Text = "";
			txtKeyCode.Text = "";
			txtKeyValue.Text = "";
			txtOrderBy.Text = "";
			chkUseYn.Checked = true;
			txtDescription.Text = "";
		}
	}
}
