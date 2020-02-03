<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="mail.aspx.cs" Inherits="mail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 55px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <br/>
    <table cellspacing="8" style="width: 100%;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="To"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Columns="100" Rows="2" TextMode="MultiLine" Font-Size="Large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="Subject"></asp:Label>
                </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Columns="100" TextMode="MultiLine" Rows="3" Font-Size="Large"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Rows="18" Columns="100" Font-Size="Medium"></asp:TextBox></td>
        </tr>
    </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Send" style="margin-left: 52px" Width="128px" Height="41px" OnClick="Button1_Click" />

    <br />
    <br />
    <asp:Label ID="Label4" runat="server"></asp:Label>

</asp:Content>

