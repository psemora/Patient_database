using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kartoteka
{
    public partial class frm_upravit_pacienta : Form
    {
        OleDbConnection pripojeni;
        public frm_upravit_pacienta()
        {
            InitializeComponent();
            string ConnectionString;
            ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lekari.mdb";
            pripojeni = new OleDbConnection(ConnectionString);
        }

        void ProvedSQLPrikaz(string SQLprikaz)
        {
            OleDbCommand sql_dotaz;
            OleDbDataReader zaznamy;
            sql_dotaz = new OleDbCommand(SQLprikaz, pripojeni);
            pripojeni.Open();
            zaznamy = sql_dotaz.ExecuteReader();
            pripojeni.Close();
        }

        private void btn_upravit_zaznam_Click(object sender, EventArgs e)
        {
            if (txt_jmeno.Text != "" && txt_prijmeni.Text != "" && txt_bydliste.Text != "" && txt_datum_narozeni.Text != "")
            {
            OleDbCommand prikaz;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String SqlPrikaz = "";
            SqlPrikaz = "UPDATE pacienti SET rodne_cislo='" + mtxt_rodne_cislo.Text + "', jmeno='" + txt_jmeno.Text + "', prijmeni='" + txt_prijmeni.Text + "', datum_narozeni='" + txt_datum_narozeni.Text + "', bydliste='" + txt_bydliste.Text + "' WHERE ID_pacienta=" + txt_ID.Text + "";
            prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
            pripojeni.Open();
            adapter.InsertCommand = new OleDbCommand(SqlPrikaz, pripojeni);
            adapter.InsertCommand.ExecuteNonQuery();
            pripojeni.Close();
            this.Close();
            SQL_prikazy.ProvedSQLPrikaz("SELECT * FROM pacienti");
            MessageBox.Show("Pacient byl úspěšně upraven", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            }
            else
            {
                DialogResult odpoved = MessageBox.Show("Chybně zadaný vstup...", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void btn_storno_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
