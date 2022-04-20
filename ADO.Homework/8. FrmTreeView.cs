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
            LoadCountry();
        }

          
        
        private void LoadCountry()
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
                        TreeNode tree = new TreeNode();
                        TreeNode tree2 = null;                                             

                        //加入Country
                        if (treeView1.Nodes[Country] == null)
                        {
                            tree.Name = Country;
                            tree.Text = Country;
                            treeView1.Nodes.Add(tree);
                            tree2 = tree;
                        }
                        else tree2 = tree;

                        //加入City
                        if (tree2.Nodes[City] == null)
                        {
                            TreeNode tree3 = new TreeNode();
                            tree3.Name = City;
                            tree3.Text = City;
                            tree2.Nodes.Add(tree3);
                            tree2 = tree3;
                        }
                        else tree2 = tree2.Nodes[City];

                        //tree.Name = $"{dataReader["country"]}";
                        //tree.Text = $"{dataReader["country"]}";
                        //treeView1.Nodes.Add(tree);


                    }

                    //for (int i = 0; i < treeView1.Nodes.Count; i++)
                    //{
                    //    for (int k = 0; k <=treeView1.Nodes.Count; k++)
                    //    {
                    //        treeView1.Nodes[i].Nodes.Add(k.ToString());
                    //    }
                    //}


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        

      
      

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                MessageBox.Show(treeView1.Nodes[i].Text);
            }
        }

        
    }
}
