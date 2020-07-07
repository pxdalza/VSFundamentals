using HospitalVSFundamentals.BL.BE;
using HospitalVSFundamentals.UI.Forms.Forms_MedicHistory;
using HospitalVSFundamentals.UI.Forms.Forms_Specialities;
using HospitalVSFundamentals.UI.Forms.Forms_Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms
{
    public partial class FMainAdm : Form
    {
        public UserLoginBE ulogin = new UserLoginBE();

        public FMainAdm()
        {
            InitializeComponent();
            gbPanel.BackColor = Color.FromArgb(25, Color.Black);

        }


        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void FMain_Load(object sender, EventArgs e)
        {

            lblNombre.Text = ulogin.Name + " " + ulogin.LastName;
            lblDNI.Text = "DNI: " + ulogin.DNI;
            lblRol.Text = "Rol: " + ulogin.Role;

        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            var Fusers = new FUsersPanel();
            Fusers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var FSpeciality = new Frm_Speciality();
            FSpeciality.Show();
        }

       
    }
}
