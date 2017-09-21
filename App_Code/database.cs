using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;


/// <summary>
/// Descrizione di riepilogo per database
/// </summary>
public class database
    {
        public string percorsoDB = "Vivaio.mdb"; //       si trova nella cartella "bin/x86/debug" dell'applicazione
        public OleDbConnection connDB=new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source= Vivaio.mdb;");
        OleDbDataReader objReader; //oggetto dataReader 
        OleDbCommand objcmd;       //oggetto Command
       
        public database()
        {

        }

        private string errore()//Nel casso ci fosse un errore nel catch viene richiamato tale metodo per far comparire un messaggio di errore
        {
            return "Errore di connessione!";
        }

        public void exe_query_combo(string query, DropDownList cb)
        {
            connDB.Open();
            objcmd = new OleDbCommand(query, connDB);//imposta l'oggetto Command per eseguire
            // la query espressa dalla stringa "codiceSQl"
            // mediante la connessione chiamata "connDB"

            objReader = objcmd.ExecuteReader();// esegue la query espressa precedentemente e assegna il risultato
            // al DataReader chiamato "objReader"

            while (objReader.Read())  //scorre in avanti il dataReader
            {
                //e l'inserisce come nodo padre nella lisView
                for (int i = 0; i < objReader.FieldCount; i++)
                {
                    cb.Items.Add(Convert.ToString(objReader[i])); //legge il campo 1 della tabella e l'nserisce nella listView come figlio
                }
            }
            connDB.Close();
        }//metodo per eseguire una query e visualizzare il risultato su una comboBox

       /* public void exe_query_list(string query, ListView listView1)
        {
            connDB.Open();
            listView1.Items.Clear();
            listView1.Columns.Clear();
            objcmd = new OleDbCommand(query, connDB);//imposta l'oggetto Command per eseguire
                                                     // la query espressa dalla stringa "codiceSQl"
                                                     // mediante la connessione chiamata "connDB"

            objReader = objcmd.ExecuteReader();// esegue la query espressa precedentemente e assegna il risultato
                                               // al DataReader chiamato "objReader"


            for (int i = 0; i < objReader.FieldCount; i++) //legge i campi espessa nella select della della query  "codiceSQL1" e intesta le                                                                 //colonne della listView1 con queste informazioni
            {
                listView1.Columns.Add(objReader.GetName(i), 150); //legge il  campo i-esimo espresso nella select,
            }



            while (objReader.Read())  //scorre in avanti il dataReader
            {
                ListViewItem item = new ListViewItem(objReader[0].ToString());//legge il campo 0 della tabella clenti
                                                                              //e l'inserisce come nodo padre nella lisView
                for (int i = 1; i < objReader.FieldCount; i++)
                {
                    item.SubItems.Add(objReader[i].ToString()); //legge il campo 1 della tabella e l'nserisce nella listView come figlio
                }

                listView1.Items.Add(item); // aggiungo alla ListView
            }
            connDB.Close();

        }//metodo per eseguire una query e visualizzare il risultato su una listView*/

        public string getImg(string query)//metodo che esegue la query e ritona l'url di un immagine 
        {
            connDB.Open();
            string url = "";
            objcmd = new OleDbCommand(query, connDB);
            objReader = objcmd.ExecuteReader();
            while (objReader.Read())  //scorre in avanti il dataReader
            {
                url= objReader[0].ToString();//legge il campo 0 della tabella clenti
            }
            connDB.Close();
            return url;
        }
        
        public string getDescr(string query)//metodo che esegue la query e ritorna la descrizione di una determinata pianta selezionata 
        {
            connDB.Open();
            string descrizione="";
            objcmd = new OleDbCommand(query, connDB);
            objReader = objcmd.ExecuteReader();
            while (objReader.Read())  //scorre in avanti il dataReader
            {
                descrizione = objReader[0].ToString();//legge il campo 0 della tabella clenti
            }
            connDB.Close();
            return descrizione;
        }

        public int read_query_data(string query, Table dataGridView)
        {
            int n = 0;
            connDB.Open();
            DataTable DT = new DataTable();
            objcmd = new OleDbCommand(query, connDB);//imposta l'oggetto Command per eseguire
            // la query espressa dalla stringa "codiceSQl"
            // mediante la connessione chiamata "connDB"

            objReader = objcmd.ExecuteReader();// esegue la query espressa precedentemente e assegna il risultato
                                               // al DataReader chiamato "objReader"

            DT.Clear();
            DT.Load(objReader);
            connDB.Close();
            n = DT.Rows.Count;
            //dataGridView.DataSource = DT;

            return n;
        }//metodo per eseguire una query e visualizzare il risultato su una listView


        public bool search(string query)
        {
            bool c = false;
            connDB.Open();
            objcmd = new OleDbCommand(query, connDB);
            objReader = objcmd.ExecuteReader();

            c = objReader.HasRows;
            connDB.Close();
            return c;
        }

        public void chiudi()
        {
            connDB.Close();
        }

        public OleDbConnection getConnessione()
        {
                connDB.Open();
                return connDB;
        }
    }