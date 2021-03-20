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
    public partial class Form3CLass : Form
    {
        Control_HangHoa HangHoa = new Control_HangHoa();
        public Form3CLass()
        {
            InitializeComponent();
        }
        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain frm = new FormMain();
            frm.ShowDialog();
           
        }
        //Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaHH.Clear();
            txtTenHH.Clear();
            txtDVT.Clear();
            txtDonGia.Clear();

            txtMaHH.Focus();
        }
        
        //Show
        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridViewHangHoa.DataSource = HangHoa.select_HangHoa();
        }
        //Insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            HangHoa.insert_HangHoa(txtMaHH.Text, txtTenHH.Text, txtDVT.Text, float.Parse(txtDonGia.Text));
            btnShow_Click(sender, e);
        }
        //Delete 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if ( check == DialogResult.Yes )
            {
                HangHoa.delete_HangHoa(txtMaHH.Text);
                btnShow_Click(sender, e);
            }

        }

        private void dataGridViewHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHH.Text = dataGridViewHangHoa.Rows [ e.RowIndex ].Cells [ 0 ].Value.ToString();
            txtTenHH.Text = dataGridViewHangHoa.Rows [ e.RowIndex ].Cells [ 1 ].Value.ToString();
            txtDVT.Text = dataGridViewHangHoa.Rows [ e.RowIndex ].Cells [ 2 ].Value.ToString();
            txtDonGia.Text = dataGridViewHangHoa.Rows [ e.RowIndex ].Cells [ 3 ].Value.ToString();
        }
        //Update
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            HangHoa.update_HangHoa(txtMaHH.Text, txtTenHH.Text, txtDVT.Text, float.Parse(txtDonGia.Text));
            btnShow_Click(sender, e);
        }

    }
    
}
