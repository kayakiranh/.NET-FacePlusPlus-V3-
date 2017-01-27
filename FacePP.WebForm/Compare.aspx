<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Compare.aspx.cs" Inherits="FacePP.WebForm.Compare" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>Compare API</h1>
            <p><a href="https://console.faceplusplus.com/documents/5679308" target="_blank">Go to Full Document Page</a></p>
            <p>Important : if you can know/call tokens(from db, xml...), token versions is recommended. Token api names are inside full document page.</p>
            <p>Compare two faces and decide whether they are from the same person. You can upload image file or use face_token for face comparing. For image upload, the biggest face by the size of bounding box within the image will be used. For face_token, you shall get it by using Detect API.</p><br />
            <p>Format : JPG (JPEG), PNG<br>Size : between 48*48 and 4096*4096 (pixels)<br>File size : no larger than 2MB<br>Minimal size of face : the bounding box of a detected face is a square. The minimal side length of a square should be no less than 150 pixels.</p><br />
        </div>
        <div class="col-md-6">
            <h2>Compare API Form With Image Upload</h2>
            File 1 : <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
            File 2 : <asp:FileUpload ID="FileUpload2" runat="server" CssClass="form-control" /><br />
            <asp:Button ID="uploadButton" runat="server" Text="Compare With Upload" CssClass="btn btn-primary btn-block" OnClick="uploadButton_Click" />
        </div>
        <div class="col-md-6">
            <h2>Compare API With Image Link</h2>
            Image 1 : <asp:TextBox ID="linkUrl" runat="server" CssClass="form-control" Text="http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg" placeholder="Image Link"></asp:TextBox>
            Image 2 : <asp:TextBox ID="linkUrl2" runat="server" CssClass="form-control" Text="http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg" placeholder="Image Link"></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="Compare With Link" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click" />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>