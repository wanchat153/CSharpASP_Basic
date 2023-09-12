<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="CSharpASP_Basic.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="height: 479px">
                <div style="height: 256px; width: 940px; margin-left: 534px; margin-top: 61px">
                    <h5 style="width: 293px; margin-left: 335px">
                        <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
                        <asp:TextBox ID="userText" runat="server" Height="25px" OnTextChanged="username_TextChanged" style="margin-left: 0px; margin-top: 5px" Width="271px"></asp:TextBox>
                        <br />
                    </h5>
                    <h5 style="width: 293px; margin-left: 335px">
                        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="passText" runat="server" Height="27px" style="margin-left: 0px; margin-top: 11px" Width="275px" OnTextChanged="passText_TextChanged"></asp:TextBox>
                        <asp:Button ID="loginBtn" runat="server" Height="49px" style="margin-left: 59px; margin-top: 31px" Text="Log in" Width="154px" OnClick="loginBtn_Click" />
                    </h5>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
