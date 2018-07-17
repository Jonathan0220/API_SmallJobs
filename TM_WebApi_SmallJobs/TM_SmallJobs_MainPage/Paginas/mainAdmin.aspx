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
                  <br>
                  <small> Inicia sesion</small>
                  </h4>
                  </a>

                </li>
                <li><a href="#"><span class="glyphicon glyphicon-home"></span> Inicio</a></li>
                <li><a href="#"><span class="glyphicon glyphicon-envelope"></span> Mensajes</a></li>
                <li><a href="#"><span class="glyphicon glyphicon-search"></span> Busqueda</a></li>
                <li>
                  <a href="#" data-toggle="collapse" data-target="#toggleDemo" data-parent="#sidenav01" class="collapsed">
                  <span class="glyphicon glyphicon-user"></span> Cuenta <span class="caret"></span>
                  </a>
                  <div class="collapse" id="toggleDemo" style="height: 0px;">
                    <ul class="nav nav-list">
                      <li><a href="#">Ajuste</a></li>
                      <li><a href="#">salir</a></li>
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
		    <div class="container">
                <h2><p class="text-center">Main Admin</p></h2>
                <br/>
                <br/>
                <form id="form1" runat="server">
                <div>
                Usuario Admin<br />
                    ID Usuario:
                    <asp:Label ID="idUsuario" runat="server" Text="Label"></asp:Label>
                </div>
                </form>
            </div>
        </div>
    </div>
    
</body>
</html>
