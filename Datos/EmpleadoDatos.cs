using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelado;

namespace Datos
{
    public static class EmpleadoDatos
    {
        public static List<Empleado> Obtener()
        {
			try
			{
                var empleadosLst = new List<Empleado>();

                empleadosLst = Conexion.SqlConn.Query<Empleado>("SpObtenerEmpleados", null, commandType: CommandType.StoredProcedure).ToList();

                return empleadosLst;
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
                var retorno = false;
                var parameters = new { 
                    empleado.IdTipoIDentificacion,
                    empleado.ValorIdentificacion,
                    empleado.PrimerNombre, 
                    empleado.SegundoNombre,
                    empleado.PrimerApellido,
                    empleado.SegundoApellido,
                    empleado.FechaIngreso,
                    empleado.SalarioBase,
                    empleado.Direccion
                };
                var count = Conexion.SqlConn.Execute("SpInsertarEmpleado", parameters, commandType: CommandType.StoredProcedure);

                if (count >= 1)
                {
                    retorno = true;
                }
                return retorno;
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
                var retorno = false;
                var parameters = new
                {
                    empleado.Id,
                    empleado.IdTipoIDentificacion,
                    empleado.ValorIdentificacion,
                    empleado.PrimerNombre,
                    empleado.SegundoNombre,
                    empleado.PrimerApellido,
                    empleado.SegundoApellido,
                    empleado.SalarioBase,
                    empleado.Direccion
                };
                var count = Conexion.SqlConn.Execute("SpActualizarEmpleado", parameters, commandType: CommandType.StoredProcedure);

                if (count >= 1)
                {
                    retorno = true;
                }
                return retorno;
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
                var retorno = false;
                var parameters = new
                {
                    Id = id
                };
                var count = Conexion.SqlConn.Execute("SpActualizarEstadoEmpleado", parameters, commandType: CommandType.StoredProcedure);

                if (count >= 1)
                {
                    retorno = true;
                }
                return retorno;
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
                var sql = "Select dbo.CalculoDiasVacaciones(@ini, @fin)";
                var parameters = new { ini, fin };
                var dias = Conexion.SqlConn.Query<int>(sql, parameters).FirstOrDefault();
                return dias;
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
                var parameters = new { Id = id };
                var dias = Conexion.SqlConn.Query<decimal>("SpActualizarVacaciones", parameters).FirstOrDefault();
                return dias;
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
                var retorno = false;
                var parameters = new
                {
                    Id = id,
                    FechaIni = fechaIni,
                    FechaFin = fechaFin,
                    DiasSolicitados = dias
                };
                var count = Conexion.SqlConn.Execute("SpGuardarSolicitudVacaciones", parameters, commandType: CommandType.StoredProcedure);

                if (count > 0)
                {
                    retorno = true;
                }
                return retorno;
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
                var historialLst = new List<HistorialVacaciones>();

                historialLst = Conexion.SqlConn.Query<HistorialVacaciones>("SpObtenerHistorialVacacionesEmpleado", new { IdEmpleado = idEmpleado }, commandType: CommandType.StoredProcedure).ToList();

                return historialLst;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
