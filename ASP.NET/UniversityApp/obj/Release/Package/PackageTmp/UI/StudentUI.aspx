<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentUI.aspx.cs" Inherits="UniversityApp.StudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 553px;
        }
        .auto-style2 {
            width: 553px;
            text-align: right;
        }
        .auto-style3 {
            width: 373px;
        }
        .auto-style4 {
            width: 553px;
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
        .auto-style7 {
            margin-left: 262px;
        }
        .auto-style8 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Student Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="nameTextBox" runat="server" Width="241px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Reg. No </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="regNoTextBox" runat="server" Width="241px"></asp:TextBox>
                    </td>
                    <td class="auto-style6"></td>
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
                        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" Width="150px" />
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
                <tr>
                    <td class="auto-style2">All Students List</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="studentDropDownList" runat="server" Height="35px" Width="253px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div class="auto-style8">
            <br />
            <asp:GridView ID="StudentGridView" runat="server" CellPadding="4" CssClass="auto-style7" ForeColor="#333333" GridLines="None" Width="826px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
