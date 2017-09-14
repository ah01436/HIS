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
   
    public partial class docSearch : Form
    {
        Connection con = new Connection();
        DataView dv;
        DataTable dt=new DataTable();
        frm_visit  ob = new frm_visit();
        public docSearch()
        {
            InitializeComponent();
        }
        public docSearch(frm_visit frm)
        {
            InitializeComponent();
            ob = frm;
        }

        private void docSearch_Load(object sender, EventArgs e)
        {
             dt = con.ReadData("doc_select");
             dv = new DataView(dt);
             if (dt.Rows.Count > 0)
             {
                dgv_doc.DataSource = dv;
             
             }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            ob.setDoc(dgv_doc.CurrentRow.Cells[0].Value.ToString(), dgv_doc.CurrentRow.Cells[1].Value.ToString());
            this.Close();
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_search.Text != "ادخل نص البحث")
                {
                    if (rdb_id.Checked)
                    {
                        dv.RowFilter = "id like '%" + txt_search.Text + "%'";
                        dgv_doc.DataSource = dv;
                    }
                    else if (rdb_name.Checked)
                    {
                        dv.RowFilter = "Name like '%" + txt_search.Text + "%'";
                        dgv_doc.DataSource = dv;
                    }
                    else if (rdb_card.Checked)
                    {
                        dv.RowFilter = "card_id like '%" + txt_search.Text + "%'";
                        dgv_doc.DataSource = dv;
                    }
                }
                else
                {
                    dgv_doc.DataSource = dv;
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
        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "ادخل نص البحث";
                txt_search.ForeColor = Color.LightGray;
            }
        }
        private void rdb_name_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Text = "ادخل نص البحث";
            txt_search.ForeColor = Color.LightGray;
            dv.RowFilter = string.Empty;

        }
    }
}
