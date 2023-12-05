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


namespace QuanLyNhanSuCuaHangQuanAo
{
    public partial class DoiMatKhau : Form
    {

        public DoiMatKhau()
        {
            InitializeComponent();
        }
        private string tkc;
        private string mkc;
        public DoiMatKhau(string tk,string mk) : this()
        {
            tkc = tk;
            mkc = mk;
            txtUsername2.Text = tkc;

        }
       

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == mkc)
            {

                if (txtNewPass1.Text.Length <= 0)
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo");
                    txtNewPass1.Focus();
                }
                if (txtUsername2.Text.Length <= 0)
                {
                    MessageBox.Show("Mời nhập lại mật khẩu mới", "Thông báo");
                    txtNewPass2.Focus();
                }

                if (txtNewPass1.Text == txtNewPass2.Text)
                {
                    using (SqlConnection Conn = new SqlConnection(Database.getConn()))
                    {
                        Conn.Open();
                        string query = "UPDATE TaiKhoan SET MatKhau = @NewMK Where TenDangNhap = '" + tkc + "' AND MatKhau = '" + mkc + "' ";
                        using (SqlCommand cmd = new SqlCommand(query, Conn))
                        {
                            cmd.Parameters.AddWithValue("@NewMK", txtNewPass1.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu chưa trùng khớp! Mời nhập lại", "Thông báo");
                    txtNewPass1.Clear();
                    txtNewPass2.Clear();
                    txtNewPass1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo");
                txtOldPass.Clear();
                txtNewPass1.Clear();
                txtNewPass2.Clear();
                txtOldPass.Focus();
            }

        }

      

    }
}
