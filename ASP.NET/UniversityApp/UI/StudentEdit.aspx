<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEdit.aspx.cs" Inherits="UniversityApp.UI.StudentEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style2 {
            width: 576px;
            text-align: right;
        }
        .auto-style3 {
            width: 373px;
        }
        .auto-style4 {
            width: 576px;
            text-align: right;
            height: 29px;
        }
        .auto-style5 {
            width: 373px;
            height: 29px;
        }
        .auto-style6 {
            height: 29px;
        }
        .auto-style1 {
            width: 576px;
        }
        </style>
</head>
<body>
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Reg. No</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="regNoTextBox" runat="server" Width="241px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="searchButton" runat="server" Text="Search" Width="150px" OnClick="searchButton_Click" />
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Student Name</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="nameTextBox" runat="server" Width="241px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Email</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="emailTextBox" runat="server" Width="242px"></asp:TextBox>
                    </td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Address</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="addressTextBox" runat="server" Width="242px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Department</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="departmentTextBox" runat="server" Width="242px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="deleteButton" runat="server" Text="Delete" Width="123px" OnClick="deleteButton_Click" />
                        <asp:Button ID="updateButton" runat="server" Text="Update" Width="125px" OnClick="updateButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="messageLabel" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        <div>
        </div>
    </form>
</body>
</html>
