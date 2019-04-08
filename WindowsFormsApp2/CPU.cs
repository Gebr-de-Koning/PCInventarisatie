using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2 {
    class CPU {
        public String name { get; set; }
        public int score { get; set; }

        public CPU(String name) {
            this.name = name;
            this.score = Benchmark.getCpuScore(name);
        }
    }
}
