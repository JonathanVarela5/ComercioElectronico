<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="ComercioProyecto.Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Proyecto Comercio Electronico<br />
            <br />
            Nombre&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-bottom: 0px" Width="171px"></asp:TextBox>
            <br />
            <br />
            Cedula&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="173px"></asp:TextBox>
            <br />
            <br />
            Direccion&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="171px"></asp:TextBox>
            <br />
            <br />
            Fecha&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="171px"></asp:TextBox>
            <br />
            <br />
            Total de Pago&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="136px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnAgregar" runat="server" OnClick="BtnAgregar_Click" Text="Agregar" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="Borrar" />
&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
