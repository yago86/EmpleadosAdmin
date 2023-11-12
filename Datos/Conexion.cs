using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class Conexion
    {
        private static string User { get => "sa"; }
        private static string Server { get => @".\Yago19"; }
        private static string Database { get => "EmpleadosAdmin"; }
        private static string Password { get => "123456"; }
        public static string StringConnection
        {
            get
            {
                return string.Format("Server={0};Database={1};User Id={2};Password={3};",Server, Database, User, Password);
            }
        }

        public static SqlConnection SqlConn
        {
            get
            {
                return new SqlConnection(StringConnection);
            }
        }

        public static bool IsValidConnection()
        {
            var conn = SqlConn;
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
        }
    }
}
