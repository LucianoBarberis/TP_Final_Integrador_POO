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
    public partial class FormGestionDeUsuarios : Form
    {
        public FormGestionDeUsuarios()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            dgvUsers.DataSource = usuariosBindingList;
            cbRol.SelectedIndex = 2;
        }
        private void ConfigurarDataGridView()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.Columns.Clear();

            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.RowHeadersVisible = false;

            dgvUsers.BackgroundColor = Color.GhostWhite;
            dgvUsers.BorderStyle = BorderStyle.FixedSingle  ;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.GridColor = Color.FromArgb(230, 230, 235);

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250);

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Width = 80;
            colId.Visible = false;
            dgvUsers.Columns.Add(colId);

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "Name";
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Nombre";
            colName.FillWeight = 30;
            dgvUsers.Columns.Add(colName);

            DataGridViewTextBoxColumn colRol = new DataGridViewTextBoxColumn();
            colRol.Name = "Rol";
            colRol.DataPropertyName = "Rol";
            colRol.HeaderText = "Rol";
            colRol.FillWeight = 15;
            dgvUsers.Columns.Add(colRol);

            DataGridViewTextBoxColumn colPass = new DataGridViewTextBoxColumn();
            colPass.Name = "Password";
            colPass.DataPropertyName = "Password";
            colPass.HeaderText = "Contraseña";
            colPass.Visible = false;
            dgvUsers.Columns.Add(colPass);

            DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn();
            colTotal.Name = "TotalReservasSemana";
            colTotal.DataPropertyName = "TotalReservasSemana";
            colTotal.HeaderText = "Reservas Semana";
            colTotal.FillWeight = 15;
            colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.Columns.Add(colTotal);

            DataGridViewTextBoxColumn colUltima = new DataGridViewTextBoxColumn();
            colUltima.Name = "UltimaReserva";
            colUltima.DataPropertyName = "UltimaReserva";
            colUltima.HeaderText = "Última Reserva";
            colUltima.FillWeight = 20;
            colUltima.DefaultCellStyle.Format = "yyyy-MM-dd";
            colUltima.DefaultCellStyle.NullValue = "— Sin reservas —";

            dgvUsers.Columns.Add(colUltima);
        }
        private BindingList<Usuario> usuariosBindingList = new BindingList<Usuario>(GestorDeDatos.RepositorioUsuarios.Listar());
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string password = tbPass.Text.Trim();
            RolesEnum rol = (RolesEnum)cbRol.SelectedIndex;
            Usuario newUser;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rol == RolesEnum.Admin)
            {
                newUser = new Administrador();
                
            }
            if (rol == RolesEnum.Gerente)
            {
                newUser = new Gerente();
               
            }
            if (rol == RolesEnum.Empleado)
            {
                newUser = new Empleado();
            }

        }
    }
}
