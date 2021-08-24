<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="ViewStateWebApp.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 582px;
            text-align: right;
        }
        .auto-style2 {
            width: 582px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            width: 318px;
        }
        .auto-style5 {
            height: 26px;
            width: 318px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="nameTextBox" runat="server" Width="227px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style5">
                        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
                        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Output"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="outputTextBox" runat="server" Width="227px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
