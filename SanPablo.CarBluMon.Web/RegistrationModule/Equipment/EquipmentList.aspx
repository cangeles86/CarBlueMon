<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="EquipmentList.aspx.cs" Inherits="SanPablo.CarBluMon.Web.RegistrationModule.Equipment.EquipmentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">    
    <form id="form1" runat="server">
        <asp:DataGrid ID="DgEquipment" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
            <Columns>
                <asp:BoundColumn DataField="SerialNumber" HeaderText="N° Serie"></asp:BoundColumn>
                <asp:BoundColumn DataField="Description" HeaderText="Descripción"></asp:BoundColumn>
                <asp:HyperLinkColumn Text="Editar" DataNavigateUrlField="Id" DataNavigateUrlFormatString="EquipmentSave.aspx?ope=edit&amp;code={0}"></asp:HyperLinkColumn>
                
                <asp:TemplateColumn>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnDelete" runat="server" OnClientClick ="show();">LinkButton</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        </asp:DataGrid>
        <a href="EquipmentSave.aspx?ope=new">Nuevo</a>
    </form>
</asp:Content>