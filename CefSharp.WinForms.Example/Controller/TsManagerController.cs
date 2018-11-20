using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTool.DAO;
using TestTool.Service;
using IBatisNet.DataMapper;

namespace TestTool.Controller
{
	class TsManagerController
	{
		TsManagereService service;
		public TsManagerController()
		{
			service = new TsManagereService();
		}

		/*
		*  Test Plan 관리
		*/
		public List<TsPlan> SelectTsPlan(string ts_plan_nm)
		{
			List<TsPlan> list = service.SelectTsPlan(ts_plan_nm);
			return list;
		}

		// INSERT or Update
		public int SaveTsPlan(TsPlan tsPlan)
		{
			object result = null;

			if (tsPlan.ts_plan_no == 0)
			{
				result = service.InsertTsPlan(tsPlan);
			}
			else
			{
				result = service.UpdateTsPlan(tsPlan);
			}

			return (int)result;
		}

		// DELETE
		public int DeleteTsPlan(TsPlan tsPlan)
		{
			object result = service.DeleteTsPlan(tsPlan);

			return (int)result;
		}

		/*
		*  Test Group 관리
		*/
		public List<TsGroup> SelectTsGroup(Dictionary<string, string> values)
		{
			List<TsGroup> list = service.SelectTsGroup(values);
			return list;
		}

		public List<TsGroup> SelectTsGroupByPlanNo(string ts_plan_no)
		{
			List<TsGroup> list = service.SelectTsGroupByPlanNo(ts_plan_no);
			return list;
		}

		// INSERT or Update
		public int SaveTsGroup(TsGroup tsGroup)
		{
			object result = null;

			if (tsGroup.ts_group_no == 0)
			{
				result = service.InsertTsGroup(tsGroup);
			}
			else
			{
				result = service.UpdateTsGroup(tsGroup);
			}

			return (int)result;
		}

		// DELETE
		public int DeleteTsGroup(TsGroup tsPlan)
		{
			object result = service.DeleteTsGroup(tsPlan);

			return (int)result;
		}
	}
}
