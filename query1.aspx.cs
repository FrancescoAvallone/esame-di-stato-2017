using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.OleDb;

public partial class vivaio_query1 : System.Web.UI.Page
{
    private OleDbConnection connection;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // Apro la connessione al database
        connection = new OleDbConnection( @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Francesco\Documents\Visual Studio 2017\WebSites\Progettomaturità\vivaio2003.mdb");
        connection.Open();

        string codiceSQL1;
        string nomePianta = txtNome.Text;

        codiceSQL1 = @"SELECT * FROM Piante 
                       WHERE Nome = '" + nomePianta + "'" + ";";


        OleDbCommand cmd = new OleDbCommand(codiceSQL1, connection);
        OleDbDataReader reader = cmd.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();

        if (GridView1.Rows.Count == 0)
            Label2.Text = "Non ci sono risultati per '" + nomePianta + "'";

        connection.Close();

        /*
        objReader = objcmd.ExecuteReader ' esegue la query impostata con l'oggetto Command.text "objcmd"
        '                                  e riempie l'oggetto DadataReader chiamato "objReader"  con il risultato
        clienti.DataSource = objReader
        clienti.DataBind()
        If objReader.HasRows Then ' Se il DataReader non è vuoto cioè la query ha fornito risultati
            '                       allora scorre in avanti il DataReader 


            '
            While objReader.Read  '
                lettura = lettura & objReader("Nome") 'in parentesi mettiamo il nome del campo 
                '                                     '
                '                                      Ricorda: possiamo mettere solo i campi espressi
                '                                               nella select della query codiceSQL1


                lettura = lettura & CStr(objReader("Numero")) & "    "

                Me.ListBox1.Items.Add(lettura)
                lettura = ""
                Me.ListBox1.Items.Add(lettura)

                ' clienti.Add(objReader("Nome"), objReader("Numero")) 'inserisci una riga 
            End While
        Else
            MsgBox("Nome della pianta: " & scelta.Text & " non è stato trovato")
        End If
        'clienti.DataSource = objReader
        'clienti.DataBind()
        
        
        objReader.Close() 'chiude il datareader altrimenti non poteva essere svolta nessuna operazione
        '                  sul data base               
        dbconn.Close()

        OleDbDataReader reader = cmd.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();
         * 
         */


    }
}