<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailFaceset.aspx.cs" Inherits="FacePP.WebForm.DetailFaceset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>FaceSet GetDetail API</h1>
            <p><a href="https://console.faceplusplus.com/documents/6329388" target="_blank">Go to Full Document Page</a></p>
            <p>Important : if you can know/call tokens(from db, xml...), token versions is recommended. Token api names are inside full document page.</p>
            <p>Get details about a FaceSet.</p><br />
        </div>
        <div class="col-md-12">
            <h2>FaceSet GetDetail API Form</h2>
            Outer ID : <asp:TextBox ID="dfsOuter" runat="server" CssClass="form-control" Text="Test" placeholder="Outer ID" required></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="GetDetail Faceset" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click" />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>