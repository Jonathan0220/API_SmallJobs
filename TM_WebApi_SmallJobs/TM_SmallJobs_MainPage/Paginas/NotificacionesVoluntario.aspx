<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotificacionesVoluntario.aspx.cs" Inherits="TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.Notificaciones" %>

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

    <div>
        <div class="row affix-row">
    
		<div class="container">
        <div class="page-header">
          <h3><span class="glyphicon glyphicon-tower"></span> Small Jobs</h3>
        </div>
           <%-- <asp:Table ID="Table1" runat="server" class="table table-bordred table-striped">
                    <asp:TableRow runat="server" TableSection="TableHeader">
                           <asp:TableHeaderCell>idVacante</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Nombre Vacante</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Fecha inicio</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Fecha Fin</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Mensaje</asp:TableHeaderCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell>1</asp:TableCell>
                        <asp:TableCell>Trabajo de carpinteria</asp:TableCell>
                        <asp:TableCell>26/07/2018</asp:TableCell>
                        <asp:TableCell>30/07/2018</asp:TableCell>
                        <asp:TableCell>Jorge</asp:TableCell>
                        <asp:TableCell>Cerrar vacante <p data-placement="top" data-toggle="tooltip" title="Edit"><button class="btn btn-primary btn-xs" data-title="Edit" data-toggle="modal" data-target="#edit" ><span class="glyphicon glyphicon-pencil"></span></button></p></asp:TableCell>
            
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell>2</asp:TableCell>
                        <asp:TableCell>Trabajo de Plomeria</asp:TableCell>
                        <asp:TableCell>26/07/2018</asp:TableCell>
                        <asp:TableCell>30/07/2018</asp:TableCell>
                        <asp:TableCell>Jorge</asp:TableCell>
                        <asp:TableCell>Cerrar vacante <p data-placement="top" data-toggle="tooltip" title="Edit"><button class="btn btn-primary btn-xs" data-title="Edit" data-toggle="modal" data-target="#edit" ><span class="glyphicon glyphicon-pencil"></span></button></p></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell>3</asp:TableCell>
                        <asp:TableCell>Trabajo de Limpieza</asp:TableCell>
                        <asp:TableCell>26/07/2018</asp:TableCell>
                        <asp:TableCell>30/07/2018</asp:TableCell>
                        <asp:TableCell>Jorge</asp:TableCell>
                        <asp:TableCell>Cerrar vacante <p data-placement="top" data-toggle="tooltip" title="Edit"><button class="btn btn-primary btn-xs" data-title="Edit" data-toggle="modal" data-target="#edit" ><span class="glyphicon glyphicon-pencil"></span></button></p></asp:TableCell>
                    </asp:TableRow>

                </asp:Table>
            <p>Vacantes Pendientes</p>
             <asp:Table ID="Table2" runat="server" class="table table-bordred table-striped">
                    <asp:TableRow runat="server" TableSection="TableHeader">
                           <asp:TableHeaderCell>idVacante</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Nombre Vacante</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Fecha inicio</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Fecha Fin</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Voluntario</asp:TableHeaderCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell>1</asp:TableCell>
                        <asp:TableCell>Trabajo de Plomeria</asp:TableCell>
                        <asp:TableCell>26/07/2018</asp:TableCell>
                        <asp:TableCell>30/07/2018</asp:TableCell>
                        <asp:TableCell>Jorge</asp:TableCell>
                        <asp:TableCell>Rechazar vacante <p data-placement="top" data-toggle="tooltip" title="Edit"><button class="btn btn-primary btn-xs" data-title="Edit" data-toggle="modal" data-target="#edit" ><span class="glyphicon glyphicon-pencil"></span></button></p></asp:TableCell>
                        <asp:TableCell>Aceptar vacante <p data-placement="top" data-toggle="tooltip" title="Edit"><button class="btn btn-primary btn-xs" data-title="Edit" data-toggle="modal" data-target="#edit" ><span class="glyphicon glyphicon-pencil"></span></button></p></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>--%>
            <asp:Table ID="Table1" runat="server" class="table table-bordred table-striped">
                    <asp:TableRow runat="server" TableSection="TableHeader">
                            <asp:TableHeaderCell>Usuario Remitente</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Descripcion</asp:TableHeaderCell>
                             <asp:TableHeaderCell>Fecha</asp:TableHeaderCell>

                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell>Teno</asp:TableCell>
                        <asp:TableCell>Ha solicitado eliminar su cuenta</asp:TableCell>
                        <asp:TableCell>26/07/2018</asp:TableCell>
                        <asp:TableCell>Eliminar <p data-placement="top" data-toggle="tooltip" title="Edit"><button class="btn btn-primary btn-xs" data-title="Close" data-toggle="modal" data-target="#edit" ><span class="glyphicon glyphicon-pencil"></span></button></p></asp:TableCell>
            
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell>Jorge</asp:TableCell>
                        <asp:TableCell>Ha solicitado cambiar su contraseña</asp:TableCell>
                        <asp:TableCell>30/07/2018</asp:TableCell>
                        <asp:TableCell>Eliminar <p data-placement="top" data-toggle="tooltip" title="Edit"><button class="btn btn-primary btn-xs" data-title="Close" data-toggle="modal" data-target="#edit" ><span class="glyphicon glyphicon-pencil"></span></button></p></asp:TableCell>
                    </asp:TableRow>
                    

                </asp:Table>


            </div>
            </div>
        </div>

    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
