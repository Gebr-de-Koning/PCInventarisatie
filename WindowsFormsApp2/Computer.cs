using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2 {
    class Computer {
        public DateTime date { get; set; }
        public String user { get; set; }
        public String workstation { get; set; }
        public String manufacturer { get; set; }
        public String model { get; set; }
        public String os { get; set; }
        public String architecture { get; set; }
        public CPU cpu { get; set; }
        public String ram { get; set; }
        public GPU gpu { get; set; }
        public DateTime modification { get; set; }
        public List<Disk> disks { get; set; }

        public Computer() {
            disks = new List<Disk>();
        }
    }
}
