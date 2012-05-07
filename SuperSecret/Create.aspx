<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="SuperSecret.Create" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Secret</title>    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" ID="txtSecret" Width="600px" />
        <asp:Button runat="server" ID="btnCreate" Text="Create Secret" OnClick="btnCreate_Click" />
    </div>
    <p>
        <asp:Label runat="server" ID="secretUrl" />
    </p>
    <p>        
        <asp:Label runat="server" ID="lblExpires" />
    </p>
    </form>
</body>
</html>
