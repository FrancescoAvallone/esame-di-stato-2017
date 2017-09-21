<%@ Page Language="C#" AutoEventWireup="true" CodeFile="query4.aspx.cs" Inherits="vivaio_query4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Query 4</title>
		<meta charset="UTF-8">
	    <meta name="viewport" content="width=device-width, initial-scale=1">
	    <link rel="stylesheet" href="style.css">
</head>
<body>

    <form id="form1" runat="server">
        
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

        <asp:Label ID="Label1" runat="server" Text="Nome agronomo:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cognome agronomo:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cerca piante associate" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </form>

</body>
</html>
