<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotificacionesGeneral.aspx.cs" Inherits="TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.NotificacionesGeneral" %>

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
            <p>Vacantes Pendientes</p>
             
           <form id="form1" runat="server">
     <div>
    <asp:GridView ID="GridView1" class="table table-bordred table-striped" runat="server" AutoGenerateColumns="False" DataKeyNames="idVacante" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="idVacante" HeaderText="idVacante" InsertVisible="False" ReadOnly="True" SortExpression="idVacante" />
            <asp:BoundField DataField="NombreVacante" HeaderText="NombreVacante" SortExpression="NombreVacante" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
            <asp:BoundField DataField="TipoPedido" HeaderText="TipoPedido" SortExpression="TipoPedido" />
            <asp:BoundField DataField="FechaInicio" HeaderText="FechaInicio" SortExpression="FechaInicio" />
            <asp:BoundField DataField="FechaFin" HeaderText="FechaFin" SortExpression="FechaFin" />
        </Columns>
         </asp:GridView>
         
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TM_SMALLJOBSConnectionStringADO %>" SelectCommand="
  SELECT [idVacante],[NombreVacante],[Descripcion],[TipoPedido],[FechaInicio],[FechaFin] FROM [TM_SMALLJOBS].[dbo].[Vacante]

"></asp:SqlDataSource>
         
    </div>
        
    </form>
            </div>
        </div>

    
</body>
</html>
