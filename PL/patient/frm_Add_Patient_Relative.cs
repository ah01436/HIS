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
    public partial class frm_Add_Patient_Relative : Form
    {
        Connection con = new Connection();
        DataTable dt=new DataTable();
        public frm_Add_Patient_Relative()
        {
            InitializeComponent();
        }

        private void frm_Add_Patient_Relative_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from Patient_relarive");
          if(dt.Rows.Count>0)
          { 
            dgv_patRel.DataSource = dt;
            dgv_patRel.Columns[0].ReadOnly = true;
            dgv_patRel.Columns[0].HeaderText = "الكود";
            dgv_patRel.Columns[1].HeaderText="صلة القرابة";
        }
            }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (con.update(dt))
            {
                MessageBox.Show("تم الاضافة بتجاح");
                this.Close();
            }

        }

        private void dgv_patRel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد حذف الاسم المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dgv_patRel.SelectedRows)
                    {
                        dgv_patRel.Rows.RemoveAt(item.Index);
                    }
                    MessageBox.Show("تم الحذف بنجاح ");
                    con.update(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
