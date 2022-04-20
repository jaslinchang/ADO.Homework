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
    public partial class Frm6MyAlbum_V2 : Form
    {
        public Frm6MyAlbum_V2()
        {
            InitializeComponent();
            LoadCountryName();
        }
     
        //Page 1
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
                    x.Top = 20+80 * i;
                    x.Tag = i;  //設他為ID
                    x.Click += X_Click; ;
                    splitContainer2.Panel1.Controls.Add(x);
                }
            }
        }

        LinkLabel x;
        private void X_Click(object sender, EventArgs e)
        {
             x = sender as LinkLabel;
            if (x != null)
            {
                this.picture1TableAdapter1.FillCountry(this.coDataSet1.Picture1, (int)x.Tag + 1);
                this.bindingSourceLabelLink.DataSource = this.coDataSet1.Picture1;
        

                int imageID =(int) x.Tag+1;
                //ShowImage(imageID);


                //MessageBox.Show(imageID.ToString());

            }
        }
        /*
        private void ShowImage(int imageID)
        {
            //Select
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.DatabaseWorldConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from MyImageTable where ImageID={imageID}";
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        //=======================
                        dataReader.Read();

                        byte[] bytes = (byte[])dataReader["Image"];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        this.pictureBox2.Image = Image.FromStream(ms);

                        //=======================
                    }
                    else
                    {
                        MessageBox.Show("No Record");
                    }
                } // Auto conn.Close()
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                this.pictureBox2.Image = this.pictureBox2.ErrorImage;
            }
        }
        
        */


        //Page 3
        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coDataSet1);
        } 
      
        private void fillCountryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {             
                this.picture1TableAdapter1.FillCountry(this.coDataSet1.Picture1, ((int)(System.Convert.ChangeType(countryIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void countryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             countryIDToolStripTextBox.Text = "";
            int na = countryBindingSource.Position + 1;
            countryIDToolStripTextBox.Text = na.ToString();
            fillCountryToolStripButton.PerformClick();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
                this.picturePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}





//fillCountryToolStripButton.Click;



//if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
//{
//    this.picture1TableAdapter1.FillCountry(this.coDataSet1.Picture1, (int)this.countryDataGridView.CurrentRow.Cells[0].Value);
//    //this.pictureTableAdapter1.Fill(coDataSet1.Picture);
//    this.bindingSource1.DataSource = this.coDataSet1.Picture1;
//    this.dataGridView1.DataSource = this.bindingSource1;

//    this.textBox1.DataBindings.Add("Text", this.bindingSource1, "PictureID");
//    this.textBox2.DataBindings.Add("Text", this.bindingSource1, "PictureName");
//    this.textBox3.DataBindings.Add("Text", this.bindingSource1, "Description");
//    this.textBox4.DataBindings.Add("Text", this.bindingSource1, "CountryID");
//}



//this.textBox1.DataBindings.Add("Text", this.bindingSource1, "PictureID");
//this.textBox2.DataBindings.Add("Text", this.bindingSource1, "PictureName");
//this.textBox3.DataBindings.Add("Text", this.bindingSource1, "Description");
//this.textBox4.DataBindings.Add("Text", this.bindingSource1, "CountryID");
//this.picturePictureBox.DataBindings.Add("Image", this.bindingSourceLabelLink, "Picture");

//this.bindingNavigatorPicture.BindingSource = this.bindingSource1;