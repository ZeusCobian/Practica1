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
                MessageBox.Show("Los campos están vacíos");
                return;
            }

            if (!txtcontraUno.Text.Equals(txtcontraDos.Text))
            {
                MessageBox.Show("Las contraseñas no son iguales");
                return;
            }

            if (validacion.IsMatch(txtcontraUno.Text))
            {
                MessageBox.Show("La Contraseña es Valida");
                return;
            }
            else
            {
                MessageBox.Show("La Contraseña NO es Valida");
                return;
            }
        }

        private void txtcontraUno_TextChanged(object sender, EventArgs e)
        {
            // Expresión regular para validar la contraseña
            Regex validacion = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^\\w+@]).*$");

            // Verificar si la contraseña cumple con los requisitos
            bool esValida = validacion.IsMatch(txtcontraUno.Text) && !txtcontraUno.Text.Contains("@");

            // Mostrar mensajes según los requisitos no cumplidos
            string mensaje = "La contraseña debe contener al menos:";
            if (!Regex.IsMatch(txtcontraUno.Text, "(?=.*[a-z])"))
            {
                mensaje += "\n- Una letra minúscula";
            }
            if (!Regex.IsMatch(txtcontraUno.Text, "(?=.*[A-Z])"))
            {
                mensaje += "\n- Una letra mayúscula";
            }
            if (!Regex.IsMatch(txtcontraUno.Text, "(?=.*[0-9])"))
            {
                mensaje += "\n- Un número";
            }
            if (!Regex.IsMatch(txtcontraUno.Text, "(?=.*[^\\w+$])"))
            {
                mensaje += "\n- Un carácter especial o símbolo";
            }

            // Configurar la propiedad PasswordChar para ocultar la contraseña
            txtcontraUno.PasswordChar = '*';

            // Si la contraseña es válida, oculta el mensaje
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
            // Expresión regular para validar la contraseña
            Regex validacion = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^\\w+$]).*$");

            // Verificar si la contraseña cumple con los requisitos
            bool esValida = validacion.IsMatch(txtcontraDos.Text);

            // Configurar la propiedad PasswordChar para ocultar los caracteres
            txtcontraDos.PasswordChar = esValida ? '\0' : '*';
        }
    }
}