<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainGeneral.aspx.cs" Inherits="TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.mainGeneral" %>

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
            <div class="navbar-collapse collapse sidebar-navbar-collapse">
              <ul class="nav navbar-nav" id="sidenav01">
                <li class="active">
                  <a href="#" data-toggle="collapse" data-target="#toggleDemo0" data-parent="#sidenav01" class="collapsed">
                  <h4>
                  Small Jobs
                  <br>
                  <small> Inicia sesion</small>
                  </h4>
                  </a>

                </li>
                <li><a href="#"><span class="glyphicon glyphicon-home"></span> Inicio</a></li>
                <li><a href="#"><span class="glyphicon glyphicon-envelope"></span> Mensajes</a></li>
                <li><a href="#"><span class="glyphicon glyphicon-search"></span> Busqueda</a></li>
                <li id="Button4">
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
          <h3><span class="glyphicon glyphicon-tower"></span> Navigation</h3>
        </div>
		    <div class="container" align="center">
                <h2><p class="text-center">Main general</p></h2>
                <br/>
                <br/>
                <div>
                usuario general
                    <br />
                    ID Usuario:
                    <asp:Label ID="idUsuario" runat="server" Text="Label"></asp:Label>
                </div>
             <!-- Trigger the modal with a button -->
        <button type="button" class="btn btn-default btn-lg" id="myBtn">Login</button>
            </div>
           
        <!-- Modal -->
        <div class="modal fade" id="myModal">
          <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
              <div class="modal-header" style="padding:35px 50px;">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4><span class="glyphicon glyphicon-lock"></span> Login</h4>
              </div>
              <div class="modal-body" style="padding:40px 50px;">
                <form class="form-horizontal" runat="server">
                  <!-- inicio de Label e  input  -->
                  <div class="form-group">
                    <label class="control-label col-sm-2" for="text">Nombre de Vacante</label>
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" placeholder="Nombre de vacante" class="form-control" ID="txtNombreVacante" />
                    </div>
                  </div>
                  <!--  fin Label e  input  -->
                  <!-- inicio de Label e  input  -->
                  <div class="form-group">
                    <label class="control-label col-sm-2" for="pwd">Descrion de vacante</label>
                    <div class="col-sm-8">
                        <asp:Textbox runat="server" placeholder="decripcion de vacante" class="form-control" ID="txtDescripcion" />
                    </div>
                  </div>
                  <!--  fin Label e  input  -->
                  <!-- inicio de Label e  input  -->
                  <div class="form-group">
                    <label class="control-label col-sm-2" for="email">Tipo de Pedido</label>
                    <div class="col-sm-8" runat ="server">
                        <asp:DropDownList runat="server" DataSourceID="SqlDataSource1" ID="ddlTipoPedido" DataTextField="Nombre" DataValueField="Nombre" class="form-control" >
                            
                        </asp:DropDownList>
                    </div>
                  </div>
                  <!--  fin Label e  input  -->
                  <!-- inicio de Label e  input  -->
                  <div class="form-group">
                    <label class="control-label col-sm-2" for="pwd">Numero de Contacto:</label>
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" placeholder="Numero de contacto" type="numeric" ID="txtNumcontacto" class="form-control"  />
                    </div>
                  </div>
                     <!--  fin Label e  input  -->
                    <!-- inicio de Label e  input  -->
                  <div class="form-group">
                    <label class="control-label col-sm-2" for="pwd">Dirección:</label>
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" placeholder="Dirección"  ID="txtDireccion" class="form-control"  />
                    </div>
                  </div>
                     <!--  fin Label e  input  -->
                    <!-- inicio de Label e  input  -->
                  <div class="form-group">
                    <label class="control-label col-sm-2" for="pwd">Fecha Inicio</label>
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" placeholder="Fecha de inicio"  ID="txtFechaInicio" class="form-control"  />
                    </div>
                  </div>
                    <!-- inicio de Label e  input  -->
                  <div class="form-group">
                    <label class="control-label col-sm-2" for="pwd">Fecha Fin:</label>
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" placeholder="Fecha Fin" type="numeric" ID="txtFechaFin" class="form-control"  />
                    </div>
                  </div>
                     <!--  fin Label e  input  -->
                     <!--  fin Label e  input  -->
                  <!--  incio del button  -->
                  <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button CommandName ="publicar" OnClick="Button_ModalClick" Text="Publicar" class="btn btn-default" runat="server" ID="btnPublicar" />
                    </div>
                  </div>
                  <!--  Fin del button  -->
                </form>
              </div>
            </div>

          </div>
        </div>
        </div>
    </div>

    <script>
$(document).ready(function(){
    $("#myBtn").click(function () {
        $("#myModal").modal();
       
    });

});
</script>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TM_SMALLJOBSConnectionString %>" SelectCommand="SELECT [Nombre] FROM [TipoPedido]"></asp:SqlDataSource>
    

</body>
</html>
