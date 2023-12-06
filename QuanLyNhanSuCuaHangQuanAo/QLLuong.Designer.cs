namespace QuanLyNhanSuCuaHangQuanAo
{
    partial class QLLuong
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
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGiamDan = new System.Windows.Forms.Button();
            this.btnTangDan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.erpBaoLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpBaoLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Thống kê theo ngày";
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(200, 157);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(229, 32);
            this.txtNgay.TabIndex = 18;
            // 
            // txtTk
            // 
            this.txtTk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTk.Location = new System.Drawing.Point(1343, 320);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(245, 32);
            this.txtTk.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGiamDan);
            this.panel1.Controls.Add(this.btnTangDan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNgay);
            this.panel1.Controls.Add(this.txtTk);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.dgvLuong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1783, 953);
            this.panel1.TabIndex = 10;
            // 
            // btnGiamDan
            // 
            this.btnGiamDan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiamDan.Location = new System.Drawing.Point(484, 310);
            this.btnGiamDan.Name = "btnGiamDan";
            this.btnGiamDan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGiamDan.Size = new System.Drawing.Size(287, 54);
            this.btnGiamDan.TabIndex = 29;
            this.btnGiamDan.Text = "   Sắp xếp giảm dần";
            this.btnGiamDan.UseVisualStyleBackColor = true;
            this.btnGiamDan.Click += new System.EventHandler(this.btnGiamDan_Click);
            // 
            // btnTangDan
            // 
            this.btnTangDan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTangDan.Location = new System.Drawing.Point(191, 310);
            this.btnTangDan.Name = "btnTangDan";
            this.btnTangDan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTangDan.Size = new System.Drawing.Size(287, 54);
            this.btnTangDan.TabIndex = 28;
            this.btnTangDan.Text = "   Sắp xếp tăng dần";
            this.btnTangDan.UseVisualStyleBackColor = true;
            this.btnTangDan.Click += new System.EventHandler(this.btnTangDan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(14, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "(Nhập theo thứ tự: năm - tháng - ngày)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1339, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Thống kê theo năm";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(1525, 157);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(229, 32);
            this.txtNam.TabIndex = 23;
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Thống kê theo tháng";
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(900, 157);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(229, 32);
            this.txtThang.TabIndex = 23;
            this.txtThang.TextChanged += new System.EventHandler(this.txtThang_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyNhanSuCuaHangQuanAo.Properties.Resources.search;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1605, 310);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(150, 54);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "          Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = global::QuanLyNhanSuCuaHangQuanAo.Properties.Resources.description;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(12, 309);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(173, 54);
            this.btnThongKe.TabIndex = 11;
            this.btnThongKe.Text = "   Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dgvLuong
            // 
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLuong.Location = new System.Drawing.Point(0, 369);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.Size = new System.Drawing.Size(1783, 584);
            this.dgvLuong.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông tin lương";
            // 
            // erpBaoLoi
            // 
            this.erpBaoLoi.ContainerControl = this;
            // 
            // QLLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1783, 953);
            this.Controls.Add(this.panel1);
            this.Name = "QLLuong";
            this.Text = "Quản lý lương";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpBaoLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGiamDan;
        private System.Windows.Forms.Button btnTangDan;
        private System.Windows.Forms.ErrorProvider erpBaoLoi;
    }
}