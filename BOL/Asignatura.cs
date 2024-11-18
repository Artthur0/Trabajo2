using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Asignatura
    {
        public int CodigoAsignatura { get; set; } // Código único de la asignatura
        public string NombreAsignatura { get; set; } // Nombre de la asignatura
        public int Creditos { get; set; } // Cantidad de créditos
    }
}
