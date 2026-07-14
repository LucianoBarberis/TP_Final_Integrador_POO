using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tp_Integrador_Final.Vistas
{
    public partial class FormGestionDeUsuarios : Form
    {
        public FormGestionDeUsuarios()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked)
            {
                tbPass.PasswordChar = '\0';
            }else
            {
                tbPass.PasswordChar = '*';
            }
        }
    }
}
