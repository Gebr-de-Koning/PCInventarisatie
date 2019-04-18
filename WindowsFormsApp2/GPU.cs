using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2{
    public class GPU{
        public String name { get; set; }
        public int score { get; set; }

        public GPU(String name) {
            this.name = name;
            this.score = Benchmark.getGpuScore(name);
        }
    }
}
