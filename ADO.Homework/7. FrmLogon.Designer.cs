
namespace ADO.Homework
{
    partial class Frm7_Logon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm7_Logon));
            this.button1 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(391, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = "建立帳號 (&A)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cancel.Location = new System.Drawing.Point(286, 170);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(77, 31);
            this.Cancel.TabIndex = 28;
            this.Cancel.Text = "取消(&C)";
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OK.Location = new System.Drawing.Point(197, 170);
            this.OK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(77, 31);
            this.OK.TabIndex = 27;
            this.OK.Text = "確定(&O)";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PasswordTextBox.Location = new System.Drawing.Point(197, 124);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(166, 23);
            this.PasswordTextBox.TabIndex = 26;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UsernameTextBox.Location = new System.Drawing.Point(197, 69);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(166, 23);
            this.UsernameTextBox.TabIndex = 24;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PasswordLabel.Location = new System.Drawing.Point(198, 102);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(165, 19);
            this.PasswordLabel.TabIndex = 25;
            this.PasswordLabel.Text = "密碼(&P)";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UsernameLabel.Location = new System.Drawing.Point(198, 47);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(165, 19);
            this.UsernameLabel.TabIndex = 22;
            this.UsernameLabel.Text = "使用者名稱(&U)";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(34, 38);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(124, 155);
            this.LogoPictureBox.TabIndex = 23;
            this.LogoPictureBox.TabStop = false;
            // 
            // Frm7_Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Name = "Frm7_Logon";
            this.Text = "Frm7_Logon";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.TextBox PasswordTextBox;
        internal System.Windows.Forms.TextBox UsernameTextBox;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
    }
}