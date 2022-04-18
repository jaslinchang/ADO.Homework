using System;
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
    public partial class Frm7_Logon : Form
    {
        public Frm7_Logon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //註冊會員
            try
            {
                string userName = this.UsernameTextBox.Text;
                string Password = this.PasswordTextBox.Text;
                using(SqlConnection conn=new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"insert into MyMember (UserName,Password) values (@UserName,@Password)";
                    command.Connection = conn;

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = userName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;

                    command.ExecuteNonQuery();
                    MessageBox.Show("註冊會員成功");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = this.UsernameTextBox.Text;
                string Password = this.PasswordTextBox.Text;
                using(SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText =$"select * from MyMember where UserName=@UserName AND Password=@Password";
                    command.Connection = conn;

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = userName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;

                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("Log ON 成功");
                        Frm0_main f0 = new Frm0_main();
                        f0.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Log ON 失敗");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
