<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainVoluntario.aspx.cs" Inherits="TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.mainVoluntario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://netdna.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/estilo.css" rel="stylesheet" type="text/css"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <script src="jquery/jquery-1.11.1.min.js" type="text/javascript"/  ></script>
    <script src="jquery/bootstrap.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        window.alert = function(){};
        var defaultCSS = document.getElementById('bootstrap-css');
        function changeCSS(css){
            if(css) $('head > link').filter(':first').replaceWith('<link rel="stylesheet" href="'+ css +'" type="text/css" />');
            else $('head > link').filter(':first').replaceWith(defaultCSS);
        }
        $( document ).ready(function() {
          var iframe_height = parseInt($('html').height());
          window.parent.postMessage( iframe_height, 'https://bootsnipp.com');
        });
    </script>
</head>
<body>
    <div class="row affix-row">
    <div class="col-sm-3 col-md-2 affix-sidebar">
		<div class="sidebar-nav">
          <div class="navbar navbar-default" role="navigation">
            <div class="navbar-header">
              <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-navbar-collapse">
              <span class="sr-only">Toggle navigation</span>
              <span class="icon-bar"></span>
              <span class="icon-bar"></span>
              <span class="icon-bar"></span>
              </button>
              <span class="visible-xs navbar-brand">Sidebar menu</span>
            </div>
            <div class="navbar-collapse collapse sidebar-navbar-collapse" runat="server">
              <ul class="nav navbar-nav" id="sidenav01">
                <li class="active">
                <a href="#" data-toggle="collapse" data-target="#toggleDemo0" data-parent="#sidenav01" class="collapsed">
                  <h4>
                  Small Jobs
                  <br/>
                  Bienvenido: <br/>
                      <asp:Label Text="text" runat="server" ID ="lblNombre" />
                  </h4>
                  </a>
                </li>
                <li><a href="mainVoluntario.aspx"><span class="glyphicon glyphicon-home"></span> Inicio</a></li>
                <li><a href="#"><span class="glyphicon glyphicon-envelope"></span> Mensajes</a></li>
                <li><a href="#"><span class="glyphicon glyphicon-search"></span> Busqueda</a></li>
                <li>
                  <a href="#" data-toggle="collapse" data-target="#toggleDemo" data-parent="#sidenav01" class="collapsed">
                  <span class="glyphicon glyphicon-user"></span> Cuenta <span class="caret"></span>
                  </a>
                  <div class="collapse" id="toggleDemo" style="height: 0px;">
                    <ul class="nav nav-list">
                      <li><a href="ActualizarInformacion.aspx">Actualizar Información</a></li>
                      <li><a href="Loggin.aspx">salir</a></li>
                    </ul>
                  </div>
                </li>
              </ul>
              </div><!--/.nav-collapse -->
            </div>
        </div>
	    </div>
        <div class="col-sm-9 col-md-10 affix-content">
        <div class="page-header">
          <h3><span class="glyphicon glyphicon-tower"></span> Small Jobs</h3>
        </div>
		    <div class="container">
                <h2><p class="text-center">Main general</p></h2>
                <br/>
                <br/>
                <form id="form1" runat="server" align="center">
                <div>
                    usuario voluntario
               
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
                                            <asp:Button ID="btnPostular" Text="Postular" CommandName ="postular" CommandArgument='<%# Eval("idVacante") %>' runat="server" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </form>
            </div>
        </div>
    </div>

    
</body>
</html>
