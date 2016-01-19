<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BMI.aspx.cs" Inherits="WCF_Labb2WebClient.BMI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Räkna ut din BMI</h2>
        <p>Skriv in din längd i cm: </p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br/>
        <p>Skriv in din vikt i kg: </p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br/>
        <p>Klicka på knappen för att räkna ut din BMI</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Knapp" />
        <br/>
        <br/>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
