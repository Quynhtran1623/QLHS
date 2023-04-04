using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Diagnostics.Eventing.Reader;
using BussinessLayer;

namespace QUANLYHOCSINH
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        USERS _user;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            _user = new USERS();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int lg = _user.Login(txtUsername.Text, txtPass.Text);
            if (lg == 1)
            {
                Func.UsertStatic = _user.getItem(txtUsername.Text);
                MainForm main = (MainForm)Application.OpenForms["MainForm"];
                main.lblFullName.Caption = Func.UsertStatic.FullName;
                if (Func.handle != null)
                    SplashScreenManager.CloseOverlayForm(Func.handle);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void rdbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHienMK.Checked)
            {
                txtPass.Properties.PasswordChar = (char)0;
            }
            else
            {
                txtPass.Properties.PasswordChar = '*';
            }
        }
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.Select();
        }
        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }  
}



        

