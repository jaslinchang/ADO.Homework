using ADO.Homework._6._FrmMyAlbum;
using System;
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

            
            this.countryTableAdapter1.Fill(this.coDataSet1.Country);
            var arr = new List<string>;

            for (int b = 0; b < coDataSet1.Tables.Count; b++)
            {
                DataTable table = this.coDataSet1.Tables[b];
                string s = "";
                for (int column = 0; column < table.Columns.Count-1; column++)
                {
                    s = table.Columns[column].ColumnName + "  ";
                    string a = "";
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        a = table.Rows[row][1].ToString();

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            LinkLabel x = new LinkLabel();
                            x.Text = a;
                            x.Left = 25;
                            x.Top = 30 * i;
                            x.Tag = i;  //設他為ID
                            x.Click += X_Click;
                           
                            this.splitContainer2.Panel1.Controls.Add(x);
                        }
                      

                        //MessageBox.Show(a);
                    }


                }                                                                        

                    
            }

            //for (int k = 0; k < coDataSet1.Tables.Count; k++)
            //{
            //    DataTable table = this.coDataSet1.Tables[k];
            //    string s = "";
            //    for (int column = 0; column < table.Columns.Count; column++)  //當column<那個資料表內的欄位數時
            //    {
            //        s += table.Columns[column].ColumnName + "  ";  //取得集合的name
            //        string a = "";
            //        for (int row = 0; row < table.Rows.Count; row++)
            //        {
            //            for (int j = 0; j < table.Columns.Count; j++)
            //            {
            //                a += table.Rows[row][j].ToString();
            //                for (int i = 0; i < coDataSet1.Tables.Count; i++)
            //                {
            //                    LinkLabel x = new LinkLabel();
            //                    x.Text= a;
            //                    x.Left = 25;
            //                    x.Top = 30 * i;
            //                    x.Tag = i;  //設他為ID
            //                    x.Click += X_Click;

            //                    this.splitContainer2.Panel1.Controls.Add(x);
            //                }
            //            }
            //            //this.listBox2.Items.Add(a);
            //            //a = "";
            //        }

            //    }
               
          
            //}




            //string[] arr = new string[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    LinkLabel x = new LinkLabel();
            //    x.Text = arr[i];
            //    x.Left = 25;
            //    x.Top = 30 * i;
            //    x.Tag = i;  //設他為ID
            //    x.Click += X_Click;

            //    this.splitContainer2.Panel1.Controls.Add(x);
            //}
        }

        private void X_Click(object sender, EventArgs e)
        {
            LinkLabel x = sender as LinkLabel;
            if (x != null)
            {
                this.pictureTableAdapter1.Fill(this.coDataSet1.Picture);
                this.bindingSource1.DataSource = this.coDataSet1.Picture;
                this.dataGridView1.DataSource = this.bindingSource1;

                this.bindingNavigator1.BindingSource = this.bindingSource1;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
          
            


            //FrmTool ft = new FrmTool();
            //ft.Show();



            //this.countryTableAdapter1.Fill(this.coDataSet1.Country);
            //this.bindingSource1.DataSource = this.coDataSet1.Country;
            //this.dataGridView1.DataSource = this.bindingSource1;


            /*
            string connString =@" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ja\ADO.NET\作業\09_張媛婕\ADO.Homework\ADO.Homework\DatabaseWorld.mdf; Integrated Security = True";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    //step1  準備連線
                    conn.Open();  //開啟連接

                    //step 2  下指令
                    SqlCommand command = new SqlCommand("select * from country", conn);

                    //step3  讀取資料
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.listBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        string s = $"{dataReader["Name"]}";
                        this.listBox1.Items.Add(s);
                    }
                }  //Auto conn.lose();  他會自動關連接

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
    }
}
