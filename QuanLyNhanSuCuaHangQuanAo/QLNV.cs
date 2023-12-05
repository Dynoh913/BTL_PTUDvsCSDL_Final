using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSuCuaHangQuanAo
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = Database.Query("select * from NhanVien");
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mnv.ReadOnly = true;
            button2.Enabled = true;
            button3.Enabled = true;
            mnv.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            ten.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            ns.Value = Convert.ToDateTime(dgvNhanVien.CurrentRow.Cells[2].Value);
            sdt.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            dc.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            cv.SelectedIndex = cv.FindString(dgvNhanVien.CurrentRow.Cells[5].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mnv.ReadOnly = false;
            button2.Enabled = false;
            button3.Enabled = false;
            mnv.Text = "";
            ten.Text = "";
            ns.Value = Convert.ToDateTime("01/01/2000");
            sdt.Text = "";
            dc.Text = "";
            cv.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@MaNV", mnv.Text);
            Database.Execute("delete from NhanVien where MaNV=@MaNV", parameters);
            dgvNhanVien.DataSource = Database.Query("select * from NhanVien");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNV", mnv.Text);
                parameters.Add("@TenNV", ten.Text);
                parameters.Add("@NgaySinh", ns.Value);
                parameters.Add("@SoDT", sdt.Text);
                parameters.Add("@DiaChi", dc.Text);
                parameters.Add("@ChucVu", cv.Text);
                Database.Execute("insert into NhanVien values (@MaNV,@TenNV,@NgaySinh,@SoDT,@DiaChi,@ChucVu)", parameters);
                dgvNhanVien.DataSource = Database.Query("select * from NhanVien");
            }
            catch 
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNV", mnv.Text);
                parameters.Add("@TenNV", ten.Text);
                parameters.Add("@NgaySinh", ns.Value);
                parameters.Add("@SoDT", sdt.Text);
                parameters.Add("@DiaChi", dc.Text);
                parameters.Add("@ChucVu", cv.Text);
                Database.Execute("update NhanVien set TenNV=@TenNV,NgaySinh=@NgaySinh,SoDT=@SoDT,DiaChi=@DiaChi,ChucVu=@ChucVu where MaNV=@MaNV", parameters);
                dgvNhanVien.DataSource = Database.Query("select * from NhanVien");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string cmd = "select * from NhanVien where 1=1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (tkmanv.Checked == true) {
                parameters.Add("@MaNV", mnv.Text);
                cmd = cmd + " and MaNV=@MaNV";
            }
            if (tkten.Checked == true)
            {
                parameters.Add("@TenNV", ten.Text);
                cmd = cmd + " and TenNV like '%'+@TenNV+'%'";
            }
            if (tkns.Checked == true)
            {
                parameters.Add("@NgaySinh", ns.Value);
                cmd = cmd + " and NgaySinh=@NgaySinh";
            }
            if (tksdt.Checked == true)
            {
                parameters.Add("@SoDT", sdt.Text);
                cmd = cmd + " and SoDT=@SoDT";
            }
            if (tkdc.Checked == true)
            {
                parameters.Add("@DiaChi", dc.Text);
                cmd = cmd + " and DiaChi like '%'+@DiaChi+'%'";
            }
            if (tkcv.Checked == true)
            {
                parameters.Add("@ChucVu", cv.Text);
                cmd = cmd + " and ChucVu like '%'+ChucVu+'%'";
            }
            dgvNhanVien.DataSource = Database.Query(cmd, parameters);
        }
    }
}
