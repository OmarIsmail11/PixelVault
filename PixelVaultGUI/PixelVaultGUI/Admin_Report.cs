﻿using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelVaultGUI
{
    public partial class Admin_Report : Form
    {
        Controller controllerObj = new Controller();
        public Admin_Report()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerObj.Report1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = controllerObj.Report3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerObj.Report4();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = controllerObj.Report2();
        }
    }
}
