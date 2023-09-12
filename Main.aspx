<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="CSharpASP_Basic.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <h1 style="width: 238px; height: 63px; margin-left: 886px">
                    <asp:Label ID="Label1" runat="server" style="font-size: xx-large; text-align: left" Text="Welcome"></asp:Label>
                    <asp:Button ID="Button1" runat="server" Height="54px" OnClick="Button1_Click" style="margin-left: 22px; margin-top: 54px" Text="Logout" Width="179px" />
                </h1>
            </div>
        </div>
    </form>
</body>
</html>
