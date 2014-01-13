using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryManager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "用户名";
            btnOk.Text = "登录";
            lblWait.Visible = false;
            Form1 fm = this.Owner as Form1;
            fm.sv.authenticateCompleted += sv_authenticateCompleted;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form1 fm = this.Owner as Form1;
            fm.sv.authenticateAsync(txtUserName.Text, txtPassword.Text);
            fm.username = txtUserName.Text;
            lblWait.Visible = true;
            lblWait.Text = "正在登录，请稍候。。。";
            fm.sv.authenticateCompleted += sv_authenticateCompleted;
        }

        void sv_authenticateCompleted(object sender, authenticateCompletedEventArgs e)
        {
            Form1 fm = this.Owner as Form1;
            try{
            if (e.Result != null)
            {
                fm.isLoggedIn = true;
                
                lblWait.Text = "登录成功";
                this.btnOk.Enabled = false;
            }
            }
            catch(Exception exp)
            {
                fm.isLoggedIn = false;
                lblWait.Text = "登录失败，请重试";
                
            }
        }
    }
}
