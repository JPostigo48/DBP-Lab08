<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication8.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>Enviado por sesión:</h4>
            <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>
            <asp:Label ID="LabelSurname" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="button_submit2" class="btn btn-primary" runat="server" OnClick="Submit2" Text="Mostrar Cookie" />
        <asp:TextBox ID="cookie_textarea" class="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
    </form>
</body>
</html>
