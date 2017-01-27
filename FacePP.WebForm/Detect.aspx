<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detect.aspx.cs" Inherits="FacePP.WebForm.Detect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
            <h1>Detect API</h1>
            <p><a href="https://console.faceplusplus.com/documents/5679127" target="_blank">Go to Full Document Page</a></p>
            <p>Detect API detects and analyzes human faces within the image that you provided by image file or URL. Every detected face gets its <em>face_token</em>, which can be used in follow-up operations. Please note that only the 5 largest faces by its bounding box size will be analyzed, while you can use Face Analyze API to analyze the rest faces. If you want to use the detected face for follow-up operations, we recommend you to add its corresponding <em>face_token</em> into <em>FaceSet</em>. A <em>face_token&nbsp;</em>expires within 72 hours if it is not added into any FaceSet.&nbsp;Every time you operate face detection upon one image, the face within the image will get a different <em>face_token</em>.</p><br />
            <p>Format : JPG (JPEG), PNG<br>Size : between 48*48 and 4096*4096 (pixels)<br>File size : no larger than 2MB<br>Minimal size of face : the bounding box of a detected face is a square. The minimal side length of a square should be no less than 1/48 of the short side of image, and no less than 48 pixels. For example if the size of image is 4096 * 3200px, the minimal size of face should be 66 * 66px.</p><br />
        </div>
        <div class="col-md-6">
            <h2>Detect API Form With Image Upload</h2>
            File : <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
            Landmark : <asp:TextBox ID="uploadLandmark" runat="server" CssClass="form-control" placeholder="1/0" Text="1"></asp:TextBox>
            Attribute : <asp:TextBox ID="uploadAttribute" runat="server" CssClass="form-control" placeholder="gender,age,smiling,headpose,facequality,blur,eyestatus" Text="gender,age,smiling,headpose,facequality,blur,eyestatus"></asp:TextBox><br />
            <asp:Button ID="uploadButton" runat="server" Text="Detect With Upload" CssClass="btn btn-primary btn-block" OnClick="uploadButton_Click" />
        </div>
        <div class="col-md-6">
            <h2>Detect API Form With Image Link</h2>
            Link : <asp:TextBox ID="linkUrl" runat="server" CssClass="form-control" Text="http://www.sephora.com/contentimages/categories/makeup/CONTOURING/030515/animations/round/round_01_before.jpg" placeholder="Image Link" required></asp:TextBox>
            Landmark : <asp:TextBox ID="LinkLandmark" runat="server" CssClass="form-control" placeholder="1/0 (Default : 0)" Text="1"></asp:TextBox>
            Attribute : <asp:TextBox ID="LinkAttribute" runat="server" CssClass="form-control" placeholder="gender,age,smiling,headpose,facequality,blur,eyestatus (Default : none)" Text="gender,age,smiling,headpose,facequality,blur,eyestatus"></asp:TextBox><br />
            <asp:Button ID="LinkButton" runat="server" Text="Detect With Link" CssClass="btn btn-primary btn-block" OnClick="LinkButton_Click" />
            <asp:Button ID="LinkAjax" runat="server" Text="Detect With Link / AJAX" CssClass="btn btn-primary btn-block"  />
        </div>
        <div class="col-md-12" runat="server" ID="result" style="white-space: pre !important; margin-top:20px;"></div>
    </div>

    <script>
        $(document).ready(function () {
            $('#<%=LinkAjax.ClientID %>').click(function () {
                var val1 = document.getElementById('<%=linkUrl.ClientID%>');
                var val2 = document.getElementById('<%=LinkLandmark.ClientID%>');
                var val3 = document.getElementById('<%=LinkAttribute.ClientID%>');
                $.ajax({
                    type: "POST",
                    url: "Detect.aspx/GetAjaxResponse",
                    data: '{lnk:' + val1.value + ', land:' + val2.value + ', attribute:' +  val3.value + '}',
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    async: true,
                    cache: false,
                    success: function (msg) {
                        console.log("SUCCESS : " + msg.d);
                    },
                    error: function (err) {
                        console.log("FAILURE : " + err);
                    }
                })
                return false;
            });
        });
    </script>
</asp:Content>