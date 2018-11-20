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
	public partial class TpManager : Form
	{
		TsManagerController controller;
		public TpManager()
		{
			InitializeComponent();

			controller = new TsManagerController();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			SearchTsPlan();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			//Initialize Control
			InitializeControl();

			//Move edit tab
			tbMain.SelectedIndex = 1;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			TsPlan plan = new TsPlan();

			plan.ts_plan_no = txtPlanNo.Text == "" ? 0 : int.Parse(txtPlanNo.Text);
			plan.ts_plan_nm = txtPlanName.Text;
			plan.ts_plan_dt = dtPlan.Value;
			plan.use_yn = chkUseYn.Checked ? "Y" : "N";
			plan.order_by = txtOrderBy.Text.Trim() == "" ? 0 : int.Parse(txtOrderBy.Text);
			plan.description = txtDescription.Text;

			int result = controller.SaveTsPlan(plan);

			MessageBox.Show("Saved Plan.");

			//전체조회 되도록
			txtKeyword.Text = "";

			//Read Plan data
			SearchTsPlan();

			tbMain.SelectedIndex = 0;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}

		private void TpManager_Load(object sender, EventArgs e)
		{
			SearchTsPlan();
		}


		private void dgPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			List<TsPlan> List = (List<TsPlan>)dgPlan.DataSource;
			TsPlan plan = List[e.RowIndex];

			//선택한 Grid값 확인
			txtPlanNo.Text = plan.ts_plan_no.ToString();
			txtPlanName.Text = plan.ts_plan_nm;
			dtPlan.Value = plan.ts_plan_dt;
			chkUseYn.Checked = plan.use_yn == "Y" ? true : false;
			txtDescription.Text = plan.description;

			//Edit 탭 선택
			tbMain.SelectedIndex = 1;
		}

		void SearchTsPlan()
		{
			string keyword = txtKeyword.Text;
			List<TsPlan> list = null;

			list = controller.SelectTsPlan(keyword);

			dgPlan.DataSource = list;
		}


		TsPlan getSelectPlan(int row)
		{
			if (dgPlan.SelectedRows.Count == 0)
			{
				return null;
			}

			List<TsPlan> list = (List<TsPlan>)dgPlan.DataSource;

			int col = dgPlan.Columns["ts_plan_no"].Index;

			int ts_plan_no = (int)dgPlan.Rows[row].Cells[col].Value;

			var query = from plan in list
						where plan.ts_plan_no == ts_plan_no
						select plan;

			try
			{
				return query.First();
			}
			catch
			{
				return null;
			}

		}
		//InitializeControl 
		void InitializeControl()
		{
			txtPlanNo.Text = "";
			txtPlanName.Text = "";
			txtOrderBy.Text = "";
			txtDescription.Text = "";
			chkUseYn.Checked = true;
		}

	}
}
