using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_proj
{
    public class wethercondion
    {
        public weatherclass current { get; set; }

    }
    public class weta
    {
        public wethe forecast { get; set; }

    }
    public class wethe
    {
        public Day forecastday { get; set; }

    }
    public class Day
    {
        public weatherclass day { get; set; }

    }
}
