using DAL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AlumnoBL
    {
        private AlumnoDAL alumnoDAL = new AlumnoDAL();

        public void AgregarAlumno(Alumno alumno)
        {
            alumnoDAL.AgregarAlumno(alumno);
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            alumnoDAL.ActualizarAlumno(alumno);
        }

        public void EliminarAlumno(int idAlumno)
        {
            alumnoDAL.EliminarAlumno(idAlumno);
        }

        public List<Alumno> ObtenerTodosLosAlumnos()
        {
            return alumnoDAL.ObtenerTodosLosAlumnos();
        }
    }
}
