<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.RegistroUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        Nombre<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Correo<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Contraseña<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        Ubicacion<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        TipoUsuario<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="207px" />
        
    </div>
    </form>
</body>
</html>
