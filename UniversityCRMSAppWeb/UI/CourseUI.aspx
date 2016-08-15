<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseUI.aspx.cs" Inherits="UniversityCRMSAppWeb.UI.CourseUI" %>

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
                        <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td></td>
                    <td><asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Credit"></asp:Label></td></td>
                    <td><asp:TextBox ID="creditTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Description"></asp:Label></td></td>
                    <td><asp:TextBox ID="DescriptionTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Department"></asp:Label></td></td>
                    <td>
                        <asp:DropDownList ID="departmentDropDownList" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label6" runat="server" Text="Semester"></asp:Label></td></td>
                    <td><asp:DropDownList ID="semesterDropDownList" runat="server"></asp:DropDownList></td>

                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="saveButton" runat="server" Text="Save" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
