using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tp_Integrador_Final.Enums;
using Tp_Integrador_Final.Modelos;

namespace Tp_Integrador_Final.Vistas
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Today;
            ConfigurarDataGridViews();
            CargarReportes();
        }

        private void ConfigurarDataGridViews()
        {
            ConfigurarDGVReservasDelDia();
            ConfigurarDGVSala();
        }

        private void ConfigurarDGVReservasDelDia()
        {
            dgvReservasDelDia.AutoGenerateColumns = false;
            dgvReservasDelDia.Columns.Clear();

            DataGridViewTextBoxColumn colSala = new DataGridViewTextBoxColumn();
            colSala.Name = "Sala";
            colSala.HeaderText = "Sala";
            colSala.FillWeight = 20;
            dgvReservasDelDia.Columns.Add(colSala);

            DataGridViewTextBoxColumn colInicio = new DataGridViewTextBoxColumn();
            colInicio.Name = "HoraInicio";
            colInicio.HeaderText = "Inicio";
            colInicio.FillWeight = 12;
            dgvReservasDelDia.Columns.Add(colInicio);

            DataGridViewTextBoxColumn colFin = new DataGridViewTextBoxColumn();
            colFin.Name = "HoraFin";
            colFin.HeaderText = "Fin";
            colFin.FillWeight = 12;
            dgvReservasDelDia.Columns.Add(colFin);

            DataGridViewTextBoxColumn colMotivo = new DataGridViewTextBoxColumn();
            colMotivo.Name = "Motivo";
            colMotivo.HeaderText = "Motivo";
            colMotivo.FillWeight = 25;
            dgvReservasDelDia.Columns.Add(colMotivo);

            DataGridViewTextBoxColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.Name = "Usuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.FillWeight = 16;
            dgvReservasDelDia.Columns.Add(colUsuario);

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.FillWeight = 10;
            dgvReservasDelDia.Columns.Add(colEstado);

            dgvReservasDelDia.CellFormatting += DgvReservasDelDia_CellFormatting;
        }

        private void ConfigurarDGVSala()
        {
            dgvUsoPorSala.AutoGenerateColumns = false;
            dgvUsoPorSala.Columns.Clear();

            DataGridViewTextBoxColumn colPos = new DataGridViewTextBoxColumn();
            colPos.Name = "Posicion";
            colPos.HeaderText = "#";
            colPos.FillWeight = 8;
            colPos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsoPorSala.Columns.Add(colPos);

            DataGridViewTextBoxColumn colSala = new DataGridViewTextBoxColumn();
            colSala.Name = "Sala";
            colSala.HeaderText = "Sala";
            colSala.FillWeight = 60;
            dgvUsoPorSala.Columns.Add(colSala);

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.Name = "Cantidad";
            colCantidad.HeaderText = "Reservas";
            colCantidad.FillWeight = 20;
            colCantidad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsoPorSala.Columns.Add(colCantidad);

            // Ranking usa las mismas columnas
            dgvRanking.AutoGenerateColumns = false;
            dgvRanking.Columns.Clear();

            DataGridViewTextBoxColumn colRankPos = new DataGridViewTextBoxColumn();
            colRankPos.Name = "Posicion";
            colRankPos.HeaderText = "#";
            colRankPos.FillWeight = 8;
            colRankPos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRanking.Columns.Add(colRankPos);

            DataGridViewTextBoxColumn colRankSala = new DataGridViewTextBoxColumn();
            colRankSala.Name = "Sala";
            colRankSala.HeaderText = "Sala";
            colRankSala.FillWeight = 60;
            dgvRanking.Columns.Add(colRankSala);

            DataGridViewTextBoxColumn colRankCantidad = new DataGridViewTextBoxColumn();
            colRankCantidad.Name = "Cantidad";
            colRankCantidad.HeaderText = "Reservas";
            colRankCantidad.FillWeight = 20;
            colRankCantidad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRanking.Columns.Add(colRankCantidad);
        }

        private void CargarReportes()
        {
            try
            {
                CargarReservasDelDia();
                CargarUsoPorSala();
                CargarRanking();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reportes: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarReservasDelDia()
        {
            DateTime fecha = dtpFecha.Value.Date;

            var reservas = GestorDeDatos.RepositorioReservas.Listar()
                .Where(r => r.FechaReserva.Date == fecha)
                .OrderBy(r => r.HoraInicio)
                .ToList();

            var data = reservas.Select(r =>
            {
                SalaDeReuniones sala = GestorDeDatos.RepositorioSalas.Obtener(r.SalaId);
                Usuario usuario = GestorDeDatos.RepositorioUsuarios.Obtener(r.UsuarioId);
                return new
                {
                    r.Id,
                    Sala = sala?.Nombre ?? "—",
                    r.HoraInicio,
                    r.HoraFin,
                    r.Motivo,
                    Usuario = usuario?.Name ?? "—",
                    Estado = r.Estado switch
                    {
                        ReservaEstadoEnum.Pendiente => "Pendiente",
                        ReservaEstadoEnum.Confirmada => "Confirmada",
                        ReservaEstadoEnum.Cancelada => "Cancelada",
                        _ => r.Estado.ToString()
                    }
                };
            }).ToList();

            dgvReservasDelDia.DataSource = null;
            dgvReservasDelDia.DataSource = new BindingList<object>(data.Cast<object>().ToList());
        }

        private void DgvReservasDelDia_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvReservasDelDia.Rows[e.RowIndex];

            if (dgvReservasDelDia.Columns[e.ColumnIndex].Name == "HoraInicio")
            {
                var hora = row.DataBoundItem.GetType().GetProperty("HoraInicio")?.GetValue(row.DataBoundItem);
                if (hora is TimeSpan ts)
                    e.Value = $"{ts.Hours:D2}:{ts.Minutes:D2}";
                e.FormattingApplied = true;
            }
            else if (dgvReservasDelDia.Columns[e.ColumnIndex].Name == "HoraFin")
            {
                var hora = row.DataBoundItem.GetType().GetProperty("HoraFin")?.GetValue(row.DataBoundItem);
                if (hora is TimeSpan ts)
                    e.Value = $"{ts.Hours:D2}:{ts.Minutes:D2}";
                e.FormattingApplied = true;
            }
        }

        private void CargarUsoPorSala()
        {
            var usoPorSala = GestorDeDatos.RepositorioReservas.Listar()
                .Where(r => r.Estado != ReservaEstadoEnum.Cancelada)
                .GroupBy(r => r.SalaId)
                .Select(g => new
                {
                    SalaId = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            int posicion = 1;
            var data = usoPorSala.Select(x =>
            {
                SalaDeReuniones sala = GestorDeDatos.RepositorioSalas.Obtener(x.SalaId);
                return new
                {
                    Posicion = posicion++,
                    Sala = sala?.Nombre ?? "—",
                    x.Cantidad
                };
            }).ToList();

            dgvUsoPorSala.DataSource = null;
            dgvUsoPorSala.DataSource = new BindingList<object>(data.Cast<object>().ToList());
        }

        private void CargarRanking()
        {
            var ranking = GestorDeDatos.RepositorioReservas.Listar()
                .Where(r => r.Estado != ReservaEstadoEnum.Cancelada)
                .GroupBy(r => r.SalaId)
                .Select(g => new
                {
                    SalaId = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            int posicion = 1;
            var data = ranking.Select(x =>
            {
                SalaDeReuniones sala = GestorDeDatos.RepositorioSalas.Obtener(x.SalaId);
                return new
                {
                    Posicion = posicion++,
                    Sala = sala?.Nombre ?? "—",
                    Cantidad = x.Cantidad,
                    Porcentaje = ranking.Count > 0
                        ? $"{x.Cantidad * 100.0 / ranking.Max(r => r.Cantidad):F0}%"
                        : "—"
                };
            }).ToList();

            dgvRanking.DataSource = null;
            dgvRanking.DataSource = new BindingList<object>(data.Cast<object>().ToList());

            if (dgvRanking.Columns["Porcentaje"] == null)
            {
                DataGridViewTextBoxColumn colPorcentaje = new DataGridViewTextBoxColumn();
                colPorcentaje.Name = "Porcentaje";
                colPorcentaje.HeaderText = "Demanda";
                colPorcentaje.DataPropertyName = "Porcentaje";
                colPorcentaje.FillWeight = 12;
                colPorcentaje.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRanking.Columns.Add(colPorcentaje);
            }
        }

        private void btnActualizar_Click(object? sender, EventArgs e)
        {
            CargarReservasDelDia();
        }
    }
}
