using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HIS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
          //  Application.EnableVisualStyles();
          //  Application.SetCompatibleTextRenderingDefault(false);
          // // Application.Run(new Log_in()); 
          //// Application.Run(new Main_Form("user_101","محمد"));
          //  frmServerSetting frm = new frmServerSetting();
          //  //  MessageBox.Show(Properties.Settings.Default.Server);
          //  if (Properties.Settings.Default.Server == "")
          //  {
          //      Application.Run(frm);
          //      if (frm.DialogResult == DialogResult.OK)
          //      {
          //          Application.Run(new Log_in());
          //      }
          //  }
          //  else
          //  {
          //      Application.Run(new Log_in());
          //  }
            Application.Run(new Log_in());
        //Application.Run(new frmServerSetting());

        }
    }
}
