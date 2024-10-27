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
    public partial class FAlumno : Form
    {
        public FAlumno()
        {
            InitializeComponent();
            LoadAlumnos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();
                // Consulta SQL para insertar un nuevo alumno
                var command = new SqlCommand(
                    "INSERT INTO Alumnos (Nombre, ApellidoPat, ApellidoMat, Email, NumeroMatricula) " +
                    "VALUES (@Nombre, @ApellidoPat, @ApellidoMat, @Email, @NumeroMatricula)",
                    db.GetConnection());

                command.Parameters.AddWithValue("@Nombre", txNombre.Text);
                command.Parameters.AddWithValue("@ApellidoPat", txApPat.Text);
                command.Parameters.AddWithValue("@ApellidoMat", txApMat.Text);
                command.Parameters.AddWithValue("@Email", txEmail.Text);
                command.Parameters.AddWithValue("@NumeroMatricula", txNumMatri.Text);

                command.ExecuteNonQuery();
                db.CloseConnection();

                MessageBox.Show("Alumno creado correctamente.");
                LoadAlumnos(); // Recargar la lista de alumnos para reflejar los cambios
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                int idAlumno = Convert.ToInt32(dgvAlumnos.SelectedRows[0].Cells["IDAlumno"].Value);

                using (var db = new DatabaseConnection())
                {
                    db.OpenConnection();
                    var command = new SqlCommand(
                        "UPDATE Alumnos SET Nombre = @Nombre, ApellidoPat = @ApellidoPat, ApellidoMat = @ApellidoMat, Email = @Email, NumeroMatricula = @NumeroMatricula " +
                        "WHERE IDAlumno = @IDAlumno",
                        db.GetConnection());

                    command.Parameters.AddWithValue("@Nombre", txNombre.Text);
                    command.Parameters.AddWithValue("@ApellidoPat", txApPat.Text);
                    command.Parameters.AddWithValue("@ApellidoMat", txApMat.Text);
                    command.Parameters.AddWithValue("@Email", txEmail.Text);
                    command.Parameters.AddWithValue("@NumeroMatricula", txNumMatri.Text);
                    command.Parameters.AddWithValue("@IDAlumno", idAlumno);

                    command.ExecuteNonQuery();
                    db.CloseConnection();

                    MessageBox.Show("Alumno actualizado correctamente.");
                    LoadAlumnos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alumno para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                int idAlumno = Convert.ToInt32(dgvAlumnos.SelectedRows[0].Cells["IDAlumno"].Value);

                using (var db = new DatabaseConnection())
                {
                    db.OpenConnection();
                    var command = new SqlCommand("DELETE FROM Alumnos WHERE IDAlumno = @IDAlumno", db.GetConnection());
                    command.Parameters.AddWithValue("@IDAlumno", idAlumno);

                    command.ExecuteNonQuery();
                    db.CloseConnection();

                    MessageBox.Show("Alumno eliminado correctamente.");
                    LoadAlumnos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alumno para eliminar.");
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
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();

                // Consulta para seleccionar todos los registros de la tabla Alumnos
                var command = new SqlCommand("SELECT * FROM Alumnos", db.GetConnection());
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();

                // Llenar el DataTable con los datos obtenidos de la base de datos
                adapter.Fill(dataTable);

                // Asignar el DataTable como fuente de datos del DataGridView
                dgvAlumnos.DataSource = dataTable;

                db.CloseConnection();
            }
        }
    }
}
