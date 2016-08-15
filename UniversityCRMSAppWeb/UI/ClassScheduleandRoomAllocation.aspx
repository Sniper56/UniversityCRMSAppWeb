<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClassScheduleandRoomAllocation.aspx.cs" Inherits="UniversityCRMSAppWeb.UI.ClassScheduleandRoomAllocation" %>

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
                <asp:Label ID="Label1" runat="server" Text="Department"></asp:Label></td>
            <td>
                <asp:DropDownList ID="departmentDropDownList" runat="server"></asp:DropDownList></td>
        </tr>
    </table>
        <asp:GridView ID="roomAllocationGridView" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
