using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP5_GRUPO_11
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        private const string CadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";
        private string consultaSQL = @"SELECT s.Id_Sucursal AS ID_SUCURSAL,
                                               s.NombreSucursal AS NOMBRE,
                                               s.DescripcionSucursal AS DESCRIPCION,
                                               p.DescripcionProvincia AS PROVINCIA,
                                               s.DireccionSucursal AS DIRECCION
                                        FROM Sucursal s
                                        INNER JOIN Provincia p ON s.Id_ProvinciaSucursal = p.Id_Provincia";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(CadenaConexion);
                connection.Open();

                SqlCommand sqlcommand = new SqlCommand(consultaSQL, connection);
                SqlDataReader sqldatareader = sqlcommand.ExecuteReader();

                gvSucursales.DataSource = sqldatareader;
                gvSucursales.DataBind();
                connection.Close();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtIdSucursal.Text.Trim() == "")
            {
                lblMensaje.Text = "Debe ingresar un ID de sucursal.";
                return;
            }
            SqlConnection connection = new SqlConnection(CadenaConexion);
            connection.Open();

            string consulta = consultaSQL +
                " WHERE s.Id_Sucursal = " + txtIdSucursal.Text;

            SqlCommand sqlcommand = new SqlCommand(consulta, connection);
            SqlDataReader sqldatareader = sqlcommand.ExecuteReader();

            gvSucursales.DataSource = sqldatareader;
            gvSucursales.DataBind();

            connection.Close();
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {

        }
    }
}