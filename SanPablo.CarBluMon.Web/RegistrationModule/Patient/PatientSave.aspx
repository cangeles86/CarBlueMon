<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="PatientSave.aspx.cs" Inherits="SanPablo.CarBluMon.Web.RegistrationModule.Patient.PatientSave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        
        <table style="width: 100%;">
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Nombre</td>
                <td style="width:40%"><asp:TextBox ID="txtName" runat="server" MaxLength="150"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Apellido</td>
                <td style="width:40%"><asp:TextBox ID="txtLastName" runat="server" MaxLength="150"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Tipo Documento</td>
                <td style="width:40%"><asp:DropDownList ID="ddlDocumentType" runat="server"></asp:DropDownList></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">N° Documento</td>
                <td style="width:40%"><asp:TextBox ID="txtDocumentNumber" runat="server" MaxLength="45"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Dirección</td>
                <td style="width:40%"><asp:TextBox ID="txtAddress" runat="server" MaxLength="400"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Correo</td>
                <td style="width:40%"><asp:TextBox ID="txtEmail" runat="server" MaxLength="150"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Telefono de Casa</td>
                <td style="width:40%"><asp:TextBox ID="txtHomePhone" runat="server" MaxLength="25"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width:20%">&nbsp;</td>
                <td style="width:20%">Telefono Movil</td>
                <td style="width:40%"><asp:TextBox ID="txtMobile" runat="server" MaxLength="25"></asp:TextBox></td>
                <td style="width:20%">&nbsp;</td>
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
            if ($('input[id$=txtName]').val() == "" || $('input[id$=txtName]').val() == undefined) {
                alert("Ingrese el Nombre");
                result = false;
            }
            else if ($('input[id$=txtLastName]').val() == "" || $('input[id$=txtLastName]').val() == undefined) {
                alert("Ingrese el Apellido");
                result = false;
            }
            else if ($('input[id$=txtDocumentNumber]').val() == "" || $('input[id$=txtDocumentNumber]').val() == undefined) {
                alert("Ingrese el Numero de Documento");
                result = false;
            }
            else if ($('input[id$=txtAddress]').val() == "" || $('input[id$=txtAddress]').val() == undefined) {
                alert("Ingrese la dirección");
                result = false;
            }
            else if ($('input[id$=txtEmail]').val() == "" || $('input[id$=txtEmail]').val() == undefined) {
                alert("Ingrese el Correo");
                result = false;
            }
            else if ($('input[id$=txtHomePhone]').val() == "" || $('input[id$=txtHomePhone]').val() == undefined) {
                alert("Ingrese el telefono de casa");
                result = false;
            }            
            return result;
        }

    </script>
</asp:Content>
