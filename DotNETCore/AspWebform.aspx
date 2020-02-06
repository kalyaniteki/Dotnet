<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AspWebform.aspx.cs" Inherits="DotNETCore.AspWebform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <br />
        <br />
        <br />
        <br />
        <asp:Label runat="server" Text="NAME"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />

        <asp:Button id="Button" runat="server" Text="Button" OnClick="Button_Click" />
        <div>
          </div>
    </form>
</body>
</html>
