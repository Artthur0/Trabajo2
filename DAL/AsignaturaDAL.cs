using BOL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AsignaturaDAL
    {
        private string connectionString = "Data Source=DESKTOP-9OMGB05\\SQLEXPRESS;Initial Catalog=BaseDeDatosEscuela;Integrated Security=True;";

        public void AgregarAsignatura(Asignatura asignatura)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Asignaturas (NombreAsignatura, Creditos) VALUES (@NombreAsignatura, @Creditos)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreAsignatura", asignatura.NombreAsignatura);
                cmd.Parameters.AddWithValue("@Creditos", asignatura.Creditos);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarAsignatura(Asignatura asignatura)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Asignaturas SET NombreAsignatura = @NombreAsignatura, Creditos = @Creditos " +
                               "WHERE CodigoAsignatura = @CodigoAsignatura";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoAsignatura", asignatura.CodigoAsignatura);
                cmd.Parameters.AddWithValue("@NombreAsignatura", asignatura.NombreAsignatura);
                cmd.Parameters.AddWithValue("@Creditos", asignatura.Creditos);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarAsignatura(int codigoAsignatura)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Asignaturas WHERE CodigoAsignatura = @CodigoAsignatura";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoAsignatura", codigoAsignatura);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Asignatura> ObtenerTodasLasAsignaturas()
        {
            List<Asignatura> asignaturas = new List<Asignatura>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Asignaturas";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        asignaturas.Add(new Asignatura
                        {
                            CodigoAsignatura = (int)reader["CodigoAsignatura"],
                            NombreAsignatura = reader["NombreAsignatura"].ToString(),
                            Creditos = (int)reader["Creditos"]
                        });
                    }
                }
            }
            return asignaturas;
        }


    }
}
