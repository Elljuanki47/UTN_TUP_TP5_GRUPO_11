<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="TP5_GRUPO_11.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 200px;
        }
        .auto-style3 {
            width: 225px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">

            <asp:HyperLink ID="hlAgregarSucursal" runat="server"
                NavigateUrl="~/AgregarSucursal.aspx"
                Text="Agregar sucursal"> </asp:HyperLink>

                </td>
                <td class="auto-style3">

            <asp:HyperLink ID="hlListadoSucursales" runat="server"
                NavigateUrl="~/ListadoSucursales.aspx"
                Text="Listado de sucursales"> </asp:HyperLink>

                </td>
                <td class="auto-style2">

            <asp:HyperLink ID="hlEliminarSucursal" runat="server"
                NavigateUrl="~/EliminarSucursales.aspx"
                Text="Eliminar sucursal"> </asp:HyperLink>

                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-weight: bold; font-size: x-large">Listado de sucursales</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
            
            <asp:Label ID="lblIdSucursal" runat="server"
                Text="Ingrese ID sucursal:">
            </asp:Label>
            
                </td>
                <td class="auto-style3">
            
            <asp:TextBox ID="txtIdSucursal" runat="server"></asp:TextBox>
                    <br />
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
            
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>

    <td class="auto-style3">
    
        <asp:Button ID="btnFiltrar" runat="server"
            Text="Filtrar" OnClick="btnFiltrar_Click" />


        <asp:Button ID="btnMostrarTodos" runat="server"
            Text="Mostrar todos"
            OnClick="btnMostrarTodos_Click" />

                   </td>
                   <td class="auto-style3">&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                </tr>
                
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="gvSucursales" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
