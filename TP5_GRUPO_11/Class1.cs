using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace TP5_GRUPO_11
{
    public class Negocios
    {
        private const string CadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";

        public int EliminarSucursal(int idSucursal)
        {
            string consulta =
                "DELETE FROM Sucursal WHERE Id_Sucursal = @IdSucursal";

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.Add("@IdSucursal", SqlDbType.Int).Value =
                        idSucursal;

                    conexion.Open();

                    return comando.ExecuteNonQuery();
                }
            }
        }
    }
}