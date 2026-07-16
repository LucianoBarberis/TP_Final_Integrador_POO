using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tp_Integrador_Final.Enums;
using Tp_Integrador_Final.Modelos;

namespace Tp_Integrador_Final.Vistas
{
    public partial class FormEditUser : Form
    {
        public Usuario usuarioEditado { get; private set; }
        public FormEditUser(Usuario userToEdit)
        {
            InitializeComponent();
            usuarioEditado = userToEdit;
            tbId.Text = userToEdit.Id.ToString();
            tbLastReserva.Text = userToEdit.UltimaReserva?.ToString("yyyy-MM-dd") ?? "Sin Reservas...";
            tbName.Text = userToEdit.Name;
            tbPass.Text = userToEdit.Password;
            cbRol.SelectedIndex = (int)userToEdit.Rol;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbPass.PasswordChar = '\0';
            }
            else
            {
                tbPass.PasswordChar = '*';
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            usuarioEditado.Rol = (RolesEnum)cbRol.SelectedIndex;
            usuarioEditado.Name = tbName.Text;
            usuarioEditado.Password = tbPass.Text;
            GestorDeDatos.RepositorioUsuarios.Actualizar(usuarioEditado);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
