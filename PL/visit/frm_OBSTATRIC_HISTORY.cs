using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HIS
{
    public partial class frm_OBSTATRIC_HISTORY : Form
    {
        public frm_OBSTATRIC_HISTORY()
        {
            InitializeComponent();
            loadPriv();
        }
        List<int> indicationValue=new List<int>();
        List<int> Abnormal_deliveries = new List<int>();
        Connection con = new Connection();
        DataTable dt;
        bool m_reliable=false;
        bool Contaceptive_Method = false;
        bool abnormal_delivers = false;
        bool Medical_Disorders = false;
        bool Previous_Operations = false;
        bool Family_History = false;
        string visit_id="";
        string abnormal_delivery_code = "";
        string indications_code = "";
        string Contaceptive_methods_code = "";
        private void frm_OBSTATRIC_HISTORY_Load(object sender, EventArgs e)
        {
            dt = new DataTable(); 
            //dt = con.selectt("select Visit.visit_id, [dbo].[patient].id,[dbo].[patient].Name,[dbo].[patient].age,[dbo].[patient].married_duration,[dbo].[patient].address,[dbo].[Visit].entry_date FROM patient,Visit where patient.id=Visit.pat_id AND [Visit].Visit_state=0 and [Visit].Visit_type LIKE N'%حو%';");
            dt = con.selectt("select [visit_id],[pat_name],[Visit_state],pat_id from [dbo].[Visit]where [Visit_state]=0  and [Visit].Visit_type LIKE N'%حوامل%';");

            if (dt.Rows.Count > 0)
            {
                dgv_entities.DataSource = dt;
                dgv_entities.Columns[0].ReadOnly = true;
                dgv_entities.Columns[1].ReadOnly = true;
                dgv_entities.Columns[0].HeaderText = "كود الزيارة";
                dgv_entities.Columns[1].HeaderText = "اسم المريضة";
                dgv_entities.Columns[2].HeaderText = "قبول";
                dgv_entities.Columns[2].Visible = false;
                dgv_entities.Columns[3].Visible = false;
            }
            try
            {
                dt = new DataTable();
                dt = con.selectt("SELECT [id],[name] FROM [HIS_women].[dbo].[Abnormal_deliveries]");
                dgv_Abnormal_deliveries.DataSource = dt;
                dgv_Abnormal_deliveries.Columns[0].Visible = false;
                dgv_Abnormal_deliveries.Columns[1].HeaderText = "الاسم";
                dt = new DataTable();
                dt = con.selectt("SELECT TOP 1000 [id],[name] FROM [HIS_women].[dbo].[indecation_of_cs]");
                dgv_Indications.DataSource = dt;
                dgv_Indications.Columns[0].Visible = false;
                dgv_Indications.Columns[1].HeaderText = "الاسم";

                 dt = new DataTable();
              
                {
                    dt = con.selectt("select * from Contaceptive_methods;");
                    cmb_conceptive_methods1.DataSource = dt;
                    cmb_conceptive_methods1.ValueMember = "id";
                    cmb_conceptive_methods1.DisplayMember = "name";

                    cmb_conceptive_methods2.DataSource = dt;
                    cmb_conceptive_methods2.ValueMember = "id";
                    cmb_conceptive_methods2.DisplayMember = "name";
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void dgv_entities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //con.update(dt);
            visit_id = dgv_entities.CurrentRow.Cells[0].Value.ToString();
            if (con.update("update Visit set Visit_state=1 where visit_id='" + dgv_entities.CurrentRow.Cells[0].Value.ToString() + "';")) 
            {
                txt_patien_name.Text = dgv_entities.CurrentRow.Cells[1].Value.ToString();
                txt_pat_code.Text = dgv_entities.CurrentRow.Cells[3].Value.ToString();
            }
            dt.Clear();
            dt = con.selectt("select [visit_id],[pat_name],[Visit_state],pat_id from [dbo].[Visit]where [Visit_state]=0  and [Visit].Visit_type LIKE N'%حوامل%';");

            if (dt.Rows.Count > 0)
            {
                dgv_entities.DataSource = dt;
                dgv_entities.Columns[0].ReadOnly = true;
                dgv_entities.Columns[1].ReadOnly = true;
                dgv_entities.Columns[0].HeaderText = "كود الزبارة";
                dgv_entities.Columns[1].HeaderText = "اسم المريضة";
                dgv_entities.Columns[2].HeaderText = "قبول";
                dgv_entities.Columns[2].Visible = false;
                dgv_entities.Columns[3].Visible = false;
            }
            this.frm_OBSTATRIC_HISTORY_Load(sender, e);
        }
        private void rdb_yes1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_yes1.Checked)
            {
                gb_MD.Visible = true;
                Medical_Disorders = true;
            }
            else if (rdb_no1.Checked)
            {
                gb_MD.Visible = false;
                Medical_Disorders = false;
            }
        }
        private void rdb_yes2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_yes2.Checked)
            {
                gb_po.Visible = true;
                Previous_Operations = true;
            }
            else if (rdb_no2.Checked)
            {
                gb_po.Visible = false;
                Previous_Operations=false;
            }
        }
        private void rdb_yes3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_yes3.Checked)
            {
                gb_fh.Visible = true;
                Family_History = true;
            }
            else if (rdb_no3.Checked)
            {
                gb_fh.Visible = false;
                Family_History = false;
            }
        }

        private void ts_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Abnormal_deliveries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_pat_code.Text == "")
            {
                MessageBox.Show("من فضلك قم باختيار اسم المريضة");
            }
            else
            {
                LI_Abnormal_deliveries.Items.Add(dgv_Abnormal_deliveries.CurrentRow.Cells[1].Value.ToString());
                if (!Abnormal_deliveries.Contains(int.Parse(dgv_Abnormal_deliveries.CurrentRow.Cells[0].Value.ToString())))
                {
                    Abnormal_deliveries.Add(int.Parse(dgv_Abnormal_deliveries.CurrentRow.Cells[0].Value.ToString()));

                }
              
            }
        }

        private void dgv_Indications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (txt_pat_code.Text == "")
            {

                MessageBox.Show("من فضلك قم باختيار اسم المريضة");
            }
            else
            {
                LI_Indications.Items.Add(dgv_Indications.CurrentRow.Cells[1].Value.ToString());             
                if (!indicationValue.Contains(int.Parse(dgv_Indications.CurrentRow.Cells[0].Value.ToString())))
                {
                    indicationValue.Add(int.Parse(dgv_Indications.CurrentRow.Cells[0].Value.ToString()));
                }
            }
        }

        private void LI_Abnormal_deliveries_DoubleClick(object sender, EventArgs e)
        {
            LI_Abnormal_deliveries.Items.Remove(LI_Abnormal_deliveries.Items[LI_Abnormal_deliveries.SelectedIndex]);

        }

        private void LI_Indications_DoubleClick(object sender, EventArgs e)
        {
            LI_Indications.Items.Remove(LI_Indications.Items[LI_Indications.SelectedIndex]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_abnormal_deliveries frm = new frm_abnormal_deliveries();
            frm.ShowDialog();
            dt = new DataTable();
            dt = con.selectt("SELECT [id],[name] FROM [HIS_women].[dbo].[Abnormal_deliveries]");
            dgv_Abnormal_deliveries.DataSource = dt;
            dgv_Abnormal_deliveries.Columns[0].Visible = false;
            dgv_Abnormal_deliveries.Columns[1].HeaderText = "الاسم";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_indecaions frm = new FRM_indecaions();
            frm.ShowDialog();
            dt = new DataTable();
            dt = con.selectt("SELECT [id],[name] FROM [HIS_women].[dbo].[indecation_of_cs]");
            dgv_Indications.DataSource = dt;
            dgv_Indications.Columns[0].Visible = false;
            dgv_Indications.Columns[1].HeaderText = "الاسم";
        }

        private void ts_btn_save_Click(object sender, EventArgs e)
        {
            string[] pramname = new string[27];
            string[] pramvalue = new string[27];
            SqlDbType[] pramtype = new SqlDbType[27];
pramname[0]="@Compain_duration";
pramname[1]="@L_Menstural_History";
pramname[2]="@M_reliability";
pramname[3]="@G";
pramname[4]="@FTP";
pramname[5]="@PTD";
pramname[6]="@Abortion";
pramname[7]="@abnormal_deliveries";
pramname[8]="@number_of_cs";
pramname[9]="@last_delivery";
pramname[10]="@last_abortion";
pramname[11]="@N_l_male";
pramname[12]="@N_l_female";
pramname[13]="@Contaceptive_Methods";
pramname[14]="@duration";
pramname[15]="@cause_discontiution";
pramname[16]="@Medical_Disorders";
pramname[17]="@Previous_Operations";
pramname[18]="@Family_History";
pramname[19]="@Drug_History";
pramname[20]="@Chronic_Medical_Diseases";
pramname[21]="@Blood_Transform_indication";
pramname[22]="@Allegies";
pramname[23]="@Obsterical_Gynecological";
pramname[24]="@Others";
pramname[25]="@F_History";
pramname[26]="@visit_id";
pramvalue[0] = txt_complain_duration.Text;
pramvalue[1] = dtp_L_menstural_History.Value.ToString() ;
pramvalue[2] = m_reliable.ToString();
pramvalue[3] = num_G.Value.ToString();
pramvalue[4] = num_ftd.Value.ToString() ;
pramvalue[5] = num_ptd.Value.ToString() ;
pramvalue[6] = num_abortion.Value.ToString();
pramvalue[7] = abnormal_delivers.ToString();
pramvalue[8] = num_css.Value.ToString();
pramvalue[9] = num_LastDelivery_since.Value.ToString();
pramvalue[10] = num_Last_abortion_since.Value.ToString();
pramvalue[11] = num_male.Value.ToString();
pramvalue[12] = num_famel.Value.ToString();
pramvalue[13] = Contaceptive_Method.ToString();
pramvalue[14] = txt_duration1.Text + "/" + txt_duration2.Text;
pramvalue[15] = cause_of_destination1.Text +"/"+ cause_of_destination2.Text;
pramvalue[16] = Medical_Disorders.ToString();
pramvalue[17] = Previous_Operations.ToString();
pramvalue[18] = Family_History.ToString();
pramvalue[19] = drug_history.Text;
pramvalue[20] = txt_CMD.Text;
pramvalue[21] = txt_BTI.Text;
pramvalue[22] = txt_allegries.Text;
pramvalue[23] = txt_Obsterical_Gynecological.Text;
pramvalue[24] = txt_others.Text;
pramvalue[25] = f_history.Text;
pramvalue[26] = visit_id;
pramtype[0] = SqlDbType.NVarChar;
pramtype[1] = SqlDbType.Date;
pramtype[2] = SqlDbType.Bit;
pramtype[3] = SqlDbType.Int;
pramtype[4] = SqlDbType.Int;
pramtype[5] = SqlDbType.Int;
pramtype[6] = SqlDbType.Int;
pramtype[7] = SqlDbType.Bit;
pramtype[8] = SqlDbType.Int;
pramtype[9] = SqlDbType.VarChar;
pramtype[10] = SqlDbType.VarChar;
pramtype[11] = SqlDbType.Int;
pramtype[12] = SqlDbType.Int;
pramtype[13] = SqlDbType.Bit;
pramtype[14] = SqlDbType.NVarChar;
pramtype[15] = SqlDbType.NVarChar;
pramtype[16] = SqlDbType.Bit;
pramtype[17] = SqlDbType.Bit;
pramtype[18] = SqlDbType.Bit;
pramtype[19] = SqlDbType.NVarChar;
pramtype[20] = SqlDbType.NVarChar;
pramtype[21] = SqlDbType.NVarChar;
pramtype[22] = SqlDbType.NVarChar;
pramtype[23] = SqlDbType.NVarChar;
pramtype[24] = SqlDbType.NVarChar;
pramtype[25] = SqlDbType.NVarChar;
pramtype[26] = SqlDbType.NVarChar;
            int i;
            if(con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("Add_OBSTATRIC_HISTORY",pramname,pramvalue,pramtype))
                            {
                                for(i=0;i<indicationValue.Count;i++)
                                {
                                    con.ExecuteQueries("insert into has_indications values ( " + indicationValue[i] + ",'" + visit_id + "')");                                
                                }
                                for ( i = 0; i < Abnormal_deliveries.Count; i++)
                                {
                                    con.ExecuteQueries("insert into has_indications values ( " + Abnormal_deliveries[i] + ",'" + visit_id + "')");
                                }
                                con.ExecuteQueries("insert into has_Contaceptive_methods values (" + cmb_conceptive_methods1.SelectedValue.ToString() + ",'" + visit_id + "');" +
                                                    "insert into has_Contaceptive_methods values (" + cmb_conceptive_methods2.SelectedValue.ToString() + ",'" + visit_id + "');");
                                MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();                             
                            }

        }

        private void yes1_CheckedChanged(object sender, EventArgs e)
        {
            if (yes1.Checked)
                m_reliable = true;
            else if (no1.Checked)
                m_reliable = false;
        }

        private void yes2_CheckedChanged(object sender, EventArgs e)
        {
            if (yes2.Checked)
                abnormal_delivers = true;
            else if (no2.Checked)
                abnormal_delivers = false;
        }

        private void yes3_CheckedChanged(object sender, EventArgs e)
        {
            if (yes3.Checked)
                Contaceptive_Method = true;
            else if(no3.Checked)
                Contaceptive_Method = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_contaceptive_methods frm = new frm_contaceptive_methods();
            frm.ShowDialog();
            dt = new DataTable();
            dt = con.selectt("select * from Contaceptive_methods;");
            cmb_conceptive_methods1.DataSource = dt;
            cmb_conceptive_methods1.ValueMember = "id";
            cmb_conceptive_methods1.DisplayMember = "name";
            dt = con.selectt("select * from Contaceptive_methods;");
            cmb_conceptive_methods2.DataSource = dt;
            cmb_conceptive_methods2.ValueMember = "id";
            cmb_conceptive_methods2.DisplayMember = "name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_contaceptive_methods frm = new frm_contaceptive_methods();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            if (timer1.Interval == 1000)
            {
                dgv_entities.Update();
                dgv_entities.Refresh();
            }

        }
        void loadPriv()
        {
            dt = new DataTable();
            dt = con.selectt("select priv_add,priv_delete,priv_edit from tb_priv where priv_screen_id=5 and priv_user_id='" + Main_Form.curnt_user + "';");
            try
            {
                if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                {
                    ts_btn_save.Enabled = false;
                }
                if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                {
                  //  btn_delete.Enabled = false;
                }
                if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                {
               //     btn_edit.Enabled = false;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
  
}
