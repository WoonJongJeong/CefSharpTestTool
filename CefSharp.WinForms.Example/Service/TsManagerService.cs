using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTool.DAO;

namespace TestTool.Service
{
	class TsManagereService
	{
		/*
		*  Test Plan관리
		*/
		public List<TsPlan> SelectTsPlan(string ts_plan_nm)
		{
			IList<TsPlan> list = Mapper.Instance().QueryForList<TsPlan>("SelectTsPlan", ts_plan_nm);

			return (List<TsPlan>)list;
		}

		// INSERT 
		public object InsertTsPlan(TsPlan tsPlan)
		{
			object result = Mapper.Instance().Insert("InsertTsPlan", tsPlan);

			return result;
		}

		// UPDATE
		public object UpdateTsPlan(TsPlan tsPlan)
		{
			object result = Mapper.Instance().Update("UpdateTsPlan", tsPlan);

			return result;
		}

		// DELETE
		public object DeleteTsPlan(TsPlan tsPlan)
		{
			object result = Mapper.Instance().Delete("DeleteTsPlan", tsPlan);

			return result;
		}

		/*
		* Test Groupe 관리 
		*/

		//SELECT
		public List<TsGroup> SelectTsGroup(Dictionary<string, string> values)
		{
			IList<TsGroup> list = Mapper.Instance().QueryForList<TsGroup>("SelectTsGroup", values);

			return (List<TsGroup>)list;
		}

		//SELECT by plan_no
		public List<TsGroup> SelectTsGroupByPlanNo(string ts_plan_no)
		{
			IList<TsGroup> list = Mapper.Instance().QueryForList<TsGroup>("SelectTsGroupByPlanNo", ts_plan_no);
			
			return (List<TsGroup>)list;
		}

		// INSERT
		public int InsertTsGroup(TsGroup tsGroup)
		{
			object result = Mapper.Instance().Insert("InsertTsGroup", tsGroup);

			return (int)result;
		}

		// UPDATE
		public int UpdateTsGroup(TsGroup tsGroup)
		{
			object result = Mapper.Instance().Update("UpdateTsGroup", tsGroup);

			return (int)result;
		}

		// DELETE
		public int DeleteTsGroup(TsGroup tsGroup)
		{
			int result = Mapper.Instance().Delete("DeleteTsGroup", tsGroup);

			return result;
		}
	}
}
