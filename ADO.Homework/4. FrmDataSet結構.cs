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
    public partial class FrmDataSet結構 : Form
    {
        public FrmDataSet結構()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //連線資料庫
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);

            this.dataGridView1.DataSource = this.nwDataSet1.Products;
            this.dataGridView2.DataSource = this.nwDataSet1.Categories;
            this.dataGridView3.DataSource = this.nwDataSet1.Customers;

            this.listBox1.Items.Clear();
            //抓資料表
            for(int i = 0; i <nwDataSet1.Tables.Count; i++)
            {
                DataTable table= this.nwDataSet1.Tables[i];
                this.listBox1.Items.Add(table.TableName);
                this.listBox1.Items.Add("-----------");

                //抓資料表欄位(橫)
                string s = "";
                for(int column = 0; column < table.Columns.Count; column++)
                {
                    s += $"{table.Columns[column].ColumnName,-40}";
                }
                listBox1.Items.Add(s);
                string r = "";
                //抓資料表行(直)
                for(int row = 0; row < table.Rows.Count; row++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        r += $"{table.Rows[row][k],-40}";                       
                    }
                    listBox1.Items.Add(r);
                    r = "";

                }
                listBox1.Items.Add("=============================================");
            }

         


        }
    }
}
