<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="PatientList.aspx.cs" Inherits="SanPablo.CarBluMon.Web.RegistrationModule.Patient.PatientList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function openDialog() {
            $("#dialog").dialog("open");
            event.preventDefault();
        }
        function callBack(state) {
            if (state) {
                $("[id*=jlink]").click();
            }
        }
    </script>
    <form name="form1" runat="server">
        <a href="PatientSave.aspx?ope=new">Nuevo</a>
        <br />
        <br />
        <asp:DataGrid ID="dgPatient" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingItemStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundColumn DataField="Name" HeaderText="Nombre"></asp:BoundColumn>
                <asp:BoundColumn DataField="LastName" HeaderText="Apellido"></asp:BoundColumn>
                <asp:TemplateColumn HeaderText="Tipo Doc.">
                    <ItemTemplate>
                        <asp:Label ID="lblDocumentType" runat="server" Text='<%# Eval("DocumentType.Description") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="DocumentNumber" HeaderText="N° Documento"></asp:BoundColumn>
                <asp:BoundColumn DataField="Mobile" HeaderText="Movil"></asp:BoundColumn>
                <asp:HyperLinkColumn Text="Editar" DataNavigateUrlField="Id" DataNavigateUrlFormatString="PatientSave.aspx?ope=edit&amp;code={0}"></asp:HyperLinkColumn>
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:LinkButton ID="jlink" runat="server" CommandArgument='<%#Eval("Id")%>' OnClientClick="return confirm('¿Desea eliminar el registro?')" OnClick="jlink_Click">Eliminar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#4B236B" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EEEEEE" ForeColor="Black" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" Mode="NumericPages" />
            <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        </asp:DataGrid>
    </form>
</asp:Content>
