using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_BLL;

namespace QLHD
{
    public partial class Login : Form
    {
        Control_Login TaiKhoan = new Control_Login();

        DataTable login;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ( txtUser.Text == "" || txtPassword.Text=="")
            {
                MessageBox.Show("Cần nhập đầy đủ tên đăng nhập và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                 login = TaiKhoan.login(txtUser.Text, txtPassword.Text);
                if ( login.Rows.Count == 0)
                {
                    MessageBox.Show("Sai tên tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                        Program.Quyen = login.Rows [ 0 ] [ 3 ].ToString();
                        Program.user = login.Rows [ 0 ] [ 0 ].ToString();
                        MessageBox.Show("Tài khoản "+Program.user.ToString().Trim()+" đã đăng nhập thành công vào hệ thống với vai trò "+Program
                            .Quyen.ToString().Trim(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        FormMain frm = new FormMain();
                        frm.ShowDialog();

                        this.Visible = false;
                        //this.Close();
                }
               
            }
        }
    }
}
