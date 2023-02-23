<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Department._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            text-decoration: underline;
        }
        .auto-style3 {
            width: 374px;
        }
        .auto-style4 {
            width: 761px;
        }
        .auto-style5 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="3"><strong>Student Registration Form<br />
                        <br />
                        </strong>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style5">
                                    <asp:Button ID="Button1" runat="server" CausesValidation="False" OnClick="Button1_Click" Text="Login" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"><a href="Product.aspx">Product</a></td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlPhoneNumbers" runat="server" OnSelectedIndexChanged="ddlPhoneNumbers_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                        <asp:HiddenField ID="hfStudentID" runat="server" Value="0" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Name</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtName" ErrorMessage="Name is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Department Name</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDept" ErrorMessage="Dept Name is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Phone Number</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPhone" ErrorMessage="Phone number is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Email</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpwd" ErrorMessage="Password is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Message</td>
                    <td class="auto-style4">
                        <asp:Label ID="Lbl" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="BtnSave" runat="server" Text="Save or Update" OnClick="BtnSave_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <a href="login.aspx">Already Have an Account ,click here</a></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="grdStudent" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
