<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RemoveFaceFromFaceset.aspx.cs" Inherits="FacePP.WebForm.RemoveFaceFromFaceset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>FaceSet RemoveFace API</h1>
            <p><a href="https://console.faceplusplus.com/documents/6329376" target="_blank">Go to Full Document Page</a></p>
            <p>Important : if you can know/call tokens(from db, xml...), token versions is recommended. Token api names are inside full document page.</p>
            <p>Remove all or part of face_token within a FaceSet.</p><br />
        </div>
        <div class="col-md-12">
            <h2>FaceSet RemoveFace API Form</h2>
            Link : <asp:TextBox ID="fsrfUrl" runat="server" CssClass="form-control" Text="http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg" placeholder="Image Link"></asp:TextBox>
            Outer ID : <asp:TextBox ID="fsrfOuter" runat="server" CssClass="form-control" Text="Test" placeholder="Outer ID"></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="Remove Face From Faceset" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click"/>
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>