<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="sregister.aspx.cs" Inherits="register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
    <style type="text/css">
        .auto-style1 {
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
     <table cellspacing="10" style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="First Name"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" placeholder="Middle Name"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
                <asp:TextBox ID="TextBox3" runat="server" placeholder="Last Name"></asp:TextBox>
                </td>
         <td>
                &nbsp;</td>
            <td>
           
                &nbsp;</td> 
        </tr>&nbsp;&nbsp;&nbsp;
           <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Father Name"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
        
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Mother Name"></asp:Label></td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label></td>
            <td>
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="g1" Text="Male" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="g1" Text="Female" /></td>
             <td>
                 &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Birth Date"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" placeholder="yyyy/mm/dd" TextMode="Date"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" Columns="20" Rows="2" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Email Id"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server" TextMode="Email"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Contact"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" TextMode="Phone"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Standard"></asp:Label></td>
            <td>
                <asp:ListBox ID="ListBox1" runat="server" Rows="1">
                    <asp:ListItem>Select </asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                </asp:ListBox></td>
        </tr>
          </table>
         
                 &nbsp;
     <br />
     <br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
                 <asp:Button ID="Button1" runat="server" Text="Insert" Width="139px" OnClick="Button1_Click" Height="38px" />
             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="Button2" runat="server" Text="Refresh" OnClick="Button2_Click" Height="36px" Width="140px" />
     <br />
     <br />
     <asp:Label ID="Label10" runat="server"></asp:Label>
     <asp:Button ID="Button3" runat="server" style="margin-left: 283px" Text="Retry" OnClick="Button3_Click" Height="37px" Width="116px" />
             
</asp:Content>

