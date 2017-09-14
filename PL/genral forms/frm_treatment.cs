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
    public partial class frm_treatment : Form
    {
        public frm_treatment()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        DataTable dt = new DataTable();
        DataView dv;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد حذف الاسم المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dgv_TREt.SelectedRows)
                    {
                        dgv_TREt.Rows.RemoveAt(item.Index);
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

        private void frm_treatment_Load(object sender, EventArgs e)
        {
            cb_type.SelectedIndex = 0;
            dt = con.selectt("select * from Treatment ");
            dv = new DataView(dt);
            if (dt.Rows.Count > 0)
            {
                dgv_TREt.DataSource = dv;
                dgv_TREt.Columns[0].ReadOnly = true;
                dgv_TREt.Columns[0].HeaderText = "الكود";
                dgv_TREt.Columns[1].HeaderText = "اسم الدواء";
                dgv_TREt.Columns[2].HeaderText = "نوع الدواء";
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

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show(cb_type.SelectedItem.ToString());
           // dt = con.selectt("select * from Treatment Where Treatment_type like '" + cb_type.SelectedItem + "'");
            if (dt.Rows.Count > 0)
            {
                dv.RowFilter = "Treatment_type like '%" + cb_type.SelectedItem.ToString() + "%'";
                dgv_TREt.DataSource = dv;
            }
        }

        private void Treat_name_TextChanged(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                dv.RowFilter = "Treatment_name like '%" + Treat_name.Text + "%'";
                dgv_TREt.DataSource = dv;
                
            }
            
        }
    }
}
