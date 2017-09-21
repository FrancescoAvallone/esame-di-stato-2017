using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.OleDb;


public partial class vivaio_query2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // NOTA: bisogna impostare la proprietà AutoPostBack, altrimenti l'evento non viene lanciato!

        OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Francesco\Documents\Visual Studio 2017\WebSites\Progettomaturità\vivaio2003.mdb");
        connection.Open();

        string stagioneScelta = DropDownList1.Items[DropDownList1.SelectedIndex].ToString();

        string query = @"SELECT Nome ,StagioneFioritura FROM Piante 
                            WHERE StagioneFioritura = '" + stagioneScelta + "';";


        OleDbCommand cmd = new OleDbCommand(query, connection);
        GridView1.DataSource = cmd.ExecuteReader();
        GridView1.DataBind();


        connection.Close();
    }
}