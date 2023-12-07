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
            loadData();
        }
        private void loadData()
        {
            dgvNhanVien.DataSource = Database.Query("select * from NhanVien");
            txtMaNv.Text = "";
            txtDiaChi.Text = "";
            txtTenNv.Text = "";
            txtSdt.Text = "";
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[3].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[5].HeaderText = "Chức vụ";
            foreach (Control control in panelQLNV.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkBox.Checked = false;
                }
            }
        }
        private bool checkForm()
        {
            bool ketQua = true;
            erpBaoLoi.Clear();
            if (txtMaNv.Text == "")
            {
                erpBaoLoi.SetError(txtMaNv, "Chưa điền mã nhân viên.");
                ketQua = false;
            }
            if (txtTenNv.Text == "")
            {
                erpBaoLoi.SetError(txtTenNv, "Chưa điền họ tên.");
                ketQua = false;
            }
            if (txtDiaChi.Text == "")
            {
                erpBaoLoi.SetError(txtDiaChi, "Chưa điền địa chỉ.");
                ketQua = false;
            }
            if (txtSdt.Text == "")
            {
                erpBaoLoi.SetError(txtDiaChi, "Chưa điền số điện thoại.");
                ketQua = false;
            }
            if (cbCv.Text == "")
            {
                erpBaoLoi.SetError(cbCv, "Chưa chọn chức vụ.");
                ketQua = false;
            }
            return ketQua;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkForm())
                {
                    return;
                }
                string query = "insert into NhanVien(MaNV, TenNV, NgaySinh, SoDT, DiaChi, ChucVu) values (@MaNV, @TenNV, @NgaySinh, @SoDT, @DiaChi, @ChucVu)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNV", txtMaNv.Text);
                parameters.Add("@TenNV", txtTenNv.Text);
                parameters.Add("@NgaySinh", dtpNs.Value);
                parameters.Add("@SoDT", txtSdt.Text);
                parameters.Add("@DiaChi", txtDiaChi.Text);
                parameters.Add("@ChucVu", cbCv.Text);
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkForm())
                {
                    return;
                }
                string query = "update NhanVien set TenNV=@TenNV, NgaySinh=@NgaySinh, SoDT=@SoDT, DiaChi=@DiaChi, ChucVu=@ChucVu where MaNV=@MaNV";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNV", txtMaNv.Text);
                parameters.Add("@TenNV", txtTenNv.Text);
                parameters.Add("@NgaySinh", dtpNs.Value);
                parameters.Add("@SoDT", txtSdt.Text);
                parameters.Add("@DiaChi", txtDiaChi.Text);
                parameters.Add("@ChucVu", cbCv.Text);
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkForm())
                {
                    return;
                }
                string query = "exec XoaNhanVien @MaNV";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNV", txtMaNv.Text);
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtMaNv.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNv.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNs.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSdt.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbCv.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string cmd = "select * from NhanVien where 1=1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (chbMaNv.Checked == true)
            {
                cmd = cmd + " and MaNV=@MaNV";
                parameters.Add("@MaNV", txtMaNv.Text);
            }
            if (chbTenNv.Checked == true)
            {
                cmd = cmd + " and TenNV like '%'+@TenNV+'%'";
                parameters.Add("@TenNV", txtTenNv.Text);
            }
            if (chbNs.Checked == true)
            {
                cmd = cmd + " and NgaySinh=@NgaySinh";
                parameters.Add("@NgaySinh", dtpNs.Value);
            }
            if (chbSdt.Checked == true)
            {
                cmd = cmd + " and SoDT like '%'+@SoDT+'%'";
                parameters.Add("@SoDT", txtSdt.Text);
            }
            if (chbDiaChi.Checked == true)
            {
                cmd = cmd + " and DiaChi like '%'+@DiaChi+'%'";
                parameters.Add("@DiaChi", txtDiaChi.Text);
            }
            if (chbCv.Checked == true)
            {
                cmd = cmd + " and ChucVu=@ChucVu";
                parameters.Add("@ChucVu", cbCv.SelectedItem.ToString());
            }
            dgvNhanVien.DataSource = Database.Query(cmd, parameters);//
        }
    }
}
