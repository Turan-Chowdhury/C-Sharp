<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ViewStateWithCollection.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 584px;
        }
        .auto-style2 {
            width: 584px;
            text-align: right;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            margin-left: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server" CssClass="auto-style3" Width="236px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="saveButton" runat="server" CssClass="auto-style4" OnClick="saveButton_Click" Text="Save" Width="90px" />
                    <asp:Button ID="showAllButton" runat="server" Text="Show All" Width="96px" OnClick="showAllButton_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:ListBox ID="nameListBox" runat="server" Height="144px" Width="242px"></asp:ListBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
