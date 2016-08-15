<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherUI.aspx.cs" Inherits="UniversityCRMSAppWeb.UI.TeacherUI" %>

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
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="contact No"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="contactNoTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Designation"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="designationDropDownList" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Department"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="departmentrDropDownList" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="course to be taken"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="courseToBeTakenTextBox" runat="server"></asp:TextBox></td>
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
