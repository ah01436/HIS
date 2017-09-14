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
    public partial class frm_Entities : Form
    {
        Connection con = new Connection();
        DataTable dt = new DataTable();
        public frm_Entities()
        {
            InitializeComponent();
        }

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
                    foreach (DataGridViewRow item in this.dgv_entities.SelectedRows)
                    {
                        dgv_entities.Rows.RemoveAt(item.Index);
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

        private void frm_Entities_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from Entities");
            if (dt.Rows.Count > 0)
            {
                dgv_entities.DataSource = dt;
                dgv_entities.Columns[0].ReadOnly = true;
                dgv_entities.Columns[0].HeaderText = "الكود";
                dgv_entities.Columns[1].HeaderText = "الجهة المرسلة";
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
