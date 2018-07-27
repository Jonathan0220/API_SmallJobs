﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.RegistroUsuarios" %>

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
    
		<div class="container">
        <div class="page-header">
          <h3><span class="glyphicon glyphicon-tower"></span> Small Jobs</h3>
        </div>

      <h2><p class="text-center">Formulario de Registro
          </p></h2>
      <br/>
      <br/>
          <form class="form-horizontal" id="form1" runat="server">

          <!-- inicio de Label e  input  -->
          <div class="form-group">
            <label class="control-label col-sm-2" for="TextBox1">Nombre:</label>
            <div class="col-sm-8">
                <asp:TextBox ID="TextBox1" runat="server" type="text" class="form-control"  placeholder="Ingresa tu Nombre" required="true"></asp:TextBox>
            </div>
          </div>
          <!--  fin Label e  input  -->
          <!-- inicio de Label e  input  -->
          <div class="form-group">
            <label class="control-label col-sm-2" for="TextBox2">Correo:</label>
            <div class="col-sm-8">
                <asp:TextBox ID="TextBox2" runat="server" type="email" class="form-control"  placeholder="Ingresa tu email" required="true"></asp:TextBox>
            </div>
          </div>
          <!--  fin Label e  input  -->
          <!-- inicio de Label e  input  -->
          <div class="form-group">
            <label class="control-label col-sm-2" for="TextBox3">Contraseña:</label>
            <div class="col-sm-8">
                <asp:TextBox ID="TextBox3" runat="server" type="password" class="form-control"  placeholder="Ingresa tu contraseña" required="true"></asp:TextBox>
            </div>
          </div>
          <!--  fin Label e  input  -->
          <!-- inicio de Label e  input  -->
          <div class="form-group">
            <label class="control-label col-sm-2" for="TextBox4">Ubicacion:</label>
            <div class="col-sm-8">
                <asp:TextBox ID="TextBox4" runat="server" type="text" class="form-control"  placeholder="Ingresa tu ubicación" required="true"></asp:TextBox>
            </div>
          </div>
          <!--  fin Label e  input  -->
          <!-- inicio de Label e  input  -->
          <div class="form-group">
            <label class="control-label col-sm-2" for="TextBox5">Tipo de usuario:</label>
            <div class="col-sm-8">
                <asp:DropDownList runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre" ID="ddlTipousuarios">
                    <asp:ListItem Text="text1" />
                    <asp:ListItem Text="text2" />
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TM_SMALLJOBSConnectionString %>" SelectCommand="SELECT [Nombre] FROM [tipoUsuarios]"></asp:SqlDataSource>
            </div>
          </div>
          <!--  fin Label e  input  -->

          <!--  incio del button  -->
          <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" class="btn btn-default" />
            </div>
          </div>
          <!--  Fin del button  -->
        </form>
            
		</div>
	</div>

    
</body>
</html>
