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
            LoadCategoriesToComboBox1();  //Connect
            LoadCategoriesToComboBox2();  //Disconnect 1.0
            LoadCategoriesToComboBox3();  //Disconnect 2.0
        }
               
        //Connect
        private void LoadCategoriesToComboBox1()
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
                    }
                }
           
        }
            catch (Exception ex)  //保護程式，抓一些無法掌控的錯誤
            {
                MessageBox.Show(ex.Message);  //show 錯誤的提示訊息
            }
        }

        //Disconnect 1.0
        private void LoadCategoriesToComboBox2()
        {
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            for (int i = 0; i < nwDataSet1.Categories.Rows.Count; i++)
            {
                this.comboBox2.Items.Add(this.nwDataSet1.Categories[i][1]);
            }
        }
       
        //Disconnect 2.0
        private void LoadCategoriesToComboBox3()
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            for (int i = 0; i < nwDataSet1.Categories.Rows.Count; i++)
            {
                this.comboBox3.Items.Add(this.nwDataSet1.Categories[i][1]);
            }
        }

        //===============================================
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
                //string bb = $"SELECT c.CategoryName, ProductName FROM Categories c join Products p on c.CategoryID = p.CategoryID where c.CategoryName = '{comboBox1.Text}'";
                
                SqlCommand command = new SqlCommand($"SELECT ProductName FROM products p join Categories c on p.CategoryID = c.CategoryID  where CategoryName ='{comboBox1.Text}'", conn);
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
        
        
        //DisConnect 1.0
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");            
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT ProductName FROM products p join Categories c on p.CategoryID = c.CategoryID  where CategoryName ='{comboBox2.Text}'", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);           
            this.dataGridView1.DataSource = ds.Tables[0];           
        }

        //DisConnect 2.0
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.products1TableAdapter1.FillCategoryName(nwDataSet1.Products1, comboBox3.Text);
            dataGridView2.DataSource = nwDataSet1.Products1;
        }

    }
}
