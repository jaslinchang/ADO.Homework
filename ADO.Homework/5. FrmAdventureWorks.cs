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
    public partial class FrmAdventureWorks : Form
    {
        public FrmAdventureWorks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Value.ToString("yyyyMMdd");
            string date2 = dateTimePicker2.Value.ToString("yyyyMMdd");

            this.productPhotoTableAdapter1.FillByDate(awDataSet1.ProductPhoto,date1,date2);
            this.bindingSource1.DataSource = this.awDataSet1.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;

            this.bindingNavigator1.BindingSource = this.bindingSource1;
   
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = this.bindingSource1.Count + 1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label4.Text = $"{this.bindingSource1.Position + 1}  /  {this.bindingSource1.Count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {      
            string datee = comboBox1.Text;
            this.productPhotoTableAdapter1.FillBycombo(awDataSet1.ProductPhoto,datee);
            this.bindingSource1.DataSource = this.awDataSet1.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;

            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void FrmAdventureWorks_Load(object sender, EventArgs e)
        {           
            SqlConnection conn = null;
            try
            {              
                conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=True");
                conn.Open();  //開啟連接

                //step 2  下指令
                SqlCommand command = new SqlCommand("SELECT DISTINCT SUBSTRING (CONVERT(varchar, ModifiedDate, 112),1,4 ) as datename FROM [Production].[ProductPhoto]", conn);
                SqlDataReader dataReader = command.ExecuteReader();

                //step3  讀取資料
                while (dataReader.Read())
                {
                    string name = $"{dataReader["datename"]}";
                    comboBox1.Items.Add(name);
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

        }

      
    }
}
