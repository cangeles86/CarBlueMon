<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="AllocationSave.aspx.cs" Inherits="SanPablo.CarBluMon.Web.RegistrationModule.Allocation.AllocationSave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function mostrarmsj(mensaje) {            
            if (confirm(mensaje)) {
                document.getElementById("btnValidate").click();
            }
        }
    </script>
     
    <script type="text/javascript">
        function CheckSingleCheckbox(ob) {
            var grid = ob.parentNode.parentNode.parentNode;
            var inputs = grid.getElementsByTagName("input");
            for (var i = 0; i < inputs.length; i++) {
                if (inputs[i].type == "checkbox") {
                    if (ob.checked && inputs[i] != ob && inputs[i].checked) {
                        inputs[i].checked = false;
                    }
                }
            }
        }
    </script>

    <script>
        function validate()
        {
            var resultHolter = false;
            var resultMobile = false;

            var gridHolter = document.getElementById('<%= this.DgEquipmentHolter.ClientID %>');
            var inputsHolter = gridHolter.getElementsByTagName("input");
            for (var i = 0; i < inputsHolter.length; i++) {
                if (inputsHolter[i].type == "checkbox") {
                    if (inputsHolter[i].checked) {
                        resultHolter = true;
                    }
                }
            }

            var gridMobile = document.getElementById('<%= this.DgEquipmentMovil.ClientID %>');
            var inputsMobile = gridMobile.getElementsByTagName("input");
            for (var i = 0; i < inputsMobile.length; i++) {
                if (inputsMobile[i].type == "checkbox") {
                    if (inputsMobile[i].checked) {
                        resultMobile = true;
                    }
                }
            }

            if (resultHolter == true && resultMobile == true) {
                return true;
            }
            else {
                alert('Seleccione al menos un Holter y al menos un Movil');
                return false;
            }
            
        }
    </script>

    <script>
        function validateSearch()
        {
            if ($('input[id$=txtDocumentNumber]').val() == "") {
                alert('Ingrese el numero de documento del Paciente');
                return false;
            }
            return true;
        }
    </script>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td class="emptyColumn">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td style="width: 2px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="emptyColumn"></td>
                <td class="lblColumn">Tipo Doc:</td>
                <td style="width: 250px">
                    <asp:DropDownList ID="ddlDocumentType" runat="server"></asp:DropDownList></td>
                <td style="width: 70px">&nbsp;</td>
                <td style="width: 2px">&nbsp;</td>
                <td style="width: auto"></td>
                <td class="emptyColumn"></td>

            </tr>
            <tr>
                <td class="emptyColumn"></td>
                <td class="lblColumn">N° Documento:</td>
                <td style="width: 250px">
                    <asp:TextBox ID="txtDocumentNumber" runat="server" MaxLength="45" CssClass="asp-textbox"></asp:TextBox>
                </td>
                <td style="width: 70px">
                    <asp:Button ID="btnFindAssign" runat="server" Text="Buscar" CssClass="ui-button" OnClientClick="return validateSearch();" OnClick="btnFindAssign_Click" />
                </td>
                <td style="width: 2px">&nbsp;</td>
                <td style="width: auto"></td>
                <td class="emptyColumn"></td>

            </tr>
            <tr>
                <td class="emptyColumn">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td style="width: 2px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="emptyColumn">&nbsp;</td>
                <td colspan="3">
                    <asp:DataGrid ID="DgEquipmentHolter" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" CssClass="asp-datagrid" Width="100%">
                        <Columns>
                            <asp:TemplateColumn HeaderText="Seleccion">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkHolter" runat="server" onclick ="CheckSingleCheckbox(this)" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Id" HeaderText="Id" Visible="False"></asp:BoundColumn>
                            <asp:BoundColumn DataField="SerialNumber" HeaderText="N° Serie"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Description" HeaderText="Descripción"></asp:BoundColumn>
                            <asp:TemplateColumn HeaderText="Tipo">
                                <ItemTemplate>
                                    <asp:Label ID="lblType" runat="server" Text='<%# Eval("Type.Description") %>'></asp:Label>
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
                <td style="width: 2px">
                    <asp:Button ID="btnSave" runat="server" Text="Guardar" CssClass="ui-button" Enabled="False" OnClientClick="return validate();" OnClick="btnSave_Click" />
                    <br />
                    <asp:Button ID="btnRemove" runat="server" Text="Eliminar" CssClass="ui-button" Enabled="False" OnClientClick="if (confirm('¿ Desea eliminar el registro ?')) { return true; } else { return false; }" OnClick="btnRemove_Click" />
                    <br />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="ui-button" OnClick="btnCancel_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="emptyColumn">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td style="width: 2px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="emptyColumn">&nbsp;</td>
                <td colspan="3">
                    <asp:DataGrid ID="DgEquipmentMovil" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" CssClass="asp-datagrid" Width="100%">
                        <Columns>
                            <asp:TemplateColumn HeaderText="Seleccion">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkMobile" runat="server" onclick ="CheckSingleCheckbox(this)" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="Id" HeaderText="Id" Visible="False"></asp:BoundColumn>
                            <asp:BoundColumn DataField="SerialNumber" HeaderText="N° Serie"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Description" HeaderText="Descripción"></asp:BoundColumn>
                            <asp:TemplateColumn HeaderText="Tipo">
                                <ItemTemplate>
                                    <asp:Label ID="lblType0" runat="server" Text='<%# Eval("Type.Description") %>'></asp:Label>
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
                <td style="width: 2px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="emptyColumn">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td style="width: 2px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="emptyColumn">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td style="width: 2px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div style="display:none;"><asp:Button ID="btnValidate" ClientIDMode="static" runat="server" OnClick="btnValidate_Click" /></div>
    </form>

</asp:Content>
