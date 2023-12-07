using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSuCuaHangQuanAo
{
    public partial class QLLuong : Form
    {
        public QLLuong()
        {
            InitializeComponent();
        }
        private bool checkForm()
        {
            bool ketQua = true;
            erpBaoLoi.Clear();
            if (txtThang.Text != "" && int.Parse(txtThang.Text) > 12)
            {
                erpBaoLoi.SetError(txtThang, "Chỉ được nhập tháng từ 1 tới 12.");
                ketQua = false;
            }
            if (txtNgay.Text != "" && int.Parse(txtNgay.Text) > 31)
            {
                erpBaoLoi.SetError(txtNgay, "Chỉ được nhập ngày từ 1 tới 31.");
                ketQua = false;
            }
            return ketQua;
        } 
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNam.Text = "";
            txtThang.Text = "";
            txtNgay.Text = "";
        }
        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            if (txtNam.Text != "") txtThang.Enabled = true;
            else txtThang.Enabled = false;
        }
        private void txtThang_TextChanged(object sender, EventArgs e)
        {
            if (txtThang.Text != "") txtNgay.Enabled = true;
            else txtNgay.Enabled = false;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkForm())
                {
                    return;
                }
                if (txtNam.Text != "" && txtThang.Text != "" && txtNgay.Text != "")
                {
                    string ngayDiLam = txtThang.Text + "/" + txtNgay.Text + "/" + txtNam.Text;
                    string query = "select * from TinhLuongTheoNgay(@ngayDiLam)";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@ngayDiLam", ngayDiLam);
                    dgvLuong.DataSource = Database.Query(query, parameters);
                }
                else if (txtNam.Text != "" && txtThang.Text != "")
                {
                    string query = "select * from TinhLuongTheoThang(@Thang,@Nam)";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@Thang", txtThang.Text);
                    parameters.Add("@Nam", txtNam.Text);
                    dgvLuong.DataSource = Database.Query(query, parameters);
                }
                else if (txtNam.Text != "")
                {
                    string query = "select * from TinhLuongTheoNam(@Nam)";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@Nam", txtNam.Text);
                    dgvLuong.DataSource = Database.Query(query, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnTangDan_Click(object sender, EventArgs e)
        {
            int lastColumnIndex = dgvLuong.Columns.Count - 1;
            if (lastColumnIndex >= 0)
            {
                dgvLuong.Sort(dgvLuong.Columns[lastColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
            }
        }
        private void btnGiamDan_Click(object sender, EventArgs e)
        {
            int lastColumnIndex = dgvLuong.Columns.Count - 1;
            if (lastColumnIndex >= 0)
            {
                dgvLuong.Sort(dgvLuong.Columns[lastColumnIndex], System.ComponentModel.ListSortDirection.Descending);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkForm())
                {
                    return;
                }
                if (txtNam.Text != "" && txtThang.Text != "" && txtNgay.Text != "")
                {
                    string ngayDiLam = txtThang.Text + "/" + txtNgay.Text + "/" + txtNam.Text;
                    string query = "select * from TinhLuongTheoNgay(@ngayDiLam) where TenNV like '%'+@TenNV+'%'";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@ngayDiLam", ngayDiLam);
                    parameters.Add("@TenNV", txtTk.Text);
                    dgvLuong.DataSource = Database.Query(query, parameters);
                }
                else if (txtNam.Text != "" && txtThang.Text != "")
                {
                    string query = "select * from TinhLuongTheoThang(@Thang,@Nam) where TenNV like '%'+@TenNV+'%'";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@Thang", txtThang.Text);
                    parameters.Add("@Nam", txtNam.Text);
                    parameters.Add("@TenNV", txtTk.Text);
                    dgvLuong.DataSource = Database.Query(query, parameters);
                }
                else if (txtNam.Text != "")
                {
                    string query = "select * from TinhLuongTheoNam(@Nam) where TenNV like '%'+@TenNV+'%'";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@Nam", txtNam.Text);
                    parameters.Add("@TenNV", txtTk.Text);
                    dgvLuong.DataSource = Database.Query(query, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
