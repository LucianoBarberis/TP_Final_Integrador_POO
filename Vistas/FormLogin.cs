using System.Drawing.Drawing2D;
using Tp_Integrador_Final.Modelos;
using Tp_Integrador_Final.Vistas;

namespace Tp_Integrador_Final
{
    public partial class Login : Form
    {
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
            List<Usuario> ListaDeUsuarios = GestorDeDatos.RepositorioUsuarios.Listar();
            string name = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Campos vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ListaDeUsuarios.Any(user => user.Name == name))
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario? userToLogin = ListaDeUsuarios.FirstOrDefault(user => user.Name == name);

            if (userToLogin == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userToLogin.Password == pass)
            {
                GestorDeDatos.usuarioLogeado = userToLogin;
                new FormMenuPrincipal().ShowDialog();
                name = string.Empty;
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
