<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPagee.aspx.cs" Inherits="MainPagee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
    <p> WHAT DO YOU WANT TO ENTER  </p>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatLayout="UnorderedList">
            <asp:ListItem Value="1"> Multiple choice question </asp:ListItem>
            <asp:ListItem Value="2"> Fill in the blank </asp:ListItem>
        </asp:RadioButtonList>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Height="34px" Width="91px" />
    </div>
    </div>
    </form>
</body>
</html>
