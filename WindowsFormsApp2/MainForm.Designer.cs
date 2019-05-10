﻿namespace WindowsFormsApp2 {
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
            this.date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
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
            this.symantecVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
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
            this.fastObjectListView1.Size = new System.Drawing.Size(1438, 360);
            this.fastObjectListView1.TabIndex = 3;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            this.fastObjectListView1.DoubleClick += new System.EventHandler(this.Form1_ItemActivate);
            // 
            // date
            // 
            this.date.AspectName = "date";
            this.date.Text = "Date";
            this.date.Width = 70;
            // 
            // Workstation
            // 
            this.Workstation.AspectName = "workstation";
            this.Workstation.Text = "Workstation";
            this.Workstation.Width = 90;
            // 
            // User
            // 
            this.User.AspectName = "user";
            this.User.Text = "User";
            this.User.Width = 75;
            // 
            // Manufacturer
            // 
            this.Manufacturer.AspectName = "manufacturer";
            this.Manufacturer.Text = "Manufacturer";
            this.Manufacturer.Width = 110;
            // 
            // Model
            // 
            this.Model.AspectName = "model";
            this.Model.Text = "Model";
            this.Model.Width = 150;
            // 
            // deviceType
            // 
            this.deviceType.AspectName = "deviceType";
            this.deviceType.Text = "Device type";
            this.deviceType.Width = 70;
            // 
            // OS
            // 
            this.OS.AspectName = "os";
            this.OS.Text = "OS";
            this.OS.Width = 95;
            // 
            // osVersion
            // 
            this.osVersion.AspectName = "osVersion";
            this.osVersion.Text = "OS Version";
            this.osVersion.Width = 65;
            // 
            // osInstallDate
            // 
            this.osInstallDate.AspectName = "osInstallDate";
            this.osInstallDate.Text = "OS Install date";
            this.osInstallDate.Width = 85;
            // 
            // Architecture
            // 
            this.Architecture.AspectName = "architecture";
            this.Architecture.Text = "Architecture";
            this.Architecture.Width = 70;
            // 
            // CPUname
            // 
            this.CPUname.AspectName = "cpu.name";
            this.CPUname.Text = "CPU";
            this.CPUname.Width = 250;
            // 
            // CPUscore
            // 
            this.CPUscore.AspectName = "cpu.score";
            this.CPUscore.Text = "CPU score";
            this.CPUscore.Width = 65;
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
            this.GPUname.Width = 175;
            // 
            // GPUscore
            // 
            this.GPUscore.AspectName = "gpu.score";
            this.GPUscore.Text = "GPU score";
            this.GPUscore.Width = 65;
            // 
            // symantecVersion
            // 
            this.symantecVersion.AspectName = "symantecVersion";
            this.symantecVersion.Text = "Symantec Version";
            this.symantecVersion.Width = 130;
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.searchBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fastObjectListView1);
            this.splitContainer1.Size = new System.Drawing.Size(1438, 476);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.TabIndex = 4;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(1213, 78);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(213, 23);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1210, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zoeken:";
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataSource = typeof(WindowsFormsApp2.Computer);
            // 
            // PCInventarisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 476);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PCInventarisation";
            this.Text = "PC Inventarisatie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
    }
}

