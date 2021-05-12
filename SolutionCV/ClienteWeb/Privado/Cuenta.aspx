<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cuenta.aspx.cs" Inherits="ClienteWeb.Privado.Cuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>Cuenta</div>
	<div class="Numbre de Usuario">
		<asp:LoginName ID="LoginName2" runat="server" />
	</div>
	<div class="Cerrar Sesion">
		<asp:LoginStatus ID="LoginStatus2" runat="server" />
	</div>

</asp:Content>
