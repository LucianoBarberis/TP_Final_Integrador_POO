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
            RefrescarDGV();
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
            dgvUsers.BorderStyle = BorderStyle.FixedSingle;
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
            colPass.FillWeight = 15;
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
        private void RefrescarDGV()
        {
            usuariosBindingList = new BindingList<Usuario>(
                GestorDeDatos.RepositorioUsuarios.Listar());
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = usuariosBindingList;
        }
        private BindingList<Usuario> usuariosBindingList;
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
            Usuario newUser;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (cbRol.SelectedIndex)
            {
                case 0:
                    newUser = new Administrador();
                    break;
                case 1:
                    newUser = new Gerente();
                    break;
                case 2:
                    newUser = new Empleado();
                    break;
                default:
                    MessageBox.Show($"Por favor, seleccione un rol válido. {cbRol.SelectedIndex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            newUser.Name = name;
            newUser.Password = password;
            GestorDeDatos.RepositorioUsuarios.Agregar(newUser);
            RefrescarDGV();
            tbName.Clear();
            tbPass.Clear();
            MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            Usuario userSelected;
            switch (cbRol.SelectedIndex)
            {
                case 0:
                    userSelected = new Administrador();
                    break;
                case 1:
                    userSelected = new Gerente();
                    break;
                case 2:
                    userSelected = new Empleado();
                    break;
            }
            int id = (int)dgvUsers.SelectedRows[0].Cells[0].Value;
            userSelected = GestorDeDatos.RepositorioUsuarios.Obtener(id);
            var formEditUser = new FormEditUser(userSelected);
            if (formEditUser.ShowDialog() == DialogResult.OK)
            {
                RefrescarDGV();
            }
            else
            {
                MessageBox.Show("Se cancelo la operación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RefrescarDGV();
        }
    }
}
