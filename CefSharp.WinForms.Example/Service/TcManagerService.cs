using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTool.DAO;

namespace TestTool.Service
{
	class TcManagereService
	{
		/*
		*  Test Case관리
		*/
		public List<TsCase> SelectTsCase(string tc_case_nm)
		{
			IList<TsCase> list = Mapper.Instance().QueryForList<TsCase>("SelectTsCase", tc_case_nm);

			return (List<TsCase>)list;
		}

		//SelectTsCaseByNo
		public List<TsCase> SelectTsCaseByNo(string tc_case_no)
		{
			IList<TsCase> list = Mapper.Instance().QueryForList<TsCase>("SelectTsCaseByNo", tc_case_no);

			return (List<TsCase>)list;
		}

		//SelectTsCaseByPlan
		public List<TsCase> SelectTsCaseByPlan(string ts_plan_no)
		{
			IList<TsCase> list = Mapper.Instance().QueryForList<TsCase>("SelectTsCaseByPlan", ts_plan_no);

			return (List<TsCase>)list;
		}

		// INSERT 
		public object InsertTsCase(TsCase tsCase)
		{
			object result = Mapper.Instance().Insert("InsertTsCase", tsCase);

			return result;
		}

		// UPDATE
		public object UpdateTsCase(TsCase tsCase)
		{
			object result = Mapper.Instance().Update("UpdateTsCase", tsCase);

			return result;
		}

		// DELETE
		public object DeleteTsCase(TsCase tsCase)
		{
			object result = Mapper.Instance().Delete("DeleteTsCase", tsCase);

			return result;
		}
	}
}
