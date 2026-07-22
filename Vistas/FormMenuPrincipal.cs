using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tp_Integrador_Final.Vistas
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            if (GestorDeDatos.usuarioLogeado.Rol == Enums.RolesEnum.Admin)
            {
                menuAdministradorToolStripMenuItem.Visible = true;
            }
            else
            {
                menuAdministradorToolStripMenuItem.Visible = false;
            }

            if (GestorDeDatos.usuarioLogeado.Rol == Enums.RolesEnum.Gerente)
            {
                gerenteToolStripMenuItem.Visible = true;
            }
            else
            {
                gerenteToolStripMenuItem.Visible = false;
            }

            lblUserName.Text = GestorDeDatos.usuarioLogeado.Name;
            lblRol.Text = GestorDeDatos.usuarioLogeado.Rol.ToString();
        }

        private void cerrarSesiónToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestionDeUsuarios().ShowDialog();
        }

        private void salasDeReunionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestionSalas().ShowDialog();
        }
    }
}
