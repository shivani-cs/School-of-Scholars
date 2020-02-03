<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="tregister.aspx.cs" Inherits="register2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 211px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table cellspacing="10" style="width: 100%;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="206px"></asp:TextBox>
                </td>
        </tr>&nbsp;&nbsp;&nbsp;
         
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Birth Date"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" placeholder="yyyy/mm/dd" TextMode="Date"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Email Id"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Email"></asp:TextBox></td>
        </tr>
       
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="Contact"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Phone"></asp:TextBox></td>
        </tr>
         
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" Text="Qualification"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
        
        </tr>
        
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label6" runat="server" Text="Salary"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
        </tr>
         
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label7" runat="server" Text="Subject"></asp:Label></td>
            <td>
                <asp:ListBox ID="ListBox1" runat="server" Rows="1">
                    <asp:ListItem>Select </asp:ListItem>
                    <asp:ListItem>Math</asp:ListItem>
                    <asp:ListItem>Science</asp:ListItem>
                    <asp:ListItem>English</asp:ListItem>
                    <asp:ListItem>History</asp:ListItem>
                    <asp:ListItem>Geography</asp:ListItem>
                </asp:ListBox></td>
        </tr>
         
         <tr>
            <td class="auto-style1">
                <asp:Label ID="Label9" runat="server" Text="Classteacher"></asp:Label></td>
            <td>
                <asp:ListBox ID="ListBox2" runat="server" Rows="1">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    
                </asp:ListBox></td>
        </tr>
        </table>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
    <br />
    &nbsp;&nbsp;
                 <asp:Button ID="Button1" runat="server" Text="Insert" Width="130px" Height="36px" OnClick="Button1_Click" />
             &nbsp;&nbsp;&nbsp;
            
   
    <asp:Button ID="Button2" runat="server" Height="36px" OnClick="Button2_Click" Text="Reset" Width="131px" />
    <br />
    <br />
    <asp:Label ID="Label10" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Height="31px" OnClick="Button3_Click" Text="Retry" Width="99px" />
            
   
</asp:Content>

