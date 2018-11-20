using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IBatisNet.DataMapper;
using TestTool.DAO;

namespace TestTool.Controller
{
    class TestSuiteController
    {
        public int InsertCompany(TestSuite  testSuite)
        {
            object obj = Mapper.Instance().Insert("InsertCompany", testSuite);

            return (int)obj;
        }
        public List<TestSuite> SelectTestSuite()
        {
            IList<TestSuite> list = Mapper.Instance().QueryForList<TestSuite>("SelectTestSuite", null);

            return (List<TestSuite>)list;
        }
    }
}
