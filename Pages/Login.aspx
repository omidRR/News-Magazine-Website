<%@ Page Title="" Language="C#" MasterPageFile="~/Master/mymaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="News_Magazine_Website.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>ورود به اکانت - مجلات خبری</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="imageSignin2">
        <img class="imageSigninsettings2" src="../Images/ui-fixed.png" alt="Snow" style="width: 100%; height: 500px">
        <div id="itemmmm2">
            <div class="SigninItem2">

                <div class="form-group2">
                    <input type="number" class="Signin-Control2" runat="server" id="codemeliID" maxlength="10" placeholder="نام کاربری">
                </div>
                <div class="form-group">
                    <input type="password" class="Signin-Control2" runat="server" id="passwordID" placeholder="پسورد">
                </div>

                <div class="formbtncreataccount">
                    <button class="btn-LoginAccount2" id="LoginID2" onserverclick="LoginID2_ServerClick" runat="server">ورود به اکانت </button>
                </div>

                <div>
                    <hr class="fasele" />
                    <button class="btn-CreateAccountinlogin2" id="btnCreataccID2" runat="server" onserverclick="btnCreataccID2_ServerClick">ایجاد حساب کاربری</button>

                </div>
                <div><a class="forgetpassword-a2" runat="server" href="#">فراموشی رمز</a></div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>