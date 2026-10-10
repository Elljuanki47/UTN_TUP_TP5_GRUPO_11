using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP5_GRUPO_11
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {

        

        private const string CadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idSucursal;

            if (!int.TryParse(txtIdSucursal.Text.Trim(), out idSucursal))
            {
                lblMensaje.Text = "Ingrese un ID numérico válido.";
                txtIdSucursal.Text = "";
                return;
            }

            Negocios negocio = new Negocios(); 

            int filasAfectadas = negocio.EliminarSucursal(idSucursal);

            if (filasAfectadas > 0)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Text = "La sucursal con ID " + idSucursal + " se ha eliminado con éxito.";
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "No existe una sucursal con el ID " + idSucursal + ".";
            }

            txtIdSucursal.Text = "";
        }
    }
}