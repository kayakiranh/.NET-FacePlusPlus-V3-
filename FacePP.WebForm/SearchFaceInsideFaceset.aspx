<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchFaceInsideFaceset.aspx.cs" Inherits="FacePP.WebForm.SearchFaceInsideFaceset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>Search API</h1>
            <p><a href="https://console.faceplusplus.com/documents/5681455" target="_blank">Go to Full Document Page</a></p>
            <p>Important : if you can know/call tokens(from db, xml...), token versions is recommended. Token api names are inside full document page.</p>
            <p>Find one or more most similar faces from Faceset, to a new face. You can upload image file or use face_token for face searching. For image upload, the biggest face by the size of bounding box within the image will be used. For face_token, you shall get it by using Detect API.</p><br />
        </div>
        <div class="col-md-12">
            <h2>Search API Form</h2>
            Link : <asp:TextBox ID="sfifUrl" runat="server" CssClass="form-control" Text="http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg" placeholder="Image Link" required></asp:TextBox>
            Outer ID : <asp:TextBox ID="sfifOuter" runat="server" CssClass="form-control" Text="Test" placeholder="Outer ID" required></asp:TextBox>
            Result Count : <asp:TextBox ID="sfifForce" runat="server" CssClass="form-control" Text="1" placeholder="1,5 (Default : 1)"></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="Search Face Inside Faceset" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click" />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>