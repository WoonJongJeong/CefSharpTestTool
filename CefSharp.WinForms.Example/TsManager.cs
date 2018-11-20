using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Example;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestTool.Controller;
using TestTool.DAO;

namespace TestTool.WinForms
{
	public partial class TsManager : Form
	{
		TsManagerController controller = null;
		TcManagerController tcController = null;

		MainTool MAIN_TOOL;
		ChromiumWebBrowser CHROME;

		TsProcessor tsProcessor = null;

		public bool IsGroupTest { get; set; }

		public TsManager(MainTool mainTool,  ChromiumWebBrowser browser)
		{
			InitializeComponent();

			controller = new TsManagerController();
			tcController = new TcManagerController();

			MAIN_TOOL = mainTool;
			CHROME = browser;
			tsProcessor = new TsProcessor(this, CHROME);

			btnRunTest.Enabled = false;

			IsGroupTest = false;
		}

		private void btnTestPlan_Click(object sender, EventArgs e)
		{
			TpManager manager = new TpManager();

			manager.ShowDialog(this);

			GetTestPlan();
		}

		private void TsManager_Load(object sender, EventArgs e)
		{

			//Retrieve Test Plan
			GetTestPlan();
		}

		//Retrieve Test Plan
		void GetTestPlan()
		{
			this.Cursor = Cursors.WaitCursor;
			try
			{
				List<TsPlan> list = null;

				list = controller.SelectTsPlan("");

				cmbTestPlan.DisplayMember = "ts_plan_nm";
				cmbTestPlan.ValueMember = "ts_plan_no";
				cmbTestPlan.DataSource = list;
			}
			catch
			{
				MessageBox.Show("Test Plan 조회 시 오류가 발생했습니다.");
			}

			this.Cursor = Cursors.Default;
		}

		//private TreeNode m_OldSelectNode;
		private void treeMenu_MouseUp(object sender, MouseEventArgs e)
		{
			//Test Case인 경우만 활성화 시킴
			btnRunTest.Enabled = false;

			if (e.Button == MouseButtons.Right)
			{
				Point p = new Point(e.X, e.Y);
				TreeNode node = tvTestCase.GetNodeAt(p);
				if (node != null)
				{
					tvTestCase.SelectedNode = node;

					if (node.Level == 0)
					{
						treeMenuGroup.Show(tvTestCase, p);
					}
					else if (node.Level == 1)
					{
						treeMenuCase.Show(tvTestCase, p);
					}
					else if (node.Level == 2)
					{
						treeMenuCaseEdit.Show(tvTestCase, p);
					}

				}
			}
			else if (e.Button == MouseButtons.Left)
			{
				Point p = new Point(e.X, e.Y);
				TreeNode node = tvTestCase.GetNodeAt(p);
				if (node != null)
				{
					if (node.Level == 1 || node.Level == 2)
					{
						btnRunTest.Enabled = true;
					}
					else
					{
						btnRunTest.Enabled = false;
					}
				}
			}
		}

		//Test plan change
		private void cmbTestPlan_SelectedIndexChanged(object sender, EventArgs e)
		{
			string planNo = cmbTestPlan.SelectedValue.ToString();
			string planName = cmbTestPlan.Text;

			//Root Node 추가
			AddRootNode(planNo, planName);

			//Group Node 추가
			AddNodeList(planNo);
		}

		//Root Node 추가
		void AddRootNode(string planNo, string planName)
		{
			tvTestCase.Nodes.Clear();
			TreeNode rootNode = new TreeNode(planName, 0, 0);
			rootNode.Tag = planNo;

			//TreeView에 rootNode추가
			tvTestCase.Nodes.Add(rootNode);
		}

		private void cmnAddGroup_Click(object sender, EventArgs e)
		{
			if (tvTestCase.SelectedNode == null)
			{
				MessageBox.Show("Group을 추가 할 Plan을 선택하세요.");
				return;
			}
			TsGroup tsGroup = new TsGroup();
			tsGroup.ts_plan_no = int.Parse(tvTestCase.SelectedNode.Tag.ToString());
			tsGroup.ts_plan_nm = tvTestCase.SelectedNode.Text;
			tsGroup.ts_group_no = 0;

			//Group 추가:  group생성시 groupNo는 공백으로 전달
			TgManager tgManager = new TgManager(tsGroup);
			tgManager.StartPosition = FormStartPosition.CenterParent;
			tgManager.ShowDialog(this);

			//Root Node 추가
			AddRootNode(tsGroup.ts_plan_no.ToString(), tsGroup.ts_plan_nm);

			//Group Node 추가
			AddNodeList(tsGroup.ts_plan_no.ToString());
		}

		private void cmnEditGroup_Click(object sender, EventArgs e)
		{
			TsGroup tsGroup = new TsGroup();

			if (tvTestCase.SelectedNode == null)
			{
				MessageBox.Show("수정할 Group을 선택하세요.");
				return;
			}

			tsGroup.ts_plan_no = 0;
			tsGroup.ts_plan_nm = "";
			tsGroup.ts_group_no = int.Parse(tvTestCase.SelectedNode.Tag.ToString());

			//Group 추가:  group생성시 groupNo는 공백으로 전달
			TgManager tgManager = new TgManager(tsGroup);
			tgManager.StartPosition = FormStartPosition.CenterParent;
			tgManager.ShowDialog(this);
		}

		private void cmnRemoveGroup_Click(object sender, EventArgs e)
		{
			DialogResult dlg = MessageBox.Show("선택한 Group을 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dlg == DialogResult.No)
			{
				return;
			}

			//Group Remove
			TsGroup tsGroup = new TsGroup();

			if (tvTestCase.SelectedNode == null)
			{
				MessageBox.Show("삭제 할 Group을 선택하세요.");
				return;
			}

			tsGroup.ts_group_no = int.Parse(tvTestCase.SelectedNode.Tag.ToString());

			int Result = controller.DeleteTsGroup(tsGroup);

			if (Result == 1)
			{
				tvTestCase.SelectedNode.Remove();
				MessageBox.Show("Group을 삭제했습니다.");
			}
			else
			{
				MessageBox.Show("Group 삭제 중 오류가 발생했습니다.");
			}
		}
		private void cmnCaseAdd_Click(object sender, EventArgs e)
		{
			if (tvTestCase.SelectedNode == null)
			{
				return;
			}

			TcManager tcManager = new TcManager(tvTestCase);
			tcManager.PLAND_NO = tvTestCase.SelectedNode.Parent.Tag.ToString();
			tcManager.GROUP_NO = tvTestCase.SelectedNode.Tag.ToString();
			tcManager.CASE_NO = "0";

			tcManager.ShowDialog(this);
		}
		
		//Node 추가
		void AddNodeList(string PlanNo)
		{

			List<TsGroup> tsGroup = new List<TsGroup>();
			List<TsCase> tcList = new List<TsCase>();

			tsGroup = controller.SelectTsGroupByPlanNo(PlanNo);
			tcList = tcController.SelectTsCaseByPlan(PlanNo);

			foreach (TsGroup v in tsGroup)
			{
				TreeNode groupNode = new TreeNode(v.ts_group_nm, 0, 0);

				groupNode.Tag = v.ts_group_no; //Group정보 Key값을 Tag에 저장
				tvTestCase.Nodes[0].Nodes.Add(groupNode);

				//Case Node 추가
				var query = from tsCase in tcList
							where tsCase.ts_group_no == v.ts_group_no
							orderby tsCase.order_by ascending
							select tsCase;
							
				foreach (TsCase c in query)
				{
					TreeNode caseNode = new TreeNode(c.tc_case_nm, 0, 0);

					caseNode.Tag = c.tc_case_no.ToString();
					groupNode.Nodes.Add(caseNode);
				}
			}

			tvTestCase.ExpandAll();
		}

		private void cmnEditCase_Click(object sender, EventArgs e)
		{
			if (tvTestCase.SelectedNode == null)
			{
				return;
			}
			// Case Edit
			TcManager tcManager = new TcManager(tvTestCase);
			tcManager.PLAND_NO = tvTestCase.SelectedNode.Parent.Parent.Tag.ToString();
			tcManager.GROUP_NO = tvTestCase.SelectedNode.Parent.Tag.ToString();
			tcManager.CASE_NO = tvTestCase.SelectedNode.Tag.ToString();

			tcManager.ShowDialog(this);

		}

		private void cmnRemoveCase_Click(object sender, EventArgs e)
		{
			if (tvTestCase.SelectedNode == null)
			{
				return;
			}

			DialogResult dlg = MessageBox.Show("선택한 Test Case을 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dlg == DialogResult.No)
			{
				return;
			}

			//Group Remove
			TsCase tsCase = new TsCase();

			if (tvTestCase.SelectedNode == null)
			{
				MessageBox.Show("삭제 할 Test Case을 선택하세요.");
				return;
			}

			tsCase.tc_case_no = int.Parse(tvTestCase.SelectedNode.Tag.ToString());

			int Result = tcController.DeleteTsCase(tsCase);

			if (Result == 1)
			{
				tvTestCase.SelectedNode.Remove();
				MessageBox.Show("Test Case를 삭제했습니다.");
			}
			else
			{
				MessageBox.Show("Test Case 삭제 중 오류가 발생했습니다.");
			}
		}

		private async void btnRunTest_Click(object sender, EventArgs e)
		{
			//Test Group 실행
			if (tvTestCase.SelectedNode != null && tvTestCase.SelectedNode.Level == 1)
			{
				IsGroupTest = true;

				if (tvTestCase.SelectedNode.Nodes.Count > 0)
				{
					tvTestCase.SelectedNode = tvTestCase.SelectedNode.Nodes[0];

					RunTestCase();
				}
				
			}
			//선택된 Node
			else if (tvTestCase.SelectedNode != null && tvTestCase.SelectedNode.Level == 2)
			{ 
				IsGroupTest = false;

				RunTestCase();
			}
		}

		private async void RunTestCase()
		{
			TsCase tsCase = null;

			ControlEnabled(false);

			string tc_case_no = tvTestCase.SelectedNode.Tag.ToString();

			tsCase = tcController.SelectTsCaseByNo(tc_case_no);

			//테스트 시작 설정
			tsProcessor.IsStartTest = true; 

			await tsProcessor.runTestCase(tsCase);
		}

		//테스트 결과 기록
		public void SetTestResultTreeView(bool result)
		{
			ControlEnabled(true);

			//테스트 종료 설정
			tsProcessor.IsStartTest = false;

			//TreeView 결과 표시
			if (this.Visible == false) return;
			try {
				if (result)
				{
					tvTestCase.Invoke(new Action(delegate () {
						tvTestCase.SelectedNode.BackColor = Color.SpringGreen;
					}));
				}
				else
				{
					IsGroupTest = false; //Test실패 시  Group Test취소

					tvTestCase.Invoke(new Action(delegate () {
						tvTestCase.SelectedNode.BackColor = Color.Tomato;
					}));
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Test TreeView 설정 오류 발생" + Environment.NewLine + ex.ToString());
			}

			if (IsGroupTest == true)
			{
				tvTestCase.Invoke(new Action(delegate () {
					TreeNode nextNode = tvTestCase.SelectedNode.NextNode;

					if (nextNode != null)
					{
						tvTestCase.SelectedNode = nextNode;

						RunTestCase();
					}
					else
					{
						IsGroupTest = false;
					}
				}));
			}
		}

		public void ControlEnabled(bool Enabled)
		{
			try
			{
				btnRunTest.Invoke(new Action(delegate ()
				{
					btnRunTest.Enabled = Enabled;
				}));

				tvTestCase.Invoke(new Action(delegate ()
				{
					tvTestCase.Enabled = Enabled;
				}));
			}
			catch (Exception ex)
			{
				//
			}
		}

		private void btnDevTool_Click(object sender, EventArgs e)
		{
			IWinFormsWebBrowser Browser;
			Browser = CHROME;
			Browser.ShowDevTools();
		}
	}
}
