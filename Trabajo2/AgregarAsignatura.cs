using BL;
using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    public partial class AgregarAsignatura : Form
    {

        public AgregarAsignatura()
        {
            InitializeComponent();
        }

        private AsignaturaBL asignaturaBL = new AsignaturaBL();

        private void LoadAsignaturas()
        {
            dgvAsignaturas.DataSource = asignaturaBL.ObtenerTodasLasAsignaturas();
        }

        private void dgvAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAsignaturas.Rows[e.RowIndex];
                txAsignatura.Text = row.Cells["NombreAsig"].Value.ToString();
                txCreditos.Text = row.Cells["Creditos"].Value.ToString();
            }
        }

        private void btnActualizarAsignatura_Click(object sender, EventArgs e)
        {
            if (dgvAsignaturas.SelectedRows.Count > 0)
            {
                // Recupera el CodigoAsignatura de la fila seleccionada
                int codigoAsignatura = Convert.ToInt32(dgvAsignaturas.SelectedRows[0].Cells["CodigoAsignatura"].Value);

                // Crea un objeto Asignatura con los datos actualizados
                Asignatura asignatura = new Asignatura
                {
                    CodigoAsignatura = codigoAsignatura,
                    NombreAsignatura = txAsignatura.Text,
                    Creditos = int.Parse(txCreditos.Text)
                };

                // Llama al método de actualización en BL
                asignaturaBL.ActualizarAsignatura(asignatura);

                MessageBox.Show("Asignatura actualizada con éxito.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una asignatura para actualizar.");
            }
        }

        private void btnEliminarAsignatura_Click(object sender, EventArgs e)
        {
            if (dgvAsignaturas.SelectedRows.Count > 0)
            {
                int codigoAsignatura = int.Parse(dgvAsignaturas.SelectedRows[0].Cells["CodigoAsignatura"].Value.ToString());
                asignaturaBL.EliminarAsignatura(codigoAsignatura);
                MessageBox.Show("Asignatura eliminada con éxito.");
            }
            else
            {
                MessageBox.Show("Seleccione una asignatura para eliminar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Asignatura asignatura = new Asignatura
            {
                NombreAsignatura = txAsignatura.Text,
                Creditos = int.Parse(txCreditos.Text)
            };

            asignaturaBL.AgregarAsignatura(asignatura);
            MessageBox.Show("Asignatura guardada con éxito.");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var asignatura = asignaturaBL.ObtenerTodasLasAsignaturas();
            dgvAsignaturas.DataSource = asignatura;
        }
    }
}
