<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddFaceToFaceset.aspx.cs" Inherits="FacePP.WebForm.AddFaceToFaceset" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>FaceSet AddFace API</h1>
            <p><a href="https://console.faceplusplus.com/documents/6329371" target="_blank">Go to Full Document Page</a></p>
            <p>Important : if you can know/call tokens(from db, xml...), token versions is recommended. Token api names are inside full document page.</p>
            <p>Add face_token into an existing FaceSet. One FaceSet can hold up to 1000 face_token.</p><br />
        </div>
        <div class="col-md-12">
            <h2>FaceSet AddFace API Form</h2>
            Link : <asp:TextBox ID="aftfsUrl" runat="server" CssClass="form-control" Text="http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg" placeholder="Image Link"></asp:TextBox>
            Landmark : <asp:TextBox ID="aftfsLandmark" runat="server" CssClass="form-control" placeholder="1/0" Text="1"></asp:TextBox>
            Attribute : <asp:TextBox ID="aftfsAttribute" runat="server" CssClass="form-control" placeholder="gender,age,smiling,headpose,facequality,blur,eyestatus" Text="gender,age,smiling,headpose,facequality,blur,eyestatus"></asp:TextBox>
            Outer ID : <asp:TextBox ID="aftfsOuter" runat="server" CssClass="form-control" Text="Test" placeholder="Outer ID"></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="Add Face To Faceset" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click" />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>