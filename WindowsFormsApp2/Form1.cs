using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class Form1 : Form {
        //private SortableBindingList<Computer> computers = new SortableBindingList<Computer>();
        private List<Computer> computers = new List<Computer>();
        private DataTable dt;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            WindowState = FormWindowState.Maximized;

            String[] files = Directory.GetFiles(@"I:\temp\Computer_specs", @"*.txt");    //DirectoryNotFoundException
            Parallel.ForEach(files, processFile);

            List<Computer> com = new List<Computer>();

            foreach (Computer c in computers) {
                if (isNewestFile(c.workstation, c.modification)) {
                    com.Add(c);
                    //remove from array
                }
            }

            for (int i = 0; i < com.Count; i++) {
                if (com[i].disks.Count > 1) {
                    Console.WriteLine(i);
                }
            }

            if (files.Length != computers.Count) {
                MessageBox.Show("Error");
            }
            fastObjectListView1.AddObjects(com);

            foreach(ColumnHeader header in fastObjectListView1.Columns) {
                header.Width = -2;
            }
            //dataGridView1.DataSource = computers;
        }

        private void processFile(String fileName) {
            string[] lines = File.ReadAllLines(fileName);
            FileHandler fh = new FileHandler(lines, fileName);
            //dt.Rows.Add(fh.getComputer().toArray());
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