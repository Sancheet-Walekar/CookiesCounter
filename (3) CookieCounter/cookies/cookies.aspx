<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookies.aspx.cs" Inherits="cookies.cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblvisit" runat="server" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnsubmit" runat="server" Font-Size="X-Large" OnClick="btnsubmit_Click" Text="Increment" />
        </div>
    </form>
</body>
</html>
