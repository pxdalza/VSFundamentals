﻿using HospitalVSFundamentals.BL.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms.Form_Main
{
    public partial class FMainPcn : Form
    {
        public UserLoginBE ulogin = new UserLoginBE();
        public FMainPcn()
        {
            InitializeComponent();
        }
    }
}
