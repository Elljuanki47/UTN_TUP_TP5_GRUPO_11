using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_GRUPO_11
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";

                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                string consulta = "SELECT * FROM Provincia";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                ddlProvincia.DataSource = reader;
                ddlProvincia.DataTextField = "DescripcionProvincia";
                ddlProvincia.DataValueField = "Id_Provincia";
                ddlProvincia.DataBind();

                conexion.Close();

                ddlProvincia.Items.Add(
                    new ListItem("--Seleccione una provincia--", "0"));

                ddlProvincia.SelectedValue = "0";
            }
        }
    }
}