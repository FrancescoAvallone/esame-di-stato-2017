using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.OleDb;

public partial class vivaio_query4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Francesco\Documents\Visual Studio 2017\WebSites\Progettomaturità\vivaio2003.mdb");
        connection.Open();

        string nome = TextBox1.Text, cognome = TextBox2.Text;

        if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome))
            return; // gestisci errore i.e. visualizza messaggio

        int numeroPiante = 0;


        string codice =
            @"  SELECT Count(Piante.IDPianta) AS numero_piante  
                FROM (Personale INNER JOIN Specie ON Personale.IDPersona=Specie.IDPersona) INNER JOIN Piante ON Specie.IDSpecie=Piante.IDSpecie 
                WHERE (((Personale.Cognome)='" + cognome +
                "') And ((Personale.Nome)='" + nome + "') And ((Personale.Categoria)='Agronomo'))";



        OleDbCommand cmd = new OleDbCommand(codice, connection);

        using (OleDbDataReader r = cmd.ExecuteReader())
        {
            r.Read();

            numeroPiante = (int)r["numero_piante"];
            Label3.Text = string.Format(@"L'agronomo ""{0} {1} ha {2}"" piante associate.",
                                                nome, cognome, numeroPiante);
        }

        connection.Close();

    }
}