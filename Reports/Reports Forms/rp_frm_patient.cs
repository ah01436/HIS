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
      
        
        public rp_frm_patient()
        {
            InitializeComponent();
         
        }

        private void rp_frm_patient_Load(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.DataSources.Clear();
            //var rtds = new ReportDataSource("DataSet1", dt);
            //reportViewer1.LocalReport.DataSources.Add(rtds);
            //reportViewer1.RefreshReport();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            string query;
            DataTable dt = new DataTable();
            query = @"select [Name],[address],[card_realease_place],[card_id],[job],[phone]from[dbo].[patient] where date_reg >='" + dtp_from.Value.ToString("yyyy/MM/dd") + "' AND date_reg<='" + dtp_to.Value.ToString("yyyy/MM/dd") + "';";
            dt.Clear();
            dt = (DataTable)conn.selectt(query);
            conn.CloseConnection();
            reportViewer1.LocalReport.DataSources.Clear();
            var rtds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rtds);
            reportViewer1.RefreshReport();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            string query;
            DataTable dt = new DataTable();
            query = @"select [Name],[address],[card_realease_place],[card_id],[job],[phone]from[dbo].[patient];";
            dt.Clear();
            dt = (DataTable)conn.selectt(query);
            conn.CloseConnection();
            reportViewer1.LocalReport.DataSources.Clear();
            var rtds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rtds);
            reportViewer1.RefreshReport();
        }
    }
}
