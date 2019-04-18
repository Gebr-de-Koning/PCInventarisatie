using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2{
    public class InstalledProgram{
        public String name { get; set; }
        public String version { get; set; }

        public InstalledProgram(String name, String version) {
            this.name = name;
            this.version = version;
        }
    }
}
