using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tp_Integrador_Final.Enums;
using Tp_Integrador_Final.Modelos;

namespace Tp_Integrador_Final.Vistas
{
    public partial class FormReportes : Form
    {
        private enum ReporteActivo { Ninguno, ReservasDelDia, UsoPorSala, Ranking }
        private ReporteActivo _reporteActual = ReporteActivo.Ninguno;

        public FormReportes()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Today;
            dtpFecha.ValueChanged += (s, e) => CargarReservasDelDia();
            panelFecha.Visible = false;
        }

        private void btnReservasDelDia_Click(object? sender, EventArgs e)
        {
            _reporteActual = ReporteActivo.ReservasDelDia;
            panelFecha.Visible = true;
            ConfigurarDGVReservasDelDia();
            CargarReservasDelDia();
        }

        private void btnUsoPorSala_Click(object? sender, EventArgs e)
        {
            _reporteActual = ReporteActivo.UsoPorSala;
            panelFecha.Visible = false;
            ConfigurarDGVSimple();
            CargarUsoPorSala();
        }

        private void btnRanking_Click(object? sender, EventArgs e)
        {
            _reporteActual = ReporteActivo.Ranking;
            panelFecha.Visible = false;
            ConfigurarDGVRanking();
            CargarRanking();
        }

        #region Configuracion de columnas

        private void ConfigurarDGVReservasDelDia()
        {
            dgvReporte.Columns.Clear();
            dgvReporte.AutoGenerateColumns = false;

            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn { Name = "Sala", HeaderText = "Sala", DataPropertyName = "Sala", FillWeight = 20 });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoraInicio", HeaderText = "Inicio", DataPropertyName = "HoraInicio", FillWeight = 12 });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoraFin", HeaderText = "Fin", DataPropertyName = "HoraFin", FillWeight = 12 });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn { Name = "Motivo", HeaderText = "Motivo", DataPropertyName = "Motivo", FillWeight = 25 });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn { Name = "Usuario", HeaderText = "Usuario", DataPropertyName = "Usuario", FillWeight = 16 });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado", DataPropertyName = "Estado", FillWeight = 10 });

            dgvReporte.CellFormatting -= DgvReporte_CellFormatting;
            dgvReporte.CellFormatting += DgvReporte_CellFormatting;
        }

        private void ConfigurarDGVSimple()
        {
            dgvReporte.Columns.Clear();
            dgvReporte.AutoGenerateColumns = false;

            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Posicion",
                HeaderText = "#",
                DataPropertyName = "Posicion",
                FillWeight = 8,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn { Name = "Sala", HeaderText = "Sala", DataPropertyName = "Sala", FillWeight = 60 });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Reservas",
                DataPropertyName = "Cantidad",
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvReporte.CellFormatting -= DgvReporte_CellFormatting;
        }

        private void ConfigurarDGVRanking()
        {
            dgvReporte.Columns.Clear();
            dgvReporte.AutoGenerateColumns = false;

            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Posicion",
                HeaderText = "#",
                DataPropertyName = "Posicion",
                FillWeight = 8,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn { Name = "Sala", HeaderText = "Sala", DataPropertyName = "Sala", FillWeight = 50 });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Reservas",
                DataPropertyName = "Cantidad",
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Porcentaje",
                HeaderText = "Demanda",
                DataPropertyName = "Porcentaje",
                FillWeight = 12,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvReporte.CellFormatting -= DgvReporte_CellFormatting;
        }

        #endregion

        #region Carga de datos

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
                    Sala = sala?.Nombre ?? "\u2014",
                    r.HoraInicio,
                    r.HoraFin,
                    r.Motivo,
                    Usuario = usuario?.Name ?? "\u2014",
                    Estado = r.Estado switch
                    {
                        ReservaEstadoEnum.Pendiente => "Pendiente",
                        ReservaEstadoEnum.Confirmada => "Confirmada",
                        ReservaEstadoEnum.Cancelada => "Cancelada",
                        _ => r.Estado.ToString()
                    }
                };
            }).ToList();

            dgvReporte.DataSource = null;
            dgvReporte.DataSource = new BindingList<object>(data.Cast<object>().ToList());
        }

        private void CargarUsoPorSala()
        {
            var usoPorSala = GestorDeDatos.RepositorioReservas.Listar()
                .Where(r => r.Estado != ReservaEstadoEnum.Cancelada)
                .GroupBy(r => r.SalaId)
                .Select(g => new { SalaId = g.Key, Cantidad = g.Count() })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            int posicion = 1;
            var data = usoPorSala.Select(x =>
            {
                SalaDeReuniones sala = GestorDeDatos.RepositorioSalas.Obtener(x.SalaId);
                return new
                {
                    Posicion = posicion++,
                    Sala = sala?.Nombre ?? "\u2014",
                    x.Cantidad
                };
            }).ToList();

            dgvReporte.DataSource = null;
            dgvReporte.DataSource = new BindingList<object>(data.Cast<object>().ToList());
        }

        private void CargarRanking()
        {
            var ranking = GestorDeDatos.RepositorioReservas.Listar()
                .Where(r => r.Estado != ReservaEstadoEnum.Cancelada)
                .GroupBy(r => r.SalaId)
                .Select(g => new { SalaId = g.Key, Cantidad = g.Count() })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            int posicion = 1;
            var data = ranking.Select(x =>
            {
                SalaDeReuniones sala = GestorDeDatos.RepositorioSalas.Obtener(x.SalaId);
                return new
                {
                    Posicion = posicion++,
                    Sala = sala?.Nombre ?? "\u2014",
                    Cantidad = x.Cantidad,
                    Porcentaje = ranking.Count > 0
                        ? $"{x.Cantidad * 100.0 / ranking.Max(r => r.Cantidad):F0}%"
                        : "\u2014"
                };
            }).ToList();

            dgvReporte.DataSource = null;
            dgvReporte.DataSource = new BindingList<object>(data.Cast<object>().ToList());
        }

        #endregion

        private void DgvReporte_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvReporte.Rows[e.RowIndex];
            var colName = dgvReporte.Columns[e.ColumnIndex].Name;

            if (colName == "HoraInicio" || colName == "HoraFin")
            {
                var prop = row.DataBoundItem?.GetType().GetProperty(colName);
                if (prop?.GetValue(row.DataBoundItem) is TimeSpan ts)
                    e.Value = $"{ts.Hours:D2}:{ts.Minutes:D2}";
                e.FormattingApplied = true;
            }
        }

        #region Exportar CSV

        private void btnExportar_Click(object? sender, EventArgs e)
        {
            if (_reporteActual == ReporteActivo.Ninguno)
            {
                MessageBox.Show("Seleccione un reporte antes de exportar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string nombreArchivo = _reporteActual switch
            {
                ReporteActivo.ReservasDelDia => "ReservasDelDia",
                ReporteActivo.UsoPorSala => "UsoPorSala",
                ReporteActivo.Ranking => "RankingSalas",
                _ => "Reporte"
            };

            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo CSV (*.csv)|*.csv";
            sfd.FileName = $"{nombreArchivo}_{DateTime.Today:yyyyMMdd}.csv";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                var sb = new StringBuilder();

                foreach (DataGridViewColumn col in dgvReporte.Columns)
                {
                    sb.Append(EscapeCsv(col.HeaderText));
                    sb.Append(';');
                }
                sb.AppendLine();

                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string valor = cell.FormattedValue?.ToString() ?? "";
                        sb.Append(EscapeCsv(valor));
                        sb.Append(';');
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Archivo exportado correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string EscapeCsv(string valor)
        {
            if (valor.Contains(';') || valor.Contains('"') || valor.Contains('\n'))
                return $"\"{valor.Replace("\"", "\"\"")}\"";
            return valor;
        }

        #endregion
    }
}
