<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication8.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
    <style>
        #cookie_textarea {
            height: 50vh;
            padding: 2vw 2vw;
        }
        .margin {
            margin : 3vh 3vw;
        }
    </style>
    <script type="text/javascript">
        function showCookie() {

            let cookie = document.cookie;
            let message = cookie.replace("=", ":\n  » ").replace(/=/g, ": ").replace(/&/g, "\n  » ");
            document.getElementById("cookie_textarea").value = message;

            return false;
        }
    </script>
    <title>Auxiliar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="margin">
            <h4>Enviado por sesión:</h4>
            <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>
            <asp:Label ID="LabelSurname" runat="server" Text=""></asp:Label>
        </div>
        <div class="margin">
            <asp:Button ID="button_submit2" class="btn btn-primary" runat="server" OnClientClick="return showCookie();" Text="Mostrar Cookie" />
        </div>
        <div class="margin">
            <asp:TextBox ID="cookie_textarea" class="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
