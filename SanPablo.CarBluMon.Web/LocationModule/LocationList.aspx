<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="LocationList.aspx.cs" Inherits="SanPablo.CarBluMon.Web.LocationModule.LocationList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DataGrid ID="dgHelpRequest" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
        <Columns>
            <asp:BoundColumn DataField="RegisterDate" HeaderText="Fecha de Registro"></asp:BoundColumn>
            <asp:TemplateColumn HeaderText="Nombre">
                <ItemTemplate>
                    <asp:Label ID="lblUsuario" runat="server" Text='<%# Eval("User.Patient.Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Apellido">
                <ItemTemplate>
                    <asp:Label ID="lblApellido" runat="server" Text='<%# Eval("User.Patient.LastName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Movil">
                <ItemTemplate>
                    <asp:Label ID="lblMovil" runat="server" Text='<%# Eval("User.Patient.Mobile") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateColumn>            
            <asp:TemplateColumn>
                <ItemTemplate>
                    <asp:HyperLink runat="server" Text="Ver" NavigateUrl='<%# "LocationInMap.aspx?Lat=" + DataBinder.Eval (Container.DataItem,"Latitude").ToString() + "&Lon=" + DataBinder.Eval(Container.DataItem,"Longitude").ToString() %>'
                        ID="ProductName" />
                </ItemTemplate>
            </asp:TemplateColumn> 
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4B236B" Font-Bold="True" ForeColor="#E7E7FF" />
        <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
    </asp:DataGrid>
</asp:Content>
