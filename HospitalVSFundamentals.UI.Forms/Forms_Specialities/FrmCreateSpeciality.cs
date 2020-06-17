using HospitalVSFundamentals.UI.Forms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms.Forms_Specialities
{
    public partial class FrmCreateSpeciality : Form
    {

        protected BD_HospitalVSFundamentalsEntities context = new BD_HospitalVSFundamentalsEntities();
        public Frm_Speciality frmmFather = new Frm_Speciality();

        public FrmCreateSpeciality()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                var speciality = context.Speciality.Add(new Speciality {  Name = txtNombre.Text, ShortName = txtNombreCorto.Text});

                context.SaveChanges();
                frmmFather.updateDGVEspecialidades();
                MessageBox.Show("Se registro satisfactoriamente." + speciality.SpecialityId.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en el sistema.");

            }

        }
    }
}
