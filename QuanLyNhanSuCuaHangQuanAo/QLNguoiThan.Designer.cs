namespace QuanLyNhanSuCuaHangQuanAo
{
    partial class QLNguoiThan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.datagridview_NT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDKN = new System.Windows.Forms.Button();
            this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMKN = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboBox_maNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhanSuCuaHangQuanAoDataSet = new QuanLyNhanSuCuaHangQuanAo.QuanLyNhanSuCuaHangQuanAoDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_tenNT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_maNT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nghenghiep = new System.Windows.Forms.TextBox();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.nhanVienTableAdapter = new QuanLyNhanSuCuaHangQuanAo.QuanLyNhanSuCuaHangQuanAoDataSetTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_NT)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuCuaHangQuanAoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã nhân viên";
            // 
            // datagridview_NT
            // 
            this.datagridview_NT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_NT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridview_NT.Location = new System.Drawing.Point(0, 369);
            this.datagridview_NT.Name = "datagridview_NT";
            this.datagridview_NT.RowHeadersWidth = 51;
            this.datagridview_NT.RowTemplate.Height = 24;
            this.datagridview_NT.Size = new System.Drawing.Size(1783, 584);
            this.datagridview_NT.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông tin người thân";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDKN);
            this.panel1.Controls.Add(this.dateTimePicker_ngaysinh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnMKN);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.comboBox_maNV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_tenNT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_maNT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_nghenghiep);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button_xoa);
            this.panel1.Controls.Add(this.button_sua);
            this.panel1.Controls.Add(this.button_them);
            this.panel1.Controls.Add(this.datagridview_NT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1783, 953);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDKN
            // 
            this.btnDKN.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDKN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDKN.Location = new System.Drawing.Point(155, 309);
            this.btnDKN.Name = "btnDKN";
            this.btnDKN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDKN.Size = new System.Drawing.Size(127, 55);
            this.btnDKN.TabIndex = 55;
            this.btnDKN.Text = "Đóng Kết Nối";
            this.btnDKN.UseVisualStyleBackColor = true;
            this.btnDKN.Click += new System.EventHandler(this.btnDKN_Click);
            // 
            // dateTimePicker_ngaysinh
            // 
            this.dateTimePicker_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(987, 123);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(176, 28);
            this.dateTimePicker_ngaysinh.TabIndex = 54;
            this.dateTimePicker_ngaysinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(889, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ngày Sinh";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(726, 310);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(140, 54);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Tìm Kiếm";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMKN
            // 
            this.btnMKN.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMKN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMKN.Location = new System.Drawing.Point(24, 309);
            this.btnMKN.Name = "btnMKN";
            this.btnMKN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMKN.Size = new System.Drawing.Size(127, 55);
            this.btnMKN.TabIndex = 51;
            this.btnMKN.Text = "Mở Kết Nối";
            this.btnMKN.UseVisualStyleBackColor = true;
            this.btnMKN.Click += new System.EventHandler(this.btnMKN_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Window;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = global::QuanLyNhanSuCuaHangQuanAo.Properties.Resources.reset11;
            this.btnReset.Location = new System.Drawing.Point(284, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(47, 43);
            this.btnReset.TabIndex = 50;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // comboBox_maNV
            // 
            this.comboBox_maNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nhanVienBindingSource, "MaNV", true));
            this.comboBox_maNV.DataSource = this.nhanVienBindingSource;
            this.comboBox_maNV.DisplayMember = "MaNV";
            this.comboBox_maNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_maNV.FormattingEnabled = true;
            this.comboBox_maNV.Location = new System.Drawing.Point(165, 124);
            this.comboBox_maNV.Name = "comboBox_maNV";
            this.comboBox_maNV.Size = new System.Drawing.Size(229, 32);
            this.comboBox_maNV.TabIndex = 49;
            this.comboBox_maNV.ValueMember = "MaNV";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyNhanSuCuaHangQuanAoDataSet;
            // 
            // quanLyNhanSuCuaHangQuanAoDataSet
            // 
            this.quanLyNhanSuCuaHangQuanAoDataSet.DataSetName = "QuanLyNhanSuCuaHangQuanAoDataSet";
            this.quanLyNhanSuCuaHangQuanAoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tên người thân";
            // 
            // textBox_tenNT
            // 
            this.textBox_tenNT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenNT.Location = new System.Drawing.Point(165, 201);
            this.textBox_tenNT.Name = "textBox_tenNT";
            this.textBox_tenNT.Size = new System.Drawing.Size(229, 32);
            this.textBox_tenNT.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã người thân";
            // 
            // textBox_maNT
            // 
            this.textBox_maNT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maNT.Location = new System.Drawing.Point(599, 124);
            this.textBox_maNT.Name = "textBox_maNT";
            this.textBox_maNT.Size = new System.Drawing.Size(229, 32);
            this.textBox_maNT.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nghề nghiệp";
            // 
            // textBox_nghenghiep
            // 
            this.textBox_nghenghiep.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nghenghiep.Location = new System.Drawing.Point(600, 201);
            this.textBox_nghenghiep.Name = "textBox_nghenghiep";
            this.textBox_nghenghiep.Size = new System.Drawing.Size(229, 32);
            this.textBox_nghenghiep.TabIndex = 41;
            // 
            // button_xoa
            // 
            this.button_xoa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Image = global::QuanLyNhanSuCuaHangQuanAo.Properties.Resources.bin1;
            this.button_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xoa.Location = new System.Drawing.Point(580, 309);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_xoa.Size = new System.Drawing.Size(140, 54);
            this.button_xoa.TabIndex = 15;
            this.button_xoa.Text = "   Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Image = global::QuanLyNhanSuCuaHangQuanAo.Properties.Resources.tool;
            this.button_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sua.Location = new System.Drawing.Point(434, 309);
            this.button_sua.Name = "button_sua";
            this.button_sua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_sua.Size = new System.Drawing.Size(140, 54);
            this.button_sua.TabIndex = 14;
            this.button_sua.Text = "   Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_them
            // 
            this.button_them.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Image = global::QuanLyNhanSuCuaHangQuanAo.Properties.Resources.plus;
            this.button_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_them.Location = new System.Drawing.Point(288, 309);
            this.button_them.Name = "button_them";
            this.button_them.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_them.Size = new System.Drawing.Size(140, 54);
            this.button_them.TabIndex = 11;
            this.button_them.Text = "   Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // QLNguoiThan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1783, 953);
            this.Controls.Add(this.panel1);
            this.Name = "QLNguoiThan";
            this.Text = "Quản lý người thân";
            this.Load += new System.EventHandler(this.QLNguoiThan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_NT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuCuaHangQuanAoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.DataGridView datagridview_NT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nghenghiep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_tenNT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_maNT;
        private System.Windows.Forms.ComboBox comboBox_maNV;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMKN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
        private System.Windows.Forms.Button btnDKN;
        private QuanLyNhanSuCuaHangQuanAoDataSet quanLyNhanSuCuaHangQuanAoDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyNhanSuCuaHangQuanAoDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}