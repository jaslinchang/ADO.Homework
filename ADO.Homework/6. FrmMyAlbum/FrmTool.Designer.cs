
namespace ADO.Homework._6._FrmMyAlbum
{
    partial class FrmTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTool));
            System.Windows.Forms.Label pictureIDLabel;
            System.Windows.Forms.Label pictureNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label pictureLabel;
            this.cODataSet = new ADO.Homework.CODataSet();
            this.pictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureTableAdapter = new ADO.Homework.CODataSetTableAdapters.PictureTableAdapter();
            this.tableAdapterManager = new ADO.Homework.CODataSetTableAdapters.TableAdapterManager();
            this.pictureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureIDTextBox = new System.Windows.Forms.TextBox();
            this.pictureNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            pictureIDLabel = new System.Windows.Forms.Label();
            pictureNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingNavigator)).BeginInit();
            this.pictureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cODataSet
            // 
            this.cODataSet.DataSetName = "CODataSet";
            this.cODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBindingSource
            // 
            this.pictureBindingSource.DataMember = "Picture";
            this.pictureBindingSource.DataSource = this.cODataSet;
            // 
            // pictureTableAdapter
            // 
            this.pictureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryTableAdapter = null;
            this.tableAdapterManager.PictureTableAdapter = this.pictureTableAdapter;
            this.tableAdapterManager.UpdateOrder = ADO.Homework.CODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBindingNavigator
            // 
            this.pictureBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pictureBindingNavigator.BindingSource = this.pictureBindingSource;
            this.pictureBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pictureBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pictureBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pictureBindingNavigatorSaveItem});
            this.pictureBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pictureBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pictureBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pictureBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pictureBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pictureBindingNavigator.Name = "pictureBindingNavigator";
            this.pictureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pictureBindingNavigator.Size = new System.Drawing.Size(803, 25);
            this.pictureBindingNavigator.TabIndex = 0;
            this.pictureBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 15);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // pictureBindingNavigatorSaveItem
            // 
            this.pictureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pictureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBindingNavigatorSaveItem.Image")));
            this.pictureBindingNavigatorSaveItem.Name = "pictureBindingNavigatorSaveItem";
            this.pictureBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pictureBindingNavigatorSaveItem.Text = "儲存資料";
            this.pictureBindingNavigatorSaveItem.Click += new System.EventHandler(this.pictureBindingNavigatorSaveItem_Click);
            // 
            // pictureDataGridView
            // 
            this.pictureDataGridView.AutoGenerateColumns = false;
            this.pictureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pictureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1});
            this.pictureDataGridView.DataSource = this.pictureBindingSource;
            this.pictureDataGridView.Location = new System.Drawing.Point(24, 62);
            this.pictureDataGridView.Name = "pictureDataGridView";
            this.pictureDataGridView.RowTemplate.Height = 24;
            this.pictureDataGridView.Size = new System.Drawing.Size(522, 267);
            this.pictureDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PictureID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PictureID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PictureName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PictureName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // pictureIDLabel
            // 
            pictureIDLabel.AutoSize = true;
            pictureIDLabel.Location = new System.Drawing.Point(552, 77);
            pictureIDLabel.Name = "pictureIDLabel";
            pictureIDLabel.Size = new System.Drawing.Size(55, 12);
            pictureIDLabel.TabIndex = 2;
            pictureIDLabel.Text = "Picture ID:";
            // 
            // pictureIDTextBox
            // 
            this.pictureIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pictureBindingSource, "PictureID", true));
            this.pictureIDTextBox.Location = new System.Drawing.Point(628, 74);
            this.pictureIDTextBox.Name = "pictureIDTextBox";
            this.pictureIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.pictureIDTextBox.TabIndex = 3;
            // 
            // pictureNameLabel
            // 
            pictureNameLabel.AutoSize = true;
            pictureNameLabel.Location = new System.Drawing.Point(552, 105);
            pictureNameLabel.Name = "pictureNameLabel";
            pictureNameLabel.Size = new System.Drawing.Size(70, 12);
            pictureNameLabel.TabIndex = 4;
            pictureNameLabel.Text = "Picture Name:";
            // 
            // pictureNameTextBox
            // 
            this.pictureNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pictureBindingSource, "PictureName", true));
            this.pictureNameTextBox.Location = new System.Drawing.Point(628, 102);
            this.pictureNameTextBox.Name = "pictureNameTextBox";
            this.pictureNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.pictureNameTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(552, 133);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 12);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pictureBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(628, 130);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(552, 158);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(40, 12);
            pictureLabel.TabIndex = 8;
            pictureLabel.Text = "Picture:";
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pictureBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(628, 158);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(100, 124);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 9;
            this.picturePictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(pictureIDLabel);
            this.Controls.Add(this.pictureIDTextBox);
            this.Controls.Add(pictureNameLabel);
            this.Controls.Add(this.pictureNameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.pictureDataGridView);
            this.Controls.Add(this.pictureBindingNavigator);
            this.Name = "FrmTool";
            this.Text = "FrmTool";
            this.Load += new System.EventHandler(this.FrmTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingNavigator)).EndInit();
            this.pictureBindingNavigator.ResumeLayout(false);
            this.pictureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CODataSet cODataSet;
        private System.Windows.Forms.BindingSource pictureBindingSource;
        private CODataSetTableAdapters.PictureTableAdapter pictureTableAdapter;
        private CODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pictureBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pictureBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pictureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox pictureIDTextBox;
        private System.Windows.Forms.TextBox pictureNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}