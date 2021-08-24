<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="UserDefineTypeApp.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
            width: 518px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">First Name</td>
                    <td>
                        <asp:TextBox ID="firstNameTextBox" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Middle Name</td>
                    <td>
                        <asp:TextBox ID="middleNameTextBox" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Last Name</td>
                    <td>
                        <asp:TextBox ID="lastNameTextBox" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
                        <asp:Button ID="getAllFullNameButton" runat="server" OnClick="getAllFullNameButton_Click" Text="Get All Full Name" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:ListBox ID="nameListBox" runat="server" Height="151px" Width="279px"></asp:ListBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
