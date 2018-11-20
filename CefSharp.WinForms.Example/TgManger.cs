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
	public partial class TgManager : Form
	{
		TsManagerController controller;

		public TreeNode PARENT_NODE { get; set; }

		string PLAN_NO;
		string PLAN_NM;
		string GROUP_NO;
		public TgManager(TsGroup tsGroup)
		{
			InitializeComponent();

			controller = new TsManagerController();

			PLAN_NO = tsGroup.ts_plan_no.ToString();
			PLAN_NM = tsGroup.ts_plan_nm.ToString();
			GROUP_NO = tsGroup.ts_group_no.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			TsGroup group = new TsGroup();

			group.ts_plan_no = txtPlanNo.Text == "" ? 0 : int.Parse(txtPlanNo.Text);
			group.ts_group_no = txtGroupNo.Text == "" ? 0 : int.Parse(txtGroupNo.Text);
			group.ts_group_nm = txtGroupName.Text;
			group.use_yn = chkUseYn.Checked ? "Y" : "N";
			group.order_by = txtOrderBy.Text.Trim() == "" ? 0 : int.Parse(txtOrderBy.Text);
			group.description = txtDescription.Text;

			int result = controller.SaveTsGroup(group);

			MessageBox.Show("Saved Group.");

			//창 닫기
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TpManager_Load(object sender, EventArgs e)
		{
			//Group No기준으로 Group정보를 조회
			if (GROUP_NO != "" && GROUP_NO != "0")
			{
				TsGroup tsGroup = GetTsGroup(GROUP_NO);
				
				InitializeControl(tsGroup);
			}
			else
			{
				//신규 Group정보를 조회할 수 있도록 기본값 설정
				TsGroup tsGroup = new TsGroup();
				tsGroup.ts_plan_no = int.Parse(PLAN_NO);
				tsGroup.ts_plan_nm = PLAN_NM;
				tsGroup.ts_group_no = 0; //신규 Group정보 시 0번
				tsGroup.use_yn = "Y"; //기본값
				InitializeControl(tsGroup); // initialize
			}
		}
		
		//InitializeControl 
		void InitializeControl(TsGroup tsGroup = null)
		{
			if (tsGroup == null)
			{
				txtPlanNo.Text = "";
				txtPlanName.Text = "";
				txtOrderBy.Text = "";
				txtDescription.Text = "";
				chkUseYn.Checked = true;
			}
			else
			{
				txtPlanNo.Text = tsGroup.ts_plan_no.ToString();
				txtPlanName.Text = tsGroup.ts_plan_nm;
				txtGroupNo.Text = tsGroup.ts_group_no.ToString();
				txtGroupName.Text = tsGroup.ts_group_nm;
				txtOrderBy.Text = tsGroup.order_by.ToString();
				txtDescription.Text = tsGroup.description;
				chkUseYn.Checked = tsGroup.use_yn == "Y" ? true : false;
			}
		}

		void SetTsGroupToControl(TsGroup tsGroup)
		{
			txtPlanNo.Text = "";
			txtPlanName.Text = "";
			txtOrderBy.Text = "";
			txtDescription.Text = "";
			chkUseYn.Checked = true;
		}

		//TsGroup정보 조회
		TsGroup GetTsGroup(string groupNo)
		{
			Dictionary<string, string> keyValues = new Dictionary<string, string>();
			keyValues.Add("ts_group_no", groupNo);

			List<TsGroup> list = controller.SelectTsGroup(keyValues);

			if (list.Count > 0)
			{
				return list[0];
			}
			else
			{
				return null;
			}
		}
		
	}
}
