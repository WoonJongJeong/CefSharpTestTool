using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTool.DAO
{
	public class TsGroup
	{
		public int ts_group_no { get; set; }
		public string ts_group_nm { get; set; }
		public int order_by { get; set; }
		public int ts_plan_no { get; set; }
		public string ts_plan_nm { get; set; }
		public string use_yn { get; set; }
		public string description { get; set; }
	}
}
