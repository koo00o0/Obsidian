<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Login
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Login</h2>
    <div class="row">
    <div class="col-md-4">
        <form method="post">
        <%: Html.AntiForgeryToken() %>
            <div class="text-danger"></div>
            <div class="form-group">
                <input type="text" class="form-control" name="UserId" />
            </div>
            <div class="form-group">
                <input type="password" class="form-control" name="Password"  />
            </div>
            <button type="submit" name="btnLogin" class="btn btn-lg btn-success btn-block">멤버십 로그인</button>
        </form>  
    </div>
</div>

</asp:Content>
