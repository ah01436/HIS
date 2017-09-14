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
    public partial class frm_examination : Form
    {
        Connection con = new Connection();
        DataTable dt = new DataTable();
        public frm_examination()
        {
            InitializeComponent();
        }

        private void frm_examination_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from examination");
            if (dt.Rows.Count > 0)
            {
                dgv_examination.DataSource = dt;
                dgv_examination.Columns[0].ReadOnly = true;
                dgv_examination.Columns[0].HeaderText = "الكود";
                dgv_examination.Columns[1].HeaderText = "الجهة المرسلة";
            }
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
                    foreach (DataGridViewRow item in this.dgv_examination.SelectedRows)
                    {
                        dgv_examination.Rows.RemoveAt(item.Index);
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (con.update(dt))
            {
                MessageBox.Show("تم الاضافة بتجاح");
                this.Close();
            }
        }

        private void dgv_examination_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
