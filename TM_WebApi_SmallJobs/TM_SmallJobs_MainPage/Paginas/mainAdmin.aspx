<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainAdmin.aspx.cs" Inherits="TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.mainAdmin" %>

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
                  <br/>
                  Bienvenido: <br/>
                      <asp:Label Text="text" runat="server" ID ="lblNombre" />
                  </h4>
                  </a>


                </li>
                <li><a href="mainAdmin.aspx"><span class="glyphicon glyphicon-home"></span> Inicio</a></li>
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
          <h3>Small Jobs</h3>
        </div>
		    <div class="container" align="center">
                <h2><p class="text-center">Main Admin</p></h2>
               
                <form id="form1" runat="server">
                    <asp:Button class="btn btn-default btn-lg" ID="btnAdministrarUsuarios" runat="server" Text="Administrar Usuarios" CommandName="admin_usuarios"/>
                    <br />
                    <br />
                    <asp:Button class="btn btn-default btn-lg" ID="btnAdministrarTiposPedidos" runat="server" Text="Administrar Tipos de Pedidos" CommandName="admin_pedidos" />
                </form>

                <asp:Table ID="Table1" runat="server" class="table table-bordred table-striped">
                    <asp:TableRow runat="server" TableSection="TableHeader">
                        <asp:TableHeaderCell><input type="checkbox" id="checkall" /></asp:TableHeaderCell>
                           <asp:TableHeaderCell>First Name</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Last Name</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Address</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Email</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Contact</asp:TableHeaderCell>
                              <asp:TableHeaderCell>Edit</asp:TableHeaderCell>
                               <asp:TableHeaderCell>Delete</asp:TableHeaderCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell><input type="checkbox" class="checkthis" /></asp:TableCell>
                        <asp:TableCell>Mohsin</asp:TableCell>
                        <asp:TableCell>Irshad</asp:TableCell>
                        <asp:TableCell>CB 106/107 Street # 11 Wah Cantt Islamabad Pakistan</asp:TableCell>
                        <asp:TableCell>isometric.mohsin@gmail.com</asp:TableCell>
                        <asp:TableCell>+923335586757</asp:TableCell>
                        <asp:TableCell><p data-placement="top" data-toggle="tooltip" title="Edit"><button class="btn btn-primary btn-xs" data-title="Edit" data-toggle="modal" data-target="#edit" ><span class="glyphicon glyphicon-pencil"></span></button></p></asp:TableCell>
                        <asp:TableCell><p data-placement="top" data-toggle="tooltip" title="Delete"><button class="btn btn-danger btn-xs" data-title="Delete" data-toggle="modal" data-target="#delete" ><span class="glyphicon glyphicon-trash"></span></button></p></asp:TableCell>
            
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell><input type="checkbox" class="checkthis" /></asp:TableCell>
                        <asp:TableCell>Mohsin</asp:TableCell>
                        <asp:TableCell>Irshad</asp:TableCell>
                        <asp:TableCell>CB 106/107 Street # 11 Wah Cantt Islamabad Pakistan</asp:TableCell>
                        <asp:TableCell>isometric.mohsin@gmail.com</asp:TableCell>
                        <asp:TableCell>+923335586757</asp:TableCell>
                        <asp:TableCell><p data-placement="top" data-toggle="tooltip" title="Edit"><button class="btn btn-primary btn-xs" data-title="Edit" data-toggle="modal" data-target="#edit" ><span class="glyphicon glyphicon-pencil"></span></button></p></asp:TableCell>
                        <asp:TableCell><p data-placement="top" data-toggle="tooltip" title="Delete"><button class="btn btn-danger btn-xs" data-title="Delete" data-toggle="modal" data-target="#delete" ><span class="glyphicon glyphicon-trash"></span></button></p></asp:TableCell>
                        
                    </asp:TableRow>

                </asp:Table>
            </div>
        </div>
    </div>
    
</body>
</html>
