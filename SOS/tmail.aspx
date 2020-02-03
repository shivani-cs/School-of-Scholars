<%@ Page Title="" Language="C#" MasterPageFile="~/teacher.master" AutoEventWireup="true" CodeFile="tmail.aspx.cs" Inherits="tmail" %>

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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
     <br/>
    <table cellspacing="8" style="width: 100%;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="To"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Columns="100" Rows="2" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="Subject"></asp:Label>
                </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Columns="100" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Rows="18" Columns="100"></asp:TextBox></td>
        </tr>
    </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Send" style="margin-left: 52px" Width="101px" OnClick="Button1_Click" />
     <br />
     <br />
     <asp:Label ID="Label4" runat="server" Font-Size="Large"></asp:Label>
</asp:Content>

