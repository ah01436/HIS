using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HIS
{
    public partial class frm_department : Form
    {
        public frm_department()
        {
            InitializeComponent();
        }

        cls_department dep;
        DataView dv;
        private void btn_add_Click(object sender, EventArgs e)
        {
           
        }

        private void frm_department_Load(object sender, EventArgs e)
        {
            try
            {
                dep = new cls_department();
                dv = new DataView(dep.selct_department());
                dgv_department.DataSource = dv;
                dgv_department.Columns[0].HeaderText = "كود القسم";
                dgv_department.Columns[1].HeaderText = "اسم القسم";
                dgv_department.Columns[2].HeaderText = "مكان القسم";
                dgv_department.Columns[3].HeaderText = "ملاحظات";
                dgv_department.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
