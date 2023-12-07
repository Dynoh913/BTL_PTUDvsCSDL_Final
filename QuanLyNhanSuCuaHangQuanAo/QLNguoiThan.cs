using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSuCuaHangQuanAo
{
    public partial class QLNguoiThan : Form
    {
        public QLNguoiThan()
        {
            InitializeComponent();
            loadCbbNV();
            loadData();

        }
        private void loadData()
        {
            string query = "select MaNT,TenNT,TenNV,NgheNghiep,NguoiThan.NgaySinh from NguoiThan inner join NhanVien on NguoiThan.MaNV = NhanVien.MaNV where NguoiThan.MaNV=@MaNV";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@MaNV", cbTenNv.SelectedValue.ToString());
            dgvNguoiThan.DataSource = Database.Query(query, parameters);
            txtMaNT.Text = "";
            txtTenNT.Text = "";
            txtNgheNghiep.Text = "";

        }
        private bool checkForm()
        {
            bool ketQua = true;
            erpBaoLoi.Clear();
            if (cbTenNv.Text == "")
            {
                erpBaoLoi.SetError(cbTenNv, "Chưa chọn nhân viên.");
                ketQua = false;
            }
            if (txtTenNT.Text == "")
            {
                erpBaoLoi.SetError(txtTenNT, "Chưa điền họ tên.");
                ketQua = false;
            }
            if (txtNgheNghiep.Text == "")
            {
                erpBaoLoi.SetError(txtNgheNghiep, "Chưa điền nghề nghiệp.");
                ketQua = false;
            }
            return ketQua;
        }
        private void loadCbbNV()
        {
            cbTenNv.ValueMember = "MaNV";
            cbTenNv.DisplayMember = "TenNV";
            cbTenNv.DataSource = Database.Query("select * from NhanVien");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void cbTenNv_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string query = "select MaNT,TenNT,TenNV,NgheNghiep,NguoiThan.NgaySinh from NguoiThan inner join NhanVien on NguoiThan.MaNV = NhanVien.MaNV where NguoiThan.MaNV=@MaNV";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNV", cbTenNv.SelectedValue.ToString());
                dgvNguoiThan.DataSource = Database.Query(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkForm())
                {
                    return;
                }
                string query = "insert into NguoiThan (TenNT, MaNV, NgheNghiep, NgaySinh) values (@TenNT, @MaNV, @NgheNghiep, @NgaySinh)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNV", cbTenNv.SelectedValue.ToString());
                parameters.Add("@TenNT", txtTenNT.Text);
                parameters.Add("@NgheNghiep", txtNgheNghiep.Text);
                parameters.Add("@NgaySinh", dtpNs.Value);
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
                string query = "UPDATE NguoiThan SET TenNT = @TenNT, NgheNghiep = @NgheNghiep, NgaySinh = @NgaySinh WHERE MaNT = @MaNT";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNT", txtMaNT.Text);
                parameters.Add("@TenNT", txtTenNT.Text);
                parameters.Add("@NgheNghiep", txtNgheNghiep.Text);
                parameters.Add("@NgaySinh", dtpNs.Value);
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
                string query = "delete NguoiThan where MaNT = @MaNT";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNT", txtMaNT.Text);
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dgvNguoiThan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtMaNT.Text = dgvNguoiThan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNT.Text = dgvNguoiThan.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbTenNv.Text = dgvNguoiThan.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNgheNghiep.Text = dgvNguoiThan.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpNs.Text = dgvNguoiThan.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtMaNT.ReadOnly = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaNT.Clear();
            txtTenNT.Clear();
            dtpNs.Value = Convert.ToDateTime("01/01/2000");
            txtNgheNghiep.Clear();
            cbTenNv.SelectedIndex = -1;
            cbTenNv.Enabled = true;
        }


    }
}
