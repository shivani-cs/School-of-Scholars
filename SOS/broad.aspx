<%@ Page Language="C#" AutoEventWireup="true" CodeFile="broad.aspx.cs" Inherits="broad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
    <title></title>
</head>
<body>
    
    <form id="form2" runat="server">
    <div>
    
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Height="258px" OnTextChanged="TextBox4_TextChanged" ReadOnly="True" TextMode="MultiLine" Width="424px"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 204px; margin-top: 0px" Text="Button" />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Width="339px" placeholder="Type Your Message here"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
    
</body>
</html>
