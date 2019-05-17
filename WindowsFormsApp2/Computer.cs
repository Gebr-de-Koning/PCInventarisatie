using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp2{
    public class Computer : Searchable{
        public String date { get; set; }
        public String user { get; set; }
        public String workstation { get; set; }
        public String manufacturer { get; set; }
        public String deviceType { get; set; }
        public String model { get; set; }
        public String os { get; set; }
        public String osVersion { get; set; }
        public String osInstallDate { get; set; }
        public String architecture { get; set; }
        public double ram { get; set; }
        public double freeSpace { get; set; }
        public String symantecVersion { get; set; }
        public CPU cpu { get; set; }
        public GPU gpu { get; set; }
        public DateTime modification { get; set; }
        public List<Disk> disks { get; set; }
        public List<OfficeLicense> officeLicences { get; set; }
        public List<InstalledProgram> programs { get; set; }

        public Computer(){
            disks = new List<Disk>();
            officeLicences = new List<OfficeLicense>();
            programs = new List<InstalledProgram>();
        }

        public override Boolean search(object instance, String word){
            Boolean result = base.search(instance, word);
            if (!result) { result = cpu.search(cpu, word); }
            if (!result) { result = gpu.search(gpu, word); }
            if (!result) { foreach (Disk d in disks) { if(!result) result = d.search(d, word); } }
            if (!result) { foreach (OfficeLicense o in officeLicences) { if (!result) result = o.search(o, word); } }
            if (!result) { foreach (InstalledProgram p in programs) { if (!result) result = p.search(p, word); } }
            return result;
        }
    }
}
