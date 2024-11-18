using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class AlumnoDAL
    {
        private string connectionString = "Data Source=DESKTOP-9OMGB05\\SQLEXPRESS;Initial Catalog=BaseDeDatosEscuela;Integrated Security=True;"; // Define tu conexión aquí

        public void AgregarAlumno(Alumno alumno)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Alumnos (Nombre, ApellidoPat, ApellidoMat, Email, NumeroMatricula) " +
                               "VALUES (@Nombre, @ApellidoPat, @ApellidoMat, @Email, @NumeroMatricula)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPat", alumno.ApellidoPat);
                cmd.Parameters.AddWithValue("@ApellidoMat", alumno.ApellidoMat);
                cmd.Parameters.AddWithValue("@Email", alumno.Email);
                cmd.Parameters.AddWithValue("@NumeroMatricula", alumno.NumeroMatricula);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Alumno> ListarAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Alumnos";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        alumnos.Add(new Alumno
                        {
                            IDAlumno = (int)reader["IDAlumno"],
                            Nombre = reader["Nombre"].ToString(),
                            ApellidoPat = reader["ApellidoPat"].ToString(),
                            ApellidoMat = reader["ApellidoMat"].ToString(),
                            Email = reader["Email"].ToString(),
                            NumeroMatricula = reader["NumeroMatricula"].ToString()
                        });
                    }
                }
            }
            return alumnos;
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Alumnos SET Nombre = @Nombre, ApellidoPat = @ApellidoPat, ApellidoMat = @ApellidoMat, " +
                               "Email = @Email, NumeroMatricula = @NumeroMatricula WHERE IDAlumno = @IDAlumno";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDAlumno", alumno.IDAlumno);
                cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPat", alumno.ApellidoPat);
                cmd.Parameters.AddWithValue("@ApellidoMat", alumno.ApellidoMat);
                cmd.Parameters.AddWithValue("@Email", alumno.Email);
                cmd.Parameters.AddWithValue("@NumeroMatricula", alumno.NumeroMatricula);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarAlumno(int idAlumno)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Alumnos WHERE IDAlumno = @IDAlumno";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDAlumno", idAlumno);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Alumno> ObtenerTodosLosAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Alumnos";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        alumnos.Add(new Alumno
                        {
                            IDAlumno = (int)reader["IDAlumno"],
                            Nombre = reader["Nombre"].ToString(),
                            ApellidoPat = reader["ApellidoPat"].ToString(),
                            ApellidoMat = reader["ApellidoMat"].ToString(),
                            Email = reader["Email"].ToString(),
                            NumeroMatricula = reader["NumeroMatricula"].ToString()
                        });
                    }
                }
            }
            return alumnos;
        }
    }
}
