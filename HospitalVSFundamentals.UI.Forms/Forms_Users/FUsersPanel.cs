using HospitalVSFundamentals.BL.BC;
using HospitalVSFundamentals.BL.BE;
using HospitalVSFundamentals.UI.Forms.Helpers;
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
    public partial class FUsersPanel : Form
    {

        UserBC userBC = new UserBC();

        List<UserViewModel> users = new List<UserViewModel>();

        private void initializeUsers()
        {
            //metodo linq
            users = userBC.GetUsers().Select(x => new UserViewModel
            {

                Id = x.IdUser,
                Apellido = x.LastName,
                Nombre = x.Name,
                Correo_electronico = x.Email,
                DNI = x.DNI,
                Estado = (x.Status == "A") ? "Activo" : "Desactivado", //(x.Status == "A") ? "Activo" : (x.Status == "E") ? "Eliminado" : "Desactivado"
                Genero = (x.Gener == "M") ? "Masculino" : "Femenino", // obtenergenero(x.gener) => String
                Fecha_Nacimiento = x.Birthday.Value.ToShortDateString(),
                Nombre_Usuario = x.username,
                Telefono = x.PhoneNumber
            }).OrderBy(x=>x.Apellido).ToList();// el OrderBy ordena de manera Ascendente y el OrderByDescending va de manera descendente

        }

        public FUsersPanel()
        {
            InitializeComponent();
            initializeUsers();
        }

        public void udpateDataGridView()
        {
            initializeUsers();
            dgvUsers.DataSource = users;
        }

        private void FUsersPanel_Load(object sender, EventArgs e)
        {

            dgvUsers.DataSource = users;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscar.Text.Length == 0)
            {
                udpateDataGridView();
            }
            else
            {
                //Sql
                //like '%{text}%' o =
                //like '%{text}'  '{text}%'
                //con Linq
                //.Contains()  => va a buscar en el texto los caracteres que estas ingresando (no importa en que posicion de la cadena este el caracter lo toma en cuenta)
                //.Equals() => solo buscara cuando la palabra que buscas sea tal cual esta en la base de datos.
                dgvUsers.DataSource = users.Where(x => x.DNI.Contains(txtBuscar.Text)).ToList();
            }

        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fNewUser = new FCreateUser();
            fNewUser.frmusers = this;
            fNewUser.Show();
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserViewModel user = new UserViewModel();
            foreach (DataGridViewRow dataRow in dgvUsers.SelectedRows)
            {
                 user = DataRowViewToViewModel.convertUserViewModel(dataRow);
            }

            FUserDetails fUserDetail = new FUserDetails();
            fUserDetail.user = user;
            fUserDetail.Show();

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            udpateDataGridView();
        }
    }
}
