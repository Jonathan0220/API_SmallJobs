<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loggin.aspx.cs" Inherits="TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.Loggin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Login</title>
    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <!-- Custom styles for this template -->
    <link href="css/signin.css" rel="stylesheet"/>
</head>
<body class="text-center">
    <form id="form1" runat="server" class="form-signin">
        <img class="mb-4" src="C:\Users\migue\Desktop\440727-best-no-game-no-life-wallpapers-1920x1200-laptop.jpg" alt="" width="72" height="72"/>
        <h1 class="h3 mb-3 font-weight-normal">Iniciar sesion</h1>
        
        <asp:Label ID="Label1" runat="server" Text="Correo" for="txtCorreo" class="sr-only"></asp:Label>
        <asp:TextBox ID="txtCorreo" runat="server" type="email" class="form-control" placeholder="Correo electronico" required="true"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Contraseña" for="txtContraseña" class="sr-only"></asp:Label>
        <asp:TextBox ID="txtContraseña" runat="server" type="password" class="form-control" placeholder="Contraseña" required="true"></asp:TextBox>
               
        <br />
        <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar"  class="btn btn-lg btn-primary btn-block"/>
       
        <br />

        <a href ="RegistroUsuarios.aspx">Resistrarte como usuario </a>
        <footer>
        <p class="mt-5 mb-3 text-muted">&copy; 2017-2018</p>
        </footer>
    </form>
    
     
</body>
</html>
