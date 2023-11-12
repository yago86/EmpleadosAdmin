using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado
{
    public class EmpleadoVacaciones
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public decimal VacacionesSolicitadas {  get; set; }
        public DateTime FechaIni {  get; set; }
        public DateTime FechaFin { get; set; }
        public bool Vigente { get; set; }
    }
}
