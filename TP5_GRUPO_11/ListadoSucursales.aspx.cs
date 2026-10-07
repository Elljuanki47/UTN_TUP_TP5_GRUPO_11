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
        private string consultaSQL = "SELECT * FROM Sucursal";
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
    }
}