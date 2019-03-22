<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label Text="First Name" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtFirstName" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text="Last NAme" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtLastNAme" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text="Contact" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtContact" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text="Gender" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:DropDownList ID="ddlGender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text="Adress" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtAdress" runat="server" TextMode="MultiLine" />
                    </td>
                </tr>

                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text="Username" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtUsername" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text="Password" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text="Password" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text="text" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txt" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
