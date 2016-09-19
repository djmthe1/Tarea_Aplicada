<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="JQueryWebForm.aspx.cs" Inherits="Tarea.JQueryWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 350px;
            height: 254px;
        }
    </style>
    <script type="text/javascript">
        $(document).ready(function(){ 
        $('#alternar-respuesta').on('click',function(){
        $('#respuesta').toggle();
            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Button ID="AccionButton" runat="server" Height="33px" Text="VOLVER" Width="88px" OnClick="AccionButton_Click" />
    </p>
    <div id="contenido">
        <p>&nbsp;<p>Que motor es ?... (<a href="#" id="alternar-respuesta">Mostrar</a>)
 
        <p>&nbsp;<p>&nbsp;<p>&nbsp;<p>&nbsp;<p>&nbsp;<p>&nbsp;<div id="respuesta" style="display:none">
        &nbsp;<img src="Pictures/Kawasaki.jpg" alt="logo" id="logo" class="auto-style2"/></div>
     </div>

</asp:Content>
