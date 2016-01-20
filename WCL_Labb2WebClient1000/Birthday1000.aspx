<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Birthday1000.aspx.cs" Inherits="WCL_Labb2WebClient1000.Birthday1000" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h2>Räkna ut när du fyller jämt 1000 dagar nästa gång</h2>
        <p>Skriv in året du föddes:</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br/>
        <p>Skriv in vilken månad du föddes: </p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br/>
        <p>Och avsluta med vilken dag: </p>
        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
        <br/>
        <p>Klicka på knappen för att räkna</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Knapp" />
        <br/>
        <br/>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
