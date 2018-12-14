<%@ Page Title="" Language="C#" MasterPageFile="~/SETPizzaApp.Master" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="SETPizzaShopApp.Page1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    SET Pizza Shop - Page1
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="sectionName" runat="server">
    Page1
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <asp:Table ID="layoutTable" runat="server" CssClass="OrderTable">
        <asp:TableRow>
            <asp:TableCell Style="text-align:right" Width="50%">
                <asp:RequiredFieldValidator ID="nameRequired" runat="server" ValidationGroup="nameValidation"
                    ControlToValidate="nameInput" CssClass="errorMessage"
                    ErrorMessage="Name cannot be empty." Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:Label runat="server" Text="Name"></asp:Label>
            </asp:TableCelL>
            <asp:TableCell Style="text-align:left">
                <asp:TextBox ID="nameInput" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell Style="text-align:left" Width="40%">
                <asp:RegularExpressionValidator ID="nameRegex" runat="server" ControlToValidate="nameInput"
                    ValidationGroup="nameValidation" ValidationExpression="[A-Za-z ]{1,}" Display="None"
                    ErrorMessage="Name con contain only alphabetical values.">
                </asp:RegularExpressionValidator>
                <asp:ValidationSummary runat="server" ValidationGroup="nameValidation" CssClass="errorMessage" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                &nbsp
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3" Style="text-align:center">
                <asp:Button ID="enter" runat="server" Text="Submit" CausesValidation="true" OnClick="enter_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
