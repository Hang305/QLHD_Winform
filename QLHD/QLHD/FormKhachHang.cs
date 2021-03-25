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
    public partial class FormKhachHang : Form
    {
       
        Control_KhachHang KhachHang = new Control_KhachHang();
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridViewKhachHang.DataSource = KhachHang.select_KhachHang();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            KhachHang.update_KhachHang(txtMaKH.Text,txtHoTen.Text,txtTenCT.Text,txtMST.Text,txtDiaChi.Text);
            btnShow_Click(sender, e);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            KhachHang.update_KhachHang(txtMaKH.Text, txtHoTen.Text, txtTenCT.Text, txtMST.Text, txtDiaChi.Text);
            btnShow_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if ( check == DialogResult.Yes )
            {
                KhachHang.delete_KhachHang(txtMaKH.Text);
                btnShow_Click(sender, e);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtMST.Clear();
            txtTenCT.Clear();
            txtDiaChi.Clear();

            txtMaKH.Text = KhachHang.automatic_MaMax("KhachHang","MaKH");
            txtMaKH.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain frm = new FormMain();
            frm.ShowDialog();

        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dataGridViewKhachHang.Rows [ e.RowIndex ].Cells [ 0 ].Value.ToString();
            txtHoTen.Text = dataGridViewKhachHang.Rows [ e.RowIndex ].Cells [ 1 ].Value.ToString();
            txtMST.Text = dataGridViewKhachHang.Rows [ e.RowIndex ].Cells [ 2 ].Value.ToString();
            txtTenCT.Text = dataGridViewKhachHang.Rows [ e.RowIndex ].Cells [ 3 ].Value.ToString();
            txtDiaChi.Text = dataGridViewKhachHang.Rows [ e.RowIndex ].Cells [ 4 ].Value.ToString();

        }
    }
}
