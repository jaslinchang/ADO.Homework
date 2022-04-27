using ADO.Homework.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ADO.Homework
{
    public partial class Frm6MyAlbum_V2 : Form
    {
        public Frm6MyAlbum_V2()
        {
            InitializeComponent();
            LoadCountryNameAsLabelLink();
            LoadCountryNameToComoboBox();
            this.countryTableAdapter1.Fill(this.coDataSet1.Country);    

            this.flowLayoutPanel3.AllowDrop = true;
            this.flowLayoutPanel3.DragEnter += FlowLayoutPanel3_DragEnter;
            this.flowLayoutPanel3.DragDrop += FlowLayoutPanel3_DragDrop;
        }

        #region   Page 1

        LinkLabel x;
        PictureBox pic = null;

        private void LoadCountryNameAsLabelLink()
        {
            this.countryTableAdapter1.Fill(this.coDataSet2.Country);
            List<string> Name = new List<string>();

            for (int b = 0; b < coDataSet2.Tables.Count; b++)
            {
                DataTable table = this.coDataSet2.Tables[b];
                string s = "";
                for (int column = 0; column < table.Columns.Count - 1; column++)
                {
                    s = table.Columns[column].ColumnName + "  ";
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        Name.Add(table.Rows[row][1].ToString());
                    }
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    LinkLabel x = new LinkLabel();
                    x.Text = Name[i];
                    x.Left = 25;
                    x.Top = 20 + 80 * i;
                    x.Tag = i;  //設他為ID
                    x.Click += X_Click; ;
                    splitContainer2.Panel1.Controls.Add(x);
                }
            }
          
        }
        private void X_Click(object sender, EventArgs e)
        {
            x = sender as LinkLabel;
            int imageID = (int)x.Tag + 1;  //傳Country ID

            if (x != null)
            {
                this.flowLayoutPanel2.Controls.Clear();
                ShowImagePage1(imageID);
            }

            this.picture1TableAdapter1.FillCountry(coDataSet2.Picture1, imageID);
            this.bindingSource1.DataSource = coDataSet2.Picture1;
            dataGridView1.DataSource = bindingSource1;

        }

        private void ShowImagePage1(int imageID)
        { //Select
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.DatabaseWorldConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = $"select * from picture where CountryID={@imageID}";
                    
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {                        
                        pic = new PictureBox();
                        byte[] bytes = (byte[])dataReader["Picture"];
                        string pd = dataReader["PictureID"].ToString();
                        MemoryStream ms = new MemoryStream(bytes);  //轉型用
                        pic.Image = Image.FromStream(ms);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 250;
                        pic.Height = 150;
                        pic.BorderStyle = BorderStyle.Fixed3D;
                        pic.Padding = new Padding(6);
                        pic.Click += Pic_Click;
                        pic.MouseEnter += Pic_MouseEnter;
                        pic.MouseLeave += Pic_MouseLeave;
                        this.flowLayoutPanel2.Controls.Add(pic);                         

                    }
                   
                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
                

        #region 處理點擊照片事件

        Frm6_MyAlbumShow f = null;
        PictureBox p = null;
       

        private void Pic_Click(object sender, EventArgs e)
        {        
            p = new PictureBox();
            f = new Frm6_MyAlbumShow();
            int position = this.flowLayoutPanel2.Controls.IndexOf((PictureBox)sender);
            bindingSource1.Position = position;         
            p.DataBindings.Add("Image", this.bindingSource1, "Picture", true);
            ShowPicToNewPage();
        }

        private void ShowPicToNewPage()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm6_MyAlbumShow));

            p.Dock = DockStyle.Fill;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            ToolStrip toolStrip = new ToolStrip();
            toolStrip.Dock = DockStyle.Bottom;
            ToolStripButton stripButton1 = new ToolStripButton();
            stripButton1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            stripButton1.Image = (Image)(resources.GetObject("toolStripButton1.Image"));
            stripButton1.Text = "實際大小";
            stripButton1.Click += StripButton1_Click;
            ToolStripButton stripButton2 = new ToolStripButton();
            stripButton2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            stripButton2.Image = (Image)(resources.GetObject("toolStripButton1.Image"));
            stripButton2.Text = "上一張";
            stripButton2.Click += StripButton2_Click;
            ToolStripButton stripButton3 = new ToolStripButton();
            stripButton3.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            stripButton3.Image = (Image)(resources.GetObject("toolStripButton1.Image"));
            stripButton3.Text = "下一張";
            stripButton3.Click += StripButton3_Click;
            ToolStripButton stripButton4 = new ToolStripButton();
            stripButton4.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            stripButton4.Image = (Image)(resources.GetObject("toolStripButton1.Image"));
            stripButton4.Text = "自動撥放";
            stripButton4.Click += StripButton4_Click;
            toolStrip.Items.Add(stripButton1);
            toolStrip.Items.Add(stripButton2);
            toolStrip.Items.Add(stripButton3);
            toolStrip.Items.Add(stripButton4);
            f.Controls.Add(p);
            f.Controls.Add(toolStrip);
            f.Show();
        }

        bool check = true;
        private void StripButton1_Click(object sender, EventArgs e)
        {
            if (check)
            {
                p.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else p.SizeMode = PictureBoxSizeMode.StretchImage;

            check = !check;

        }
        private void StripButton2_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }
        private void StripButton3_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }
        private void StripButton4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bindingSource1.Position == bindingSource1.Count - 1)
            {
                bindingSource1.Position = 0;
            }
            else bindingSource1.MoveNext();
        }
        private void Pic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox x = sender as PictureBox;
            x.BackColor = Color.Red;
        }
        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox x = sender as PictureBox;
            x.BackColor = Color.Transparent;
        }
        #endregion
        #endregion
        //=========================================================================

        #region Page 2

        private void LoadCountryNameToComoboBox()
        {           
            for (int b = 0; b < coDataSet2.Tables.Count; b++)
            {
                DataTable table = this.coDataSet2.Tables[b];
                string s = "";
                for (int column = 0; column < table.Columns.Count - 1; column++)
                {
                    s = table.Columns[column].ColumnName + "  ";
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        this.comboBox1.Items.Add(table.Rows[row][1].ToString());
                    }
                }
            }         
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Countryname = this.comboBox1.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.DatabaseWorldConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = $"select CountryId from country where CountryName='{Countryname}'";

                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string s = $"{dataReader["CountryId"]}";
                        int CountryID = int.Parse(s);
                        this.flowLayoutPanel3.Controls.Clear();
                        label7.Text = CountryID.ToString();
                        ShowImagePage2(CountryID);
                    }
                }
            }

            catch (Exception ex){ MessageBox.Show(ex.Message);}

        }
        private void ShowImagePage2(int countryID)
        {
            //Select
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.DatabaseWorldConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = $"select * from picture where CountryID={@countryID}";

                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        PictureBox pic = new PictureBox();
                        byte[] bytes = (byte[])dataReader["Picture"];
                        MemoryStream ms = new MemoryStream(bytes);  //轉型用

                        pic.ContextMenuStrip = this.contextMenuStrip1;
                        pic.Image = Image.FromStream(ms);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 250;
                        pic.Height = 150;
                        pic.BorderStyle = BorderStyle.Fixed3D;
                        pic.Padding = new Padding(6, 6, 6, 6);
                        pic.MouseEnter += Pic_MouseEnter;
                        pic.MouseLeave += Pic_MouseLeave;

                        this.flowLayoutPanel3.Controls.Add(pic);

                    }

                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
       
        //開啟整個資料夾
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "請選擇城市...")
            {
                MessageBox.Show("請先選擇城市");
            }
            else
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filepath = dialog.SelectedPath;
                    foreach (string photo in Directory.GetFiles(filepath))
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(photo);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 250;
                        pic.Height = 150;
                        pic.BorderStyle = BorderStyle.Fixed3D;
                        pic.Padding = new Padding(6, 6, 6, 6);
                        pic.MouseEnter += Pic_MouseEnter;
                        pic.MouseLeave += Pic_MouseLeave;
                        InsertPicture(pic);
                        this.flowLayoutPanel3.Controls.Add(pic);
                    }
                }
            }
          
        }
        private void InsertPicture(PictureBox pic)
        {
            //Insert 
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.DatabaseWorldConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "INSERT INTO Picture(Picture,CountryID) VALUES (@Picture,@CountryID)";
                    command.Connection = conn;
                    //=============================
                    byte[] bytes = null;
                    MemoryStream ms = new MemoryStream();
                    pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();
                    //=============================
                    command.Parameters.Add("@Picture", SqlDbType.Image).Value = bytes;
                    command.Parameters.Add("@CountryID", SqlDbType.Int).Value = int.Parse(label7.Text);

                    conn.Open();
                    command.ExecuteNonQuery();
                    //MessageBox.Show("Insert Image successfully");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        //flowlayoutpanel事件
        private void FlowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            for (int i = 0; i <= files.Length - 1; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 250;
                pic.Height = 150;
                pic.BorderStyle = BorderStyle.Fixed3D;
                pic.Padding = new Padding(6, 6, 6, 6);
                pic.MouseEnter += Pic_MouseEnter;
                pic.MouseLeave += Pic_MouseLeave;
                InsertPicture(pic);
                this.flowLayoutPanel3.Controls.Add(pic);
            }
        }
        private void FlowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        //刪除照片
        private void 刪除照片ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PictureBox pp = ((PictureBox)sender);
            pp.ContextMenuStrip = this.contextMenuStrip1;
            int position = this.flowLayoutPanel2.Controls.IndexOf((PictureBox)sender);
            MessageBox.Show(position.ToString());
         
            //this.flowLayoutPanel3.Controls.RemoveAt(position);
            //MessageBox.Show("Remove Successful!!");
            //PictureBox pictureBox = (PictureBox)sender;
            //pictureBoxes.RemoveAt(this.flowLayoutPanel3.Controls.IndexOf(pictureBox));
            //this.flowLayoutPanel3.Controls.RemoveAt(this.flowLayoutPanel3.Controls.IndexOf(pictureBox));
            //if (this.flowLayoutPanel3.Controls.Count == 0)
            //{
            //    button3.Visible = false;
            //}
        }

        #endregion
        //=========================================================================

        #region Page 3
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
                this.picture1BindingSource.DataSource = this.coDataSet1.Picture1;
                this.photobindingNavigator.BindingSource = this.picture1BindingSource;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void countryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //countryIDToolStripTextBox.Text = "";
            //int na = countryBindingSource.Position + 1;
            //countryIDToolStripTextBox.Text = na.ToString();
            //fillCountryToolStripButton.PerformClick();
        }

        private void countryBindingSource_CurrentChanged(object sender, EventArgs e)
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








        #endregion

       
    }
}


