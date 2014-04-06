<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SanPablo.CarBluMon.Web.Login"%>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Monitoreo Cardiaco</title>
    <link href="css/CarBlueMon.css" rel="stylesheet" type="text/css" />
    <link href="../css/custom-theme/jquery-ui-1.10.4.custom.css" rel="stylesheet" type="text/css" />
    <link href="../css/custom-theme/jquery-ui-1.10.4.custom.min.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .ui- {
            font-size: small;
        }
    </style>
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
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="lblColumn">Contraseña :</td>
                    <td >
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="lblColumn">&nbsp;</td>
                    <td >
                        <asp:Button ID="btnOk" CssClass="ui-button" runat="server" Text="Ingresar" OnClick="btnOk_Click" />
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
