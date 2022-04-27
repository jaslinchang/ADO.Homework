using ADO.Homework.Properties;
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
    public partial class Frm8_TreeView : Form
    {
        public Frm8_TreeView()
        {
            InitializeComponent();
            LoadCountryToTreeView();
        }

        int count = 0;       

        private void LoadCount(string name)
        {
            this.customersTableAdapter1.FillByTreeCount(this.nwDataSet1.Customers,name);
            dataGridView2.DataSource = nwDataSet1.Customers;
            count = (dataGridView2.Rows.Count - 1);
        }

        private void LoadCountryToTreeView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select *  from customers", conn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    

                    while (dataReader.Read())
                    {
                        string Country = dataReader["Country"].ToString();
                        string City = dataReader["City"].ToString();
                        
                        //=============================
                         TreeNode tree2 = null;  //拿來暫存
                        count++;
                        LoadCount(Country);
                        //加入Country

                        if (treeView1.Nodes[Country] == null)
                        {
                            TreeNode tree = new TreeNode();

                            //LoadCount(Country);
                            tree.Name = Country;
                            tree.Text = Country +"("+ count+")";
                            treeView1.Nodes.Add(tree);
                            tree2 = tree;

                            tree2.Tag = "Country";
                        }
                        else  tree2 = treeView1.Nodes[Country];                                               
                    

                         //==========================================


                        
                       /* SAFE
                        TreeNode tree2 = null;  //拿來暫存
                        //加入Country
                        if (treeView1.Nodes[Country] == null)
                        {
                            TreeNode tree = new TreeNode();
                            tree.Name = Country;
                            tree.Text = Country;
                            treeView1.Nodes.Add(tree);
                            tree2 = tree;
                            tree2.Tag = "Country";
                        }
                        else tree2 = treeView1.Nodes[Country];

                        */



                        //加入City
                        if (tree2.Nodes[City] == null)
                        {
                            TreeNode tree3 = new TreeNode();
                            tree3.Name = City;
                            tree3.Text = City;
                            tree2.Nodes.Add(tree3);
                            tree2 = tree3;
                            tree2.Tag = "City";
                        }
                        else tree2 = tree2.Nodes[City] ;                    


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag.ToString() == "Country") return;

            string city = e.Node.Text;
            this.customersTableAdapter1.FillByTree(this.nwDataSet1.Customers, city);
            dataGridView1.DataSource = nwDataSet1.Customers;            

            label1.Text = "共 " + (dataGridView1.Rows.Count - 1) +" 筆,  ' "+city+ " '  Customers";
        }

        
    }
}
