using System;
using System.IO;

namespace WindowsFormsApp2 {
    class FileHandler {
        private Computer c = new Computer();
        private int diskIndex = 0;
        private int licenseIndex = 0;
        private String subject = "";

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
                        } else if (value == "Microsoft Corporation") {
                            c.manufacturer = "Microsoft";
                        }
                        else {
                            c.manufacturer = value;
                        }
                    } else if (key == "Model") {
                        c.model = value;
                    } else if (key == "Operating System") {
                        if (value.Contains("Microsoft")) {
                            value = value.Replace("Microsoft ", "");
                            c.os = value;
                        }
                        c.os = value;
                    } else if (key == "OS Version") {
                        c.osVersion = value;
                    } else if (key == "Windows installation date") {
                        DateTime date = Convert.ToDateTime(value);
                        value = date.ToString("yyyy-MM-dd");
                        c.osInstallDate = value;
                    } else if (key == "Architecture") {
                        value = value.Replace(" bits", "");
                        value = value.Replace("-bit", "");
                        c.architecture = value;
                    } else if (key == "CPU") {
                        c.cpu = new CPU(value);
                    } else if (key == "RAM (GB)") {
                        c.ram = Math.Round(Convert.ToDouble(value));
                    } else if (key == "GPU") {
                        c.gpu = new GPU(value);
                    } else if (key == "Disk Name") {
                        c.disks.Add(new Disk());
                        c.disks[diskIndex].name = value;
                        subject = key;
                        diskIndex++;
                    } else if (key == "Disk Media Type") {
                        if (subject == "Disk Name") {
                            diskIndex = 0;
                        }
                        c.disks[diskIndex].type = value;
                        subject = key;
                        diskIndex++;
                    } else if (key == "Disk Total Size (GB)") {
                        if (subject == "Disk Media Type") {
                            diskIndex = 0;
                        }
                        c.disks[diskIndex].size = value;
                        subject = key;
                        diskIndex++;
                    } else if (key == "LICENSE NAME") {
                        c.officeLicences.Add(new OfficeLicense());
                        c.officeLicences[licenseIndex].name = value;
                    } else if (key == "Last 5 characters of installed product key") {
                        c.officeLicences[licenseIndex].key = value;
                        LicenseManager.getFullLicense(c.officeLicences[licenseIndex]);
                        licenseIndex++;
                    }
                }
            }
        }

        public Computer getComputer() {
            return c;
        }
    }
}
