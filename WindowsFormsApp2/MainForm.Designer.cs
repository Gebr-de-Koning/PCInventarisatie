namespace WindowsFormsApp2 {
    partial class PCInventarisation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCInventarisation));
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.Workstation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.User = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Manufacturer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Model = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.deviceType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OS = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.osVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.osInstallDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Architecture = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.CPUname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.CPUscore = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.RAM = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.GPUname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.GPUscore = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.symantecVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.AllColumns.Add(this.date);
            this.fastObjectListView1.AllColumns.Add(this.Workstation);
            this.fastObjectListView1.AllColumns.Add(this.User);
            this.fastObjectListView1.AllColumns.Add(this.Manufacturer);
            this.fastObjectListView1.AllColumns.Add(this.Model);
            this.fastObjectListView1.AllColumns.Add(this.deviceType);
            this.fastObjectListView1.AllColumns.Add(this.OS);
            this.fastObjectListView1.AllColumns.Add(this.osVersion);
            this.fastObjectListView1.AllColumns.Add(this.osInstallDate);
            this.fastObjectListView1.AllColumns.Add(this.Architecture);
            this.fastObjectListView1.AllColumns.Add(this.CPUname);
            this.fastObjectListView1.AllColumns.Add(this.CPUscore);
            this.fastObjectListView1.AllColumns.Add(this.RAM);
            this.fastObjectListView1.AllColumns.Add(this.GPUname);
            this.fastObjectListView1.AllColumns.Add(this.GPUscore);
            this.fastObjectListView1.AllColumns.Add(this.symantecVersion);
            this.fastObjectListView1.CellEditUseWholeCell = false;
            this.fastObjectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.Workstation,
            this.User,
            this.Manufacturer,
            this.Model,
            this.deviceType,
            this.OS,
            this.osVersion,
            this.osInstallDate,
            this.Architecture,
            this.CPUname,
            this.CPUscore,
            this.RAM,
            this.GPUname,
            this.GPUscore,
            this.symantecVersion});
            this.fastObjectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastObjectListView1.FullRowSelect = true;
            this.fastObjectListView1.Location = new System.Drawing.Point(0, 0);
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.Size = new System.Drawing.Size(800, 339);
            this.fastObjectListView1.TabIndex = 3;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            // 
            // Workstation
            // 
            this.Workstation.AspectName = "workstation";
            this.Workstation.Text = "Workstation";
            // 
            // User
            // 
            this.User.AspectName = "user";
            this.User.Text = "User";
            // 
            // Manufacturer
            // 
            this.Manufacturer.AspectName = "manufacturer";
            this.Manufacturer.Text = "Manufacturer";
            // 
            // Model
            // 
            this.Model.AspectName = "model";
            this.Model.Text = "Model";
            // 
            // deviceType
            // 
            this.deviceType.AspectName = "deviceType";
            this.deviceType.Text = "Device type";
            // 
            // OS
            // 
            this.OS.AspectName = "os";
            this.OS.Text = "OS";
            // 
            // osVersion
            // 
            this.osVersion.AspectName = "osVersion";
            this.osVersion.Text = "OS Version";
            // 
            // osInstallDate
            // 
            this.osInstallDate.AspectName = "osInstallDate";
            this.osInstallDate.Text = "OS Installation date";
            // 
            // Architecture
            // 
            this.Architecture.AspectName = "architecture";
            this.Architecture.Text = "Architecture";
            // 
            // CPUname
            // 
            this.CPUname.AspectName = "cpu.name";
            this.CPUname.Text = "CPU";
            // 
            // CPUscore
            // 
            this.CPUscore.AspectName = "cpu.score";
            this.CPUscore.Text = "CPU score";
            // 
            // RAM
            // 
            this.RAM.AspectName = "ram";
            this.RAM.Text = "RAM (GB)";
            // 
            // GPUname
            // 
            this.GPUname.AspectName = "gpu.name";
            this.GPUname.Text = "GPU";
            // 
            // GPUscore
            // 
            this.GPUscore.AspectName = "gpu.score";
            this.GPUscore.Text = "GPU score";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fastObjectListView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 4;
            // 
            // symantecVersion
            // 
            this.symantecVersion.AspectName = "symantecVersion";
            this.symantecVersion.Text = "Symantec Version";
            // 
            // date
            // 
            this.date.AspectName = "date";
            this.date.Text = "Date";
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataSource = typeof(WindowsFormsApp2.Computer);
            // 
            // PCInventarisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PCInventarisation";
            this.Text = "PC Inventarisatie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource computerBindingSource;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
        private BrightIdeasSoftware.OLVColumn Workstation;
        private BrightIdeasSoftware.OLVColumn User;
        private BrightIdeasSoftware.OLVColumn Manufacturer;
        private BrightIdeasSoftware.OLVColumn Model;
        private BrightIdeasSoftware.OLVColumn OS;
        private BrightIdeasSoftware.OLVColumn Architecture;
        private BrightIdeasSoftware.OLVColumn CPUname;
        private BrightIdeasSoftware.OLVColumn RAM;
        private BrightIdeasSoftware.OLVColumn GPUname;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BrightIdeasSoftware.OLVColumn CPUscore;
        private BrightIdeasSoftware.OLVColumn GPUscore;
        private BrightIdeasSoftware.OLVColumn osInstallDate;
        private BrightIdeasSoftware.OLVColumn osVersion;
        private BrightIdeasSoftware.OLVColumn deviceType;
        private BrightIdeasSoftware.OLVColumn symantecVersion;
        private BrightIdeasSoftware.OLVColumn date;
    }
}

