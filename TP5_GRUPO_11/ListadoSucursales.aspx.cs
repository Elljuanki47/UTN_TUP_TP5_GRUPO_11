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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarSucursales();
            }
        }

        private void CargarSucursales()
        {
            Negocios negocio = new Negocios();

            gvSucursales.DataSource = negocio.ListarSucursales();
            gvSucursales.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            string textoId = txtIdSucursal.Text.Trim();
            txtIdSucursal.Text = "";

            if (textoId == "")
            {
                lblMensaje.Text = "Debe ingresar un ID de sucursal.";
                return;
            }

            int idSucursal;

            if (!int.TryParse(textoId, out idSucursal))
            {
                lblMensaje.Text =
                    "Debe ingresar un ID de sucursal que sea un número entero.";
                return;
            }

            if (idSucursal <= 0)
            {
                lblMensaje.Text = "El ID de sucursal debe ser mayor a cero.";
                return;
            }

            Negocios negocio = new Negocios();

            using (SqlDataReader lector = negocio.FiltrarSucursal(idSucursal))
            {
                if (!lector.HasRows)
                {
                    lblMensaje.Text = "No se encontró una sucursal con ese ID.";
                }

                gvSucursales.DataSource = lector;
                gvSucursales.DataBind();
            }
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtIdSucursal.Text = "";
            lblMensaje.Text = "";

            CargarSucursales();
        }
    }
}