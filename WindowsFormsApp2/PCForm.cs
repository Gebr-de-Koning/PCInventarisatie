using System;
using System.Windows.Forms;

namespace WindowsFormsApp2{
    public partial class PCForm : Form{
        public Computer computer;

        public PCForm(){
            InitializeComponent();
        }

        public PCForm(Computer computer) : this() {
            CenterToScreen();
            this.computer = computer;
            Text = computer.workstation + " Specification";
            PCheader.Text = computer.workstation;
            PCHeader2.Text = computer.workstation;
            PCHeader3.Text = computer.workstation;
            textDate.Text = computer.date;
            textUser.Text = computer.user;
            textManufacturer.Text = computer.manufacturer;
            textModel.Text = computer.model;
            textDeviceType.Text = computer.deviceType;
            textOperatingSystem.Text = computer.os;
            textOSVersion.Text = computer.osVersion;
            textWindowsInstallDate.Text = computer.osInstallDate;
            textArchitecture.Text = computer.architecture;
            textCPU.Text = computer.cpu.name;
            textCPUBench.Text = computer.cpu.score.ToString();
            textGPU.Text = computer.gpu.name;
            textGPUBench.Text = computer.gpu.score.ToString();
            textRAM.Text = computer.ram.ToString();
            textFreeSpace.Text = computer.freeSpace.ToString();
            textSymVersion.Text = computer.symantecVersion;
            DiskObjectListView.AddObjects(computer.disks);
            OfficeLicenseListView.AddObjects(computer.officeLicences);
            InstalledProgramsObjectListView.AddObjects(computer.programs);
        }
    }
}
