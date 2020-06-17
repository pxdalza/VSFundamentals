using HospitalVSFundamentals.UI.Forms.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms.Forms_Users
{
    public partial class FUserDetails : Form
    {

        public UserViewModel user = new UserViewModel();

        public FUserDetails()
        {
            InitializeComponent();
        }

        private void FUserDetails_Load(object sender, EventArgs e)
        {
            lblNombre.Text = user.Nombre;
            lblApellido.Text = user.Apellido;
            lblDNI.Text = user.DNI;
            lblUsername.Text = user.Nombre;
            lblEstado.Text = user.Estado;
            lblEmail.Text = user.Correo_electronico;
            lblTelefono.Text = user.Telefono;
            lblFechaNacimiento.Text = user.Fecha_Nacimiento;
            lblGenero.Text = user.Genero;
        }
    }
}
