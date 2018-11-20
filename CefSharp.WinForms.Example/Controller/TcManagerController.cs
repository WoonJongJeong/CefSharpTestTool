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
	class TcManagerController
	{
		TcManagereService service;
		public TcManagerController()
		{
			service = new TcManagereService();
		}

		/*
		*  Test Case 관리
		*/
		public List<TsCase> SelectTsCase(string ts_plan_nm)
		{
			List<TsCase> list = service.SelectTsCase(ts_plan_nm);
			return list;
		}

		//SelectTsCaseByNo
		public TsCase SelectTsCaseByNo(string tc_case_no)
		{
			List<TsCase> list = service.SelectTsCaseByNo(tc_case_no);

			if (list.Count > 0)
			{
				return list[0];
			}
			else
			{
				return null;
			}
			
		}

		//SelectTsCaseByPlan
		public List<TsCase> SelectTsCaseByPlan(string ts_plan_no)
		{
			List<TsCase> list = service.SelectTsCaseByPlan(ts_plan_no);
			return list;
		}

		// INSERT or Update
		public int SaveTsCase(TsCase tsCase)
		{
			object result = null;

			if (tsCase.tc_case_no == 0)
			{
				result = service.InsertTsCase(tsCase);
			}
			else
			{
				result = service.UpdateTsCase(tsCase);
			}

			return (int)result;
		}

		// DELETE
		public int DeleteTsCase(TsCase tsCase)
		{
			object result = service.DeleteTsCase(tsCase);

			return (int)result;
		}
	}
}
