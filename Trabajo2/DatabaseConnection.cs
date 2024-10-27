using System;
using System.Data.SqlClient;

public class DatabaseConnection : IDisposable
{
    private SqlConnection connection;

    public DatabaseConnection()
    {
        // Inicializa la conexión a SQL Server
        connection = new SqlConnection("Data Source=DESKTOP-9OMGB05\\SQLEXPRESS;Initial Catalog=BaseDeDatosEscuela;Integrated Security=True");
    }

    public SqlConnection GetConnection()
    {
        return connection;
    }

    public void OpenConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    // Implementación de IDisposable
    public void Dispose()
    {
        CloseConnection(); // Cerrar la conexión al liberar recursos
        connection?.Dispose(); // Liberar el objeto SqlConnection
    }
}

