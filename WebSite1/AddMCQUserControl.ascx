<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddMCQUserControl.ascx.cs" Inherits="MCQUserControl" %>
<p>ADD MCQ PAGE </p>

<asp:Button ID="Button1" runat="server" Text="Add New Question" OnClick="Button1_Click" />
<br />
<br />
<asp:Panel ID="Panel1" runat="server">
    <asp:TextBox ID="QuestionTextBox" runat="server" Height="20px" Width="171px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="QuestionAddButton" runat="server" Text="Add Question" OnClick="QuestionAddButton_Click"  Height="28px" Width="128px" />
    <br />
</asp:Panel>

<asp:Panel ID="Panel2" runat="server">
    <asp:Label ID="QuestionLabel" OnLoad="QuestionLabel_Load" runat="server" Text=" labeltext"></asp:Label>
</asp:Panel>
<br />

<asp:Panel ID="Panel3" runat="server">
    <asp:Label ID="Label1" runat="server" OnLoad="Label1_Load" Text="Enter Option"></asp:Label>
    <br />
    &nbsp;&nbsp;&nbsp;
     <asp:TextBox ID="TextBox1" runat="server"  Height="25px" Width="132px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="AddOption" OnClick="AddOption_Click" runat="server" Text="Add Option" Height="29px" Width="105px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="CheckBox1" Checked="false"  runat="server" />
    <br />
    <br />
</asp:Panel>

<asp:Button ID="NoMoreOption" runat="server" OnClick="NoMoreOption_Click" Text="No More Option" Height="35px" Width="200px" />

<br />

<br />

<asp:Label ID="Label2"  runat="server" Text="Label"></asp:Label>
<br />
<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>





<br />





<p> Repeater Output </p>
<asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
    <HeaderTemplate>
<%--        Text='<%# DataBinder.Eval(Container.DataItem, "Options.option")%>' 
        Text='<%# DataBinder.Eval(Container.DataItem, "Options.status")%>'--%>
    </HeaderTemplate>
    <ItemTemplate>
        <asp:Label ID="OptionLabel"  runat="server" Text='<%#Eval("Option") %>' ></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="StatusLabel" runat="server"  Text='<%#Eval("Option") %>' ></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="OptionButtonDelete"  runat="server" Text="Delete" />
        <br />
    </ItemTemplate>
    <FooterTemplate>

    </FooterTemplate>
</asp:Repeater>
<br /><br />
