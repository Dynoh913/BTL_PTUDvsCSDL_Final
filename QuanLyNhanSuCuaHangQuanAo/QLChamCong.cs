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
    public partial class QLChamCong : Form
    {
        public QLChamCong()
        {
            InitializeComponent();
            LoadEmployeeNames();
        }

        private void LoadEmployeeNames()
        {
            string query = "SELECT TenNV FROM NhanVien";
            var table = Database.Query(query);

            foreach (DataRow row in table.Rows)
            {
                string tennv = row["TenNV"].ToString();
                comboBox1.Items.Add(tennv);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> paramNV = new Dictionary<string, object>();
                paramNV.Add("@TenNV", comboBox1.Text);
                var maNVTable = Database.Query("SELECT MaNV FROM NhanVien WHERE TenNV = @TenNV", paramNV);
                if (maNVTable.Rows.Count > 0)
                {
                    string maNV = maNVTable.Rows[0]["MaNV"].ToString();
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@MaNV", maNV);
                    parameters.Add("@NgayDiLam", dateTimePicker1.Value);
                    parameters.Add("@SoGioLam", txtGioLam.Text);
                    Database.Execute("INSERT INTO ChamCong (MaNV, NgayDiLam, SoGioLam) VALUES (@MaNV, @NgayDiLam, @SoGioLam)", parameters);
                    dgvChamCong.DataSource = Database.Query("SELECT TenNV, NgayDilam, SoGioLam FROM NhanVien INNER JOIN ChamCong ON NhanVien.MaNV = ChamCong.MaNV");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }


        private void QLChamCong_Load(object sender, EventArgs e)
        {
            dgvChamCong.DataSource = Database.Query("select TenNV, NgayDilam, SoGioLam\r\nfrom NhanVien\r\ninner join ChamCong on NhanVien.MaNV = ChamCong.MaNV");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@TenNV", comboBox1.Text);
                parameters.Add("@NgayDiLam", dateTimePicker1.Value);
                parameters.Add("@SoGioLam", txtGioLam.Text);

                var maNVTable = Database.Query("SELECT MaNV FROM NhanVien WHERE TenNV = @TenNV", parameters);
                if (maNVTable.Rows.Count > 0)
                {
                    string maNV = maNVTable.Rows[0]["MaNV"].ToString();
                    parameters.Add("@MaNV", maNV);
                    Database.Execute("UPDATE ChamCong SET NgayDiLam = @NgayDiLam, SoGioLam = @SoGioLam WHERE MaNV = @MaNV AND NgayDiLam = @NgayDiLam", parameters);
                    RefreshDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void RefreshDataGridView()
        {
            dgvChamCong.DataSource = Database.Query("SELECT TenNV, NgayDiLam, SoGioLam FROM NhanVien INNER JOIN ChamCong ON NhanVien.MaNV = ChamCong.MaNV");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            var maNVTable = Database.Query("SELECT MaNV FROM NhanVien WHERE TenNV = @TenNV", parameters);
            if (maNVTable.Rows.Count > 0)
            {
                string maNV = maNVTable.Rows[0]["MaNV"].ToString();
                parameters.Add("@MaNV", maNV);
                parameters.Add("@NgayDiLam", dateTimePicker1.Value);
                Database.Execute("DELETE FROM ChamCong WHERE MaNV = @MaNV AND NgayDiLam = @NgayDiLam", parameters);
            }
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string cmd = "select TenNV, NgayDilam, SoGioLam\r\nfrom NhanVien\r\ninner join ChamCong on NhanVien.MaNV = ChamCong.MaNV";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (tkten.Checked == true)
            {
                parameters.Add("@TenNV", comboBox1.Text);
                cmd = cmd + " and TenNV like '%'+@TenNV+'%'";
            }
            if (tknl.Checked == true)
            {
                parameters.Add("@NgayDiLam", dateTimePicker1.Value);
                cmd = cmd + " and NgayDiLam = @NgayDiLam";
            }
            if (tkgl.Checked == true)
            {
                parameters.Add("@SoGioLam", txtGioLam.Text);
                cmd = cmd + " and SoGioLam=@SoGioLam";
            }
            dgvChamCong.DataSource = Database.Query(cmd, parameters);
        }

        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            comboBox1.Text = dgvChamCong.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvChamCong.CurrentRow.Cells[1].Value);
            txtGioLam.Text = dgvChamCong.CurrentRow.Cells[2].Value.ToString();
        }


    }
}
