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
            LoadAsignaturas();
        }

        private void LoadAsignaturas()
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                var command = new SqlCommand("SELECT * FROM Asignaturas", db.GetConnection());
                var adapter = new SqlDataAdapter(command);
                var table = new System.Data.DataTable();
                adapter.Fill(table);
                dgvAsignaturas.DataSource = table;
                db.CloseConnection();
            }
        }

        private void dgvAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAsignaturas.Rows[e.RowIndex];
                txAsignatura.Text = row.Cells["NombreAsignatura"].Value.ToString();
                txCreditos.Text = row.Cells["Creditos"].Value.ToString();
            }
        }

        private void btnActualizarAsignatura_Click(object sender, EventArgs e)
        {
            if (dgvAsignaturas.SelectedRows.Count > 0)
            {
                // Obtener el código de la asignatura seleccionada
                int codigoAsignatura = Convert.ToInt32(dgvAsignaturas.SelectedRows[0].Cells["CodigoAsignatura"].Value);

                using (var db = new DatabaseConnection())
                {
                    db.OpenConnection();
                    // Consulta SQL para actualizar la asignatura
                    var command = new SqlCommand("UPDATE Asignaturas SET NombreAsignatura = @NombreAsignatura, Creditos = @Creditos  " + "WHERE CodigoAsignatura = @CodigoAsignatura", db.GetConnection());

                    command.Parameters.AddWithValue("@NombreAsignatura", txAsignatura.Text);
                    command.Parameters.AddWithValue("@Creditos", Convert.ToInt32(txCreditos.Text));
                    command.Parameters.AddWithValue("@CodigoAsignatura", codigoAsignatura);

                    command.ExecuteNonQuery();
                    db.CloseConnection();

                    MessageBox.Show("Asignatura actualizada correctamente.");
                    LoadAsignaturas(); // Recargar la lista de asignaturas para reflejar los cambios
                }
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
                // Obtener el código de la asignatura seleccionada
                int codigoAsignatura = Convert.ToInt32(dgvAsignaturas.SelectedRows[0].Cells["CodigoAsignatura"].Value);

                using (var db = new DatabaseConnection())
                {
                    db.OpenConnection();
                    // Consulta SQL para eliminar la asignatura
                    var command = new SqlCommand("DELETE FROM Asignaturas WHERE CodigoAsignatura = @CodigoAsignatura", db.GetConnection());
                    command.Parameters.AddWithValue("@CodigoAsignatura", codigoAsignatura);

                    command.ExecuteNonQuery();
                    db.CloseConnection();

                    MessageBox.Show("Asignatura eliminada correctamente.");
                    LoadAsignaturas(); // Recargar la lista de asignaturas para reflejar los cambios
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una asignatura para eliminar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //esta variable sirve para identificar si el valor de creditos es un número
            decimal cred;
            bool real = decimal.TryParse(txCreditos.Text, out cred);

            //esto es para validar que los campos esten con algun valor
            if (String.IsNullOrEmpty(txAsignatura.Text))
            {
                MessageBox.Show("Ingrese una Asignatura valida");
                txAsignatura.Focus();
                return;
            }
            if (!real)
            {
                MessageBox.Show("Ingresa un valor valido para los creditos");
                txCreditos.Focus();
                return;
            }
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                var command = new SqlCommand("INSERT INTO Asignaturas (NombreAsignatura, Creditos)" + "VALUES (@NombreAsignatura, @Creditos)", db.GetConnection());

                command.Parameters.AddWithValue("@NombreAsignatura", txAsignatura.Text);
                command.Parameters.AddWithValue("@Creditos", Convert.ToInt32(txCreditos.Text));

                command.ExecuteNonQuery();
                db.CloseConnection();

                MessageBox.Show("Asignatura creada correctamente.");
                LoadAsignaturas();
            }
        }
    }
}
