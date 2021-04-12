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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace QLHD
{
    public partial class PrintHoaDon : Form
    {
        Control_CTHD CTHD = new Control_CTHD();
        long total;
        public PrintHoaDon()
        {
            InitializeComponent();

         
          
            
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           CTHD.selectWhereSoHD_CTHD(formHD.MaHD.ToString());

            HoaDonBH rpt = new HoaDonBH();
            
            TextObject convertNumberToText = ( TextObject )rpt.Section4.ReportObjects [ "convertNumToText" ];
            total = long.Parse(formHD.TongTien.ToString());
            MessageBox.Show(formHD.TongTien.ToString());
            convertNumberToText.Text = ConvertNumberToText.docso(total);
            //convertNumberToText.Text = ConvertNumberToText.motso(total.ToString());
            rpt.SetDataSource(CTHD.selectWhereSoHD_CTHD(formHD.MaHD.ToString()));
            crystalReportViewer1.ReportSource = rpt;
        }
        
        private void PrintHoaDon_Load(object sender, EventArgs e)
        {
            total = long.Parse(formHD.TongTien.ToString());
        }
    }
}
