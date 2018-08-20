<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VideosManager.aspx.cs" Inherits="OnlineVideoManager.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 216px;
        }
        #Text2 {
            height: 67px;
            width: 208px;
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="视频地址："></asp:Label>
            <asp:TextBox ID="TxtVideoUrl" runat="server" Width="220px" Height="64px" TextMode="MultiLine"></asp:TextBox>
            <asp:Button ID="btnFile" runat="server" OnClick="btnFile_Click" Text="..." />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="作者："></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtBoxAuthor" runat="server" Width="205px" Height="16px" style="margin-left: 0px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="专业："></asp:Label>
            <asp:ListBox ID="ListBoxMajor" runat="server" DataSourceID="xmlMajor"></asp:ListBox>
            <asp:XmlDataSource ID="xmlMajor" runat="server" DataFile="~/App_Data/xmlMajor.xml" XPath="xmlMajor"></asp:XmlDataSource>
            <br />
            <asp:Label ID="Label4" runat="server" Text="关键字："></asp:Label>
            <asp:TextBox ID="TxtBoxKeyWord" runat="server" Width="218px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="类型："></asp:Label>
            <asp:ListBox ID="ListBoxVideoType" runat="server" DataSourceID="XmlDataSource1"></asp:ListBox>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/videoType.xml" XPath="VideoType"></asp:XmlDataSource>
            <br />
            <asp:Button ID="BtnSub" runat="server" OnClick="BtnSub_Click" Text="提交" />
            <br />
        </div>
    </form>
</body>
</html>
