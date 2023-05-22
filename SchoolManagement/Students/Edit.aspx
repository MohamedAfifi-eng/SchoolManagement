<%@ Page Title="Update Student" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="SchoolManagement.Students.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h1 class="text-center">Update Student Informations</h1>
            

            <div class="col-md-4">
                    <div class="form-floating mb-2">
                        <asp:HiddenField ID="txtid" runat="server" />
                        <asp:TextBox runat="server" class="form-control" ID="txtFName"></asp:TextBox>
                        <label for="MainContent_txtFName">Firest Name</label>
                    </div>
                <asp:RequiredFieldValidator runat="server" CssClass="text-danger" ValidationGroup="myValidationGroup" ErrorMessage="Firest Name Is Required" ControlToValidate="txtFName" SetFocusOnError="True"></asp:RequiredFieldValidator>

                <div class="form-floating mb-2">
                        <asp:TextBox runat="server" class="form-control" ID="txtLName"></asp:TextBox>
                        <label for="MainContent_txtLName">Last Name</label>
                    </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="text-danger" ValidationGroup="myValidationGroup" ControlToValidate="txtLName" ErrorMessage="Last Name Is Required"></asp:RequiredFieldValidator>

                <div class="form-floating mb-2">
                        <asp:TextBox runat="server" class="form-control" ID="txtNotes"></asp:TextBox>
                        <label for="MainContent_txtNotes">Notes</label>
                    </div>
                    <div class="form-floating mb-2">
                        <asp:TextBox runat="server" class="form-control" ID="txtDOP" TextMode="DateTimeLocal" ></asp:TextBox>
                        <label for="MainContent_txtDOP">Date Of Birth</label>
                    </div>
                <asp:Button CssClass="btn btn-primary" ID="submitButton" runat="server" Text="Submit" ValidationGroup="myValidationGroup" OnClick="submitButton_Click1" />
                <a class="btn btn-outline-info" href="List.aspx">Cancel</a>

            </div>
        </div>
    </div>
</asp:Content>
