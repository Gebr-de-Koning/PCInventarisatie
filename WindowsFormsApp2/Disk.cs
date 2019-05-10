using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2 {
    public class Disk : Searchable{
        public String name { get; set; }
        public String type { get; set; }
        public String health { get; set; }
        public String size { get; set; }
    }
}
