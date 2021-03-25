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
    public partial class FormCongTy : Form
    {
        Control_CongTy CongTy = new Control_CongTy();
        public FormCongTy()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridViewCongTy.DataSource = CongTy.select_CongTy();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewCongTy.DataSource = CongTy.update_CongTy(txtMaCT.Text, txtTenCT.Text, txtDiaChi.Text, int.Parse(txtSDT.Text), int.Parse(txtFax.Text), int.Parse(txtMST.Text));
            btnShow_Click(sender, e);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataGridViewCongTy.DataSource = CongTy.insert_CongTy(txtMaCT.Text, txtTenCT.Text, txtDiaChi.Text, int.Parse(txtSDT.Text), int.Parse(txtFax.Text), int.Parse(txtMST.Text));
            btnShow_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridViewCongTy.DataSource = CongTy.delete_CongTy(txtMaCT.Text);
            btnShow_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaCT.Clear();
            txtTenCT.Clear();
            txtDiaChi.Clear();
          txtSDT.Clear();
            txtFax.Clear();
            txtMST.Clear();

            txtMaCT.Text = CongTy.automatic_MaMax("CongTy", "MaCty");
            txtMaCT.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain frm = new FormMain();
            frm.ShowDialog();
        }

        private void dataGridViewCongTy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCT.Text = dataGridViewCongTy.Rows [ e.RowIndex ].Cells [ 0 ].Value.ToString();
            txtTenCT.Text = dataGridViewCongTy.Rows [ e.RowIndex ].Cells [ 1 ].Value.ToString();
            txtDiaChi.Text = dataGridViewCongTy.Rows [ e.RowIndex ].Cells [ 2 ].Value.ToString();
            txtSDT.Text = dataGridViewCongTy.Rows [ e.RowIndex ].Cells [ 3 ].Value.ToString();
            txtFax.Text = dataGridViewCongTy.Rows [ e.RowIndex ].Cells [ 4 ].Value.ToString();
            txtMST.Text = dataGridViewCongTy.Rows [ e.RowIndex ].Cells [ 5 ].Value.ToString();
        }
    }
}
