<%@ Page Language="C#" AutoEventWireup="true" CodeFile="query1.aspx.cs" Inherits="vivaio_query1" %>


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
				<li><a href="#">Query2</a></li>
				<li><a href="#">Query3</a></li>
			</ul>
		</li>
	<!--	<li><a href="#">News</a></li>
		<li><a href="#">Contact</a></li>-->
	</ul>

    <br />
    <br />
    <br />
    <br />


    <div style="height: 315px">
    
        <asp:Label ID="Label3" runat="server" Text="Nome pianta"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Cerca" />
        <asp:GridView ID="GridView1" runat="server" Height="157px" Width="308px">
        </asp:GridView>
       
    
        <asp:Label ID="Label2" runat="server" ForeColor="Maroon"></asp:Label>
       
    
    </div>

    </form>

    </body>
	</html>