<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="SchoolManagement.Students.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h1 class="text-center">Student List</h1>
        </div>
        <div class="row">
            <p>
                <a class="btn btn-info my-3" href="Create">Create</a>
            </p>
            <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover table-striped table-bordered text-center" AutoGenerateColumns="False" EnableSortingAndPagingCallbacks="True">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID"></asp:BoundField>
                    <asp:BoundField DataField="FName" HeaderText="Firest Name"></asp:BoundField>
                    <asp:BoundField DataField="LName" HeaderText="Last Name"></asp:BoundField>
                    <asp:BoundField DataField="DateOfBirth" HeaderText="Date Of Birth"></asp:BoundField>
                    <asp:BoundField DataField="Notes" HeaderText="Notes"></asp:BoundField>
                    <asp:HyperLinkField ControlStyle-CssClass="btn btn-outline-info" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="~/Students/Edit.aspx?id={0}" NavigateUrl="~/Students/Edit.aspx" Text="Edit" HeaderText="Edit"></asp:HyperLinkField>
                    <asp:HyperLinkField ControlStyle-CssClass="btn btn-outline-danger" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="~/Students/Delete.aspx?id={0}" NavigateUrl="~/Students/Delete.aspx" Text="Delete" HeaderText="Delete"></asp:HyperLinkField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
