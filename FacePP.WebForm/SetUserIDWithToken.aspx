<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SetUserIDWithToken.aspx.cs" Inherits="FacePP.WebForm.SetUserIDWithToken" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>Face SetUserID API</h1>
            <p><a href="https://console.faceplusplus.com/documents/6329500" target="_blank">Go to Full Document Page</a></p>
            <p>Important : if you can know/call tokens(from db, xml...), token versions is recommended. Token api names are inside full document page.</p>
            <p>Set user_id for a detected face. user_id can be returned in Search results to determine the identity of user.</p><br />
        </div>
        <div class="col-md-12">
            <h2>Face SetUserID API Form</h2>
            Link : <asp:TextBox ID="suivtUrl" runat="server" CssClass="form-control" Text="http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg" placeholder="Image Link" required></asp:TextBox>
            Landmark : <asp:TextBox ID="suivtLandmark" runat="server" CssClass="form-control" placeholder="1/0 (Default : 0)" Text="1"></asp:TextBox>
            Attribute : <asp:TextBox ID="suivtAttribute" runat="server" CssClass="form-control" placeholder="gender,age,smiling,headpose,facequality,blur,eyestatus (Default : none)" Text="gender,age,smiling,headpose,facequality,blur,eyestatus"></asp:TextBox>
            New User ID : <asp:TextBox ID="suivtUser" runat="server" CssClass="form-control" Text="Test" placeholder="New User ID" required></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="Set UserID" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click" />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>