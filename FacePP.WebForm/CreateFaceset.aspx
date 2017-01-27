<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateFaceset.aspx.cs" Inherits="FacePP.WebForm.CreateFaceset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>FaceSet Create API</h1>
            <p><a href="https://console.faceplusplus.com/documents/6329329" target="_blank">Go to Full Document Page</a></p>
            <p>Important : if you can know/call tokens(from db, xml...), token versions is recommended. Token api names are inside full document page.</p>
            <p>Create a face collection called FaceSet to store face_token. One FaceSet can hold up to 1000 face_token.</p><br />
        </div>
        <div class="col-md-12">
            <h2>FaceSet Create API Form</h2>
            Display Name : <asp:TextBox ID="cfsDisplay" runat="server" CssClass="form-control" Text="Test" placeholder="Display Name"></asp:TextBox>
            Outer ID : <asp:TextBox ID="cfsOuter" runat="server" CssClass="form-control" Text="Test" placeholder="Outer ID"></asp:TextBox>
            Tags : <asp:TextBox ID="cfsTag" runat="server" CssClass="form-control" Text="Tag,Tag,Tag" placeholder="Tag,Tag,Tag"></asp:TextBox>
            Data : <asp:TextBox ID="cfsData" runat="server" CssClass="form-control" Text="Data Info" placeholder="Data Info"></asp:TextBox>
            Merge : <asp:TextBox ID="cfsForce" runat="server" CssClass="form-control" Text="0" placeholder="1/0 (Default : 0)"></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="Create Faceset" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click" />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>