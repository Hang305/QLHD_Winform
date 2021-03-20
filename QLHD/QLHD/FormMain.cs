using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace QLHD
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
       
        //Hàng hóa
        private void ItemHangHoa_Click(object sender, EventArgs e)
        {
            Form3CLass Hanghoa = new Form3CLass();
            this.Hide();
            Hanghoa.ShowDialog();
        }
        //Nhân viên
        private void ItemNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien NhanVien = new FormNhanVien();
            this.Hide();
            NhanVien.ShowDialog();
        }
        //Hóa đơn
        private void ItemHoaDon_Click(object sender, EventArgs e)
        {
            formHD HoaDon = new formHD();
            this.Hide();
            HoaDon.ShowDialog();
        }
        //Công ty
        private void ItemCongTy_Click(object sender, EventArgs e)
        {
            FormCongTy CongTy = new FormCongTy();
            this.Hide();
            CongTy.ShowDialog();
        }
        //Khách hàng
        private void ItemKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang KhachHang = new FormKhachHang();
            this.Hide();
            KhachHang.ShowDialog();
        }
        //Thoát
        private void ItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
