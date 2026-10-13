
using System;
using System.Data;
using System.Data.SqlClient;

namespace TP5_GRUPO_11
{
    public class Negocios
    {
        private const string CadenaConexion =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";

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

        public DataTable ListarSucursales()
        {
            string consulta = @"
                SELECT s.Id_Sucursal AS ID_SUCURSAL,
                       s.NombreSucursal AS NOMBRE,
                       s.DescripcionSucursal AS DESCRIPCION,
                       p.DescripcionProvincia AS PROVINCIA,
                       s.DireccionSucursal AS DIRECCION
                FROM Sucursal s
                INNER JOIN Provincia p
                    ON s.Id_ProvinciaSucursal = p.Id_Provincia
                ORDER BY s.Id_Sucursal";

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
        }

        public SqlDataReader FiltrarSucursal(int idSucursal)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);

            string consulta = @"
                SELECT s.Id_Sucursal AS ID_SUCURSAL,
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
