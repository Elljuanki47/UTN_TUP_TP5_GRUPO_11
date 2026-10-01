<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="TP5_GRUPO_11.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Listado de sucursales</h2>

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

            <asp:HyperLink ID="hlEliminarSucursal" runat="server"
                NavigateUrl="~/EliminarSucursales.aspx"
                Text="Eliminar sucursal">
            </asp:HyperLink>

            <br /><br />
            
            <asp:Label ID="lblIdSucursal" runat="server"
                Text="Ingrese ID sucursal:">
            </asp:Label>
            
            <asp:TextBox ID="txtIdSucursal" runat="server">
            </asp:TextBox>
            
            <asp:RegularExpressionValidator ID="revIdSucursal" runat="server"
                ControlToValidate="txtIdSucursal"
                ValidationExpression="^[0-9]+$"
                ErrorMessage="Ingrese un valor numérico."
                ForeColor="Red">
            </asp:RegularExpressionValidator>
            
            <br /><br />
            
            <asp:Button ID="btnFiltrar" runat="server"
                Text="Filtrar" />
        </div>
    </form>
</body>
</html>
