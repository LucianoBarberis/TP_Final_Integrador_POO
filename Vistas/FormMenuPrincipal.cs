using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tp_Integrador_Final.Enums;
using Tp_Integrador_Final.Excepciones;
using Tp_Integrador_Final.Modelos;

namespace Tp_Integrador_Final.Vistas
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();

            if (GestorDeDatos.usuarioLogeado.Rol == RolesEnum.Admin)
                menuAdministradorToolStripMenuItem.Visible = true;
            else
                menuAdministradorToolStripMenuItem.Visible = false;

            if (GestorDeDatos.usuarioLogeado.Rol == RolesEnum.Gerente)
                gerenteToolStripMenuItem.Visible = true;
            else
                gerenteToolStripMenuItem.Visible = false;

            lblUserName.Text = GestorDeDatos.usuarioLogeado.Name;
            lblRol.Text = GestorDeDatos.usuarioLogeado.Rol.ToString();
            
            ConfigurarDataGridView();
            CargarSalas();
            RefrescarDGV();
        }

        private void ConfigurarDataGridView()
        {
            dgvReservas.AutoGenerateColumns = false;
            dgvReservas.Columns.Clear();

            dgvReservas.ReadOnly = true;
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.MultiSelect = false;
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.AllowUserToResizeRows = false;
            dgvReservas.RowHeadersVisible = false;

            dgvReservas.BackgroundColor = Color.GhostWhite;
            dgvReservas.BorderStyle = BorderStyle.FixedSingle;
            dgvReservas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReservas.GridColor = Color.FromArgb(230, 230, 235);

            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250);

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Visible = false;
            dgvReservas.Columns.Add(colId);

            DataGridViewTextBoxColumn colSalaId = new DataGridViewTextBoxColumn();
            colSalaId.Name = "SalaId";
            colSalaId.DataPropertyName = "SalaId";
            colSalaId.HeaderText = "Sala ID";
            colSalaId.Visible = false;
            dgvReservas.Columns.Add(colSalaId);

            DataGridViewTextBoxColumn colSala = new DataGridViewTextBoxColumn();
            colSala.Name = "SalaNombre";
            colSala.HeaderText = "Sala";
            colSala.FillWeight = 15;
            dgvReservas.Columns.Add(colSala);

            DataGridViewTextBoxColumn colUsuarioId = new DataGridViewTextBoxColumn();
            colUsuarioId.Name = "UsuarioId";
            colUsuarioId.DataPropertyName = "UsuarioId";
            colUsuarioId.HeaderText = "Usuario ID";
            colUsuarioId.Visible = false;
            dgvReservas.Columns.Add(colUsuarioId);

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.Name = "FechaReserva";
            colFecha.DataPropertyName = "FechaReserva";
            colFecha.HeaderText = "Fecha";
            colFecha.FillWeight = 15;
            colFecha.DefaultCellStyle.Format = "yyyy-MM-dd";
            dgvReservas.Columns.Add(colFecha);

            DataGridViewTextBoxColumn colInicio = new DataGridViewTextBoxColumn();
            colInicio.Name = "HoraInicio";
            colInicio.DataPropertyName = "HoraInicio";
            colInicio.HeaderText = "Inicio";
            colInicio.FillWeight = 10;
            colInicio.DefaultCellStyle.Format = @"hh\:mm";
            dgvReservas.Columns.Add(colInicio);

            DataGridViewTextBoxColumn colFin = new DataGridViewTextBoxColumn();
            colFin.Name = "HoraFin";
            colFin.DataPropertyName = "HoraFin";
            colFin.HeaderText = "Fin";
            colFin.FillWeight = 10;
            colFin.DefaultCellStyle.Format = @"hh\:mm";
            dgvReservas.Columns.Add(colFin);

            DataGridViewTextBoxColumn colMotivo = new DataGridViewTextBoxColumn();
            colMotivo.Name = "Motivo";
            colMotivo.DataPropertyName = "Motivo";
            colMotivo.HeaderText = "Motivo";
            colMotivo.FillWeight = 10;
            dgvReservas.Columns.Add(colMotivo);

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado";
            colEstado.DataPropertyName = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.FillWeight = 10;
            dgvReservas.Columns.Add(colEstado);

            DataGridViewTextBoxColumn colDuracion = new DataGridViewTextBoxColumn();
            colDuracion.Name = "Duracion";
            colDuracion.HeaderText = "Duración";
            colDuracion.FillWeight = 10;
            dgvReservas.Columns.Add(colDuracion);

            dgvReservas.CellFormatting += DgvReservas_CellFormatting;
        }

        private void DgvReservas_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
            Reserva reserva = row.DataBoundItem as Reserva;
            if (reserva == null) return;

            if (dgvReservas.Columns[e.ColumnIndex].Name == "SalaNombre")
            {
                SalaDeReuniones sala = GestorDeDatos.RepositorioSalas.Obtener(reserva.SalaId);
                e.Value = sala?.Nombre ?? "—";
                e.FormattingApplied = true;
            }
            else if (dgvReservas.Columns[e.ColumnIndex].Name == "Duracion")
            {
                e.Value = $"{reserva.DuracionReserva.Hours}h {reserva.DuracionReserva.Minutes}m";
                e.FormattingApplied = true;
            }
            else if (dgvReservas.Columns[e.ColumnIndex].Name == "Estado")
            {
                e.Value = reserva.Estado switch
                {
                    ReservaEstadoEnum.Pendiente => "Pendiente",
                    ReservaEstadoEnum.Confirmada => "Confirmada",
                    ReservaEstadoEnum.Cancelada => "Cancelada",
                    _ => reserva.Estado.ToString()
                };
                e.FormattingApplied = true;
            }
        }

        private void CargarSalas()
        {
            cbSala.DataSource = GestorDeDatos.RepositorioSalas.Listar()
                .Where(s => s.Disponible).ToList();
            cbSala.DisplayMember = "Nombre";
            cbSala.ValueMember = "Id";

            if (cbSala.Items.Count > 0)
                cbSala.SelectedIndex = 0;
        }

        private void RefrescarDGV()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = new BindingList<Reserva>(
                GestorDeDatos.RepositorioReservas.Listar());
        }

        private void btnNewReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSala.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una sala.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SalaDeReuniones sala = (SalaDeReuniones)cbSala.SelectedItem;
                string motivo = tbMotivo.Text.Trim();
                DateTime fecha = dtpInitDate.Value.Date;
                TimeSpan horaInicio = new TimeSpan(dtpInitDate.Value.Hour, dtpInitDate.Value.Minute, 0);
                TimeSpan horaFin = new TimeSpan(dtpEndDate.Value.Hour, dtpEndDate.Value.Minute, 0);

                if (horaInicio >= horaFin)
                {
                    MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(motivo))
                {
                    MessageBox.Show("Ingrese un motivo para la reserva.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var reservas = GestorDeDatos.RepositorioReservas.Listar();

                bool solapa = reservas.Any(r =>
                    r.SalaId == sala.Id &&
                    r.FechaReserva.Date == fecha &&
                    r.Estado != ReservaEstadoEnum.Cancelada &&
                    r.HoraInicio < horaFin &&
                    r.HoraFin > horaInicio);

                if (solapa)
                {
                    throw new ReservaSolapadaException(
                        $"La sala \"{sala.Nombre}\" ya tiene una reserva en ese horario.");
                }

                int limite = GestorDeDatos.usuarioLogeado.ObtenerLimiteReservasSemanales();
                DateTime inicioSemana = fecha.AddDays(-(int)fecha.DayOfWeek);
                DateTime finSemana = inicioSemana.AddDays(7);

                int reservasSemana = reservas.Count(r =>
                    r.UsuarioId == GestorDeDatos.usuarioLogeado.Id &&
                    r.FechaReserva >= inicioSemana &&
                    r.FechaReserva < finSemana &&
                    r.Estado != ReservaEstadoEnum.Cancelada);

                if (reservasSemana >= limite)
                {
                    MessageBox.Show($"Ha alcanzado el límite semanal de {limite} reservas.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Reserva nuevaReserva = new Reserva(
                    sala.Id,
                    GestorDeDatos.usuarioLogeado.Id,
                    fecha,
                    horaInicio,
                    horaFin,
                    motivo);

                GestorDeDatos.RepositorioReservas.Agregar(nuevaReserva);

                GestorDeDatos.usuarioLogeado.TotalReservasSemana = reservasSemana + 1;
                GestorDeDatos.usuarioLogeado.UltimaReserva = fecha;
                GestorDeDatos.RepositorioUsuarios.Actualizar(GestorDeDatos.usuarioLogeado);

                RefrescarDGV();
                tbMotivo.Clear();
                dtpInitDate.Value = DateTime.Now;
                dtpEndDate.Value = DateTime.Now.AddHours(1);

                MessageBox.Show("Reserva creada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ReservaSolapadaException ex)
            {
                MessageBox.Show(ex.Message,
                    "Solapamiento de horarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la reserva: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para cancelar.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dgvReservas.SelectedRows[0].Cells["Id"].Value;
            Reserva reserva = GestorDeDatos.RepositorioReservas.Obtener(id);

            if (reserva == null)
            {
                MessageBox.Show("No se encontró la reserva seleccionada.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (reserva.Estado == ReservaEstadoEnum.Cancelada)
            {
                MessageBox.Show("Esta reserva ya está cancelada.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!GestorDeDatos.usuarioLogeado.PuedeCancelar(reserva))
            {
                MessageBox.Show("No tiene permisos para cancelar esta reserva.",
                    "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"¿Está seguro de cancelar la reserva del {reserva.FechaReserva:yyyy-MM-dd} " +
                $"de {reserva.HoraInicio:hh\\:mm} a {reserva.HoraFin:hh\\:mm}?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    reserva.Estado = ReservaEstadoEnum.Cancelada;
                    GestorDeDatos.RepositorioReservas.Actualizar(reserva);
                    RefrescarDGV();

                    MessageBox.Show("Reserva cancelada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cancelar la reserva: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cerrarSesiónToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestionDeUsuarios().ShowDialog();
        }

        private void salasDeReunionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGestionSalas().ShowDialog();
            CargarSalas();
        }
    }
}
