using HospitalVSFundamentals.BL.BC;
using HospitalVSFundamentals.BL.BE;
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
    public partial class FCreateUser : Form
    {
        public FUsersPanel frmusers = new FUsersPanel();


        public FCreateUser()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {

            UserBC userBC = new UserBC();

            try
            {
                var user = new UserBE();

                user.Birthday = Convert.ToDateTime(dtpBirthday.Text);
                user.DNI = txtDNI.Text;
                user.Email = txtEmail.Text;
                user.Gener = ((KeyValuePair<string, string>)cmbGener.SelectedItem).Value;
                user.LastName = txtLastName.Text;
                user.Name = txtNombre.Text;
                user.Password = txtPassword.Text;
                user.PhoneNumber = txtTelefono.Text;
                user.Status = ((KeyValuePair<string, string>)cmbStatus.SelectedItem).Value;
                user.username = txtUsername.Text;
                user.User_Role = 1;

                var result = userBC.CreateUser(user);

                if (result)
                {
                    frmusers.udpateDataGridView();
                    MessageBox.Show("Se registro satisfactoriamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error vuelva a intentar");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void FCreateUser_Load(object sender, EventArgs e)
        {
            var genero = new Dictionary<string, string>();
            genero.Add("Femenino", "F");
            genero.Add("Masculino", "M");

            cmbGener.DataSource = new BindingSource(genero,null);
            cmbGener.DisplayMember = "Key";
            cmbGener.ValueMember = "Value";

            var estados = new Dictionary<string, string>();
            estados.Add("Activo", "A");
            estados.Add("Inactivo", "I");

            cmbStatus.DataSource = new BindingSource(estados, null);
            cmbStatus.DisplayMember = "Key";
            cmbStatus.ValueMember = "Value";

        }
    }
}
