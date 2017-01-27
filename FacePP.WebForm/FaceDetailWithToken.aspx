<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FaceDetailWithToken.aspx.cs" Inherits="FacePP.WebForm.FaceDetailWithToken" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>Face GetDetail API</h1>
            <p><a href="https://console.faceplusplus.com/documents/6329496" target="_blank">Go to Full Document Page</a></p>
            <p>Important : if you can know/call tokens(from db, xml...), token versions is recommended. Token api names are inside full document page.</p>
            <p>Get related information to a face by passing its face_token which you can get from Detect API. Face related information includes image_id and FaceSet which it belongs to.</p><br />
        </div>
        <div class="col-md-12">
            <h2>Face GetDetail API Form With Image Link</h2>
            Link : <asp:TextBox ID="fdwtUrl" runat="server" CssClass="form-control" Text="http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg" placeholder="Image Link" required></asp:TextBox>
            Landmark : <asp:TextBox ID="fdwtLandmark" runat="server" CssClass="form-control" placeholder="1/0 (Default : 0)" Text="1"></asp:TextBox>
            Attribute : <asp:TextBox ID="fdwtAttribute" runat="server" CssClass="form-control" placeholder="gender,age,smiling,headpose,facequality,blur,eyestatus (Default : none)" Text="gender,age,smiling,headpose,facequality,blur,eyestatus"></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="GetDetail Face" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click" />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>