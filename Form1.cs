using System.Text.RegularExpressions;
using System;
using System.Windows.Forms;
namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblRequisitos_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Regex validacion = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^\\w+$]).*$");

            if (string.IsNullOrEmpty(txtcontraUno.Text) &&
                string.IsNullOrEmpty(txtcontraDos.Text))
            {
                MessageBox.Show("Los campos est�n vac�os");
                return;
            }

            if (!txtcontraUno.Text.Equals(txtcontraDos.Text))
            {
                MessageBox.Show("Las contrase�as no son iguales");
                return;
            }

            if (validacion.IsMatch(txtcontraUno.Text))
            {
                MessageBox.Show("La Contrase�a es Valida");
                return;
            }
            else
            {
                MessageBox.Show("La Contrase�a NO es Valida");
                return;
            }
        }

        private void txtcontraUno_TextChanged(object sender, EventArgs e)
        {
            // Expresi�n regular para validar la contrase�a
            Regex validacion = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^\\w+@]).*$");

            // Verificar si la contrase�a cumple con los requisitos
            bool esValida = validacion.IsMatch(txtcontraUno.Text) && !txtcontraUno.Text.Contains("@");

            // Mostrar mensajes seg�n los requisitos no cumplidos
            string mensaje = "La contrase�a debe contener al menos:";
            if (!Regex.IsMatch(txtcontraUno.Text, "(?=.*[a-z])"))
            {
                mensaje += "\n- Una letra min�scula";
            }
            if (!Regex.IsMatch(txtcontraUno.Text, "(?=.*[A-Z])"))
            {
                mensaje += "\n- Una letra may�scula";
            }
            if (!Regex.IsMatch(txtcontraUno.Text, "(?=.*[0-9])"))
            {
                mensaje += "\n- Un n�mero";
            }
            if (!Regex.IsMatch(txtcontraUno.Text, "(?=.*[^\\w+$])"))
            {
                mensaje += "\n- Un car�cter especial o s�mbolo";
            }

            // Configurar la propiedad PasswordChar para ocultar la contrase�a
            txtcontraUno.PasswordChar = '*';

            // Si la contrase�a es v�lida, oculta el mensaje
            if (esValida)
            {
                lblRequisitos.Text = "";
            }
            else
            {
                lblRequisitos.Text = mensaje;
            }
        }

        private void txtcontraDos_TextChanged(object sender, EventArgs e)
        {
            // Expresi�n regular para validar la contrase�a
            Regex validacion = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^\\w+$]).*$");

            // Verificar si la contrase�a cumple con los requisitos
            bool esValida = validacion.IsMatch(txtcontraDos.Text);

            // Configurar la propiedad PasswordChar para ocultar los caracteres
            txtcontraDos.PasswordChar = esValida ? '\0' : '*';
        }
    }
}