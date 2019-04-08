﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class Form1 : Form {
        private List<Computer> computers = new List<Computer>();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            WindowState = FormWindowState.Maximized;

            try {
                String[] files = Directory.GetFiles(@"I:\temp\Computer_specs", @"*.txt");
                Parallel.ForEach(files, processFile);

                List<Computer> com = new List<Computer>();

                foreach (Computer c in computers) {
                    if(!c.workstation.Contains("DKP"))
                        if (isNewestFile(c.workstation, c.modification))
                            com.Add(c);
                }

                if (files.Length != computers.Count) {
                    MessageBox.Show("Error");
                }
                fastObjectListView1.AddObjects(com);
            } catch (DirectoryNotFoundException){
                MessageBox.Show("Geen computers gevonden");
            }

            foreach (ColumnHeader header in fastObjectListView1.Columns) {
                header.Width = -2;
            }
        }

        private void processFile(String fileName) {
            string[] lines = File.ReadAllLines(fileName);
            FileHandler fh = new FileHandler(lines, fileName);
            computers.Add(fh.getComputer());
            Console.WriteLine(fileName);
        }

        private Boolean isNewestFile(String workstation, DateTime modification) {
            foreach (Computer c in computers) {
                if (c.workstation == workstation && c.modification > modification) {
                    return false;
                }
            }
            return true;
        }
    }
}