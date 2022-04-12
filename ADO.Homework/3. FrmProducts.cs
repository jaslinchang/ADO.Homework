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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.FillByProduct(nwDataSet1.Products, textBox3.Text);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;

            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = this.bindingSource1.Count-1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label2.Text = $"{this.bindingSource1.Position + 1} / {this.bindingSource1.Count}";
            this.lblResult.Text = $"結果 {this.bindingSource1.Count} 筆";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);
            decimal txt2 = Convert.ToDecimal(textBox2.Text);
            this.productsTableAdapter1.FillByProductPrice(nwDataSet1.Products, txt1, txt2);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;

            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }
    }
}
