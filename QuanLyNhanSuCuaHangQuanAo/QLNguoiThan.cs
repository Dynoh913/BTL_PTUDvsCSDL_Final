using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        }
        string strCon = @"Data Source=DESKTOP-IH50D4M\SQLEXPRESS;Initial Catalog=QuanLyNhanSuCuaHangQuanAo;Integrated Security=True";
        SqlConnection sqlCon = null;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QLNguoiThan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuCuaHangQuanAoDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyNhanSuCuaHangQuanAoDataSet.NhanVien);
            LoadDatatoDataGridView();
        }
        private void LoadDatatoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();

                string query = "SELECT NguoiThan.MaNT, NguoiThan.TenNT, NguoiThan.MaNV, NhanVien.TenNV, NguoiThan.NgheNghiep, NguoiThan.NgaySinh FROM NguoiThan INNER JOIN NhanVien ON NguoiThan.MaNV = NhanVien.MaNV";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                datagridview_NT.DataSource = dataTable;

                //Hiển thị cột MaNV dưới dạng ComboBox
                DataGridViewComboBoxColumn comboBoxColum = new DataGridViewComboBoxColumn();
                comboBoxColum.HeaderText = "Nhân Viên";
                comboBoxColum.Name = "MaNV";
                comboBoxColum.DataSource = GetNhanVienList();
                comboBoxColum.DisplayMember = "TenNV";
                comboBoxColum.ValueMember = "MaNV";

                //datagridview_NT.Columns.Add(comboBoxColum);
            }
        }
        private DataTable GetNhanVienList()
        {
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();

                string query = "SELECT MaNV, TenNV FROM NhanVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string MaNT = textBox_maNT.Text.Trim();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select *from NguoiThan where MaNT = @MaNT ";

            // Định nghĩa
            SqlParameter parMaNT = new SqlParameter("@MaNT", SqlDbType.Int);
            parMaNT.Value = textBox_maNT.Text.Trim();
            sqlCmd.Parameters.Add(parMaNT);

            sqlCmd.Connection = sqlCon;

            // Thực thi
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                string TenNT = reader.GetString(1);
                int MaNV = reader.GetInt32(2);
                string NgheNghiep = reader.GetString(3);
                DateTime NgaySinh = reader.GetDateTime(4);

                // Hiển thị 
                textBox_tenNT.Text = TenNT;
                comboBox_maNV.Text = MaNV.ToString();
                textBox_nghenghiep.Text = NgheNghiep;
                dateTimePicker_ngaysinh.Text = NgaySinh.ToString();

            }

            // Đóng đầu đọc
            sqlCon.Close();
        }
   

        private void button_them_Click(object sender, EventArgs e)
        {
            string maNT = textBox_maNT.Text;
            string maNhanVien = comboBox_maNV.Text;
            string tenNguoiThan = textBox_tenNT.Text;
            string ngheNghiep = textBox_nghenghiep.Text;
            string ngaySinh = dateTimePicker_ngaysinh.Value.ToString("yyyy-MM-dd");

            if (!string.IsNullOrEmpty(maNhanVien) && !string.IsNullOrEmpty(tenNguoiThan) && !string.IsNullOrEmpty(ngheNghiep))
            {
                using (SqlConnection connection = new SqlConnection(strCon))
                {
                    connection.Open();

                    string query = "INSERT INTO NguoiThan (MaNT,TenNT, MaNV, NgheNghiep, NgaySinh)  VALUES (@MaNT, @TenNT, @MaNV, @NgheNghiep, @NgaySinh)  ";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNT", maNT);
                    command.Parameters.AddWithValue("@TenNT", tenNguoiThan);
                    command.Parameters.AddWithValue("@MaNV", maNhanVien);
                    command.Parameters.AddWithValue("@NgheNghiep", ngheNghiep);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm người thân thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm người thân không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin người thân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            string maNguoiThan = textBox_maNT.Text;
            string tenNguoiThan = textBox_tenNT.Text;
            string ngheNghiep = textBox_nghenghiep.Text;
            string ngaySinh = dateTimePicker_ngaysinh.Value.ToString("yyyy-MM-dd");

            if (!string.IsNullOrEmpty(maNguoiThan) && !string.IsNullOrEmpty(tenNguoiThan) && !string.IsNullOrEmpty(ngheNghiep))
            {
                using (SqlConnection connection = new SqlConnection(strCon))
                {
                    connection.Open();

                    string query = "UPDATE NguoiThan SET TenNT = @TenNT, NgheNghiep = @NgheNghiep, NgaySinh = @NgaySinh WHERE MaNT = @MaNT";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenNT", tenNguoiThan);
                    command.Parameters.AddWithValue("@NgheNghiep", ngheNghiep);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@MaNT", maNguoiThan);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa thông tin người thân thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin người thân không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin người thân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteNguoiThan(int maNguoiThan)
        {
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();

                string query = "DELETE FROM NguoiThan WHERE MaNT = @MaNT";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNT", maNguoiThan);

                command.ExecuteNonQuery();
            }
        }
        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (datagridview_NT.SelectedRows.Count > 0)
            {
                int selectedRowIndex = datagridview_NT.SelectedRows[0].Index;
                int maNguoiThan = Convert.ToInt32(datagridview_NT.Rows[selectedRowIndex].Cells["MaNT"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người thân này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteNguoiThan(maNguoiThan);
                    LoadDatatoDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một người thân để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMKN_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon); // Rỗng thì tạo mới
                }

                // Mở kết nối
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open(); // Đóng thì mở
                    MessageBox.Show("Kết nối thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDKN_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đóng kết nối thành công");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối");
            }
        }
    }
}
