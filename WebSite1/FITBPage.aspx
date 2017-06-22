<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FITBPage.aspx.cs" Inherits="FITBPage" %>

<%@ Register Src="~/AddFillInTheBlankUserControl.ascx" TagPrefix="uc1" TagName="AddFillInTheBlankUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:AddFillInTheBlankUserControl runat="server" ID="AddFillInTheBlankUserControl" />
    </div>
         <asp:Button ID="Button1" runat="server" Text="Previous Page" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Next Page" OnClick="Button2_Click" />
    </form>
   
</body>
</html>
