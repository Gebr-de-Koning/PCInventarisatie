namespace WindowsFormsApp2
{
    partial class PCForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCForm));
            this.PCheader = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblOSVersion = new System.Windows.Forms.Label();
            this.lblWindowsInstallDate = new System.Windows.Forms.Label();
            this.lblArchitecture = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblCPUBench = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblGPUBench = new System.Windows.Forms.Label();
            this.lblFreeSpace = new System.Windows.Forms.Label();
            this.lblSymantecVersion = new System.Windows.Forms.Label();
            this.diskHeader = new System.Windows.Forms.Label();
            this.DiskObjectListView = new BrightIdeasSoftware.FastObjectListView();
            this.diskName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.diskType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.diskSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.diskHealth = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OfficeLicenseTab = new System.Windows.Forms.TabControl();
            this.HardwareSpecsTab = new System.Windows.Forms.TabPage();
            this.OfficeProgramsTab = new System.Windows.Forms.TabPage();
            this.InstalledProgramsTab = new System.Windows.Forms.TabPage();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textManufacturer = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textDeviceType = new System.Windows.Forms.TextBox();
            this.textOperatingSystem = new System.Windows.Forms.TextBox();
            this.textOSVersion = new System.Windows.Forms.TextBox();
            this.textWindowsInstallDate = new System.Windows.Forms.TextBox();
            this.textArchitecture = new System.Windows.Forms.TextBox();
            this.textCPU = new System.Windows.Forms.TextBox();
            this.textCPUBench = new System.Windows.Forms.TextBox();
            this.textGPU = new System.Windows.Forms.TextBox();
            this.textGPUBench = new System.Windows.Forms.TextBox();
            this.textRAM = new System.Windows.Forms.TextBox();
            this.textFreeSpace = new System.Windows.Forms.TextBox();
            this.textSymVersion = new System.Windows.Forms.TextBox();
            this.PCHeader2 = new System.Windows.Forms.Label();
            this.OfficeLicenseListView = new BrightIdeasSoftware.FastObjectListView();
            this.officeName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.officeKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.officeNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OfficeEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PCHeader3 = new System.Windows.Forms.Label();
            this.InstalledProgramsObjectListView = new BrightIdeasSoftware.FastObjectListView();
            this.ProgramName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ProgramVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DiskObjectListView)).BeginInit();
            this.OfficeLicenseTab.SuspendLayout();
            this.HardwareSpecsTab.SuspendLayout();
            this.OfficeProgramsTab.SuspendLayout();
            this.InstalledProgramsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeLicenseListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstalledProgramsObjectListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PCheader
            // 
            this.PCheader.AutoSize = true;
            this.PCheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCheader.Location = new System.Drawing.Point(6, 10);
            this.PCheader.Name = "PCheader";
            this.PCheader.Size = new System.Drawing.Size(60, 24);
            this.PCheader.TabIndex = 0;
            this.PCheader.Text = "WS##";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(7, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(7, 68);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(7, 90);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblManufacturer.TabIndex = 3;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(7, 112);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Location = new System.Drawing.Point(7, 134);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(67, 13);
            this.lblDeviceType.TabIndex = 5;
            this.lblDeviceType.Text = "Device type:";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(7, 156);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(91, 13);
            this.lblOS.TabIndex = 6;
            this.lblOS.Text = "Operating system:";
            // 
            // lblOSVersion
            // 
            this.lblOSVersion.AutoSize = true;
            this.lblOSVersion.Location = new System.Drawing.Point(7, 178);
            this.lblOSVersion.Name = "lblOSVersion";
            this.lblOSVersion.Size = new System.Drawing.Size(62, 13);
            this.lblOSVersion.TabIndex = 7;
            this.lblOSVersion.Text = "OS version:";
            // 
            // lblWindowsInstallDate
            // 
            this.lblWindowsInstallDate.AutoSize = true;
            this.lblWindowsInstallDate.Location = new System.Drawing.Point(7, 200);
            this.lblWindowsInstallDate.Name = "lblWindowsInstallDate";
            this.lblWindowsInstallDate.Size = new System.Drawing.Size(130, 13);
            this.lblWindowsInstallDate.TabIndex = 8;
            this.lblWindowsInstallDate.Text = "Windows installation date:";
            // 
            // lblArchitecture
            // 
            this.lblArchitecture.AutoSize = true;
            this.lblArchitecture.Location = new System.Drawing.Point(373, 46);
            this.lblArchitecture.Name = "lblArchitecture";
            this.lblArchitecture.Size = new System.Drawing.Size(67, 13);
            this.lblArchitecture.TabIndex = 9;
            this.lblArchitecture.Text = "Architecture:";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(373, 68);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(32, 13);
            this.lblCPU.TabIndex = 10;
            this.lblCPU.Text = "CPU:";
            // 
            // lblCPUBench
            // 
            this.lblCPUBench.AutoSize = true;
            this.lblCPUBench.Location = new System.Drawing.Point(373, 90);
            this.lblCPUBench.Name = "lblCPUBench";
            this.lblCPUBench.Size = new System.Drawing.Size(88, 13);
            this.lblCPUBench.TabIndex = 11;
            this.lblCPUBench.Text = "CPU benchmark:";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(373, 156);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(58, 13);
            this.lblRAM.TabIndex = 12;
            this.lblRAM.Text = "RAM (GB):";
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Location = new System.Drawing.Point(373, 112);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(33, 13);
            this.lblGPU.TabIndex = 13;
            this.lblGPU.Text = "GPU:";
            // 
            // lblGPUBench
            // 
            this.lblGPUBench.AutoSize = true;
            this.lblGPUBench.Location = new System.Drawing.Point(373, 134);
            this.lblGPUBench.Name = "lblGPUBench";
            this.lblGPUBench.Size = new System.Drawing.Size(89, 13);
            this.lblGPUBench.TabIndex = 14;
            this.lblGPUBench.Text = "GPU benchmark:";
            // 
            // lblFreeSpace
            // 
            this.lblFreeSpace.AutoSize = true;
            this.lblFreeSpace.Location = new System.Drawing.Point(373, 178);
            this.lblFreeSpace.Name = "lblFreeSpace";
            this.lblFreeSpace.Size = new System.Drawing.Size(87, 13);
            this.lblFreeSpace.TabIndex = 15;
            this.lblFreeSpace.Text = "Free space (GB):";
            // 
            // lblSymantecVersion
            // 
            this.lblSymantecVersion.AutoSize = true;
            this.lblSymantecVersion.Location = new System.Drawing.Point(373, 200);
            this.lblSymantecVersion.Name = "lblSymantecVersion";
            this.lblSymantecVersion.Size = new System.Drawing.Size(94, 13);
            this.lblSymantecVersion.TabIndex = 16;
            this.lblSymantecVersion.Text = "Symantec version:";
            // 
            // diskHeader
            // 
            this.diskHeader.AutoSize = true;
            this.diskHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.diskHeader.Location = new System.Drawing.Point(6, 240);
            this.diskHeader.Name = "diskHeader";
            this.diskHeader.Size = new System.Drawing.Size(62, 20);
            this.diskHeader.TabIndex = 33;
            this.diskHeader.Text = "Disk(s):";
            // 
            // DiskObjectListView
            // 
            this.DiskObjectListView.AllColumns.Add(this.diskName);
            this.DiskObjectListView.AllColumns.Add(this.diskType);
            this.DiskObjectListView.AllColumns.Add(this.diskSize);
            this.DiskObjectListView.AllColumns.Add(this.diskHealth);
            this.DiskObjectListView.BackColor = System.Drawing.Color.White;
            this.DiskObjectListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiskObjectListView.CellEditUseWholeCell = false;
            this.DiskObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.diskName,
            this.diskType,
            this.diskSize,
            this.diskHealth});
            this.DiskObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.DiskObjectListView.FullRowSelect = true;
            this.DiskObjectListView.Location = new System.Drawing.Point(5, 263);
            this.DiskObjectListView.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.DiskObjectListView.Name = "DiskObjectListView";
            this.DiskObjectListView.RowHeight = 20;
            this.DiskObjectListView.ShowGroups = false;
            this.DiskObjectListView.Size = new System.Drawing.Size(398, 186);
            this.DiskObjectListView.TabIndex = 34;
            this.DiskObjectListView.UseCompatibleStateImageBehavior = false;
            this.DiskObjectListView.View = System.Windows.Forms.View.Details;
            this.DiskObjectListView.VirtualMode = true;
            // 
            // diskName
            // 
            this.diskName.AspectName = "name";
            this.diskName.HeaderForeColor = System.Drawing.Color.Black;
            this.diskName.Text = "Name";
            this.diskName.Width = 220;
            // 
            // diskType
            // 
            this.diskType.AspectName = "type";
            this.diskType.Text = "Type";
            this.diskType.Width = 50;
            // 
            // diskSize
            // 
            this.diskSize.AspectName = "size";
            this.diskSize.Text = "Size";
            this.diskSize.Width = 45;
            // 
            // diskHealth
            // 
            this.diskHealth.AspectName = "health";
            this.diskHealth.Text = "Health";
            this.diskHealth.Width = 75;
            // 
            // OfficeLicenseTab
            // 
            this.OfficeLicenseTab.Controls.Add(this.HardwareSpecsTab);
            this.OfficeLicenseTab.Controls.Add(this.OfficeProgramsTab);
            this.OfficeLicenseTab.Controls.Add(this.InstalledProgramsTab);
            this.OfficeLicenseTab.Location = new System.Drawing.Point(0, 0);
            this.OfficeLicenseTab.Name = "OfficeLicenseTab";
            this.OfficeLicenseTab.SelectedIndex = 0;
            this.OfficeLicenseTab.Size = new System.Drawing.Size(777, 493);
            this.OfficeLicenseTab.TabIndex = 35;
            // 
            // HardwareSpecsTab
            // 
            this.HardwareSpecsTab.Controls.Add(this.textSymVersion);
            this.HardwareSpecsTab.Controls.Add(this.textFreeSpace);
            this.HardwareSpecsTab.Controls.Add(this.textRAM);
            this.HardwareSpecsTab.Controls.Add(this.textGPUBench);
            this.HardwareSpecsTab.Controls.Add(this.textGPU);
            this.HardwareSpecsTab.Controls.Add(this.textCPUBench);
            this.HardwareSpecsTab.Controls.Add(this.textCPU);
            this.HardwareSpecsTab.Controls.Add(this.textArchitecture);
            this.HardwareSpecsTab.Controls.Add(this.textWindowsInstallDate);
            this.HardwareSpecsTab.Controls.Add(this.textOSVersion);
            this.HardwareSpecsTab.Controls.Add(this.textOperatingSystem);
            this.HardwareSpecsTab.Controls.Add(this.textDeviceType);
            this.HardwareSpecsTab.Controls.Add(this.textModel);
            this.HardwareSpecsTab.Controls.Add(this.textManufacturer);
            this.HardwareSpecsTab.Controls.Add(this.textUser);
            this.HardwareSpecsTab.Controls.Add(this.textDate);
            this.HardwareSpecsTab.Controls.Add(this.PCheader);
            this.HardwareSpecsTab.Controls.Add(this.diskHeader);
            this.HardwareSpecsTab.Controls.Add(this.DiskObjectListView);
            this.HardwareSpecsTab.Controls.Add(this.lblDate);
            this.HardwareSpecsTab.Controls.Add(this.lblUser);
            this.HardwareSpecsTab.Controls.Add(this.lblManufacturer);
            this.HardwareSpecsTab.Controls.Add(this.lblModel);
            this.HardwareSpecsTab.Controls.Add(this.lblDeviceType);
            this.HardwareSpecsTab.Controls.Add(this.lblOS);
            this.HardwareSpecsTab.Controls.Add(this.lblOSVersion);
            this.HardwareSpecsTab.Controls.Add(this.lblWindowsInstallDate);
            this.HardwareSpecsTab.Controls.Add(this.lblArchitecture);
            this.HardwareSpecsTab.Controls.Add(this.lblCPU);
            this.HardwareSpecsTab.Controls.Add(this.lblCPUBench);
            this.HardwareSpecsTab.Controls.Add(this.lblRAM);
            this.HardwareSpecsTab.Controls.Add(this.lblGPU);
            this.HardwareSpecsTab.Controls.Add(this.lblGPUBench);
            this.HardwareSpecsTab.Controls.Add(this.lblFreeSpace);
            this.HardwareSpecsTab.Controls.Add(this.lblSymantecVersion);
            this.HardwareSpecsTab.Location = new System.Drawing.Point(4, 22);
            this.HardwareSpecsTab.Name = "HardwareSpecsTab";
            this.HardwareSpecsTab.Padding = new System.Windows.Forms.Padding(3);
            this.HardwareSpecsTab.Size = new System.Drawing.Size(769, 467);
            this.HardwareSpecsTab.TabIndex = 0;
            this.HardwareSpecsTab.Text = "Hardware specifications";
            this.HardwareSpecsTab.UseVisualStyleBackColor = true;
            // 
            // OfficeProgramsTab
            // 
            this.OfficeProgramsTab.Controls.Add(this.OfficeLicenseListView);
            this.OfficeProgramsTab.Controls.Add(this.PCHeader2);
            this.OfficeProgramsTab.Location = new System.Drawing.Point(4, 22);
            this.OfficeProgramsTab.Name = "OfficeProgramsTab";
            this.OfficeProgramsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OfficeProgramsTab.Size = new System.Drawing.Size(769, 467);
            this.OfficeProgramsTab.TabIndex = 1;
            this.OfficeProgramsTab.Text = "Office licenses";
            this.OfficeProgramsTab.UseVisualStyleBackColor = true;
            // 
            // InstalledProgramsTab
            // 
            this.InstalledProgramsTab.Controls.Add(this.InstalledProgramsObjectListView);
            this.InstalledProgramsTab.Controls.Add(this.PCHeader3);
            this.InstalledProgramsTab.Location = new System.Drawing.Point(4, 22);
            this.InstalledProgramsTab.Name = "InstalledProgramsTab";
            this.InstalledProgramsTab.Padding = new System.Windows.Forms.Padding(3);
            this.InstalledProgramsTab.Size = new System.Drawing.Size(769, 467);
            this.InstalledProgramsTab.TabIndex = 2;
            this.InstalledProgramsTab.Text = "Installed Programs";
            this.InstalledProgramsTab.UseVisualStyleBackColor = true;
            // 
            // textDate
            // 
            this.textDate.BackColor = System.Drawing.Color.White;
            this.textDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDate.Location = new System.Drawing.Point(171, 46);
            this.textDate.Name = "textDate";
            this.textDate.ReadOnly = true;
            this.textDate.Size = new System.Drawing.Size(190, 13);
            this.textDate.TabIndex = 35;
            this.textDate.Text = "##########";
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.White;
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Location = new System.Drawing.Point(171, 68);
            this.textUser.Name = "textUser";
            this.textUser.ReadOnly = true;
            this.textUser.Size = new System.Drawing.Size(190, 13);
            this.textUser.TabIndex = 36;
            this.textUser.Text = "##########";
            // 
            // textManufacturer
            // 
            this.textManufacturer.BackColor = System.Drawing.Color.White;
            this.textManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textManufacturer.Location = new System.Drawing.Point(171, 90);
            this.textManufacturer.Name = "textManufacturer";
            this.textManufacturer.ReadOnly = true;
            this.textManufacturer.Size = new System.Drawing.Size(190, 13);
            this.textManufacturer.TabIndex = 37;
            this.textManufacturer.Text = "##########";
            // 
            // textModel
            // 
            this.textModel.BackColor = System.Drawing.Color.White;
            this.textModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textModel.Location = new System.Drawing.Point(171, 112);
            this.textModel.Name = "textModel";
            this.textModel.ReadOnly = true;
            this.textModel.Size = new System.Drawing.Size(190, 13);
            this.textModel.TabIndex = 38;
            this.textModel.Text = "##########";
            // 
            // textDeviceType
            // 
            this.textDeviceType.BackColor = System.Drawing.Color.White;
            this.textDeviceType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDeviceType.Location = new System.Drawing.Point(171, 134);
            this.textDeviceType.Name = "textDeviceType";
            this.textDeviceType.ReadOnly = true;
            this.textDeviceType.Size = new System.Drawing.Size(190, 13);
            this.textDeviceType.TabIndex = 39;
            this.textDeviceType.Text = "##########";
            // 
            // textOperatingSystem
            // 
            this.textOperatingSystem.BackColor = System.Drawing.Color.White;
            this.textOperatingSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOperatingSystem.Location = new System.Drawing.Point(171, 156);
            this.textOperatingSystem.Name = "textOperatingSystem";
            this.textOperatingSystem.ReadOnly = true;
            this.textOperatingSystem.Size = new System.Drawing.Size(190, 13);
            this.textOperatingSystem.TabIndex = 40;
            this.textOperatingSystem.Text = "##########";
            // 
            // textOSVersion
            // 
            this.textOSVersion.BackColor = System.Drawing.Color.White;
            this.textOSVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOSVersion.Location = new System.Drawing.Point(171, 178);
            this.textOSVersion.Name = "textOSVersion";
            this.textOSVersion.ReadOnly = true;
            this.textOSVersion.Size = new System.Drawing.Size(190, 13);
            this.textOSVersion.TabIndex = 41;
            this.textOSVersion.Text = "##########";
            // 
            // textWindowsInstallDate
            // 
            this.textWindowsInstallDate.BackColor = System.Drawing.Color.White;
            this.textWindowsInstallDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textWindowsInstallDate.Location = new System.Drawing.Point(171, 200);
            this.textWindowsInstallDate.Name = "textWindowsInstallDate";
            this.textWindowsInstallDate.ReadOnly = true;
            this.textWindowsInstallDate.Size = new System.Drawing.Size(190, 13);
            this.textWindowsInstallDate.TabIndex = 42;
            this.textWindowsInstallDate.Text = "##########";
            // 
            // textArchitecture
            // 
            this.textArchitecture.BackColor = System.Drawing.Color.White;
            this.textArchitecture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArchitecture.Location = new System.Drawing.Point(521, 46);
            this.textArchitecture.Name = "textArchitecture";
            this.textArchitecture.ReadOnly = true;
            this.textArchitecture.Size = new System.Drawing.Size(190, 13);
            this.textArchitecture.TabIndex = 43;
            this.textArchitecture.Text = "##########";
            // 
            // textCPU
            // 
            this.textCPU.BackColor = System.Drawing.Color.White;
            this.textCPU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCPU.Location = new System.Drawing.Point(521, 68);
            this.textCPU.Name = "textCPU";
            this.textCPU.ReadOnly = true;
            this.textCPU.Size = new System.Drawing.Size(245, 13);
            this.textCPU.TabIndex = 44;
            this.textCPU.Text = "##########";
            // 
            // textCPUBench
            // 
            this.textCPUBench.BackColor = System.Drawing.Color.White;
            this.textCPUBench.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCPUBench.Location = new System.Drawing.Point(521, 90);
            this.textCPUBench.Name = "textCPUBench";
            this.textCPUBench.ReadOnly = true;
            this.textCPUBench.Size = new System.Drawing.Size(190, 13);
            this.textCPUBench.TabIndex = 45;
            this.textCPUBench.Text = "##########";
            // 
            // textGPU
            // 
            this.textGPU.BackColor = System.Drawing.Color.White;
            this.textGPU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGPU.Location = new System.Drawing.Point(521, 112);
            this.textGPU.Name = "textGPU";
            this.textGPU.ReadOnly = true;
            this.textGPU.Size = new System.Drawing.Size(190, 13);
            this.textGPU.TabIndex = 46;
            this.textGPU.Text = "##########";
            // 
            // textGPUBench
            // 
            this.textGPUBench.BackColor = System.Drawing.Color.White;
            this.textGPUBench.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGPUBench.Location = new System.Drawing.Point(521, 134);
            this.textGPUBench.Name = "textGPUBench";
            this.textGPUBench.ReadOnly = true;
            this.textGPUBench.Size = new System.Drawing.Size(190, 13);
            this.textGPUBench.TabIndex = 47;
            this.textGPUBench.Text = "##########";
            // 
            // textRAM
            // 
            this.textRAM.BackColor = System.Drawing.Color.White;
            this.textRAM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRAM.Location = new System.Drawing.Point(521, 156);
            this.textRAM.Name = "textRAM";
            this.textRAM.ReadOnly = true;
            this.textRAM.Size = new System.Drawing.Size(190, 13);
            this.textRAM.TabIndex = 48;
            this.textRAM.Text = "##########";
            // 
            // textFreeSpace
            // 
            this.textFreeSpace.BackColor = System.Drawing.Color.White;
            this.textFreeSpace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFreeSpace.Location = new System.Drawing.Point(521, 178);
            this.textFreeSpace.Name = "textFreeSpace";
            this.textFreeSpace.ReadOnly = true;
            this.textFreeSpace.Size = new System.Drawing.Size(190, 13);
            this.textFreeSpace.TabIndex = 49;
            this.textFreeSpace.Text = "##########";
            // 
            // textSymVersion
            // 
            this.textSymVersion.BackColor = System.Drawing.Color.White;
            this.textSymVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSymVersion.Location = new System.Drawing.Point(521, 200);
            this.textSymVersion.Name = "textSymVersion";
            this.textSymVersion.ReadOnly = true;
            this.textSymVersion.Size = new System.Drawing.Size(190, 13);
            this.textSymVersion.TabIndex = 50;
            this.textSymVersion.Text = "##########";
            // 
            // PCHeader2
            // 
            this.PCHeader2.AutoSize = true;
            this.PCHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCHeader2.Location = new System.Drawing.Point(6, 10);
            this.PCHeader2.Name = "PCHeader2";
            this.PCHeader2.Size = new System.Drawing.Size(60, 24);
            this.PCHeader2.TabIndex = 1;
            this.PCHeader2.Text = "WS##";
            // 
            // OfficeLicenseListView
            // 
            this.OfficeLicenseListView.AllColumns.Add(this.officeName);
            this.OfficeLicenseListView.AllColumns.Add(this.officeKey);
            this.OfficeLicenseListView.AllColumns.Add(this.officeNumber);
            this.OfficeLicenseListView.AllColumns.Add(this.OfficeEmail);
            this.OfficeLicenseListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OfficeLicenseListView.CellEditUseWholeCell = false;
            this.OfficeLicenseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.officeName,
            this.officeKey,
            this.officeNumber,
            this.OfficeEmail});
            this.OfficeLicenseListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.OfficeLicenseListView.Location = new System.Drawing.Point(4, 43);
            this.OfficeLicenseListView.Name = "OfficeLicenseListView";
            this.OfficeLicenseListView.RowHeight = 20;
            this.OfficeLicenseListView.ShowGroups = false;
            this.OfficeLicenseListView.Size = new System.Drawing.Size(754, 421);
            this.OfficeLicenseListView.TabIndex = 2;
            this.OfficeLicenseListView.UseCompatibleStateImageBehavior = false;
            this.OfficeLicenseListView.View = System.Windows.Forms.View.Details;
            this.OfficeLicenseListView.VirtualMode = true;
            // 
            // officeName
            // 
            this.officeName.AspectName = "name";
            this.officeName.Text = "Program name";
            this.officeName.Width = 250;
            // 
            // officeKey
            // 
            this.officeKey.AspectName = "key";
            this.officeKey.Text = "License key";
            this.officeKey.Width = 220;
            // 
            // officeNumber
            // 
            this.officeNumber.AspectName = "number";
            this.officeNumber.Text = "Number";
            this.officeNumber.Width = 70;
            // 
            // OfficeEmail
            // 
            this.OfficeEmail.AspectName = "email";
            this.OfficeEmail.Text = "Email";
            this.OfficeEmail.Width = 210;
            // 
            // PCHeader3
            // 
            this.PCHeader3.AutoSize = true;
            this.PCHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCHeader3.Location = new System.Drawing.Point(6, 10);
            this.PCHeader3.Name = "PCHeader3";
            this.PCHeader3.Size = new System.Drawing.Size(60, 24);
            this.PCHeader3.TabIndex = 2;
            this.PCHeader3.Text = "WS##";
            // 
            // InstalledProgramsObjectListView
            // 
            this.InstalledProgramsObjectListView.AllColumns.Add(this.ProgramName);
            this.InstalledProgramsObjectListView.AllColumns.Add(this.ProgramVersion);
            this.InstalledProgramsObjectListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstalledProgramsObjectListView.CellEditUseWholeCell = false;
            this.InstalledProgramsObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProgramName,
            this.ProgramVersion});
            this.InstalledProgramsObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.InstalledProgramsObjectListView.Location = new System.Drawing.Point(4, 43);
            this.InstalledProgramsObjectListView.Name = "InstalledProgramsObjectListView";
            this.InstalledProgramsObjectListView.RowHeight = 20;
            this.InstalledProgramsObjectListView.ShowGroups = false;
            this.InstalledProgramsObjectListView.Size = new System.Drawing.Size(756, 421);
            this.InstalledProgramsObjectListView.TabIndex = 3;
            this.InstalledProgramsObjectListView.UseCompatibleStateImageBehavior = false;
            this.InstalledProgramsObjectListView.View = System.Windows.Forms.View.Details;
            this.InstalledProgramsObjectListView.VirtualMode = true;
            // 
            // ProgramName
            // 
            this.ProgramName.AspectName = "name";
            this.ProgramName.Text = "Program name";
            this.ProgramName.Width = 580;
            // 
            // ProgramVersion
            // 
            this.ProgramVersion.AspectName = "version";
            this.ProgramVersion.Text = "Version";
            this.ProgramVersion.Width = 150;
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataSource = typeof(WindowsFormsApp2.Computer);
            // 
            // PCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 491);
            this.Controls.Add(this.OfficeLicenseTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PCForm";
            ((System.ComponentModel.ISupportInitialize)(this.DiskObjectListView)).EndInit();
            this.OfficeLicenseTab.ResumeLayout(false);
            this.HardwareSpecsTab.ResumeLayout(false);
            this.HardwareSpecsTab.PerformLayout();
            this.OfficeProgramsTab.ResumeLayout(false);
            this.OfficeProgramsTab.PerformLayout();
            this.InstalledProgramsTab.ResumeLayout(false);
            this.InstalledProgramsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficeLicenseListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstalledProgramsObjectListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PCheader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblOSVersion;
        private System.Windows.Forms.Label lblWindowsInstallDate;
        private System.Windows.Forms.Label lblArchitecture;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblCPUBench;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblGPUBench;
        private System.Windows.Forms.Label lblFreeSpace;
        private System.Windows.Forms.Label lblSymantecVersion;
        private System.Windows.Forms.Label diskHeader;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private BrightIdeasSoftware.FastObjectListView DiskObjectListView;
        private BrightIdeasSoftware.OLVColumn diskName;
        private BrightIdeasSoftware.OLVColumn diskType;
        private BrightIdeasSoftware.OLVColumn diskSize;
        private BrightIdeasSoftware.OLVColumn diskHealth;
        private System.Windows.Forms.TabControl OfficeLicenseTab;
        private System.Windows.Forms.TabPage HardwareSpecsTab;
        private System.Windows.Forms.TabPage OfficeProgramsTab;
        private System.Windows.Forms.TabPage InstalledProgramsTab;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textWindowsInstallDate;
        private System.Windows.Forms.TextBox textOSVersion;
        private System.Windows.Forms.TextBox textOperatingSystem;
        private System.Windows.Forms.TextBox textDeviceType;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textManufacturer;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textSymVersion;
        private System.Windows.Forms.TextBox textFreeSpace;
        private System.Windows.Forms.TextBox textRAM;
        private System.Windows.Forms.TextBox textGPUBench;
        private System.Windows.Forms.TextBox textGPU;
        private System.Windows.Forms.TextBox textCPUBench;
        private System.Windows.Forms.TextBox textCPU;
        private System.Windows.Forms.TextBox textArchitecture;
        private System.Windows.Forms.Label PCHeader2;
        private BrightIdeasSoftware.FastObjectListView OfficeLicenseListView;
        private BrightIdeasSoftware.OLVColumn officeName;
        private BrightIdeasSoftware.OLVColumn officeKey;
        private BrightIdeasSoftware.OLVColumn officeNumber;
        private BrightIdeasSoftware.OLVColumn OfficeEmail;
        private System.Windows.Forms.Label PCHeader3;
        private BrightIdeasSoftware.FastObjectListView InstalledProgramsObjectListView;
        private BrightIdeasSoftware.OLVColumn ProgramName;
        private BrightIdeasSoftware.OLVColumn ProgramVersion;
    }
}