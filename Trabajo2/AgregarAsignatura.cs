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
    }
}
