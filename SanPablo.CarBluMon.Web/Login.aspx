<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SanPablo.CarBluMon.Web.Login"%>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Monitoreo Cardiaco</title>
    <link href="css/CarBlueMon.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 20px;
        }
        .auto-style3 {
            width: 83px;
        }
        .auto-style4 {
            width: 83px;
            text-align: right;
        }
        .auto-style5 {
            width: 284px;
        }
    </style>
</head>
<body>
    <form id="frmLogin" runat="server">
        <div id="LoginArea">

            <table class="auto-style1">
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="auto-style4">Usuario :</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="auto-style4">Contraseña :</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" Text="Button" />
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
