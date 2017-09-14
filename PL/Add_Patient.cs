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
    public partial class Add_Patient : Form
    {
        public Add_Patient()
        {
            InitializeComponent();
        }

        private void tab_basic_info_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_controrl_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Add_Patient_Load(object sender, EventArgs e)
        {
         
        }

        private void ts_btn_save_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            if (txt_patientName.Text == "")
                MessageBox.Show("من فضلك ادخل اسم المريض");

           
        }
    }
}
