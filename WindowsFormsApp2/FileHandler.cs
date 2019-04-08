using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2 {
    class FileHandler {
        private Computer c = new Computer();
        private int diskIndex = 0;
        private String diskKey = "";


        public FileHandler(string[] lines, string fileName) {
            c.modification = File.GetLastWriteTime(fileName);
            if (fileName.Length < 4) {
                Console.WriteLine(lines);
            }
            foreach(String line in lines) {
                int keyLocation = line.IndexOf(":");
                if (keyLocation > 0) {
                    String key = line.Substring(0, keyLocation);
                    String value = line.Substring(keyLocation+2);
                    if (key == "Date") {
                        c.date = Convert.ToDateTime(value);
                    } else if (key == "User") {
                        c.user = value;
                    } else if (key == "Workstation") {
                        if (value.Length == 4) {
                            value = value.Replace("WS", "WS0");
                        }
                        c.workstation = value;
                    } else if (key == "Manufacturer") {
                        if (value == "Hewlett-Packard") {
                            c.manufacturer = "HP";
                        } else {
                            c.manufacturer = value;
                        }
                    } else if (key == "Model") {
                        c.model = value;
                    } else if (key == "Operating System") {
                        c.os = value;
                    } else if (key == "Architecture") {
                        value = value.Replace(" bits", "");
                        value = value.Replace("-bit", "");
                        c.architecture = value;
                    } else if (key == "CPU") {
                        c.cpu = new CPU(value);
                    } else if (key == "RAM (GB)") {
                        c.ram = value + " GB";
                    } else if (key == "GPU") {
                        c.gpu = new GPU(value);
                    } else if (key == "Disk Name") {
                        c.disks.Add(new Disk());
                        c.disks[diskIndex].name = value;
                        diskKey = key;
                        diskIndex++;
                    } else if (key == "Disk Media Type") {
                        if (diskKey == "Disk Name") {
                            diskIndex = 0;
                        }
                        c.disks[diskIndex].type = value;
                        diskKey = key;
                        diskIndex++;
                    } else if (key == "Disk Total Size (GB)") {
                        if (diskKey == "Disk Media Type") {
                            diskIndex = 0;
                        }
                        c.disks[diskIndex].size = value;
                        diskKey = key;
                        diskIndex++;
                    }
                }
            }
        }

        public Computer getComputer() {
            return c;
        }
    }
}
