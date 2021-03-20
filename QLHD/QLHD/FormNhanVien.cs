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
    public partial class FormNhanVien : Form
    {
        Control_NhanVien NhanVien = new Control_NhanVien();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridViewNhanVien.DataSource = NhanVien.select_NhanVien();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NhanVien.update_NhanVien(txtMaNV.Text, txtTenNV.Text);
             btnShow_Click(sender, e);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            NhanVien.insert_NhanVien(txtMaNV.Text, txtTenNV.Text);
            btnShow_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if ( check == DialogResult.Yes )
            {
                NhanVien.delete_NhanVien(txtMaNV.Text);
                btnShow_Click(sender, e);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();

            txtMaNV.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain frm = new FormMain();
            frm.ShowDialog();
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dataGridViewNhanVien.Rows [ e.RowIndex ].Cells [ 0 ].Value.ToString();
            txtTenNV.Text = dataGridViewNhanVien.Rows [ e.RowIndex ].Cells [ 1 ].Value.ToString();
        }
    }
}
