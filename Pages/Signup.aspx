<%@ Page Title="" Language="C#" MasterPageFile="~/Master/mymaster.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="News_Magazine_Website.Pages.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>ثبت نام - مجلات خبری</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="imageSignup">
        <img class="imagesignupsettings" src="../Images/ui-fixed.png" alt="Snow" style="width: 100%; height: 500px">
        <div id="itemmmm">
            <div class="SignUpItem">
                
                <div class="form-group">
                    <input type="text" class="Signup-Control" runat="server" id="NameID" placeholder="نام و نام خانوادگی"/>
                </div>
                <div class="form-group">
                    <input type="number" class="Signup-Control" maxlength="10"  runat="server" id="CodemeliID" placeholder="نام کاربری (کدملی)"/>
                </div>
                <div class="form-group">
                    <input type="email" class="Signup-Control" runat="server" id="emailID" placeholder="ایمیل"/>
                </div>
                <div class="form-group">
                    <input type="password" class="Signup-Control" runat="server" id="passwordID" placeholder="پسورد"/>
                </div>
                <div class="form-group">
                    <input type="password" class="Signup-Control" runat="server" id="confirm_passwordID" placeholder="تکرار مجدد پسورد"/>
                </div>
                <div class="formbtncreataccount">
                    <button  class="btn-CreateAccount" id="btnCreataccID" runat="server" onserverclick="btnCreataccID_OnServerClick">ایجاد حساب کاربری</button>
                </div>
                <div>
                    <hr class="fasele" />
                    <button class="btn-LoginAccount" id="btnLoginAccountID" onserverclick="btnLoginAccountID_ServerClick" runat="server">ورود به اکانت </button>
                </div>
                <div><a class="forgetpassword-a" runat="server" href="#">فراموشی رمز</a></div>
            </div>
        </div>
    </div>




</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
