using System;
using System.Data.OleDb;
public partial class vivaio_query3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string dataInizio = TextBox1.Text;
        string dataFine = TextBox2.Text;
        string tipoAttivita = "";

        if (string.IsNullOrEmpty(dataInizio) || string.IsNullOrEmpty(dataFine))
            return;

        string q = @"
                 SELECT Clienti.Cognome, Clienti.Nome, Clienti.Telefono 
                       FROM Clienti INNER JOIN Attivita ON Clienti.IDCliente=Attivita.IDCliente  
                        WHERE Attivita.Tipo = '" + tipoAttivita + @"'
                      And (Attivita.DataPrenotazione Between " + "#" + dataInizio + "#"
                      + "And & #" + dataFine + "#" + ");";

        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Francesco\Documents\Visual Studio 2017\WebSites\Progettomaturità\vivaio2003.mdb");
        connection.Open();

        OleDbCommand cmd = new OleDbCommand(q, connection);

        // creo un datareader 'r' che viene chiuso automaticamente fuori dal blocco {}
        using (OleDbDataReader r = cmd.ExecuteReader())
        {
            GridView1.DataSource = r;
            GridView1.DataBind();
        }

        connection.Close();

    }
}