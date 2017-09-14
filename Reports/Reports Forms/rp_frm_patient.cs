using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS
{
    public partial class rp_frm_patient : Form
    {
        DataTable dt = new DataTable();
        
        public rp_frm_patient(DataTable d)
        {
            InitializeComponent();
            dt = d;
        }

        private void rp_frm_patient_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            var rtds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rtds);
            reportViewer1.RefreshReport();

        }
    }
}
