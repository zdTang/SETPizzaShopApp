<%@ Page Title="" Language="C#" MasterPageFile="~/SETPizzaApp.Master" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="SETPizzaShopApp.Page2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    SET Pizza Shop - Page2
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="sectionName" runat="server">
    Page 2
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    
    <asp:Table ID="layoutTable" runat="server" CssClass="OrderTable">
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="ingredientView" runat="server"> </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                &nbsp
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell runat="server" ID="feedback" CssClass="errorMessage"></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Style="text-align:center">
                <asp:Button ID="enter" runat="server" Text="Make It!" CausesValidation="true" OnClick="enter_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
