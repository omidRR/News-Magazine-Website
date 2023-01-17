<%@ Page Title="" Language="C#" MasterPageFile="~/Master/mymaster.Master" AutoEventWireup="true" CodeBehind="Panel.aspx.cs" Inherits="News_Magazine_Website.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style type="text/css">
        body {
            font-family: 'Vazirmatn-Regular';
            font-family: Arial;
            font-size: 10pt;
        }

        table {
            width: 100%;
            background-color: #ffffff;
            border-collapse: collapse;
            padding: 10px;
            border-width: 2px;
            color: #000000;
            transition: 1s;
        }

        table th {
            background-color: #ff7f00;
            color: #fff;
            font-weight: bold;
            transition: 0.5s;
        }

        table th, table td {
            border-width: 1px;
            padding: 10px;
            text-align: center;
        }

        table, table table td {
            border: 0px solid #ccc;
        }
    </style>
    <div>

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>