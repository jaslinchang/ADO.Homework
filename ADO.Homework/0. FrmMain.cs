﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.Homework
{
    public partial class Frm0_main : Form
    {
        public Frm0_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form1 f1 = new Form1();
            f1.TopLevel = false; 
            splitContainer2.Panel2.Controls.Add(f1);
            f1.Show();        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmCategoryProducts f2 = new FrmCategoryProducts();
            f2.TopLevel = false; 
            splitContainer2.Panel2.Controls.Add(f2);
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmProducts f3 = new FrmProducts();
            f3.TopLevel = false; 
            splitContainer2.Panel2.Controls.Add(f3);
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmDataSet結構 f4 = new FrmDataSet結構();
            f4.TopLevel = false; 
            splitContainer2.Panel2.Controls.Add(f4);
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmAdventureWorks f5 = new FrmAdventureWorks();
            f5.TopLevel = false; 
            splitContainer2.Panel2.Controls.Add(f5);
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmMyAlbum_V1 f6 = new FrmMyAlbum_V1();
            f6.TopLevel = false; 
            splitContainer2.Panel2.Controls.Add(f6);
            f6.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm6MyAlbum_V2 f66 = new Frm6MyAlbum_V2();
            f66.TopLevel = false; 
            splitContainer2.Panel2.Controls.Add(f66);
            f66.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm7_Customers f7 = new Frm7_Customers();
            f7.TopLevel = false; 
            splitContainer2.Panel2.Controls.Add(f7);
            f7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm7_Logon f77 = new Frm7_Logon();
            f77.TopLevel = false; 
            splitContainer2.Panel2.Controls.Add(f77);
            f77.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm8_TreeView f8 = new Frm8_TreeView();
            f8.TopLevel = false; 
            splitContainer2.Panel2.Controls.Add(f8);
            f8.Show();
        }

      
    }
}
