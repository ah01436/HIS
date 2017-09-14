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
    public partial class frm_diagnosis : Form
    {
        public frm_diagnosis()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        DataTable dt = new DataTable();
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (con.update(dt))
            {
                MessageBox.Show("تم الاضافة بتجاح");
                this.Close();
            }
        }

        private void frm_diagnosis_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from diagnosis");
            if (dt.Rows.Count > 0)
            {
                dgv_diago.DataSource = dt;
                dgv_diago.Columns[0].ReadOnly = true;
                dgv_diago.Columns[0].HeaderText = "الكود";
                dgv_diago.Columns[1].HeaderText = "اسم التشخيص";
                dgv_diago.Columns[2].HeaderText = "نوع التشخيص";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click_1(object sender, EventArgs e)
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
                    foreach (DataGridViewRow item in this.dgv_diago.SelectedRows)
                    {
                        dgv_diago.Rows.RemoveAt(item.Index);
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
    }
}