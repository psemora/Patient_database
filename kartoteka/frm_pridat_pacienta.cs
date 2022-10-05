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
    public partial class frm_pridat_pacienta : Form
    {
        OleDbConnection pripojeni;
        

        public frm_pridat_pacienta()
        {
            InitializeComponent();
            string ConnectionString;
            ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lekari.mdb";
            pripojeni = new OleDbConnection(ConnectionString);
            txt_jmeno.Text = "";
            txt_prijmeni.Text = "";
            txt_datum_narozeni.Text = "";
            txt_bydliste.Text = "";        
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

        private void btn_vloz_pacienta_Click(object sender, EventArgs e)
        {
            if(txt_jmeno.Text != "" && txt_prijmeni.Text != "" && txt_bydliste.Text != "" && txt_datum_narozeni.Text != "")
            {
            String SqlPrikaz = "";
            OleDbCommand prikaz;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            SqlPrikaz = "INSERT INTO pacienti (rodne_cislo, jmeno, prijmeni, datum_narozeni, bydliste) VALUES('" + mtxt_rodne_cislo.Text + "','" + txt_jmeno.Text + "','" + txt_prijmeni.Text + "','" + txt_datum_narozeni.Text + "','" + txt_bydliste.Text + "')";
            prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
            pripojeni.Open();
            adapter.InsertCommand = new OleDbCommand(SqlPrikaz, pripojeni);
            adapter.InsertCommand.ExecuteNonQuery();
            pripojeni.Close();
            this.Close();
            SQL_prikazy.ProvedSQLPrikaz("SELECT * FROM pacienti");
            MessageBox.Show("Pacient byl úspěšně vložen", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
            DialogResult odpoved = MessageBox.Show("Chybně zadaný vstup...", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void btn_zavrit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
