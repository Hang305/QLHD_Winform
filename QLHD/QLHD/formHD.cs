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
using Control_BLL;


namespace QLHD
{
    public partial class formHD : Form
    {
        Control_NhanVien NhanVien = new Control_NhanVien();
        Control_KhachHang KhachHang = new Control_KhachHang();
        Control_HangHoa HangHoa = new Control_HangHoa();
        Control_HoaDon HoaDon = new Control_HoaDon();
        Control_CTHD cthd = new Control_CTHD();
        Control_CongTy CongTy = new Control_CongTy();

        public static string MaHD;
        public static double ThanhTien =0;
        public static double TongTien ;
       
        DataTable CTHD;
        //SqlCommand cmd;
        int cell, cell_CTHD;
        //double ThanhTien;
        public formHD()
        {
            InitializeComponent();
        }
        //formLoad
        private void formHD_Load(object sender, EventArgs e)
        {

            cbTenNV.DataSource = NhanVien.select_NhanVien();
            cbTenNV.DisplayMember = "Tên nhân viên";
            cbTenNV.ValueMember = "Mã nhân viên";

            cbTenKH.DataSource = KhachHang.select_KhachHang();
            cbTenKH.DisplayMember = "Họ tên";
            cbTenKH.ValueMember = "Mã khách hàng";

            cbHangHoa.DataSource = HangHoa.select_HangHoa();
            cbHangHoa.DisplayMember = "Tên hàng hóa";
            cbHangHoa.ValueMember = "Mã hàng hóa";


            cbTenCT.DataSource = CongTy.select_CongTy();
            cbTenCT.DisplayMember = "Tên công ty";
            cbTenCT.ValueMember = "Mã công ty";

            dataGridViewHD.DataSource = HoaDon.selectFind_HoaDon();

            CTHD = new DataTable();
            CTHD.Columns.Add("Mã hàng hóa", typeof(string));
            CTHD.Columns.Add("Tên hàng hóa", typeof(string));
            CTHD.Columns.Add("ĐVT", typeof(string));
            CTHD.Columns.Add("Đơn giá", typeof(double));
            CTHD.Columns.Add("Số lượng", typeof(int));
            CTHD.Columns.Add("Thành tiền", typeof(double));
            dataGridViewCTHD.DataSource = CTHD;
        }
        //Exit
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain frm = new FormMain();
            frm.Show();
        }

        private void dataGridViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CTHD.Clear();
            cell = dataGridViewHD.CurrentRow.Index;

            txtMaHD.Text = dataGridViewHD [ 1, cell ].Value.ToString();
            dateTimePickerNgayLap.Value = DateTime.Parse(dataGridViewHD [ 2, cell ].Value.ToString());
            cbTenNV.Text = dataGridViewHD [ 3, cell ].Value.ToString();
           
            dataGridViewCTHD.DataSource = cthd.selectFind_CTHD(txtMaHD.Text);

            CTHD = cthd.selectFind_CTHD(txtMaHD.Text);

        }
        //Insert CTHD
        private void btnInsertCTHD_Click(object sender, EventArgs e)
        {
            int i = 1;
            try
            {
                if ( txtSoLuong.Text == null )
                {
                    MessageBox.Show("Bạn phải nhập số lượng mới thêm hàng hóa vào được thực hiện được ", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach ( DataRow item in CTHD.Rows )
                    {
                        if ( item [ 0 ].ToString() == cbHangHoa.SelectedValue.ToString() )
                        {
                            int SL = int.Parse(txtSoLuong.Text) + int.Parse(item [ 4 ].ToString());
                            ThanhTien = SL * double.Parse(item [ 3 ].ToString());
                            item.Delete();
                            CTHD.Rows.Add(cbHangHoa.SelectedValue.ToString(), cbHangHoa.Text, txtDVT.Text, double.Parse(txtDonGia.Text), SL, ThanhTien);

                            dataGridViewCTHD.DataSource = CTHD;
                            TongTien += ThanhTien;
                           
                            break;
                        }
                        i++;
                    }
                    if ( i > CTHD.Rows.Count )
                    {
                        ThanhTien = int.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text);
                        CTHD.Rows.Add(cbHangHoa.SelectedValue.ToString(), cbHangHoa.Text, txtDVT.Text, double.Parse(txtDonGia.Text), int.Parse(txtSoLuong.Text), ThanhTien);
                        dataGridViewCTHD.DataSource = CTHD;
                        TongTien += ThanhTien;
                    }
                }
            }
            catch ( Exception )
            {

                MessageBox.Show("Lỗi trong quá trình thêm vào !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //Seleted Combobox HoaDon
        private void cbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable AddHangHoa =  HangHoa.selectWhere_HangHoa(cbHangHoa.SelectedValue.ToString());

            if ( AddHangHoa.Rows.Count > 0 )
            {
                txtDVT.Text = AddHangHoa.Rows [ 0 ] [ 2 ].ToString();
                txtDonGia.Text = AddHangHoa.Rows [ 0 ] [ 3 ].ToString();
            }
        }
        //Update CTHD
        private void btnUpdateCTHD_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = dataGridViewCTHD.Rows [ cell_CTHD ];
            newRow.Cells [ 0 ].Value = cbHangHoa.SelectedValue.ToString();
            newRow.Cells [ 1 ].Value = cbHangHoa.Text;
            newRow.Cells [ 2 ].Value = txtDVT.Text;
            newRow.Cells [ 3 ].Value = txtDonGia.Text;
            newRow.Cells [ 4 ].Value = txtSoLuong.Text;
            newRow.Cells [ 5 ].Value = double.Parse(txtDonGia.Text)*int.Parse(txtSoLuong.Text);

        }
        //Delete CTHD
        private void btnDeleteCTHD_Click(object sender, EventArgs e)
        {
            dataGridViewCTHD.Rows.RemoveAt(cell_CTHD);
        }
        //Refresh
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            formHD_Load(sender, e);
            dateTimePickerNgayLap.Value = DateTime.Parse(DateTime.Now.ToShortDateString());
            cbTenNV.SelectedIndex = 0;
            cbTenKH.SelectedIndex = 0;
            cbHangHoa.SelectedIndex = 0;
            txtSoLuong.Clear();
            txtDVT.Clear();
            txtDonGia.Clear();
            txtMaHD.Clear();

            txtMaHD.Text = HangHoa.automatic_MaMax("HoaDon","SoHD");
            txtMaHD.Enabled = false;
            dataGridViewCTHD = null;

            
        }
        //Save HoaDon_CTHD
        private void btnLuu_Click(object sender, EventArgs e)
        {
           HoaDon.insert_HoaDon(txtMaHD.Text, dateTimePickerNgayLap.Value,cbHinhThucTT.Text.ToString(), cbTenKH.SelectedValue.ToString(), cbTenNV.SelectedValue.ToString(), cbTenCT.SelectedValue.ToString());
            foreach ( DataRow item in CTHD.Rows )
            {
                    cthd.insert_CTHD(txtMaHD.Text, item [ 0 ].ToString(), int.Parse(item [ 4 ].ToString()));
            }
            //CTHD.Clear();
            formHD_Load(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dataGridViewCTHD.DataSource = cthd.delete_CTHD(txtMaHD.Text);
            HoaDon.update_HoaDon(txtMaHD.Text, DateTime.Parse(dateTimePickerNgayLap.Value.ToShortDateString()), cbHinhThucTT.Text.ToString(), cbTenKH.SelectedValue.ToString(), cbTenNV.SelectedValue.ToString(), cbTenCT.SelectedValue.ToString());

            CTHD.AcceptChanges();


            foreach ( DataRow item in CTHD.Rows )
            {
               cthd.insert_CTHD(txtMaHD.Text, item [ 0 ].ToString(), int.Parse(item [ 4 ].ToString()));
            }
           
            //CTHD.Clear();
            formHD_Load(sender, e);
            dataGridViewCTHD.DataSource = cthd.selectFind_CTHD(txtMaHD.Text);
        }

        //CellClick CTHD
        private void dataGridViewCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cell_CTHD = e.RowIndex;
            cbHangHoa.Text = dataGridViewCTHD [ 1, cell_CTHD ].Value.ToString();
            txtDVT.Text = dataGridViewCTHD [ 2, cell_CTHD ].Value.ToString();
            txtDonGia.Text = dataGridViewCTHD [ 3, cell_CTHD ].Value.ToString();
            txtSoLuong.Text = dataGridViewCTHD [4, cell_CTHD ].Value.ToString();
        }
        //Print HoaDon
        private void btnIn_Click(object sender, EventArgs e)
        {
            MaHD = dataGridViewHD [ 1, cell ].Value.ToString();
            PrintHoaDon printHD = new PrintHoaDon();

            foreach ( DataRow item in CTHD.Rows )
            {
                TongTien += double.Parse(item [ 5 ].ToString());
               
            }
            if ( CTHD.Rows.Count <0 )
            {
                TongTien += TongTien;
            }
            //MessageBox.Show(TongTien.ToString());
            printHD.Show();
        }

       

        //Delete HoaDon
        private void btnXoa_Click(object sender, EventArgs e)
        {
            dataGridViewCTHD.DataSource = cthd.delete_CTHD(txtMaHD.Text);

            dataGridViewHD.DataSource = HoaDon.delete_HoaDon(txtMaHD.Text);

            formHD_Load(sender, e);
        }

        
    }
}
