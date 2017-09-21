using System;
using System.Data.OleDb;

public partial class vivaio_query6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Francesco\Documents\Visual Studio 2017\WebSites\Progettomaturità\vivaio2003.mdb");
        connection.Open();

        string q = @"SELECT (Attivita.Nome), Cognome, (Clienti.Nome), Telefono 
                     FROM Clienti INNER JOIN Attivita ON Clienti.IDCliente = Attivita.IDCliente
                     WHERE (Attivita.Evaso)=" + false + ";";

        OleDbCommand cmd = new OleDbCommand(q, connection);

        GridView1.DataSource = cmd.ExecuteReader();
        GridView1.DataBind();

        connection.Close();
    }
}