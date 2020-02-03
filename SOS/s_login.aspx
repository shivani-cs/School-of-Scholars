<%@ Page Language="C#" AutoEventWireup="true" CodeFile="s_login.aspx.cs" Inherits="s_login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
      .login-page{
          width: 360px;
          padding: 8% 0 0;
          margin: auto;
          margin-top: -50px;
      }
      .form {
            position: relative;
            z-index: 5;
            background: #FFFFFF;
            max-width: 360px;
            margin: 0 auto 50px;
            padding: 45px;
            text-align: center;
            box-shadow: 0 0 20px 0 rgba(0, 0, 0, 1), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
}

    #text,#password {
  font-family: "Roboto", sans-serif;
  border: 0px;
  background: #c6e1b2;
  width: 100%;
  margin-bottom: 15px;
  padding: 15px;
  box-sizing: border-box;
  font-size: 14px;
}
 #Button1 {
  font-family: "Roboto", sans-serif;
  text-transform: uppercase;
  outline: 0;
  background: #4CAF50;
  width: 100%;
  padding: 15px;
  color: #FFFFFF;
  font-size: 14px;
  //-webkit-transition: all 0.3 ease;
  //transition: all 0.3 ease;
  cursor: pointer;
}
#Button1:hover,#Button1:active,#Button1:focus {
  background: #43A047;
}

#topContent {
    text-align: center;
    background-color:#a0f230;
    color: White;
    font-size: x-large;
    text-decoration: none;
    font-weight: bold;
    //padding: 10px;
    height: 150px;
}



  </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <div id="topContent">
           <image src="SOS.bmp" alt="LOGO" width="250px" height="150px"> 
            <!--<a href="a.aspx">Master Pages</a> -->
        </div>
        
        <div class="login-page">

        

        <div class="form">
            
            <asp:TextBox ID="text" runat="server" placeholder="USERNAME"></asp:TextBox>
            <asp:TextBox ID="password" runat="server" TextMode="Password" placeholder="PASSWORD"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOG IN" />
         </div>
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    </form>
        
    </div>
    </form>
</body>
</html>
