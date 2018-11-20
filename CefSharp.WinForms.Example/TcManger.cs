using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestTool;
using TestTool.Controller;
using TestTool.DAO;


namespace TestTool.WinForms
{
	public partial class TcManager : Form
	{
		CommonCodeController cmController;
		TcManagerController  tcController;

		public TreeView TREE_VIEW { get; set; }

		string CATEGORY_TEST_TYPE = "";      //TestType
		string CATEGORY_CHECK_TYPE = "";      //Check type

		public string PLAND_NO { get; set; }
		public string GROUP_NO { get; set; }
		public string CASE_NO { get; set; }

		public TcManager( TreeView treeView)
		{
			InitializeComponent();

			cmController = new CommonCodeController();
			tcController = new TcManagerController();

			CATEGORY_TEST_TYPE = ConfigurationManager.AppSettings["CATEGORY_TEST_TYPE"];
			CATEGORY_CHECK_TYPE = ConfigurationManager.AppSettings["CATEGORY_CHECK_TYPE"];

			TREE_VIEW = treeView;
		}

		private void TcManager_Load(object sender, EventArgs e)
		{
			TsCase tsCase = new TsCase();

			//Case No가 있는 경우 Test Case 조회
			if (this.CASE_NO != "0"  && this.CASE_NO != "")
			{
				tsCase = tcController.SelectTsCaseByNo(this.CASE_NO);
			}
			else
			{
				tsCase.ts_plan_no = int.Parse(this.PLAND_NO);
				tsCase.ts_group_no = int.Parse(this.GROUP_NO);
				tsCase.tc_case_no = 0;
				tsCase.use_yn = "Y";
				tsCase.tc_check_timeout = 3000;
			}

			List<CommonCode> commonCodes = null;
			
			//Test Type설정
			commonCodes = Util.GetCommonCodeByCategory(CATEGORY_TEST_TYPE);
			cmbTestType.DisplayMember = "common_nm";
			cmbTestType.ValueMember = "common_cd";
			cmbTestType.DataSource = commonCodes;

			//Check Type
			commonCodes = Util.GetCommonCodeByCategory(CATEGORY_CHECK_TYPE);
			cmbCheckType.DisplayMember = "common_nm";
			cmbCheckType.ValueMember = "common_cd";
			cmbCheckType.DataSource = commonCodes;

			//Event Type조회
			GetCommonTypeListByParent();

			//초기화
			InitializeControl(tsCase);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			TsCase  tsCase = new TsCase();

			tsCase.tc_case_no = txtCaseNo.Text == "" ? 0 : int.Parse(txtCaseNo.Text);
			tsCase.tc_case_nm = txtCaseName.Text;
			tsCase.tc_test_type = int.Parse(cmbTestType.SelectedValue.ToString());
			tsCase.tc_element_id = txtElementID.Text;
			tsCase.tc_value = txtValue.Text;
			tsCase.tc_event_type = int.Parse(cmbEventType.SelectedValue.ToString());
			tsCase.tc_check_type = int.Parse(cmbCheckType.SelectedValue.ToString());
			tsCase.tc_check_timeout = txtCheckTimeout.Text == "" ? 0 : int.Parse(txtCheckTimeout.Text);
			tsCase.tc_check_string = txtCheckString.Text;
			tsCase.ts_plan_no = txtPlanNo.Text == "" ? 0 : int.Parse(txtPlanNo.Text);
			tsCase.ts_group_no = txtGroupNo.Text == "" ? 0 : int.Parse(txtGroupNo.Text); ;
			tsCase.tc_case_no = txtCaseNo.Text == "" ? 0 : int.Parse(txtCaseNo.Text); 
			tsCase.use_yn = chkUseYn.Checked ? "Y" : "N";
			tsCase.order_by = txtOrderBy.Text.Trim() == "" ? 0 : int.Parse(txtOrderBy.Text);
			tsCase.description = txtDescription.Text;

			int result = tcController.SaveTsCase(tsCase);

			//추가
			if (this.CASE_NO == "0")
			{
				TreeNode child = new TreeNode(txtCaseName.Text);
				child.Tag = result.ToString();

				TREE_VIEW.SelectedNode.Nodes.Add(child);
			}
			else
			{
				TREE_VIEW.SelectedNode.Text = txtCaseName.Text;
			}
			
			MessageBox.Show("Save Test Case.");

			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void SetTsGroupToControl(TsGroup tsGroup)
		{
			txtPlanNo.Text = "";
			txtPlanName.Text = "";
			txtOrderBy.Text = "";
			txtDescription.Text = "";
			chkUseYn.Checked = true;
		}

		private void cmbTestType_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetCommonTypeListByParent();
		}

		void GetCommonTypeListByParent()
		{
			//선택된 값 확인
			if (cmbTestType.SelectedItem == null)
			{
				return;
			}

			string parent_cd = cmbTestType.SelectedValue.ToString();

			List<CommonCode> commonCodes = null;

			//Event Type설정
			commonCodes = Util.SelectCmCodeByParent(parent_cd);
			cmbEventType.DisplayMember = "common_nm";
			cmbEventType.ValueMember = "common_cd";
			cmbEventType.DataSource = commonCodes;
		}

		void InitializeControl(TsCase tsCase = null)
		{
			if (tsCase == null)
			{
				txtPlanNo.Text = "";
				txtPlanName.Text = "";
				txtGroupNo.Text = "";
				txtGroupName.Text = "";
				txtCaseNo.Text = "";
				txtCaseName.Text = "";
				txtElementID.Text = "";
				txtValue.Text = "";
				txtCheckTimeout.Text = "3000"; //기본 Timeout: 3초(3000ms)
				txtCheckString.Text = "";
				chkUseYn.Checked = true;
				txtOrderBy.Text = "";
				txtDescription.Text = "";
			}
			else
			{
				//combo box
				cmbTestType.SelectedValue = tsCase.tc_test_type;
				cmbEventType.SelectedValue = tsCase.tc_event_type;
				cmbCheckType.SelectedValue = tsCase.tc_check_type;

				txtPlanNo.Text = tsCase.ts_plan_no.ToString();
				txtPlanName.Text = "";
				txtGroupNo.Text = tsCase.ts_group_no.ToString();
				txtGroupName.Text = "";
				txtCaseNo.Text =tsCase.tc_case_no.ToString() ;
				txtCaseName.Text = tsCase.tc_case_nm;
				txtElementID.Text = tsCase.tc_element_id;
				txtValue.Text = tsCase.tc_value;
				txtCheckTimeout.Text = tsCase.tc_check_timeout.ToString();
				txtCheckString.Text = tsCase.tc_check_string;
				chkUseYn.Checked = tsCase.use_yn == "Y" ? true : false;
				txtOrderBy.Text = tsCase.order_by.ToString();
				txtDescription.Text = tsCase.description;
			}
		}
	}
}
