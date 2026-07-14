using System.Drawing.Drawing2D;
using Tp_Integrador_Final.Vistas;

namespace Tp_Integrador_Final
{
    public partial class Login : Form
    {
        private const string HardcodedUser = "admin";
        private const string HardcodedPass = "1234";

        public Login()
        {
            InitializeComponent();
            SetPlaceholderText();
        }

        private void SetPlaceholderText()
        {
            txtUser.Tag = "Ingrese su usuario";
            txtPass.Tag = "Ingrese su contraseña";
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Campos vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user == HardcodedUser && pass == HardcodedPass)
            {
                new FormMenuPrincipal().ShowDialog();
                user = string.Empty;
                pass = string.Empty;
                txtUser.Text = string.Empty;
                txtPass.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
