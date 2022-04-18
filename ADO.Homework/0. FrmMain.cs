using System;
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
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCategoryProducts f2 = new FrmCategoryProducts();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmProducts f3 = new FrmProducts();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDataSet結構 f4 = new FrmDataSet結構();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAdventureWorks f5 = new FrmAdventureWorks();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMyAlbum_V1 f6 = new FrmMyAlbum_V1();
            f6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm7_Customers f7 = new Frm7_Customers();
            f7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm7_Logon f77 = new Frm7_Logon();
            f77.Show();
        }
    }
}
