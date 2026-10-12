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

        public DataTable Provincias()
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                string consulta =
                    "SELECT Id_Provincia, DescripcionProvincia FROM Provincia";

                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
        }

        public int AgregarSucursal(string nombre, string descripcion, int provincia, string direccion)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);

            conexion.Open();

            string consulta =
                "INSERT INTO Sucursal " +
                "(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) " +
                "VALUES (@Nombre,@Descripcion,@Provincia,@Direccion)";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Provincia", provincia);
            comando.Parameters.AddWithValue("@Direccion", direccion);

            int filas = comando.ExecuteNonQuery();

            conexion.Close();

            return filas;
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