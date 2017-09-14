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

namespace HIS
{
    public partial class frm_Doc_Instruction : Form
    {
        string diagnosis;
        string vis_id;
        DataTable dt,dtt;
        Connection con = new Connection();
        string anatomy;
        
        public frm_Doc_Instruction()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frm_anatomy frm = new frm_anatomy();
            frm.ShowDialog();
             dt = new DataTable();
            dt = con.selectt("select * from anatomy");
            cmb_anatomy.DataSource = dt;
            cmb_anatomy.ValueMember = "id";
            cmb_anatomy.DisplayMember = "name";
           
        }
        private void frm_Doc_Instruction_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from anatomy;");
            cmb_anatomy.DataSource = dt;
            cmb_anatomy.ValueMember = "id";
            cmb_anatomy.DisplayMember = "name";
            dtt = new DataTable();
            dtt = con.selectt("select id,name from diagnosis");
            cmb_diagnosis.DataSource = dtt;
            cmb_diagnosis.ValueMember = "id";
            cmb_diagnosis.DisplayMember = "name";
        }
        private void cmb_anatomy_SelectedIndexChanged(object sender, EventArgs e)
        {
            anatomy = cmb_anatomy.SelectedValue.ToString();  
        }

        private void ts_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            frm_visits_Show frm = new frm_visits_Show(this);
            frm.ShowDialog();
        }
        public void setData(string visit_id,string pat_name)
        {
            try
            {
                vis_id = visit_id;
                txt_name.Text = pat_name;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                
        }
        private void ts_btn_save_Click(object sender, EventArgs e)
        {
               string[] pramname = new string[5];
                    string[] pramvalue = new string[5];
                    SqlDbType[] pramtype = new SqlDbType[5];
                    pramname[0] = "@id_anatomy";
                    pramname[1] = "@treatment";
                    pramname[2] = "@notes";
                    pramname[3] = "@visit_id";
                    pramname[4] = "@diagnosis_id";
                    pramvalue[0] = anatomy;
                    pramvalue[1] = txt_treatment.Text;
                    pramvalue[2] = txt_notes.Text;
                    pramvalue[3] = vis_id;
                    pramvalue[4] =diagnosis;                   
                    pramtype[0] = SqlDbType.Int;
                    pramtype[1] = SqlDbType.NVarChar;
                    pramtype[2] = SqlDbType.NVarChar;
                    pramtype[3] = SqlDbType.NVarChar;
                    pramtype[4] = SqlDbType.Int;
            if (con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("doc_instruction_insert",pramname,pramvalue,pramtype))
            {
                MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            dt = new DataTable();
            dt = con.selectt("select [dbo].[diagnosis].name,[dbo].[anatomy].name,[treatment],[notes] from [dbo].[diagnosis],[dbo].[anatomy],[dbo].[doc_instruction] where [dbo].[doc_instruction].diagnosis_id=[dbo].[diagnosis].id and [dbo].[doc_instruction].id_anatomy=[dbo].[anatomy].id and [dbo].[doc_instruction].Visit_id='" + vis_id + "'");
            if (dt.Rows.Count > 0)
            {
                dgv_doc_inst.DataSource = dt;
                dgv_doc_inst.Columns[0].HeaderText = "التشخيص";
                dgv_doc_inst.Columns[1].HeaderText = "التحليل";
                dgv_doc_inst.Columns[2].HeaderText = "العلاج";
                dgv_doc_inst.Columns[3].HeaderText = "ملاحظات";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frm_diagnosis frm = new frm_diagnosis();
            frm.ShowDialog();
             dtt = new DataTable();
            dtt = con.selectt("select id,name from diagnosis");
            cmb_diagnosis.DataSource = dtt;
            cmb_diagnosis.ValueMember = "id";
            cmb_diagnosis.DisplayMember = "name";
        }

        private void cmb_diagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            diagnosis = cmb_anatomy.SelectedValue.ToString();
        }
        DataColumn dc;
        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = con.selectt("select [dbo].[diagnosis].name,[dbo].[anatomy].name,[treatment],[notes] from [dbo].[diagnosis],[dbo].[anatomy],[dbo].[doc_instruction] where [dbo].[doc_instruction].diagnosis_id=[dbo].[diagnosis].id and [dbo].[doc_instruction].id_anatomy=[dbo].[anatomy].id and [dbo].[doc_instruction].Visit_id='" + vis_id + "'");
            if (dt.Rows.Count > 0)
            {
                dgv_doc_inst.DataSource = dt;
                dgv_doc_inst.Columns[0].HeaderText = "التشخيص";
                dgv_doc_inst.Columns[1].HeaderText="التحليل";
                dgv_doc_inst.Columns[2].HeaderText = "العلاج";
                dgv_doc_inst.Columns[3].HeaderText = "ملاحظات";
            }
        }
        private void ts_btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_notes.Clear();
            txt_treatment.Clear();
            cmb_anatomy.ResetText();
            cmb_diagnosis.ResetText();
        }      
    }
}