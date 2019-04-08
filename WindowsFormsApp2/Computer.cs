using System;
using System.Collections.Generic;

namespace WindowsFormsApp2 {
    class Computer {
        public DateTime date { get; set; }
        public String user { get; set; }
        public String workstation { get; set; }
        public String manufacturer { get; set; }
        public String model { get; set; }
        public String os { get; set; }
        public String osInstallDate { get; set; }
        public String architecture { get; set; }
        public String ram { get; set; }
        public String freeSpace { get; set; }
        public CPU cpu { get; set; }
        public GPU gpu { get; set; }
        public DateTime modification { get; set; }
        public List<Disk> disks { get; set; }
        public List<OfficeLicense> licences { get; set; }

        public Computer() {
            disks = new List<Disk>();
            licences = new List<OfficeLicense>();
        }
    }
}
