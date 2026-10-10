using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP5_GRUPO_11
{
    public class Negocios
    {
        private const string CadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";
        
        public int EliminarSucursal(int idSucursal)
        {
            int filasAfectadas;

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();

                string consulta = "DELETE FROM Sucursal WHERE Id_Sucursal = @IdSucursal";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdSucursal", idSucursal);

                filasAfectadas = comando.ExecuteNonQuery();
            }

            return filasAfectadas;
        }
    }
}