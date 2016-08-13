<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentUI.aspx.cs" Inherits="UniversityCRMSAppWeb.UI.DepartmentUI" %>

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
                    <td>Code</td>
                    <td>
                        <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" /> </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
