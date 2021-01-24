using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{



    public class Tinderuserinfo
    {
        public DateTime id { get; set; }
        public string username { get; set; }
        public int age { get; set; }
        public bool sex { get; set; }
        public string whoami { get; set; }
        public int liked { get; set; }
    }

    public class Root
    {
        public List<Tinderuserinfo> tinderuserinfo { get; set; }
    }

}
