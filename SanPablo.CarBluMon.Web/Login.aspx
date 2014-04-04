<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SanPablo.CarBluMon.Web.Login"%>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Monitoreo Cardiaco</title>
    <link href="css/CarBlueMon.css" rel="stylesheet" type="text/css" />   
</head>
<body>
    <form id="frmLogin" runat="server">
        <div id="LoginArea" >
            <table>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="lblColumn">&nbsp;</td>
                    <td >&nbsp;</td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="lblColumn">Usuario :</td>
                    <td >
                        <asp:TextBox ID="txtUser" CssClass="textb" runat="server"></asp:TextBox>
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="lblColumn">Contraseña :</td>
                    <td >
                        <asp:TextBox ID="txtPass" CssClass="textb" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="lblColumn">&nbsp;</td>
                    <td >
                        <asp:Button ID="btnOk" CssClass="button" runat="server" Text="Ingresar" OnClick="btnOk_Click" />
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td >&nbsp;</td>
                    <td >&nbsp;</td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
