using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_proj
{
    public class weatherclass
    {
        public string last_updated { get; set; }
        public decimal temp_c { get; set; }
        public string is_day{ get; set; }
        public Condition condition { get; set; }

    }
    public class Condition
    {
        public string text { get; set; }


    }
}
