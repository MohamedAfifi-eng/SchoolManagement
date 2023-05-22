<%@ Page Title="Delete Student" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="SchoolManagement.Students.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 class="text-center"> Do You Want <span class="text-danger"> Delete</span> <asp:Label ID="lblName" runat="server"></asp:Label> From Students List ?</h3>
    <p class="text-center">
        <asp:Button runat="server" ID="btnConfirm" Text="Yes" CssClass="btn btn-outline-danger" OnClick="btnConfirm_Click" />
        <a class="btn btn-secondary" href="List">No</a>
    </p>
</asp:Content>
