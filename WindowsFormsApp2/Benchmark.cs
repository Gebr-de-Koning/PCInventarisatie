using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2 {
    static class Benchmark {
        public static int getCpuScore(String deviceName) {
            return getScore(@"G:\11. ICT\03. Projecten\DKI.004 Inventarisatie PC's\Inputfiles\CPU benchmarks.txt", deviceName);
        }

        public static int getGpuScore(String deviceName) {
            return getScore(@"G:\11. ICT\03. Projecten\DKI.004 Inventarisatie PC's\Inputfiles\GPU benchmarks.txt", deviceName);
        }


        private static int getScore(String fileName, String deviceName) {
            string[] lines = File.ReadAllLines(fileName);

            foreach (String line in lines) {
                int keyLocation = line.IndexOf(":");
                if (keyLocation > 0) {
                    String key = line.Substring(0, keyLocation);
                    String value = line.Substring(keyLocation + 2);
                    if (key == deviceName) {
                        return Convert.ToInt32(value);
                    }
                }
            }

            return 0;
        }
    }
}
