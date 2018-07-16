<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainVoluntario.aspx.cs" Inherits="TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.mainVoluntario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            usuario voluntario
            <br />
        <asp:Label ID="lblBoton" runat="server"/>
           <br/>
            ID Usuario:
        <asp:Label ID="idUsuario" runat="server" Text="Label"></asp:Label>

            <asp:Repeater ID="RepeaterVacante" runat="server">
                <ItemTemplate >
                    <div class="tablaRepeater">
                        <table class="tg">
                            <tr>
                                <th class="tr_nombre-vacante" colspan="3">
                                    <asp:Label ID="lblnombreVacante" Text='<%# Eval("NombreVacante") %>' runat="server" />
                                </th>
                            </tr>
                            <tr>
                                <td class="tr_ubicacion" rowspan="5">
                                    <asp:Label ID="lblubicacion" Text='<%# Eval("Direccion") %>' runat="server" />
                                </td>
                                <td class="tr_tipoPedido" colspan="2">
                                    <asp:Label ID="lbltipoPedido" Text='<%# Eval("TipoPedido") %>' runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td class="tr_descripcion" colspan="2">
                                    <asp:Label ID="lbldescripcion" Text='<%# Eval("Descripcion") %>' runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td class="tr_numerocontacto" colspan="2">
                                    <asp:Label ID="lblnumeroContacto" Text='<%# Eval("NumContacto") %>' runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td class="tr_fechainicio">
                                    <asp:Label ID="lblfechaInicio" Text='<%# Eval("FechaInicio") %>' runat="server" />
                                </td>
                                <td class="tr_fechafin">
                                    <asp:Label ID="lblfechaFin" Text='<%# Eval("FechaFin") %>' runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td class="tr_botonvacante" colspan="2">
                                    <asp:Button ID="btnPostular" Text="Postular" CommandName ="postular" runat="server" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
