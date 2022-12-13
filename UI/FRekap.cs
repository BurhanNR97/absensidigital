using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Absensi_Mahasiswa.UI
{
    public partial class FRekap : Form
    {
        db_rekap.DataTable1DataTable data           = new db_rekap.DataTable1DataTable();        
        
        ReportDocument reportDocument;
        public FRekap()
        {
            InitializeComponent();
            reportDocument = new laporanAbsen();
        }

        private void InitializeReport(ReportClass rpt)
        {
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Zoom(0);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FRekap_Load(object sender, EventArgs e)
        {
           /* string kd_jadwal = "%" + Absensi_Mahasiswa.simpan.getJadwal().Trim() + "%";

            reportDocument.SetDataSource((DataTable)data);

            crystalReportViewer1.ReportSource = reportDocument; */
        }
    }
}
