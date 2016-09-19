using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Tarea
{
    public partial class ContactoWebForm : System.Web.UI.Page
    {

        Mensajes mensaje = new Mensajes();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void ObtenerValores()
        {
            mensaje.Email = EmailTextBox.Text;
            mensaje.Asunto = AsuntoTextBox.Text;
            mensaje.Mensaje = MensajeTextBox.Text;
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            ObtenerValores();
           
            if (EmailTextBox.Text != "" && AsuntoTextBox.Text != "" && MensajeTextBox.Text != "")
            {
                if (mensaje.Insertar())
                {
                }
                else
                {
                }
            }
        }

        protected void VolverButton_Click(object sender, EventArgs e)
        {

        }
    }
}