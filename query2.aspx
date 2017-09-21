
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="query2.aspx.cs" Inherits="vivaio_query2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Query 2</title>
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
    <div style="height: 313px">
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>ESTATE</asp:ListItem>
            <asp:ListItem>INVERNO</asp:ListItem>
            <asp:ListItem>AUTUNNO</asp:ListItem>
            <asp:ListItem>PRIMAVERA</asp:ListItem>
        </asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server" Height="133px" Width="189px">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>