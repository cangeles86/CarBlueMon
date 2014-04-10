<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="EquipmentSave.aspx.cs" Inherits="SanPablo.CarBluMon.Web.RegistrationModule.Equipment.EquipmentSave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <form id="form1" runat="server">
        
        <table style="width: 100%;">
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">N° Serie</td>
                <td style="width:40%"><asp:TextBox ID="txtSerialNumber" runat="server" MaxLength="75"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Descripción</td>
                <td style="width:40%"><asp:TextBox ID="txtDescription" runat="server" MaxLength="150"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Tipo</td>
                <td style="width:40%"><asp:DropDownList ID="ddlEquipmentType" runat="server"></asp:DropDownList></td>
                <td style="width:20%">
                    <asp:Label ID="lblRegisterDate" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Tipo</td>
                <td style="width:40%"><asp:DropDownList ID="ddlState" runat="server">
                    <asp:ListItem Value="1">Activo</asp:ListItem>
                    <asp:ListItem Value="0">De Baja</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width:20%">
                    <asp:Label ID="lblAssign" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:60%" colspan="2">
                    <asp:Button ID="btnOk" runat="server" Text="Guardar" OnClientClick="return validate();" OnClick="btnOk_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancelar" OnClick="btnCancel_Click" />
                </td>
                <td style="width:20%">&nbsp;</td>
            </tr>
        </table>
    </form>
    <script type="text/javascript">
        function validate() {
            var result = true;
            if ($('input[id$=txtSerialNumber]').val() == "" || $('input[id$=txtSerialNumber]').val() == undefined) {
                alert("Ingrese Numero de Serie");
                result = false;
            }
            else if ($('input[id$=txtDescription]').val() == "" || $('input[id$=txtDescription]').val() == undefined) {
                alert("Ingrese Descripcion");
                result = false;
            }
            return result;
        }

    </script>
</asp:Content>
