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
    public partial class frm_upravit_zaznam : Form
    {
        OleDbConnection pripojeni;
        public frm_upravit_zaznam()
        {
            InitializeComponent();
            string ConnectionString;
            ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lekari.mdb";
            pripojeni = new OleDbConnection(ConnectionString);
            Vypis_nemoci();
            Vypis_leky();
            dtp_kontrola.Format = DateTimePickerFormat.Custom;
            dtp_kontrola.ShowUpDown = true;
            dtp_kontrola.CustomFormat = "dd. M. yyyy H:m ";
        }

        private void btn_storno_Click(object sender, EventArgs e)
        {
            Close();
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

        private void lb_nemoci_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ošetření, když kliknu do listboxu, ale nekliknu na nemoc, aby to nehodilo error
            try
            {
                txt_nemoc.Text = lb_nemoci.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void lb_leky_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ošetření, když kliknu do listboxu, ale nekliknu na lék, aby to nehodilo error
            try
            { 
                txt_leky.Text = lb_leky.SelectedItem.ToString();
            }
            catch
            {
                
            }
        }

        private void btn_upravit_zaznam_Click(object sender, EventArgs e)
        {
            OleDbCommand prikaz;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            String SqlPrikaz = "";
            SqlPrikaz = "UPDATE lecba SET nemoc='" + txt_nemoc.Text + "', priznaky='" + txt_priznaky.Text + "', leky='" + txt_leky.Text + "', kontrola='" + dtp_kontrola.Value.ToString() + "', poznamka='" + txt_poznamka.Text + "' WHERE ID_zaznamu=" + txt_ID.Text + "";
            prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
            pripojeni.Open();
            adapter.InsertCommand = new OleDbCommand(SqlPrikaz, pripojeni);
            adapter.InsertCommand.ExecuteNonQuery();
            pripojeni.Close();
            this.Close();
            SQL_prikazy.ProvedSqlPrikaz2("SELECT lecba.ID_zaznamu, lecba.nemoc, lecba.priznaky, lecba.leky, lecba.kontrola, lecba.poznamka FROM lecba INNER JOIN pacienti ON lecba.id_pacienta = pacienti.id_pacienta WHERE pacienti.ID_pacienta=" + frm_kartoteka.ListView1.SelectedItems[0].SubItems[0].Text.ToString());
            MessageBox.Show("Záznam byl úspěšně upraven", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_pridat_nemoc_Click(object sender, EventArgs e)
        {
            String SqlPrikaz = "";
            OleDbCommand prikaz;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            SqlPrikaz = "INSERT INTO Nemoci (nemoc) VALUES (" + "'" + txt_pridat_nemoc.Text + "')";
            prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
            pripojeni.Open();
            adapter.InsertCommand = new OleDbCommand(SqlPrikaz, pripojeni);
            adapter.InsertCommand.ExecuteNonQuery();
            pripojeni.Close();
            lb_nemoci.Items.Clear();
            Vypis_nemoci();
        }

        private void btn_pridat_lek_Click(object sender, EventArgs e)
        {
            String SqlPrikaz = "";
            OleDbCommand prikaz;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            SqlPrikaz = "INSERT INTO Leky (lek) VALUES (" + "'" + txt_pridat_lek.Text + "')";
            prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
            pripojeni.Open();
            adapter.InsertCommand = new OleDbCommand(SqlPrikaz, pripojeni);
            adapter.InsertCommand.ExecuteNonQuery();
            pripojeni.Close();
            lb_leky.Items.Clear();
            Vypis_leky();
        }

        void Vypis_nemoci()
        {
            String SqlPrikaz = "";
            OleDbCommand prikaz;
            OleDbDataReader zaznamy;
            String[] polozka = new string[1];
            SqlPrikaz = "SELECT Nemoc FROM nemoci ORDER BY Nemoc";
            prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
            pripojeni.Open();
            zaznamy = prikaz.ExecuteReader();

            while (zaznamy.Read())
            {
                polozka[0] = polozka[0] + zaznamy.GetValue(0);
                lb_nemoci.Items.Add(polozka[0]);
                polozka[0] = null;
            }
            pripojeni.Close();
        }

        void Vypis_leky()
        {
            String SqlPrikaz = "";
            OleDbCommand prikaz;
            OleDbDataReader zaznamy;
            String[] polozka = new string[1];
            SqlPrikaz = "SELECT Lek FROM Leky ORDER BY lek";
            prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
            pripojeni.Open();
            zaznamy = prikaz.ExecuteReader();

            while (zaznamy.Read())
            {
                polozka[0] = polozka[0] + zaznamy.GetValue(0);
                lb_leky.Items.Add(polozka[0]);
                polozka[0] = null;
            }
            pripojeni.Close();
        }

        private void btn_odstranit_nemoc_Click(object sender, EventArgs e)
        {
            if (lb_nemoci.SelectedItems.Count == 1)
            {
                DialogResult odpoved = MessageBox.Show("Jste si jistý/á ?", "Vymazání nemoci", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (odpoved == DialogResult.OK)
                {
                    OleDbCommand prikaz;
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    String SqlPrikaz = "";
                    string text = lb_nemoci.GetItemText(lb_nemoci.SelectedItem);
                    SqlPrikaz = "DELETE * FROM Nemoci WHERE nemoc =" + "'" + text.ToString() + "'";
                    prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
                    pripojeni.Open();
                    adapter.InsertCommand = new OleDbCommand(SqlPrikaz, pripojeni);
                    adapter.InsertCommand.ExecuteNonQuery();
                    pripojeni.Close();
                    lb_nemoci.Items.Clear();
                    Vypis_nemoci();
                }
            }
            else
            {
                DialogResult odpoved2 = MessageBox.Show("Vyberte záznam", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_odstranit_lek_Click(object sender, EventArgs e)
        {
            if (lb_leky.SelectedItems.Count == 1)
            {
                DialogResult odpoved = MessageBox.Show("Jste si jistý/á ?", "Vymazání nemoci", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (odpoved == DialogResult.OK)
                {
                    OleDbCommand prikaz;
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    String SqlPrikaz = "";
                    string text = lb_leky.GetItemText(lb_leky.SelectedItem);
                    SqlPrikaz = "DELETE * FROM Leky WHERE lek =" + "'" + text.ToString() + "'";
                    prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
                    pripojeni.Open();
                    adapter.InsertCommand = new OleDbCommand(SqlPrikaz, pripojeni);
                    adapter.InsertCommand.ExecuteNonQuery();
                    pripojeni.Close();
                    lb_leky.Items.Clear();
                    Vypis_leky();
                }
            }
            else
            {
                DialogResult odpoved2 = MessageBox.Show("Vyberte záznam", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
