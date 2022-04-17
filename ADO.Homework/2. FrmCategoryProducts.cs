using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ADO.Homework.Properties;

namespace ADO.Homework
{
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
            LoadCategoriesToComboBox();
        }

        private void LoadCategoriesToComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    //step1  準備連線               
                    conn.Open();  //開啟連接

                    //step 2  下指令
                    SqlCommand command = new SqlCommand("select CategoryName from Categories", conn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    //step3  讀取資料
                    this.listBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        string name = $"{dataReader["CategoryName"]}";
                        this.comboBox1.Items.Add(name);
                        this.comboBox2.Items.Add(name);
                    }
                }
           
        }
            catch (Exception ex)  //保護程式，抓一些無法掌控的錯誤
            {
                MessageBox.Show(ex.Message);  //show 錯誤的提示訊息
            }
        }

        private void FrmCategoryProducts_Load(object sender, EventArgs e)
        {
            //Connect
            try
            {
                //step1  準備連線
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();  //開啟連接

                //step 2  下指令
                SqlCommand command = new SqlCommand("select CategoryName from Categories" , conn);
                SqlDataReader dataReader = command.ExecuteReader();

                //step3  讀取資料
                this.listBox1.Items.Clear();
                while (dataReader.Read())
                {
                   string  name = $"{dataReader["CategoryName"]}";
                    this.comboBox1.Items.Add(name);
                    this.comboBox2.Items.Add(name);
                }
            }
            catch (Exception ex)  //保護程式，抓一些無法掌控的錯誤
            {
                MessageBox.Show(ex.Message);  //show 錯誤的提示訊息
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();  //斷開連接
                }
            }
            //Disconnect
            //this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);

            //for(int i = 0; i < this.nwDataSet1.Tables.Count; i++)
            //{
            //    DataTable table =this.nwDataSet1.Tables[i];
            //    string s = "";
            //    for(int column = 0; column < table.Columns.Count; column++)
            //    {
            //        s = table.Columns[column].ColumnName;
            //        this.comboBox2.Items.Add(s);

            //    }
            //}
        }

        //Connect
        SqlConnection conn = null;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {          
            try
            {
                this.listBox1.Items.Clear();
                //step1  準備連線
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();

                //step 2  下指令
                string bb = $"SELECT c.CategoryName, ProductName FROM Categories c join Products p on c.CategoryID = p.CategoryID where c.CategoryName = '{comboBox1.Text}'";
                SqlCommand command = new SqlCommand(bb, conn);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string s = $"{dataReader["ProductName"]}";
                    this.listBox1.Items.Add(s);
                }               

            }
            
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message);  
            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();  
                }
            }
        }

        //===============================================
        //DisConnect

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            //1.0
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            
            SqlDataAdapter adapter = new SqlDataAdapter($" SELECT ProductName FROM Categories c join Products p on c.CategoryID = p.CategoryID where c.CategoryName = '{comboBox2.Text}'", conn);
           
            DataSet ds = new DataSet();

            adapter.Fill(ds);
           
            this.dataGridView1.DataSource = ds.Tables[0];


            /*//2.0
         
            //string aa =comboBox2.Text;
            this.categoriesTableAdapter1.FillByCategoryName(this.nwDataSet1.Categories, comboBox2.Text);
            this.dataGridView1.DataSource = this.nwDataSet1.Categories;
            */

        }
    }
}
