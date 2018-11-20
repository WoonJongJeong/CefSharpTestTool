using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTool.DAO;

namespace TestTool.Service
{
	class CommonCodeService
	{
		/*
		*  Common Code Category관리
		*/
		public List<CommonCategory> SelectCommonCategory(string category_nm)
		{
			IList<CommonCategory> list = Mapper.Instance().QueryForList<CommonCategory>("SelectCmCategory", category_nm);

			return (List<CommonCategory>)list;
		}

		// INSERT 
		public object InsertCommonCategory(CommonCategory category)
		{
			object result = Mapper.Instance().Insert("InsertCmCategory", category);

			return result;
		}

		// UPDATE
		public object UpdateCommonCategory(CommonCategory category)
		{
			object result = Mapper.Instance().Update("UpdateCmCategory", category);

			return result;
		}

		// DELETE
		public object DeleteCommonCategory(CommonCategory category)
		{
			object result = Mapper.Instance().Delete("DeleteCmCategory", category);

			return result;
		}

		/*
		* Common Code 관리 
		*/

		//SELECT
		public List<CommonCode> SelectCommonCode(string common_nm)
		{
			IList<CommonCode> list = Mapper.Instance().QueryForList<CommonCode>("SelectCmCode", common_nm);

			return (List<CommonCode>)list;
		}

		//SelectCmCodeByCategory
		public List<CommonCode> SelectCmCodeByCategory(string category_cd)
		{
			IList<CommonCode> list = Mapper.Instance().QueryForList<CommonCode>("SelectCmCodeByCategory", category_cd);

			return (List<CommonCode>)list;
		}

		//SelectCmCodeByParent
		public List<CommonCode> SelectCmCodeByParent(string parent_cd)
		{
			IList<CommonCode> list = Mapper.Instance().QueryForList<CommonCode>("SelectCmCodeByParent", parent_cd);

			return (List<CommonCode>)list;
		}

		// INSERT
		public int InsertCommonCode(CommonCode code)
		{
			object result = Mapper.Instance().Insert("InsertCmCode", code);

			return (int)result;
		}

		// UPDATE
		public int UpdateCommonCode(CommonCode code)
		{
			object result = Mapper.Instance().Update("UpdateCmCode", code);

			return (int)result;
		}

		// DELETE
		public int DeleteCommonCode(CommonCode code)
		{
			int result = Mapper.Instance().Delete("DeleteCmCode", code);

			return result;
		}
	}
}
