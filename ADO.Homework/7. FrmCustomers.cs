﻿using System;
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
    public partial class Frm7_Customers : Form
    {
        public Frm7_Customers()
        {
            InitializeComponent();
            this.listView1.View = View.Details;
            LoadCountryToComboBox();
            CreateListViewColumns();
        }              

        private void LoadCountryToComboBox()
        {  //載入country到combobox
            this.comboBox1.Items.Add("(ALL)");
            try
            {
                using (SqlConnection conn=new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select distinct country from customers",conn);

                    SqlDataReader dataReader = command.ExecuteReader();
                    
                    while (dataReader.Read())
                    {
                        string s = $"{dataReader["country"]}";
                        this.comboBox1.Items.Add(s);
                    }
                    this.comboBox1.SelectedIndex = 0;
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateListViewColumns()
        {  //加入橫標題
            try
            {
                using(SqlConnection conn=new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select * from customers", conn);
                    SqlDataReader dataReader = command.ExecuteReader();
                    DataTable table= dataReader.GetSchemaTable();
                    
                    for(int i = 0; i < table.Rows.Count; i++)
                    {
                        this.listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (this.comboBox1.Text == "(ALL)")
            {
                //disconnect
                this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);
                this.listView1.Items.Clear();
                for(int i = 0; i < nwDataSet1.Customers.Rows.Count; i++)
                {
                    ListViewItem lvi = this.listView1.Items.Add(nwDataSet1.Customers.Rows[i][0].ToString());
                    for(int j = 0; j < nwDataSet1.Customers.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(nwDataSet1.Customers.Rows[i][j].ToString());
                    }
                }


                /*  connect
               
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand($"select * from customers", conn);
                        SqlDataReader dataReader = command.ExecuteReader();

                        this.listView1.Items.Clear();
                        Random r = new Random();
                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

                            //設定Icon圖片
                            lvi.ImageIndex = r.Next(0, this.ImageList1.Images.Count);

                            //設定欄位背景色
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.LightSteelBlue;
                            }
                            else
                            {
                                lvi.BackColor = Color.LightGray;
                            }

                            //設定副標題
                            for (int i = 0; i < dataReader.FieldCount; i++)
                            {
                                if (dataReader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());
                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
 
                */
            }
            else
            {
                //disconnect
                this.customersTableAdapter1.FillByCountry(this.nwDataSet1.Customers,this.comboBox1.Text);
                listView1.Items.Clear();
                for (int i = 0; i < nwDataSet1.Customers.Rows.Count; i++)
                {
                    ListViewItem lvi = this.listView1.Items.Add(this.nwDataSet1.Customers.Rows[i][0].ToString());
                    for(int j = 1; j < this.nwDataSet1.Customers.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(this.nwDataSet1.Customers.Rows[i][j].ToString());
                    }
                }

                 /*disconnect
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand($"select * from customers where country ='{this.comboBox1.Text}'", conn);
                        SqlDataReader dataReader = command.ExecuteReader();

                        this.listView1.Items.Clear();
                        Random r = new Random();

                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

                            //設定Icon圖片
                            lvi.ImageIndex = r.Next(0, this.ImageList1.Images.Count);

                            //設定欄位背景色
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.LightSteelBlue;
                            }
                            else
                            {
                                lvi.BackColor = Color.LightGray;
                            }

                            //設定副標題
                            for (int i = 0; i < dataReader.FieldCount; i++)
                            {
                                if (dataReader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());
                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                 */

            }
                     
        }

        private void detailsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void customerIDAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "(ALL)")
            {
                this.customersTableAdapter1.FillByIDAscAll(this.nwDataSet1.Customers);
                this.listView1.Items.Clear();
                for (int i = 0; i < this.nwDataSet1.Customers.Rows.Count; i++)
                {
                    ListViewItem lvi = this.listView1.Items.Add(this.nwDataSet1.Customers.Rows[i][0].ToString());
                    for (int k = 1; k < this.nwDataSet1.Customers.Columns.Count; k++)
                    {
                        lvi.SubItems.Add(this.nwDataSet1.Customers.Rows[i][k].ToString());
                    }
                }
            }
            else
            {
                this.customersTableAdapter1.FillByIDAsc(this.nwDataSet1.Customers, this.comboBox1.Text);
                this.listView1.Items.Clear();
                for (int i = 0; i < this.nwDataSet1.Customers.Rows.Count; i++)
                {
                    ListViewItem lvi = this.listView1.Items.Add(this.nwDataSet1.Customers.Rows[i][0].ToString());
                    for (int k = 1; k < this.nwDataSet1.Customers.Columns.Count; k++)
                    {
                        lvi.SubItems.Add(this.nwDataSet1.Customers.Rows[i][k].ToString());
                    }
                }
            }            

        }

        private void customersIDDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "(ALL)")
            {
                this.customersTableAdapter1.FillByIDDescAll(this.nwDataSet1.Customers);
                this.listView1.Items.Clear();
                for (int i = 0; i < this.nwDataSet1.Customers.Rows.Count; i++)
                {
                    ListViewItem lvi = this.listView1.Items.Add(this.nwDataSet1.Customers.Rows[i][0].ToString());
                    for (int k = 1; k < this.nwDataSet1.Customers.Columns.Count; k++)
                    {
                        lvi.SubItems.Add(this.nwDataSet1.Customers.Rows[i][k].ToString());
                    }
                }
            }
            else
            {
                this.customersTableAdapter1.FillByIDDesc(this.nwDataSet1.Customers, this.comboBox1.Text);
                this.listView1.Items.Clear();
                for (int i = 0; i < this.nwDataSet1.Customers.Rows.Count; i++)
                {
                    ListViewItem lvi = this.listView1.Items.Add(this.nwDataSet1.Customers.Rows[i][0].ToString());
                    for (int k = 1; k < this.nwDataSet1.Customers.Columns.Count; k++)
                    {
                        lvi.SubItems.Add(this.nwDataSet1.Customers.Rows[i][k].ToString());
                    }
                }
            }



        }

    }
}


//TODO HW

//1. All Country


//================================
//2. ContextMenuStrip2
//選擇性作業
//Groups
//USA (100) 
//UK (20)

//this.listview1.visible = false;
//ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

//if (this.listView1.Groups["USA"] == null)
//{                       {
//    ListViewGroup group = this.listView1.Groups.Add("USA", "USA"); //Add(string key, string headerText);
//    group.Tag = 0;
//    lvi.Group = group; 
//}
//else
//{
//    ListViewGroup group = this.listView1.Groups["USA"]; 
//    lvi.Group = group;
//}

//this.listView1.Groups["USA"].Tag = 
//this.listView1.Groups["USA"].Header = 