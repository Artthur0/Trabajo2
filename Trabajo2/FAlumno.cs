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
using BL;
using BOL;

namespace Trabajo2
{
    public partial class FAlumno : Form
    {
        public FAlumno()
        {
            InitializeComponent();
            LoadAlumnos();
        }

        private AlumnoBL alumnoBL = new AlumnoBL();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno
            {
                Nombre = txNombre.Text,
                ApellidoPat = txApPat.Text,
                ApellidoMat = txApMat.Text,
                Email = txEmail.Text,
                NumeroMatricula = txNumMatri.Text
            };
            alumnoBL.AgregarAlumno(alumno);
            MessageBox.Show("Alumno guardado con éxito.");
            LoadAlumnos();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                Alumno alumno = new Alumno
                {
                    IDAlumno = Convert.ToInt32(dgvAlumnos.SelectedRows[0].Cells["IDAlumno"].Value),
                    Nombre = txNombre.Text,
                    ApellidoPat = txApPat.Text,
                    ApellidoMat = txApMat.Text,
                    Email = txEmail.Text,
                    NumeroMatricula = txNumMatri.Text
                };
                alumnoBL.ActualizarAlumno(alumno);
                MessageBox.Show("Alumno actualizado con éxito.");
                LoadAlumnos();
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                int idAlumno = Convert.ToInt32(dgvAlumnos.SelectedRows[0].Cells["IDAlumno"].Value);
                alumnoBL.EliminarAlumno(idAlumno);
                MessageBox.Show("Alumno eliminado con éxito.");
                LoadAlumnos();
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para eliminar.");
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAlumnos.Rows[e.RowIndex];
                txNombre.Text = row.Cells["Nombre"].Value.ToString();
                txApPat.Text = row.Cells["ApellidoPat"].Value.ToString();
                txApMat.Text = row.Cells["ApellidoMat"].Value.ToString();
                txEmail.Text = row.Cells["Email"].Value.ToString();
                txNumMatri.Text = row.Cells["NumeroMatricula"].Value.ToString();
            }
        }

        private void LoadAlumnos()
        {
            dgvAlumnos.DataSource = alumnoBL.ObtenerTodosLosAlumnos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var alumnos = alumnoBL.ListarAlumnos();
            dgvAlumnos.DataSource = alumnos;
        }
    }
}
