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
            ID Usuario:
        <asp:Label ID="idUsuario" runat="server" Text="Label"></asp:Label>

            <div class="tablaRepeater">
                <table class="tg">
                    <tr>
                        <th class="tr_nombre-vacante" colspan="3">
                             <asp:Label ID="lblnombreVacante" Text="Nombre de la vacante" runat="server" />
                        </th>
                    </tr>
                    <tr>
                        <td class="tr_ubicacion" rowspan="5">
                             <asp:Label ID="lblubicacion" Text="ubicacion" runat="server" />
                        </td>
                        <td class="tr_tipovacante" colspan="2">
                             <asp:Label ID="lbltipoVacante" Text="Tipo de vacante" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tr_descripcion" colspan="2">
                             <asp:Label ID="lbldescripcion" Text="Descripcion de vacante" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tr_numerocontacto" colspan="2">
                             <asp:Label ID="lblnumeroContacto" Text="Numero Contacto" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tr_fechainicio"> 
                            <asp:Label ID="lblfechaInicio" Text="Fecha inicio" runat="server" />
                        </td>
                        <td class="tr_fechafin">
                            <asp:Label ID="lblfechaFin" Text="Fecha fin" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tr_botonvacante" colspan="2">
                            <asp:Button ID="btnPostular" Text="Postular" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
