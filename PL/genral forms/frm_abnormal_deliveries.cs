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
    public partial class frm_abnormal_deliveries : Form
    {
        public frm_abnormal_deliveries()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        DataTable dt = new DataTable();
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
                    foreach (DataGridViewRow item in this.dgv_ABnormal.SelectedRows)
                    {
                        dgv_ABnormal.Rows.RemoveAt(item.Index);
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

        private void frm_abnormal_deliveries_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from Abnormal_deliveries");
            if (dt.Rows.Count > 0)
            {
                dgv_ABnormal.DataSource = dt;
                dgv_ABnormal.Columns[0].ReadOnly = true;
                dgv_ABnormal.Columns[0].HeaderText = "الكود";
                dgv_ABnormal.Columns[1].HeaderText = "الاسم";
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
    }
}
