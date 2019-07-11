<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

</head>
<body>
    <form id="form1" runat="server">
        <div>
            Categoria:<asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Name" DataValueField="CoffeeTypeId" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <asp:GridView ID="GridView1" runat="server" CssClass="table" >
            </asp:GridView>
            <br />

            <ul class="pagination">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <li class="page-item">
                        <a class="page-link" href="<%#Eval("Url") %>"  ><%#Eval("Pag") %></a></li>
                </ItemTemplate>
            </asp:Repeater>
            </ul>
            <br />
        </div>
    </form>
</body>
</html>
