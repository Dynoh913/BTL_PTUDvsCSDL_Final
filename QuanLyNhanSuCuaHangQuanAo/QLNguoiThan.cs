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
    public partial class QLNguoiThan : Form
    {
        public QLNguoiThan()
        {
            InitializeComponent();
            loadData();
            loadCbbNV();
        }
        private void loadData()
        {
            dgvNguoiThan.DataSource = Database.Query("select * from NguoiThan");
            cbTenNv.Text = "";
            txtMaNT.Text = "";
            txtTenNT.Text = "";
            txtNgheNghiep.Text = "";
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
                string query = "select * from NguoiThan where MaNV=@MaNV";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaNV", cbTenNv.SelectedValue.ToString());
                dgvNguoiThan.DataSource = Database.Query(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
