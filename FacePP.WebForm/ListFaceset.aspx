<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListFaceset.aspx.cs" Inherits="FacePP.WebForm.ListFaceset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>FaceSet GetFaceSets API</h1>
            <p><a href="https://console.faceplusplus.com/documents/6329430" target="_blank">Go to Full Document Page</a></p>
            <p>Get all the FaceSet.</p><br />
        </div>
        <div class="col-md-12">
            <h2>FaceSet GetFaceSets API Form</h2>
            Tags : <asp:TextBox ID="lfsTag" runat="server" CssClass="form-control" Text="Test" placeholder="Tags, Optional"></asp:TextBox>
            Start : <asp:TextBox ID="lfsStart" runat="server" CssClass="form-control" Text="1" placeholder="1-1000 (Default : 1)"></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="List Facesets" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click1" />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>