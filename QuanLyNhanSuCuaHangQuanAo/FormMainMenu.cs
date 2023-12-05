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
    public partial class FormMainMenu : Form
    {
        private Button currentBtn;
        private Form activeForm;
        public FormMainMenu()
        {
            InitializeComponent();
            btnClose.Visible = false;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }


        private string TaiKhoanF1;
        private string MatKhauF1;
        public FormMainMenu(string tk,string mk) : this() 
        {
               TaiKhoanF1 = tk;
                MatKhauF1 = mk;
        }


        private void activeBtn(object btnSender, Form f, Color color)
        {
            if (btnSender != null)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                if (currentBtn != (Button)btnSender) 
                {
                    disableBtn();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = color;
                    currentBtn.Font = new System.Drawing.Font("Calibri", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    btnClose.Visible = true;
                }
                activeForm = f;
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                this.panelMain.Controls.Add(f);
                this.panelMain.Tag = f;
                f.BringToFront();
                f.Show();
                labelTitle.Text = f.Text.ToUpper();
            }
        }

        private void showControl(Control ctrl)
        {
            panelMain.Controls.Clear();
            ctrl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ctrl);
        }
        private void disableBtn()
        {
            foreach (Control btn in panelMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(110, 194, 247);
                    btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void btnQLNV_Click(object sender, EventArgs e)
        {
            activeBtn(sender, new QLNV(), Color.FromArgb(238, 229, 222));
        }
        private void btnQLL_Click(object sender, EventArgs e)
        {
            activeBtn(sender, new QLLuong(), Color.FromArgb(244, 164, 96));
        }


        private void btnDMK_Click(object sender, EventArgs e)
        {
            activeBtn(sender, new DoiMatKhau(), Color.FromArgb(240, 255, 240));

            fDoiMatKhau Child = new fDoiMatKhau(TaiKhoanF1, MatKhauF1);
            showControl(Child);
   

        }

        private void btnQLCC_Click(object sender, EventArgs e)
        {
            activeBtn(sender, new QLChamCong(), Color.FromArgb(238, 232, 170));
        }
        private void btnQLNT_Click(object sender, EventArgs e)
        {
            activeBtn(sender, new QLNguoiThan(), Color.FromArgb(60, 179, 113));
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            this.Hide();
            f.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            disableBtn();
            labelTitle.Text = "TRANG CHỦ";
            panelTitle.BackColor = Color.FromArgb(39, 164, 242);
            currentBtn = null;
            btnClose.Visible = false;
        }

    }
}
