using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    public partial class IngresoDatos : Form
    {
        public IngresoDatos()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAlumno AgregarAlumno = new FAlumno();
            AgregarAlumno.MdiParent = this.MdiParent;
            AgregarAlumno.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAsignatura agregarAsignatura = new AgregarAsignatura();
            agregarAsignatura.MdiParent = this.MdiParent;
            agregarAsignatura.Show();
        }
    }
}
