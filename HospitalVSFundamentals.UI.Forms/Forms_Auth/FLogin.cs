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

namespace HospitalVSFundamentals.UI.Forms
{
    public partial class FLogin : Form
    {

        UserBC userbc = new UserBC();

        public FLogin()
        {
            InitializeComponent();

            gbPanel.BackColor = Color.FromArgb(25, Color.Black);

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                UserLoginBE ulogin = new UserLoginBE();

                if (txtPassword.Text.Length == 0 && txtUsername.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese sus datos.");
                }
                else if (txtPassword.Text.Length == 0 || txtUsername.Text.Length == 0)
                {
                    MessageBox.Show("Usuario y/o contrasenia esta vacia");
                }
                else
                {
                    ulogin = userbc.getLogin(txtUsername.Text, txtPassword.Text);
                    if (ulogin.IdUser == null)
                    {
                        MessageBox.Show("Usuario y/o contrasenia incorrecto.");
                    }
                    else
                    {
                        ////redirigir al main
                        this.Hide();
                        switch (ulogin.Role.ToString())
                        {
                            case "ADM":
                                var frmMainAdm = new FMainAdm();
                                frmMainAdm.ulogin = ulogin;
                                frmMainAdm.Show(); break;
                            case "MDC":
                                var frmMainMdc = new FMainAdm();
                                frmMainMdc.ulogin = ulogin;
                                frmMainMdc.Show(); break;
                            case "PCN":
                                var frmMainPcn = new FMainAdm();
                                frmMainPcn.ulogin = ulogin;
                                frmMainPcn.Show(); break;
                            default:
                                MessageBox.Show("Usuario no tiene rol asignado");
                                break;
                        }
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en el sistema.");
            }

}

private void llOlvidoContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{

    try
    {
        var frmForgotPassword = new FForgotPassword();
        frmForgotPassword.Show();
    }
    catch (Exception)
    {
        MessageBox.Show("Ocurrio un error en el sistema.");
    }

}
    }
}
