<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="EquipmentSave.aspx.cs" Inherits="SanPablo.CarBluMon.Web.RegistrationModule.Equipment.EquipmentSave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">N° Serie</td>
                <td style="width:40%"><asp:TextBox ID="txtSerialNumber" runat="server"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Descripción</td>
                <td style="width:40%"><asp:TextBox ID="txtDescription" runat="server"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Tipo</td>
                <td style="width:40%"><asp:DropDownList ID="ddlEquipmentType" runat="server"></asp:DropDownList></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:60%" colspan="2">
                    <asp:Button ID="btnOk" runat="server" Text="Guardar" OnClick="btnOk_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancelar" OnClick="btnCancel_Click" />
                </td>
                <td style="width:20%">&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
