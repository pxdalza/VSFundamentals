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
using HospitalVSFundamentals.UI.Forms.Data;
using HospitalVSFundamentals.UI.Forms.ViewModel;
using HospitalVSFundamentals.FL.Utility;

namespace HospitalVSFundamentals.UI.Forms.Forms_Users
{
    public partial class FCreateUser : Form
    {
        public FUsersPanel frmusers = new FUsersPanel();
        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();


        public FCreateUser()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {

            UserBC userBC = new UserBC();

            try
            {
                /*
                 *var user = new UserBE();

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
                 */

                var birthday = Convert.ToDateTime(dtpBirthday.Text);
                var gener = ((KeyValuePair<string, string>)cmbGener.SelectedItem).Value;
                var pass = PasswordSC.PasswordEncriptarSHA512(txtPassword.Text);
                var status = ((KeyValuePair<string, string>)cmbStatus.SelectedItem).Value;
                var guid = Guid.NewGuid();
                var role = (cmbRol.Text == "ADM") ? 1 : (cmbRol.Text == "DOC") ? 2 : (cmbRol.Text == "PCT") ? 3 : 4;

                var user = context.Users.Add(new Users {
                    Name = txtNombre.Text,
                    LastName = txtLastName.Text,
                    Birthday = birthday,
                    DNI = txtDNI.Text,
                    Email = txtEmail.Text,
                    Gener = gener,
                    Password = pass,
                    PhoneNumber = txtTelefono.Text,
                    Status = status,
                    username = txtUsername.Text,
                    IdUser = guid,
                    User_Role = role,
                });

                if (cmbRol.Text == "PCT")
                {
                    var idBlood = cmbTipoSangre.SelectedIndex+1;
                    var paciente = context.Patients.Add(new Patients {
                       UserId = user.IdUser,
                       BloodType = idBlood,
                       Policy = txtPoliza.Text,
                       Date_Creation = DateTime.Now,
                       Date_Update = DateTime.Now,
                    });

                }
                else if (cmbRol.Text == "DOC" || cmbRol.Text == "ENF")
                {

                    var idSpecility = cmbEspecialidad.SelectedIndex+1;

                    var doc = context.Doctor.Add(new Doctor { 
                        Userid = user.IdUser,
                        CMP = txtCMP.Text,
                        SpecialityId = idSpecility
                    });

                }

                context.SaveChanges();

                frmusers.udpateDataGridView();
                MessageBox.Show("Se registro satisfactoriamente.");
                this.Close();

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

            cmbRol.DataSource = context.Roles.Select(x => new RolViewModel {
                Id = x.User_Role_Id,
                Nombre = x.ShortName
            }).ToList();

            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var rol = ((KeyValuePair<string, string>)cmbRol.SelectedItem).Value;

            if (cmbRol.Text == "DOC" || cmbRol.Text == "ENF")
            {

                lblCMP.Visible = true;
                lblEspecialidad.Visible = true;
                txtCMP.Visible = true;
                cmbEspecialidad.Visible = true;

                lblPoliza.Visible = false;
                lblTipoSangre.Visible = false;
                txtPoliza.Visible = false;
                cmbTipoSangre.Visible = false;

                var specialities = context.Speciality.Select(x => new SpecialityViewModel
                {
                    Id = x.SpecialityId,
                    Nombre = x.Name
                }).ToList();

                cmbEspecialidad.DataSource = specialities;
                cmbEspecialidad.DisplayMember = "Nombre";
                cmbEspecialidad.ValueMember = "Id";
            }
            else if (cmbRol.Text == "PCT")
            {

                lblPoliza.Visible = true;
                lblTipoSangre.Visible = true;
                txtPoliza.Visible = true;
                cmbTipoSangre.Visible = true;

                lblCMP.Visible = false;
                lblEspecialidad.Visible = false;
                txtCMP.Visible = false;
                cmbEspecialidad.Visible = false;

                var bloods = context.BloodType.Select(x => new BloodViewModel
                {
                    Id = x.BloodTypeId,
                    Nombre = x.Name
                }).ToList();

                cmbTipoSangre.DataSource = bloods;
                cmbTipoSangre.DisplayMember = "Nombre";
                cmbTipoSangre.ValueMember = "Id";

            }
            else {

                lblCMP.Visible = false;
                lblEspecialidad.Visible = false;
                txtCMP.Visible = false;
                cmbEspecialidad.Visible = false;

                lblPoliza.Visible = false;
                lblTipoSangre.Visible = false;
                txtPoliza.Visible = false;
                cmbTipoSangre.Visible = false;

            }

        }
    }
}
