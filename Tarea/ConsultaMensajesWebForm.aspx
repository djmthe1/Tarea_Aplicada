<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ConsultaMensajesWebForm.aspx.cs" Inherits="Tarea.ConsultaMensajesWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource2" Width="795px">
    </asp:GridView>
</asp:Content>
