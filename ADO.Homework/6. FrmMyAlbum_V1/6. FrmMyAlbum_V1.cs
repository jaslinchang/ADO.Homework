using ADO.Homework._6._FrmMyAlbum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.Homework
{
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();
            LoadCountryName();
        }

        private void LoadCountryName()
        {
            this.countryTableAdapter1.Fill(this.coDataSet1.Country);
            List<string> Count = new List<string>();

            for (int b = 0; b < coDataSet1.Tables.Count; b++)
            {
                DataTable table = this.coDataSet1.Tables[b];
                string s = "";
                for (int column = 0; column < table.Columns.Count - 1; column++)
                {
                    s = table.Columns[column].ColumnName + "  ";
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        Count.Add(table.Rows[row][1].ToString());                     
                    }
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    LinkLabel x = new LinkLabel();
                    x.Text = Count[i];
                    x.Left = 25;
                    x.Top = 30 * i;
                    x.Tag = i;  //設他為ID
                    x.Click += X_Click;

                    this.splitContainer2.Panel1.Controls.Add(x);
                }
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            LinkLabel x = sender as LinkLabel;
            if (x != null)
            {
                this.picture1TableAdapter1.FillCountry(this.coDataSet1.Picture1, (int)x.Tag + 1);
                this.bindingSource1.DataSource = this.coDataSet1.Picture1;
                this.dataGridView1.DataSource = this.bindingSource1;
                this.bindingNavigator1.BindingSource = this.bindingSource1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTool ft = new FrmTool();
            ft.Show();
        }
    }
}
