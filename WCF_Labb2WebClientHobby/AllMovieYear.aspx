<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllMovieYear.aspx.cs" Inherits="WCF_Labb2WebClientHobby.AllMovieYear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4>Klicka på den det årtalet som du vill se alla filmer från</h4>
        <asp:Button ID="Button1" runat="server" Text="2012" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="2013" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="2014" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="2015" OnClick="Button4_Click" />
        <br/>
        <br/>
        <asp:TextBox ID="TextBox1" runat="server" Height="403px" TextMode="MultiLine" Width="531px" ></asp:TextBox>
    </div>
    </form>
</body>
</html>
