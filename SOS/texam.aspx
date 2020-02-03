<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="texam.aspx.cs" Inherits="texam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table cellspacing="10" style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Question"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Columns="20" Rows="4" TextMode="MultiLine"></asp:TextBox></td>
           
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Option1"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Option2"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Option3"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Option4"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Correct Answer"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            
        </tr>

    </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Insert" style="margin-left: 49px" Width="141px" />
</asp:Content>

