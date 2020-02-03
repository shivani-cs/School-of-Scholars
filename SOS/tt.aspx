<%@ Page Title="" Language="C#" MasterPageFile="~/student.master" AutoEventWireup="true" CodeFile="tt.aspx.cs" Inherits="tt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <style>
        table{
                width: 80%;
                margin-left: 10%;
                background-color:#DCDCDC;
               
            }
            
            th{
                background-color: #696969;
                height: 30px;
                vertical-align: center;
                color:white;
            }
            td{
                height: 50px;
                vertical-align: center;
                text-align: center;
                //color:white;
            }
            tr:hover{
                color: white;
                text-decoration:bold;
                background-color: #696969;
            }
            th, td {
            border-bottom: 1px solid #ddd;
            }
</style>
</asp:Content>

