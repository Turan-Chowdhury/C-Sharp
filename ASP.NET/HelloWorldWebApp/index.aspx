<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HelloWorldWebApp.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 655px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 655px;
            text-align: right;
        }
    </style>
</head>
<body>
    <h1>Hello World Batch 54</h1>
    <p>&nbsp;</p>
    <form id="form1" runat="server">
        <p>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style3">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="nameTextBox" runat="server" Height="20px" Width="158px" CssClass="auto-style2"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td> 
            <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
            <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>           
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>
