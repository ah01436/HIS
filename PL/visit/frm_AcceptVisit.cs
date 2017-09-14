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
    public partial class frm_AcceptVisit : Form
    {
        public frm_AcceptVisit()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        DataTable dt = new DataTable();

        private void frm_AcceptVisit_Load(object sender, EventArgs e)
        {
            //dt = con.selectt("select [visit_id],[dbo].[Visit].[Visit_state] from Visit where Visit.Visit_state=0;");
            dt = con.selectt("select [visit_id],[pat_name],[Visit_state] from [dbo].[Visit]where [Visit_state]=0;");
         
            if (dt.Rows.Count > 0)
            {
                dgv_entities.DataSource = dt;
                dgv_entities.Columns[0].ReadOnly = true;
                dgv_entities.Columns[1].ReadOnly = true;
                dgv_entities.Columns[0].HeaderText = "الكود";
                dgv_entities.Columns[1].HeaderText = "اسم المريضة";
               dgv_entities.Columns[2].HeaderText = "قبول";
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (con.update(dt))
            {
                MessageBox.Show("تم الاضافة بتجاح");
                this.Close();
            }
        }
    }
}
