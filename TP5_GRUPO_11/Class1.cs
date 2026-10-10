using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP5_GRUPO_11
{
    public class Negocios
    {
        private const string CadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";

        public SqlDataReader Provincias()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);

            string consulta = "SELECT * FROM Provincia";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            conexion.Open();

            return comando.ExecuteReader(
                System.Data.CommandBehavior.CloseConnection);
        }
        public SqlDataReader FiltrarSucursal(int idSucursal)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);

            string consulta = @"SELECT s.Id_Sucursal AS ID_SUCURSAL,
                                       s.NombreSucursal AS NOMBRE,
                                       s.DescripcionSucursal AS DESCRIPCION,
                                       p.DescripcionProvincia AS PROVINCIA,
                                       s.DireccionSucursal AS DIRECCION
                                FROM Sucursal s
                                INNER JOIN Provincia p
                                ON s.Id_ProvinciaSucursal = p.Id_Provincia
                                WHERE s.Id_Sucursal = @IdSucursal";

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@IdSucursal", idSucursal);

            conexion.Open();

            return comando.ExecuteReader(CommandBehavior.CloseConnection);
        }
        
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