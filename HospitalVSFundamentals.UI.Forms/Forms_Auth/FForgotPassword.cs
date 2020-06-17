using HospitalVSFundamentals.BL.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalVSFundamentals.UI.Forms
{
    public partial class FForgotPassword : Form
    {
        UserBC userbc = new UserBC();

        public FForgotPassword()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                var user = userbc.getUserByEmail(txtEmail.Text);

                if (user.IdUser == null)
                {
                    MessageBox.Show("El correo ingresado no se encuentra en la base de datos.");
                }
                else
                {

                    //hacemos el envio de correo
                    //1 creamos el mailMessge y el smtpclient
                    MailMessage mail = new MailMessage();
                    SmtpClient smtpServer = new SmtpClient();

                    //2 creamos el cuerpo y accesos del mensaje
                    mail.From = new MailAddress("hospitalvsfundamental@gmail.com");
                    mail.To.Add(txtEmail.Text);
                    mail.Subject = "Hospital VSFundamentals - Recuperar contraseña";
                    //tip crear un utilitario para armar todo el template del correo
                    //si quieres hacer un disenio de correo al estilo saga falabella
                    // no hacerlos con divs sino con table de table
                    //nota: el gmail no importa estilos solo maneja html puro
                    // pagina de templates para email free https://w3layouts.com/email-templates/
                    mail.Body = @"<div style='background-color: #f0f02;'>
                                    <p>Hola " + user.Name + " " + user.LastName + @" usted ha solicitado recuperar su contraseña. </p>
                                    <p>Su contraseña es: " + user.Password + @"</p>
                                  </div>";
                    mail.IsBodyHtml = true;
                    //configuracion del mail server (en este caso usamos Gmail)
                    smtpServer.Port = 587;
                    smtpServer.Host = "smtp.gmail.com";
                    smtpServer.UseDefaultCredentials = false;
                    smtpServer.Credentials = new NetworkCredential("hospitalvsfundamental@gmail.com","123Fundamental");
                    smtpServer.EnableSsl = true;
                    smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    //Si sale error de autorizacion en el servidor de Gmail tienes que configurar la seguridad
                    //de la cuenta gmail para que puedas iniciar sesion desde cualquier dispositivo.
                    //error: (El servidor SMTP requiere una conexión segura o el cliente no se autenticó. La respuesta del servidor fue: 5.7.0 Authentication Required. Learn more at)
                    //url para habilitar el permiso: https://myaccount.google.com/lesssecureapps
                    smtpServer.Send(mail);

                    MessageBox.Show("Se le envio un correo con su contraseña");

                    this.Close();

                }


            }
            catch (Exception ex )
            {

                MessageBox.Show("Ocurrio un error en el sistema.");
            }

        }
    }
}
