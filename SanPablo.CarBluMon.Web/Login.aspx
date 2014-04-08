<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SanPablo.CarBluMon.Web.Login"%>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Monitoreo Cardiaco</title>
    <!-- JQuery UI -->    
    <link href="/css/custom-theme/jquery-ui-1.10.4.custom.min.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/jquery-1.10.2.min.js"></script>    
    <script type="text/javascript" src="/js/jquery-ui-1.10.4.custom.min.js"></script>
    <!-- Custom -->
    <link href="/css/CarBlueMon.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/menu.js"></script>
    <script type="text/javascript" src="/js/open-dialog.js"></script>   
    <script type="text/javascript">
        function validate()
        {
            var result = true
            if ($("#txtUser").val() == "" || $("#txtUser").val() == undefined) {
                alert("Ingrese el usuario");
                result = false;
            }
            else if ($("#txtPass").val() == "" || $("#txtPass").val() == undefined) {
                alert("Ingrese el contraseña");
                result = false;
            }           
            return result;           
        }
    </script>
</head>
<body>
    <form id="frmLogin" runat="server">
        <div id="LoginArea" >
            <table style="width:100%">
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
                        <asp:TextBox ID="txtUser" runat="server" CssClass="asp-textbox"></asp:TextBox>
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="lblColumn">Contraseña :</td>
                    <td >
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" CssClass="asp-textbox"></asp:TextBox>
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td class="lblColumn">&nbsp;</td>
                    <td >
                        <asp:Button ID="btnOk" CssClass="ui-button" runat="server" Text="Ingresar" OnClientClick="return validate();" OnClick="btnOk_Click" />
                    </td>
                    <td class="emptyColumn">&nbsp;</td>
                </tr>
                <tr>
                    <td class="emptyColumn">&nbsp;</td>
                    <td >&nbsp;</td>
                    <td >&nbsp;</td>
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
