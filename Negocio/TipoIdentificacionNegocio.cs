using Datos;
using Modelado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class TipoIdentificacionNegocio
    {
        public static List<TipoIdentificacion> Obtener()
        {
            try
            {
                return TipoIdentificacionDatos.Obtener();
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
                return TipoIdentificacionDatos.Agregar(tipoIdentificacion);
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
                return TipoIdentificacionDatos.Catalogo();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
