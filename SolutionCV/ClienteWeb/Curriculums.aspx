<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Curriculums.aspx.cs" Inherits="ClienteWeb.Curriculums" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="tabla">
        <asp:GridView ID="dgvTabla" runat="server"></asp:GridView>
    </div>
    <hr />
    <div class="container-fluid">
	<div class="row">
		<div class="col-md-3">
            <div class="blanco1">
                <a href="#" class="btn btn-success">General</a>

            </div>
		</div>
		<div class="col-md-9">
            <div class="blanco1">
                <asp:Panel ID="PnlPersonas" runat="server">
                    <div>contenido</div>
                </asp:Panel>
                <div class="persona">
                    <asp:Image ID="Image1" runat="server" />
                    <img src="cbs/nos1.jpg" class="personaFoto" />
                    <h4>Cobos Vargas</h4>
                    <h5>Irvin Julian</h5>
                    <p>Carrera</p>
                </div>
                <div class="persona">
                    <h4>Cobos Vargas</h4>
                    <h5>Irvin Julian</h5>
                    <p>Carrera</p>
                </div>
                <div class="persona">
                    <h4>Cobos Vargas</h4>
                    <h5>Irvin Julian</h5>
                    <p>Carrera</p>
                </div>
                <div class="limpia"></div>
            </div>
		</div>
	</div>
</div>
</asp:Content>
