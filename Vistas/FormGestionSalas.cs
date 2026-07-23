using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tp_Integrador_Final.Modelos;

namespace Tp_Integrador_Final.Vistas
{
    public partial class FormGestionSalas : Form
    {
        public FormGestionSalas()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            RefrescarDGV();
        }

        private void ConfigurarDataGridView()
        {
            dgvSalas.AutoGenerateColumns = false;
            dgvSalas.Columns.Clear();

            dgvSalas.ReadOnly = true;
            dgvSalas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalas.MultiSelect = false;
            dgvSalas.AllowUserToAddRows = false;
            dgvSalas.AllowUserToDeleteRows = false;
            dgvSalas.AllowUserToResizeRows = false;
            dgvSalas.RowHeadersVisible = false;

            dgvSalas.BackgroundColor = Color.GhostWhite;
            dgvSalas.BorderStyle = BorderStyle.FixedSingle;
            dgvSalas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSalas.GridColor = Color.FromArgb(230, 230, 235);

            dgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250);

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Width = 80;
            colId.Visible = false;
            dgvSalas.Columns.Add(colId);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.FillWeight = 25;
            dgvSalas.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colCapacidad = new DataGridViewTextBoxColumn();
            colCapacidad.Name = "Capacidad";
            colCapacidad.DataPropertyName = "Capacidad";
            colCapacidad.HeaderText = "Capacidad";
            colCapacidad.FillWeight = 10;
            colCapacidad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSalas.Columns.Add(colCapacidad);

            DataGridViewTextBoxColumn colUbicacion = new DataGridViewTextBoxColumn();
            colUbicacion.Name = "Ubicacion";
            colUbicacion.DataPropertyName = "Ubicacion";
            colUbicacion.HeaderText = "Ubicación / Piso";
            colUbicacion.FillWeight = 20;
            dgvSalas.Columns.Add(colUbicacion);

            DataGridViewTextBoxColumn colEquipamiento = new DataGridViewTextBoxColumn();
            colEquipamiento.Name = "Equipamiento";
            colEquipamiento.DataPropertyName = "Equipamiento";
            colEquipamiento.HeaderText = "Equipamiento";
            colEquipamiento.FillWeight = 30;
            dgvSalas.Columns.Add(colEquipamiento);

            DataGridViewCheckBoxColumn colDisponible = new DataGridViewCheckBoxColumn();
            colDisponible.Name = "Disponible";
            colDisponible.DataPropertyName = "Disponible";
            colDisponible.HeaderText = "Disponible";
            colDisponible.FillWeight = 10;
            colDisponible.ReadOnly = true;
            dgvSalas.Columns.Add(colDisponible);
        }

        private void RefrescarDGV()
        {
            dgvSalas.DataSource = null;
            dgvSalas.DataSource = new BindingList<SalaDeReuniones>(
                GestorDeDatos.RepositorioSalas.Listar());
        }

        private void btnNewSala_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tbName.Text.Trim();
                string ubicacion = tbUbi.Text.Trim();
                string equipamiento = tbEquipamiento.Text.Trim();
                int capacidad = (int)inpCapacidad.Value;

                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("El nombre de la sala es obligatorio.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (capacidad <= 0)
                {
                    MessageBox.Show("La capacidad debe ser mayor a cero.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SalaDeReuniones nuevaSala = new SalaDeReuniones
                {
                    Nombre = nombre,
                    Capacidad = capacidad,
                    Ubicacion = ubicacion,
                    Equipamiento = equipamiento,
                    Disponible = true
                };

                GestorDeDatos.RepositorioSalas.Agregar(nuevaSala);
                RefrescarDGV();

                tbName.Clear();
                tbUbi.Clear();
                tbEquipamiento.Clear();
                inpCapacidad.Value = 0;

                MessageBox.Show("Sala creada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la sala: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditSala_Click(object sender, EventArgs e)
        {
            if (dgvSalas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una sala para editar.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dgvSalas.SelectedRows[0].Cells["Id"].Value;
            SalaDeReuniones salaSeleccionada = GestorDeDatos.RepositorioSalas.Obtener(id);

            if (salaSeleccionada == null)
            {
                MessageBox.Show("No se encontró la sala seleccionada.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var formEditSala = new FormEditSala(salaSeleccionada))
            {
                if (formEditSala.ShowDialog() == DialogResult.OK)
                {
                    RefrescarDGV();
                    MessageBox.Show("Sala actualizada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteSala_Click(object sender, EventArgs e)
        {
            if (dgvSalas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una sala para eliminar.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dgvSalas.SelectedRows[0].Cells["Id"].Value;
            string nombre = dgvSalas.SelectedRows[0].Cells["Nombre"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"¿Está seguro de eliminar la sala \"{nombre}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = GestorDeDatos.RepositorioSalas.Eliminar(id);
                    if (eliminado)
                    {
                        RefrescarDGV();
                        MessageBox.Show("Sala eliminada correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la sala.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la sala: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
