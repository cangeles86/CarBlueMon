<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="EquipmentList.aspx.cs" Inherits="SanPablo.CarBluMon.Web.RegistrationModule.Equipment.EquipmentList" %>
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
    <form id="form1" runat="server">
        <a href="EquipmentSave.aspx?ope=new">
            <h2>Nuevo</h2>
        </a>
        <table style="width: 100%;">
            <tr>
                <td class="emptyColumn"></td>
                <td class="lblColumn">N° Serie:</td>
                <td>
                    <asp:TextBox ID="txtSerialNumber" runat="server" CssClass="asp-textbox" MaxLength="75"></asp:TextBox></td>
                <td style="width: 70px">
                    <asp:Button ID="btnFind" runat="server" Text="Buscar" CssClass="ui-button" OnClick="btnFind_Click" /></td>
                <td style="width: auto"></td>
                <td class="emptyColumn"></td>
            </tr>
            <tr>
                <td class="emptyColumn"></td>
                <td class="lblColumn">Descripción:</td>
                <td style="width: 250px">
                    <asp:TextBox ID="txtDescription" runat="server" CssClass="asp-textbox" MaxLength="150"></asp:TextBox></td>
                <td style="width: 70px"></td>
                <td style="width: auto"></td>
                <td class="emptyColumn"></td>
            </tr>
            <tr>
                <td class="emptyColumn"></td>
                <td colspan="3">
                    <asp:DataGrid ID="DgEquipment" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" CssClass="asp-datagrid">
                        <Columns>
                            <asp:BoundColumn DataField="SerialNumber" HeaderText="N° Serie"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Description" HeaderText="Descripción"></asp:BoundColumn>
                            <asp:TemplateColumn HeaderText="Tipo">
                                <ItemTemplate>
                                    <asp:Label ID="lblType" runat="server" Text='<%# Eval("Type.Description") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:HyperLinkColumn Text="Editar" DataNavigateUrlField="Id" DataNavigateUrlFormatString="EquipmentSave.aspx?ope=edit&amp;code={0}"></asp:HyperLinkColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="jlink" runat="server" CommandArgument='<%#Eval("Id")%>' OnClientClick="return confirm('¿Desea eliminar el registro?')" OnClick="jlink_Click">Eliminar</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" CssClass="asp-datagrid" />
                        <HeaderStyle BackColor="#4B236B" Font-Bold="True" ForeColor="#E7E7FF" />
                        <ItemStyle BackColor="#DEDFDE" ForeColor="Black" CssClass="asp-datagrid" />
                        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    </asp:DataGrid>
                </td>
                <td style="width: auto"></td>
                <td class="emptyColumn"></td>
            </tr>
        </table>
        <br />
        <br />
        <div id="dialog" title="Eliminar Registro">
            <p>¿ Esta seguro de eliminar el registro ?</p>
        </div>
    </form>

</asp:Content>