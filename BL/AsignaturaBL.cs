using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AsignaturaBL
    {
        private AsignaturaDAL asignaturaDAL = new AsignaturaDAL();

        public void AgregarAsignatura(Asignatura asignatura)
        {
            asignaturaDAL.AgregarAsignatura(asignatura);
        }

        public void ActualizarAsignatura(Asignatura asignatura)
        {
            asignaturaDAL.ActualizarAsignatura(asignatura);
        }

        public void EliminarAsignatura(int codigoAsignatura)
        {
            asignaturaDAL.EliminarAsignatura(codigoAsignatura);
        }

        public List<Asignatura> ObtenerTodasLasAsignaturas()
        {
            return asignaturaDAL.ObtenerTodasLasAsignaturas();
        }
    }
}
