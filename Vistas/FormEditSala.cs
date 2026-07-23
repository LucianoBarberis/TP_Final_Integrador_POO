using System;
using System.Windows.Forms;
using Tp_Integrador_Final.Modelos;

namespace Tp_Integrador_Final.Vistas
{
    public partial class FormEditSala : Form
    {
        private SalaDeReuniones _salaEditada;

        public FormEditSala(SalaDeReuniones salaToEdit)
        {
            InitializeComponent();
            _salaEditada = salaToEdit;

            tbId.Text = salaToEdit.Id.ToString();
            tbNombre.Text = salaToEdit.Nombre;
            inpCapacidad.Value = salaToEdit.Capacidad;
            tbUbicacion.Text = salaToEdit.Ubicacion;
            tbEquipamiento.Text = salaToEdit.Equipamiento;
            cbDisponible.Checked = salaToEdit.Disponible;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();
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

            _salaEditada.Nombre = nombre;
            _salaEditada.Capacidad = capacidad;
            _salaEditada.Ubicacion = tbUbicacion.Text.Trim();
            _salaEditada.Equipamiento = tbEquipamiento.Text.Trim();
            _salaEditada.Disponible = cbDisponible.Checked;

            GestorDeDatos.RepositorioSalas.Actualizar(_salaEditada);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
