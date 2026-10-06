<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="TP5_GRUPO_11.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 54px;
        }
        .auto-style3 {
            height: 54px;
            width: 137px;
        }
        .auto-style4 {
        }
        .auto-style5 {
            width: 137px;
        }
        .auto-style6 {
            height: 54px;
            width: 182px;
        }
        .auto-style7 {
            width: 182px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">

            <asp:HyperLink ID="hlAgregarSucursal" runat="server"
                NavigateUrl="~/AgregarSucursal.aspx"
                Text="Agregar sucursal">
            </asp:HyperLink>

                </td>
                <td class="auto-style6">

            <asp:HyperLink ID="hlListadoSucursales" runat="server"
                NavigateUrl="~/ListadoSucursales.aspx"
                Text="Listado de sucursales">
            </asp:HyperLink>

                </td>
                <td class="auto-style2">

            <asp:HyperLink ID="hlEliminarSucursales" runat="server"
                NavigateUrl="~/EliminarSucursales.aspx"
                Text="Eliminar sucursales">
            </asp:HyperLink>

                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2" style="font-size: xx-large; font-weight: bold">Agregar Sucursal</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">

            <asp:Label ID="lblNombreSucursal" runat="server"
                Text="Nombre Sucursal:">
            </asp:Label>

                </td>
                <td class="auto-style7">

            <asp:TextBox ID="txtNombreSucursal" runat="server">
            </asp:TextBox>
        
                </td>
                <td class="auto-style7">
        
            <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server"
                ControlToValidate="txtNombreSucursal"
                ErrorMessage="Ingrese nombre de sucursal"
                ForeColor="Red">
            </asp:RequiredFieldValidator>

                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">

            <asp:Label ID="lblDescripcion" runat="server"
                Text="Descripcion:">
            </asp:Label>

                </td>
                <td class="auto-style7">

            <asp:TextBox ID="txtDescripcion" runat="server">
            </asp:TextBox>

                </td>
                <td class="auto-style7">

            <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Ingrese una descripcion" ForeColor="Red"></asp:RequiredFieldValidator>

                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">

            <asp:Label ID="lblProvincia" runat="server"
                Text="Provincia:">
            </asp:Label>

                </td>
                <td class="auto-style7">

            <asp:DropDownList ID="ddlProvincia" runat="server" Height="16px" Width="124px">
            <asp:ListItem Text="--Seleccionar--" Value="0" Selected="True"></asp:ListItem>
            </asp:DropDownList>

                </td>
                <td class="auto-style7">

            <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="ddlProvincia" ErrorMessage="Seleccione una provincia" ForeColor="Red" InitialValue="--Seleccionar--"></asp:RequiredFieldValidator>

                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">

            <asp:Label ID="lblDireccion" runat="server"
                Text="Dirección:">
            </asp:Label>

                </td>
                <td class="auto-style7">

            <asp:TextBox ID="txtDireccion" runat="server">
            </asp:TextBox>

                </td>
                <td class="auto-style7">

            <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Ingrese una direccion" ForeColor="Red"></asp:RequiredFieldValidator>

                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
