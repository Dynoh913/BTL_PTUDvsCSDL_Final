namespace QuanLyNhanSuCuaHangQuanAo
{
    partial class QLChamCong
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tknl = new System.Windows.Forms.CheckBox();
            this.tkgl = new System.Windows.Forms.CheckBox();
            this.tkten = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSogiolam = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên nhân viên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(1014, 320);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(245, 32);
            this.txtTimKiem.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tknl);
            this.panel1.Controls.Add(this.tkgl);
            this.panel1.Controls.Add(this.tkten);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSogiolam);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.dgvChamCong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1611, 840);
            this.panel1.TabIndex = 11;
            // 
            // tknl
            // 
            this.tknl.AutoSize = true;
            this.tknl.Location = new System.Drawing.Point(673, 201);
            this.tknl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tknl.Name = "tknl";
            this.tknl.Size = new System.Drawing.Size(185, 20);
            this.tknl.TabIndex = 35;
            this.tknl.Text = "Tìm kiếm theo ngày đi làm";
            this.tknl.UseVisualStyleBackColor = true;
            // 
            // tkgl
            // 
            this.tkgl.AutoSize = true;
            this.tkgl.Location = new System.Drawing.Point(1245, 201);
            this.tkgl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tkgl.Name = "tkgl";
            this.tkgl.Size = new System.Drawing.Size(160, 20);
            this.tkgl.TabIndex = 34;
            this.tkgl.Text = "Tìm kiếm theo giờ làm";
            this.tkgl.UseVisualStyleBackColor = true;
            // 
            // tkten
            // 
            this.tkten.AutoSize = true;
            this.tkten.Location = new System.Drawing.Point(142, 201);
            this.tkten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tkten.Name = "tkten";
            this.tkten.Size = new System.Drawing.Size(134, 20);
            this.tkten.TabIndex = 33;
            this.tkten.Text = "Tìm kiếm theo tên";
            this.tkten.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 32);
            this.comboBox1.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(673, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 32);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày đi làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1106, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số giờ làm";
            // 
            // txtSogiolam
            // 
            this.txtSogiolam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSogiolam.Location = new System.Drawing.Point(1245, 154);
            this.txtSogiolam.Name = "txtSogiolam";
            this.txtSogiolam.Size = new System.Drawing.Size(231, 32);
            this.txtSogiolam.TabIndex = 16;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyNhanSuCuaHangQuanAo.Properties.Resources.bin1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(304, 309);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(140, 54);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyNhanSuCuaHangQuanAo.Properties.Resources.tool;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(158, 308);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(140, 54);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "   Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyNhanSuCuaHangQuanAo.Properties.Resources.search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1325, 295);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(150, 54);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "          Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyNhanSuCuaHangQuanAo.Properties.Resources.plus;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(12, 309);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(140, 54);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChamCong.Location = new System.Drawing.Point(0, 256);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(1611, 584);
            this.dgvChamCong.TabIndex = 10;
            this.dgvChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông tin chấm công";
            // 
            // QLChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1611, 840);
            this.Controls.Add(this.panel1);
            this.Name = "QLChamCong";
            this.Text = "Quản lý chấm công";
            this.Load += new System.EventHandler(this.QLChamCong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSogiolam;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox tknl;
        private System.Windows.Forms.CheckBox tkgl;
        private System.Windows.Forms.CheckBox tkten;

    }
}

