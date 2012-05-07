<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SuperSecret.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Secret</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
    <script type="text/javascript">

        function RemoveSecret() {
            $('div.secret span').fadeOut('slow', function () { $(this).remove(); });
        }

        $(function () {
            setTimeout(RemoveSecret, 30000);
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="secret">
        <asp:Label runat="server" ID="secret" />
    </div>
    </form>
</body>
</html>
