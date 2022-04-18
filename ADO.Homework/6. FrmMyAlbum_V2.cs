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
    public partial class Frm6MyAlbum_V2 : Form
    {
        public Frm6MyAlbum_V2()
        {
            InitializeComponent();
            LoadCountryName();
            LoadPictureToDataGridView();
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
                    x.Left = 50;
                    x.Top = 20 * i;
                    x.Tag = i;  //設他為ID
                    x.Click += X_Click; ;
                    this.flowLayoutPanel1.Controls.Add(x);
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
            }
        }
        
        //Page 3
       
        private void LoadPictureToDataGridView()
        {
            //right
            this.pictureTableAdapter1.Fill(this.coDataSet1.Picture);
            this.picture1BindingSource.DataSource = this.coDataSet1.Picture;
            //this.picture1DataGridView.DataSource = this.picture1BindingSource;

            this.bindingNavigatorPicture.BindingSource = this.picture1BindingSource;
        }
        

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coDataSet1);

        }

        private void countryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.picture1TableAdapter1.FillCountry(this.coDataSet1.Picture1, countryDataGridView.CurrentCell.RowIndex+1);
            this.picture1TableAdapter1.FillCountry(this.coDataSet1.Picture1,int.Parse(countryIdTextBox.Text));
            this.bindingSourceLabelLink.DataSource = this.coDataSet1.Picture1;
            this.picture1DataGridView.DataSource = this.bindingSourceLabelLink;

            this.pictureIDTextBox.DataBindings.Add("Text", this.bindingSourceLabelLink, "PictureID");
            this.pictureNameTextBox.DataBindings.Add("Text", this.bindingSourceLabelLink, "PictureName");
            this.descriptionTextBox.DataBindings.Add("Text", this.bindingSourceLabelLink, "Description");
            this.countryIDTextBox1.DataBindings.Add("Text", this.bindingSourceLabelLink, "CountryID");
            this.picturePictureBox.DataBindings.Add("Image", this.bindingSourceLabelLink, "Picture");

            this.bindingNavigatorPicture.BindingSource = this.bindingSourceLabelLink;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
