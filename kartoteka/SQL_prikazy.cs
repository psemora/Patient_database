using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kartoteka
{
    class SQL_prikazy
    {
        internal static void ProvedSQLPrikaz(string SQLprikaz)
        {
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lekari.mdb";
            OleDbConnection pripojeni = new OleDbConnection(ConnectionString);

            // Vypíše všechny pacienty z databáze do listview
            frm_kartoteka.ListView1.Items.Clear();
            frm_kartoteka.ListView1.View = View.Details;

            OleDbCommand sql_dotaz;
            OleDbDataReader DataReader;
            String[] polozka = new string[6];

            sql_dotaz = new OleDbCommand(SQLprikaz, pripojeni);
            pripojeni.Open();
            DataReader = sql_dotaz.ExecuteReader();
            while (DataReader.Read())
            {
                polozka[0] = polozka[0] + DataReader.GetValue(0);
                polozka[1] = polozka[1] + DataReader.GetValue(1);
                polozka[2] = polozka[2] + DataReader.GetValue(2);
                polozka[3] = polozka[3] + DataReader.GetValue(3);
                polozka[4] = polozka[4] + DataReader.GetValue(4);
                polozka[5] = polozka[5] + DataReader.GetValue(5);
                ListViewItem item = new ListViewItem(polozka);
                frm_kartoteka.ListView1.Items.Add(item);
                polozka[0] = null;
                polozka[1] = null;
                polozka[2] = null;
                polozka[3] = null;
                polozka[4] = null;
                polozka[5] = null;
            }
            DataReader.Close();
            pripojeni.Close();
            frm_kartoteka.txt_pocet_zaznamu.Text = frm_kartoteka.ListView1.Items.Count.ToString();
        }

        internal static void ProvedSqlPrikaz2(String SqlPrikaz2)
        {
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lekari.mdb";
            OleDbConnection pripojeni = new OleDbConnection(ConnectionString);
            
            frm_slozka_pacienta.lv_slozka_pacienta.Items.Clear();
            OleDbCommand sql_dotaz;
            OleDbDataReader DataReader;
            String[] polozka = new string[6];
            sql_dotaz = new OleDbCommand(SqlPrikaz2, pripojeni);
            pripojeni.Open();
            DataReader = sql_dotaz.ExecuteReader();
            
            while (DataReader.Read())
            {
                polozka[0] = polozka[0] + DataReader.GetValue(0);
                polozka[1] = polozka[1] + DataReader.GetValue(1);
                polozka[2] = polozka[2] + DataReader.GetValue(2);
                polozka[3] = polozka[3] + DataReader.GetValue(3);
                polozka[4] = polozka[4] + DataReader.GetValue(4);
                polozka[5] = polozka[5] + DataReader.GetValue(5);
                ListViewItem item = new ListViewItem(polozka);
                frm_slozka_pacienta.lv_slozka_pacienta.Items.Add(item);
                polozka[0] = null;
                polozka[1] = null;
                polozka[2] = null;
                polozka[3] = null;
                polozka[4] = null;
                polozka[5] = null;
            }
            DataReader.Close();
            pripojeni.Close();
        }

        internal static void ProvedSqlprikaz3(String SqlPrikaz3)
        {
           
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lekari.mdb";
            OleDbConnection pripojeni = new OleDbConnection(ConnectionString);
    
            frm_kontrola.lv_kontrola.Items.Clear();
            frm_kontrola.lv_kontrola.View = View.Details;
            // frm_slozka_pacienta.lv_slozka_pacienta.View = View.Details;
            OleDbCommand sql_dotaz;
            OleDbDataReader zaznamy;
            String[] polozka = new string[3];
            sql_dotaz = new OleDbCommand(SqlPrikaz3, pripojeni);
            pripojeni.Open();
            zaznamy = sql_dotaz.ExecuteReader();
            
            while (zaznamy.Read())
            {
                polozka[0] = polozka[0] + zaznamy.GetValue(0);
                polozka[1] = polozka[1] + zaznamy.GetValue(1);
                ListViewItem item = new ListViewItem(polozka);
                frm_kontrola.lv_kontrola.Items.Add(item);
                polozka[0] = null;
                polozka[1] = null;
            }
            pripojeni.Close();
        }
            
    }
}

