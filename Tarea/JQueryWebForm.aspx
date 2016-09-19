<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="JQueryWebForm.aspx.cs" Inherits="Tarea.JQueryWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 350px;
            height: 254px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Button ID="AccionButton" runat="server" Height="33px" Text="Presione Aqui" Width="146px" />
    </p>

        &nbsp;<img src="Pictures/Kawasaki.jpg" alt="logo" id="logo" class="auto-style2"/>

</asp:Content>
