using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTool.DAO
{
	public class TsPlan
	{
		public int ts_plan_no { get; set; }
		public string ts_plan_nm { get; set; }
		public DateTime  ts_plan_dt { get; set; }
		public int order_by { get; set; }
		public string use_yn { get; set; }
		public string description { get; set; }
	}
}
