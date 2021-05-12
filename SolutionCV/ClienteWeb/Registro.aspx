<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ClienteWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="registro">
        <h4 class="subtit">Registro</h4>
	    <div class="form-group">
            <label for="txtUsuario">usuario:</label>
            <asp:TextBox runat="server" ID="txtUsuario" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtCorreo">Correo Seguro:</label>
            <asp:TextBox runat="server" ID="txtCorreo" type="email" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtContrasena">Contraseña:</label>
            <asp:TextBox runat="server" ID="txtContrasena" type="password" class="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtConfirma">confirma Contraseña:</label>
            <asp:TextBox runat="server" ID="txtConfirma" type="password" class="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" class="btn btn-primary" OnClick="btnRegistrar_Click"/>
        <div class="form-group banda1">
            <asp:Label runat="server" ID="lblFecha"></asp:Label>
        </div>
    </div>
</asp:Content>
