<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowDepartmentUI.aspx.cs" Inherits="UniversityCRMSAppWeb.UI.ShowDepartmentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="showDepGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="SL">
                        <ItemTemplate><%# Container.DataItemIndex + 1 %></ItemTemplate>
                    </asp:TemplateField>
                <asp:BoundField DataField="DepartmentCode" HeaderText="Code" />
                <asp:BoundField DataField="DepartmentName" HeaderText="Name" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
