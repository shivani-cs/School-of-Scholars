<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="a_default.aspx.cs" Inherits="a_default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <script type="text/javascript">
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
    <h2>Welcome!</h2>
    <p>
        Welcome to the demo application for the Master Page Tutorials. Over the course 
        of the next several tutorials this demo application will illustrate a variety of 
        features of master pages, including:</p>
    <ul>
        <li>Creating master pages and content pages</li>
        <li>Using multiple ContentPlaceHolder controls</li>
        <li>Specifying Title, META tags, and other HTML header contents</li>
        <li>Correctly basing URLs</li>
        <li>Control ID naming</li>
        <li>Master page and content page interaction</li>
        <li>Master pages and ASP.NET AJAX</li>
        <li>Specifying a content page&#39;s master page programmatically</li>
        <li>sample page </li>

    </ul>
</asp:Content>

