<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
		<title>Vivaio Home</title>
		<meta charset="UTF-8">
	    <meta name="viewport" content="width=device-width, initial-scale=1">
	    <link rel="stylesheet" href="style.css">
	</head>	


<label for="show-menu" class="show-menu">Show Menu</label>
<input type="checkbox" id="show-menu" role="button">

<body>


<form id="form1" runat="server">
    <ul id="menu">
		<li><a href="Default.aspx">Home</a></li>
		<li>
			<a href="#">Visualizza Piante</a>
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
    </form>

    </body>
	</html>
