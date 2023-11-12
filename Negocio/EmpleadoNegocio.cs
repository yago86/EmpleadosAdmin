using Datos;
using Modelado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class EmpleadoNegocio
    {
        public static List<Empleado> Obtener()
        {
            try
            {
                return EmpleadoDatos.Obtener();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool Agregar(Empleado empleado)
        {
            try
            {
                return EmpleadoDatos.Agregar(empleado);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool Actualizar(Empleado empleado)
        {
            try
            {
                return EmpleadoDatos.Actualizar(empleado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool ActualizarEstado(int id)
        {
            try
            {
                return EmpleadoDatos.ActualizarEstado(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int ObtenerDiasVacacionesProyeccion(DateTime ini, DateTime fin)
        {
            try
            {
                return EmpleadoDatos.ObtenerDiasVacacionesProyeccion(ini, fin);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static decimal ActualizarVacaciones(int id)
        {
            try
            {
                return EmpleadoDatos.ActualizarVacaciones(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool GuardarSolicitudVacaciones(int id, DateTime fechaIni, DateTime fechaFin, decimal dias)
        {
            try
            {
                return EmpleadoDatos.GuardarSolicitudVacaciones(id, fechaIni, fechaFin, dias);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<HistorialVacaciones> ObtenerHistorialVacaciones(int idEmpleado)
        {
            try
            {
                return EmpleadoDatos.ObtenerHistorialVacaciones(idEmpleado);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
