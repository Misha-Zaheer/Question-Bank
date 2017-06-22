<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddFillInTheBlankUserControl.ascx.cs" Inherits="AddFillInTheBlankUserControl" %>


<p> ADD FILL IN THE BLANK PAGE </p>
<asp:Button ID="Button2" runat="server" Text="Add Question" Height="31px" OnClick="Button2_Click" Width="185px" />
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="Enter Question:" OnLoad="Label3_Load"></asp:Label>
<br />
<br />
<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Height="38px" Width="183px"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label4" runat="server" Text="Enter Answer: " OnLoad="Label4_Load"></asp:Label>

<br />
<br />

<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Height="31px" Width="186px"></asp:TextBox>
&nbsp;
<br />
<br />
<asp:Label ID="Label1" runat="server" Text="" OnLoad="Label1_Load" ></asp:Label>
<br /><br />
<asp:Label ID="Label2" runat="server" Text="" OnLoad="Label2_Load"></asp:Label>
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" Text="Submit" Height="26px" OnClick="Button1_Click" Width="126px" />
<p>
    &nbsp;</p>

