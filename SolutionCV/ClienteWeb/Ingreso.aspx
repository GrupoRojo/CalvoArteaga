<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="ClienteWeb.Ingreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ingreso</h1>
    <div class="ingreso">
        <asp:Login ID="LoadIngreso" runat="server" OnAuthenticate="LoadIngreso_Autenticar">
            <LayoutTemplate>
                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre de usuario o Correo:</asp:Label>
                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="UserName" runat="server" class="form-control"></asp:TextBox>
                        
				<asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
				<asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="La contraseña es obligatoria." ToolTip="La contraseña es obligatoria." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="Password" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                <hr />
				<asp:CheckBox ID="RememberMe" runat="server" Text="Recordármelo la próxima vez."/>
                <hr />
                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Inicio de sesión" ValidationGroup="Login1" class="btn btn-primary"/>
                <div class="banda2">
					<asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
				</div>
            </LayoutTemplate>
        </asp:Login>
     </div>
</asp:Content>
