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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cODataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'cODataSet.Country' 資料表。您可以視需要進行移動或移除。
            this.countryTableAdapter.Fill(this.cODataSet.Country);

        }
    }
}
