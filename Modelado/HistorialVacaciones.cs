using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado
{
    public class HistorialVacaciones
    {
        public DateTime FechaRegistro {  get; set; }
        public decimal Solicitud {  get; set; }
        public decimal VacacionesFecha { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin {  get; set; }
        public bool Vigente { get; set; }
    }
}
