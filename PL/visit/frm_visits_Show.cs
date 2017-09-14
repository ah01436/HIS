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
    public partial class frm_visits_Show : Form
    {
        frm_Doc_Instruction frm = new frm_Doc_Instruction();
        Connection con = new Connection();
        DataTable dt;
        DataView dv;
        string v_id;
        string pat_name;
        public frm_visits_Show()
        {
            InitializeComponent();
        }
        public frm_visits_Show(frm_Doc_Instruction ob)
        {
            frm = ob;
            InitializeComponent();
        }

        private void frm_visits_Show_Load(object sender, EventArgs e)
        {
            try
            {
                dt = con.selectt("select [visit_id],[pat_name],[Initial_diagnosis],[send_side_name] from Visit where [Visit_state]=1;");
                dv = new DataView(dt);
                dgv_visit.DataSource = dv;
                dgv_visit.Columns[0].HeaderText = "كود الزيارة";
                dgv_visit.Columns[0].ReadOnly = true;
                dgv_visit.Columns[1].HeaderText = "الاسم";
                dgv_visit.Columns[2].HeaderText = "التشخيص المبدئي";
                dgv_visit.Columns[3].HeaderText = "الجهة المرسل منها";
                dgv_visit.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }

        private void txt_search_MouseEnter(object sender, EventArgs e)
        {
            if (txt_search.Text == "ادخل نص البحث")
            {
                txt_search.Clear();
                txt_search.ForeColor = Color.Black;
            }
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "ادخل نص البحث";
                txt_search.ForeColor = Color.LightGray;
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text != "ادخل نص البحث")
                {
                    if (rdb_id.Checked)
                    {
                        dv.RowFilter = "visit_id like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                        dgv_visit.DataSource = dv;
                    }
                    else if (rdb_name.Checked)
                    {
                        dv.RowFilter = "pat_name like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                        dgv_visit.DataSource = dv;
                    }
                 
                }
                else
                {
                    dgv_visit.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_search.ForeColor = Color.Black;
        }

        private void rdb_phone_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Text = "ادخل نص البحث";
            dv.RowFilter = string.Empty;
        }

        private void dgv_visit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             v_id = dgv_visit.CurrentRow.Cells[0].Value.ToString();
             pat_name = dgv_visit.CurrentRow.Cells[1].Value.ToString();
             frm.setData(v_id, pat_name);
             this.Close();
        }

    }
}
