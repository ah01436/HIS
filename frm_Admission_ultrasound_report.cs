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
    public partial class frm_Admission_ultrasound_report : Form
    {
        public frm_Admission_ultrasound_report()
        {
            InitializeComponent();
        }

        private void frm_Admission_ultrasound_report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
