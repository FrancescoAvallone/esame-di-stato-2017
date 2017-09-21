using System;
using System.Data.OleDb;

public partial class vivaio_query5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection connection = new OleDbConnection( @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Francesco\Documents\Visual Studio 2017\WebSites\Progettomaturità\vivaio2003.mdb");
        connection.Open();

        string codice = @"SELECT Nome, Descrizione, Numero, PrezzoVendita  FROM(Piante)
                            WHERE PrezzoVendita = ANY(
                                                        SELECT MIN(PrezzoVendita) FROM Piante);";

        OleDbCommand cmd = new OleDbCommand(codice, connection);

        using (OleDbDataReader reader = cmd.ExecuteReader())
        {
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }

        connection.Close();

    }
}