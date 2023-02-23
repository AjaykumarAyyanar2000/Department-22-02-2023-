<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Department.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 37%;
        }
        .auto-style2 {
            width: 346px;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table cellpadding="3" cellspacing="3" class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="2">Product Master</td>
            </tr>
            <tr>
                <td class="auto-style2">Product Name</td>
                <td>
                    <asp:TextBox ID="txtPName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Product Category</td>
                <td>
                    <asp:DropDownList ID="ddlCat" runat="server">
                        <asp:ListItem>--Category--</asp:ListItem>
                        <asp:ListItem>Laptop</asp:ListItem>
                        <asp:ListItem>Electronics</asp:ListItem>
                        <asp:ListItem>Accessories</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sales Price&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtSalePrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Purchase Price</td>
                <td>
                    <asp:TextBox ID="txtPurchasePrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Discount Allowed</td>
                <td>
                    <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnProduct" runat="server" OnClick="BtnProduct_Click" Text="Save Product" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
