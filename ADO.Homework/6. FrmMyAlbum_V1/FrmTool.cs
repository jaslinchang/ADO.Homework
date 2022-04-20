using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.Homework._6._FrmMyAlbum
{
    public partial class FrmTool : Form
    {
        public FrmTool()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show("OK  " + this.openFileDialog1.FileName);  //秀出檔案的路徑
                this.picturePictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }

        private void pictureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pictureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cODataSet);

        }

        private void FrmTool_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'cODataSet.Picture' 資料表。您可以視需要進行移動或移除。
            this.pictureTableAdapter.Fill(this.cODataSet.Picture);

        }
    }
}
