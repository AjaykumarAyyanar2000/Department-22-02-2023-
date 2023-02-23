<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Department.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 762px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>LOGIN SCREEN<br />
            <br />
            </strong>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">UserName</td>
                    <strong>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    </td>
                </tr>
                </strong>
                <tr>
                    <td class="auto-style3">Password</td>
                    <strong>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Message</td>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2"><strong>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2"><a href="default.aspx">Don&#39;t have an account,Click here</a></td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            </strong>
        </div>
    </form>
</body>
</html>
