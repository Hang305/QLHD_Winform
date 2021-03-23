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
    public partial class PrintHoaDon : Form
    {
        Control_CTHD CTHD = new Control_CTHD();
        public PrintHoaDon()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           CTHD.selectWhereSoHD_CTHD(formHD.MaHD.ToString());

            HoaDonBH rpt = new HoaDonBH();
            rpt.SetDataSource(CTHD.selectWhereSoHD_CTHD(formHD.MaHD.ToString()));
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
