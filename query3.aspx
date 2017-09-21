<%@ Page Language="C#" AutoEventWireup="true" CodeFile="query3.aspx.cs" Inherits="vivaio_query3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Query 3</title>
		<meta charset="UTF-8">
	    <meta name="viewport" content="width=device-width, initial-scale=1">
	    <link rel="stylesheet" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <ul id="menu">
		<li><a href="Default.aspx">Home</a></li>
		<li>
			<a href="#">Gestione</a>
			<ul class="hidden">
				<li><a href="#">Gestione Personale</a></li>
				<li><a href="#">Gestione Piante</a></li>
			</ul>
		</li>
		<li>
			<a href="#">Query</a>
			<ul class="hidden">
				<li><a href="query1.aspx">Query1</a></li>
				<li><a href="query2.aspx">Query2</a></li>
				<li><a href="query3.aspx">Query3</a></li>
                <li><a href="query4.aspx">Query4</a></li>
				<li><a href="query5.aspx">Query5</a></li>
                <li><a href="query6.aspx">Query6</a></li>
			</ul>
		</li>
	<!--	<li><a href="#">News</a></li>
		<li><a href="#">Contact</a></li>-->
	</ul>

        <br /> <br /> <br /> <br />

        <asp:Label ID="Label1" runat="server" Text="Data inizio:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Data fine:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Tipo attività:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cerca" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>