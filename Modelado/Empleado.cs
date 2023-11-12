using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado
{
    public class Empleado
    {
        public int Id { get; set; }
        public int IdTipoIDentificacion { get; set; }
        public string ValorIdentificacion { get; set; }
        public string NombreEmpleado { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set;}
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get;set; }
        public DateTime FechaIngreso { get; set; }
        public decimal SalarioBase { get; set; }
        public string Direccion {  get; set; }
        public decimal VacacionesAcumuladas { get; set; }
        public bool Activo { get; set; }

        public string TipoIdentificacion { get; set;}
    }
}
