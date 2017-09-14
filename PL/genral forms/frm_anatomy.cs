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
    public partial class frm_anatomy : Form
    {
        DataTable dt = new DataTable();
        Connection con = new Connection();
        public frm_anatomy()
        {
            InitializeComponent();
        }

        private void frm_anatomy_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from anatomy");
            if (dt.Rows.Count > 0)
            {
                dgv_anatomy.DataSource = dt;
                dgv_anatomy.Columns[0].ReadOnly = true;
                dgv_anatomy.Columns[0].HeaderText = "الكود";
                dgv_anatomy.Columns[1].HeaderText = "اسم التحليل";
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد حذف الاسم المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dgv_anatomy.SelectedRows)
                    {
                        dgv_anatomy.Rows.RemoveAt(item.Index);
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
