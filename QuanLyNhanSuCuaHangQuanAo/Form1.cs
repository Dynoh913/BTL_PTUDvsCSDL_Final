using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace QuanLyNhanSuCuaHangQuanAo
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        public string Username;
        public string Password;
        private void button1_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection Conn = new SqlConnection(Database.getConn()))
            {
                Conn.Open();
                Username = txtUsername.Text;
                Password = txtPassword.Text;
                string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @Username AND MatKhau = @Password";
                using (SqlCommand cmd = new SqlCommand(query, Conn))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            FormMainMenu f = new FormMainMenu(txtUsername.Text, txtPassword.Text);
                            this.Hide();
                            f.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtUsername.Focus();

                        }
                    }
                }
            }




           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtUsername.Focus();

        }
    }
}
