using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNavigation
{

    public class TestMasterDetailPageMenuItem
    {
        public TestMasterDetailPageMenuItem()
        {
            TargetType = typeof(TestMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
