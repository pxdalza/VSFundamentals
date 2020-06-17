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

namespace HospitalVSFundamentals.UI.Forms.Forms_Specialities
{
    public partial class Frm_DetailSpeciality : Form
    {
        //entity framework
        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();
        //frm padre donde esta la grilla
        public Frm_Speciality frmmFather = new Frm_Speciality();
        //y este bool nos indica si el formulario es editable o no
        public bool isEditable = false;
        //y este es el modelo del objeto especialidad
        public SpecialityViewModel specialityViewModel = new SpecialityViewModel();

        public Frm_DetailSpeciality()
        {
            InitializeComponent();
        }

        private void Frm_DetailSpeciality_Load(object sender, EventArgs e)
        {

            txtId.Enabled = false;

            if (!isEditable)
            {
                txtNombre.Enabled = false;
                txtNombreCorto.Enabled = false;
                btn_Guardar.Visible = false;
            }

            txtId.Text = specialityViewModel.Id.ToString();
            txtNombre.Text = specialityViewModel.Nombre;
            txtNombreCorto.Text = specialityViewModel.NombreCorto;

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {

                //SingleOrDefault   --> Vas a traer el objeto si lo encuentras o sino traeras null
                //Single --> Vas a traer el objeto si o si xq existe.

                var especialidad = context.Speciality
                    .Where(x => x.SpecialityId.Equals(specialityViewModel.Id))
                    .SingleOrDefault();

                if (especialidad != null)
                {
                    especialidad.Name = txtNombre.Text;
                    especialidad.ShortName = txtNombreCorto.Text;

                    context.SaveChanges();

                    MessageBox.Show("Se actualizo satisfactoriamente");
                }
               

                this.Close();

                frmmFather.updateDGVEspecialidades();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema");
            }

        }

        
    }
}
