using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTool.DAO
{
	public class TsCase
	{
		public int tc_case_no { get; set; }
		public string tc_case_nm { get; set; }

		public int tc_test_type { get; set; }
		public string test_type_key { get; set; }

		public string tc_element_id { get; set; }
		public int tc_event_type { get; set; }

		public string tc_event_key { get; set; }
		public string event_type_key { get; set; }

		public string tc_value { get; set; }

		public int tc_check_type { get; set; }
		public string check_type_key {get; set;}
		public int tc_check_timeout { get; set; }
		public string tc_check_string { get; set; }

		public int ts_plan_no { get; set; }
		public int ts_group_no { get; set; }
		public int order_by { get; set; }
		public string use_yn { get; set; }
		public string description { get; set; }
	}
}
