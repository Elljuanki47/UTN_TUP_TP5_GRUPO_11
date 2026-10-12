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
            lblMensaje.Text = "";

            if (!Page.IsValid)
            {
                return;
            }

            string nombre = txtNombreSucursal.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (nombre == "" || descripcion == "" || direccion == "")
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Todos los campos son obligatorios.";
                return;
            }

            if (nombre.Length > 100 ||
                descripcion.Length > 100 ||
                direccion.Length > 100)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text =
                    "El nombre, la descripción y la dirección admiten " +
                    "hasta 100 caracteres cada uno.";
                return;
            }

            Negocios negocios = new Negocios();

            int filasAfectadas = negocios.AgregarSucursal(
                nombre,
                descripcion,
                Convert.ToInt32(ddlProvincia.SelectedValue),
                direccion);

            if (filasAfectadas == 1)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Text = "La sucursal se ha agregado con éxito.";
                limpiarCampos();
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "No se pudo agregar la sucursal.";
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