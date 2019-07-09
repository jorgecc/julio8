<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Categoria:<asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Name" DataValueField="CoffeeTypeId" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />

            <ul>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <li><a href="<%#Eval("Url") %>"  ><%#Eval("Pag") %></a></li>
                </ItemTemplate>
            </asp:Repeater>
            </ul>
            <br />
        </div>
    </form>
</body>
</html>
