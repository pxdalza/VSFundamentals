﻿using HospitalVSFundamentals.UI.Forms.Forms_MedicHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FLogin());
            //Application.Run(new Form1());
            // Application.Run(new Frm_MedicHistory());
            //  Application.Run(new FrmReportMedicHistory());
            // Application.Run(new FrmReportMedicHistoryCopia());
            // Application.Run(new FrmReporteMedicHIstoryFinal());
        }
    }
}
