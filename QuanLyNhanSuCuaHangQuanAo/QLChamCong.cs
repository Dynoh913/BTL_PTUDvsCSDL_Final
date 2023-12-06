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
    public partial class QLChamCong : Form
    {
        private String maChamCong = "";
        public QLChamCong()
        {
            InitializeComponent();
            loadCbbNV();
            loadData();
        }
        private void loadData()
        {
            dgvChamCong.DataSource = Database.Query("select MaChamCong,TenNV,NgayDiLam,SoGioLam from ChamCong inner join NhanVien on ChamCong.MaNV = NhanVien.MaNV");
            txtSogiolam.Text = "";
            txtTimKiem.Text = "";
            maChamCong = "";
        }
        private void loadCbbNV()
        {
            cbTenNv.ValueMember = "MaNV";
            cbTenNv.DisplayMember = "TenNV";
            cbTenNv.DataSource = Database.Query("select * from NhanVien");
        }

        private void cbTenNv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "select MaChamCong,TenNV,NgayDiLam,SoGioLam from ChamCong inner join NhanVien on ChamCong.MaNV = NhanVien.MaNV where ChamCong.MaNV=@MaNV";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNV", cbTenNv.SelectedValue.ToString());
                dgvChamCong.DataSource = Database.Query(query, parameters);
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
                string query = "insert ChamCong(MaNV,NgayDiLam,SoGioLam) values (@MaNV,@NgayDiLam,@SoGioLam)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNV", cbTenNv.SelectedValue.ToString());
                parameters.Add("@NgayDiLam", dtpNgayLam.Value);
                parameters.Add("@SoGioLam", txtSogiolam.Text);
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
                string query = "update ChamCong set NgayDiLam=@NgayDiLam,SoGioLam=@SoGioLam where MaChamCong=@MaChamCong";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaChamCong", maChamCong);
                parameters.Add("@NgayDiLam", dtpNgayLam.Value);
                parameters.Add("@SoGioLam", txtSogiolam.Text);
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
                string query = "delete ChamCong where MaChamCong=@MaChamCong";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaChamCong", maChamCong);
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                maChamCong = dgvChamCong.Rows[e.RowIndex].Cells[0].Value.ToString();
                //cbTenNv.Text = dgvChamCong.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgayLam.Text = dgvChamCong.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSogiolam.Text = dgvChamCong.Rows[e.RowIndex].Cells[3].Value.ToString();
            }

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "select MaChamCong,TenNV,NgayDiLam,SoGioLam from ChamCong inner join NhanVien on ChamCong.MaNV = NhanVien.MaNV where 1=1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (txtTimKiem.Text != "")
            {
                query += " and TenNV like '%'+@TenNV+'%'";
                parameters.Add("@TenNV", txtTimKiem.Text);
            }
            else
            {
                query += " and NgayDiLam=@NgayDiLam";
                parameters.Add("@NgayDiLam", dtpNgayLam.Value);
            }
            dgvChamCong.DataSource = Database.Query(query, parameters);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbTenNv.Text = "";
            loadData();
        }
    }
}
