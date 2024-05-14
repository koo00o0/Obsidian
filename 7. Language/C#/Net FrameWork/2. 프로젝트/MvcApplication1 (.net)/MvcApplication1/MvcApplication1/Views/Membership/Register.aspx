<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Register
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>회원가입</h2>

    <form method="post" >
        id: <input type="text" id="id" name="UserId" /><br/><br/>
        pw :<input type="text" id="pw" name="Password" /><br/>
        name : <input type="text" id="name" name="UserName" /><br/>
        <input type="submit" id="btnRegister" value="회원가입">
    </form>
    


</asp:Content>
