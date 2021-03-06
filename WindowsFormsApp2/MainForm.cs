﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class PCInventarisation : Form {
        private List<Computer> computers = new List<Computer>();

        public PCInventarisation(){
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
                    MessageBox.Show("Fout bij het inlezen van de computers");
                }

                computers = com;
                TotalPClist.AddObjects(computers);

            } catch (DirectoryNotFoundException){
                MessageBox.Show("Geen computers gevonden");
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

        private void Form1_ItemActivate(Object sender, EventArgs e) {
            Computer selectedPC = (Computer) TotalPClist.SelectedObject;
            Console.WriteLine(selectedPC.workstation);
            PCForm detailView = new PCForm(selectedPC);
            detailView.Show();
        }

        private void searchBox_TextChanged(object sender, EventArgs e){
            if(searchBox.TextLength > 2) { 
                TotalPClist.ClearObjects();
                foreach (Computer c in computers){
                    if (c.search(c, searchBox.Text)){
                        TotalPClist.AddObject(c);
                    }
                }
            }else{
                TotalPClist.ClearObjects();
                TotalPClist.AddObjects(computers);
            }
        }
    }
}