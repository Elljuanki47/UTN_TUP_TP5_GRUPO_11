<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="TP5_GRUPO_11.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>Agregar Sucursal</h2>

            <asp:HyperLink ID="hlAgregarSucursal" runat="server"
                NavigateUrl="~/AgregarSucursal.aspx"
                Text="Agregar sucursal">
            </asp:HyperLink>

            &nbsp;&nbsp;

            <asp:HyperLink ID="hlListadoSucursales" runat="server"
                NavigateUrl="~/ListadoSucursales.aspx"
                Text="Listado de sucursales">
            </asp:HyperLink>

            &nbsp;&nbsp;

            <asp:HyperLink ID="hlEliminarSucursales" runat="server"
                NavigateUrl="~/EliminarSucursales.aspx"
                Text="Eliminar sucursales">
            </asp:HyperLink>

            <br /><br />

            <asp:Label ID="lblNombreSucursal" runat="server"
                Text="Nombre Sucursal:">
            </asp:Label>

            <asp:TextBox ID="txtNombreSucursal" runat="server">
            </asp:TextBox>
        
            <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server"
                ControlToValidate="txtNombreSucursal"
                ErrorMessage="Ingrese nombre de sucursal"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

            <br /><br />

            <asp:Label ID="lblDescripcion" runat="server"
                Text="Descripcion:">
            </asp:Label>
        </div>
    </form>
</body>
</html>
