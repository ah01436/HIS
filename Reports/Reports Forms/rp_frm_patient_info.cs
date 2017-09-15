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
    public partial class rp_frm_patient_info : Form
    {
        DataTable dt = new DataTable();
        public rp_frm_patient_info(DataTable d)
        {
            InitializeComponent();
            this.dt = d;
            loadPriv();
        }
        public rp_frm_patient_info()
        {
            InitializeComponent();
            loadPriv();
        }
        private void rp_frm_patient_info_Load(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.DataSources.Clear();
            //var rtds = new ReportDataSource("DataSet1", dt);
            //reportViewer1.LocalReport.DataSources.Add(rtds);
            //reportViewer1.RefreshReport();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Connection con=new Connection();
            frm_patient frm = new frm_patient();
            frm.btn_add.Visible = false;
            frm.btn_delete.Visible = false;
            frm.btn_edit.Visible = false;
            frm.btn_exit.Visible = false;
            frm.btn_accept.Visible = true;
            frm.ShowDialog();
            dt = new DataTable();
            string code = frm_patient.pat_cod;
            txt_pat_name.Text = frm_patient.pat_name;
            dt = con.selectt("select [Name],[address],[card_realease_place],[card_id],[job],[phone]from[dbo].[patient] where [id]='"+code+"';");
            reportViewer1.LocalReport.DataSources.Clear();
            var rtds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rtds);
            reportViewer1.RefreshReport();
        }
        
        void loadPriv()
        {
            Connection con = new Connection();
            dt = new DataTable();
            dt = con.selectt("select priv_display,priv_delete,priv_edit from tb_priv where priv_screen_id=3 and priv_user_id='" + Main_Form.curnt_user + "';");
            try
            {
                if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                {
                   btn_search.Enabled = false;
                }
                if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                {
                    //  btn_delete.Enabled = false;
                }
                if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                {
                  //  btn_edit.Enabled = false;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }
}
