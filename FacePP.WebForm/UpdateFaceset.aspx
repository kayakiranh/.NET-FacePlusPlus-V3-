<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateFaceset.aspx.cs" Inherits="FacePP.WebForm.UpdateFaceset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>FaceSet Update API</h1>
            <p><a href="https://console.faceplusplus.com/documents/6329383" target="_blank">Go to Full Document Page</a></p>
            <p>Important : if you can know/call tokens(from db, xml...), token versions is recommended. Token api names are inside full document page.</p>
            <p>Update the attributes of a FaceSet.</p><br />
        </div>
        <div class="col-md-12">
            <h2>FaceSet Update API Form</h2>
            Outer ID : <asp:TextBox ID="ufsOuter" runat="server" CssClass="form-control" Text="Test" placeholder="Outer ID" reqired></asp:TextBox>
            New Outer ID : <asp:TextBox ID="ufsNewOuter" runat="server" CssClass="form-control" Text="Test" placeholder="New Outer ID" required></asp:TextBox>
            Display Name : <asp:TextBox ID="ufsDisplay" runat="server" CssClass="form-control" Text="Test" placeholder="Display Name"></asp:TextBox>
            Tags : <asp:TextBox ID="ufsTag" runat="server" CssClass="form-control" Text="Tag,Tag,Tag" placeholder="Tag,Tag,Tag"></asp:TextBox>
            Data : <asp:TextBox ID="ufsData" runat="server" CssClass="form-control" Text="Data Info" placeholder="Data Info"></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="Update Faceset" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click" />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>
</asp:Content>