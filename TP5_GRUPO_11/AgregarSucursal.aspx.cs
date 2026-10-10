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
                Negocios negocios = new Negocios();

                ddlProvincia.DataSource = negocios.Provincias();
                ddlProvincia.DataTextField = "DescripcionProvincia";
                ddlProvincia.DataValueField = "Id_Provincia";
                ddlProvincia.DataBind();

                ddlProvincia.Items.Insert(
                    0,
                    new ListItem("--Seleccione una provincia--", "0"));

                ddlProvincia.SelectedValue = "0";
            }
        }

        protected void aceptar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Negocios negocios = new Negocios();

                int filasAfectadas = negocios.AgregarSucursal(txtNombreSucursal.Text, txtDescripcion.Text, Convert.ToInt32(ddlProvincia.SelectedValue), txtDireccion.Text);

                if (filasAfectadas == 1)
                {
                    lblMensaje.Text = "La sucursal se ha agregar con exito";
                    limpiarCampos();
                }
                else
                {
                    lblMensaje.Text = "No se pudo agregar la sucursal";
                }
            }
        }

        private void limpiarCampos()
        {
            txtNombreSucursal.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtDireccion.Text = string.Empty;

            ddlProvincia.SelectedValue = "0";
        }
    }
}