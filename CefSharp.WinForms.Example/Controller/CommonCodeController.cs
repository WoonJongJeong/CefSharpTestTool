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
	class CommonCodeController
	{
		CommonCodeService service;
		public CommonCodeController()
		{
			service = new CommonCodeService();
		}

		/*
		*  Common Code Category관리
		*/
		public List<CommonCategory> SelectCommonCategory(string category_nm)
		{
			List<CommonCategory> list = service.SelectCommonCategory(category_nm);
			return list;
		}

		// INSERT or Update
		public int SaveCommonCategory(CommonCategory category)
		{
			object result = null;

			if (category.category_cd == 0)
			{
				result = service.InsertCommonCategory(category);
			}
			else
			{
				result = service.UpdateCommonCategory(category);
			}

			return (int)result;
		}

		// DELETE
		public int DeleteCommonCategory(CommonCategory category)
		{
			object result = service.DeleteCommonCategory(category);

			return (int)result;
		}

		/*
		* Common Code 관리 
		*/

		//SELECT
		public List<CommonCode> SelectCommonCode(string common_nm)
		{
			List<CommonCode> list = service.SelectCommonCode(common_nm);

			return list;
		}

		//SelectCmCodeByCategory
		public List<CommonCode> SelectCmCodeByCategory(string category_cd)
		{
			List<CommonCode> list = service.SelectCmCodeByCategory(category_cd);

			return list;
		}

		//SelectCmCodeByParent
		public List<CommonCode> SelectCmCodeByParent(string parent_cd)
		{
			List<CommonCode> list = service.SelectCmCodeByParent(parent_cd);

			return list;
		}

		// INSERT or UPDATE
		public int SaveCommonCode(CommonCode code)
		{
			int result = 0;

			if (code.common_cd == 0)
			{
				result = service.InsertCommonCode(code);
			}
			else
			{
				result = service.UpdateCommonCode(code);
			}
			
			return result;
		}

		// DELETE
		public int DeleteCommonCode(CommonCode code)
		{
			int result = service.DeleteCommonCode(code);

			return result;
		}
	}
}
