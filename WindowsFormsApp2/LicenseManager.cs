using System;
using System.IO;

namespace WindowsFormsApp2 {
    static class LicenseManager{
        public static String fileName = @"G:\11. ICT\03. Projecten\DKI.004 Inventarisatie PC's\Inputfiles\Licentie codes.txt";

        public static OfficeLicense getFullLicense(OfficeLicense license){
            string[] lines = File.ReadAllLines(fileName);
            int keyCount = 0;
            string shortKey = license.key;
            foreach (String line in lines){
                String[] values = line.Split(new[] { ": " }, StringSplitOptions.None);
                if (shortKey == values[1] && keyCount == 0){
                    license.name = values[0];
                    license.key = values[2];
                    license.number = values[3];
                    license.email = values[4];
                    keyCount++;
                } else if (shortKey == values[1] && keyCount != 0) {
                    keyCount++;
                }
            }
            if(keyCount > 1){
                license.key = "!" + license.key;
            }
            return license;
        }
    }
}
