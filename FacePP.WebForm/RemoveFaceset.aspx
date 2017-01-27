<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RemoveFaceset.aspx.cs" Inherits="FacePP.WebForm.RemoveFaceset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>FaceSet Delete API</h1>
            <p><a href="https://console.faceplusplus.com/documents/6329394" target="_blank">Go to Full Document Page</a></p>
            <p>Important : if you can know/call tokens(from db, xml...), token versions is recommended. Token api names are inside full document page.</p>
            <p>Delete a FaceSet.</p><br />
        </div>
        <div class="col-md-12">
            <h2>FaceSet Delete API Form</h2>
            Outer ID : <asp:TextBox ID="rfsOuter" runat="server" CssClass="form-control" Text="Test" placeholder="Outer ID" required></asp:TextBox>
            Check Empty : <asp:TextBox ID="rfsForce" runat="server" CssClass="form-control" Text="1" placeholder="1/0 (Default : 1)"></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="Remove Faceset" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click" />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>