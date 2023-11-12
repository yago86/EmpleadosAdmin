using Dapper;
using Modelado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TipoIdentificacionDatos
    {
        public static List<TipoIdentificacion> Obtener()
        {
            try
            {
                var tipoIdentificacionLst = new List<TipoIdentificacion>();

                tipoIdentificacionLst = Conexion.SqlConn.Query<TipoIdentificacion>("SpObtenerTipoIdentificaciones", null, commandType: CommandType.StoredProcedure).ToList();

                return tipoIdentificacionLst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool Agregar(TipoIdentificacion tipoIdentificacion)
        {
            try
            {
                var retorno = false;
                var parameters = new
                {
                    tipoIdentificacion.Nombre,
                    tipoIdentificacion.Activo
                };
                var count = Conexion.SqlConn.Execute("SpInsertarTipoIdentificacion", parameters, commandType: CommandType.StoredProcedure);

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

        public static List<TipoIdentificacion> Catalogo()
        {
            try
            {
                var tipoIdentificacionLst = new List<TipoIdentificacion>();

                tipoIdentificacionLst = Conexion.SqlConn.Query<TipoIdentificacion>("SpObtenerTipoIdentificacionesCatalogo", null, commandType: CommandType.StoredProcedure).ToList();

                return tipoIdentificacionLst;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
