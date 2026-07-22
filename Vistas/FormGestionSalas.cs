using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tp_Integrador_Final.Vistas
{
    public partial class FormGestionSalas : Form
    {
        public FormGestionSalas()
        {
            InitializeComponent();
            ConfigurarDataGridView();
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

    }
}
