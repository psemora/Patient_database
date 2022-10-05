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
    public partial class frm_kartoteka : Form
    {
        
        public frm_kartoteka()
        {
            InitializeComponent();
        }

       
        private void btn_vypis_Click(object sender, EventArgs e)
        {
            SQL_prikazy.ProvedSQLPrikaz("SELECT * FROM pacienti");
        }
        
        private void btn_serad_AZ_Click(object sender, EventArgs e)
        {
            // Seřadí všechny pacienty v kartotéce podle příjmení od A do Z
            SQL_prikazy.ProvedSQLPrikaz("SELECT * FROM pacienti ORDER BY prijmeni");
        }

        private void btn_serad_ZA_Click(object sender, EventArgs e)
        {
            // Seřadí všechny pacienty v kartotéce podle příjmení od Z do A
            
            SQL_prikazy.ProvedSQLPrikaz("SELECT * FROM pacienti ORDER BY prijmeni DESC");
        }

        private void tsb_pridat_Click(object sender, EventArgs e)
        {
            frm_pridat_pacienta frm_pridat_pacienta = new frm_pridat_pacienta();
            frm_pridat_pacienta.ShowDialog();
        }

        private void tsb_odebrat_Click(object sender, EventArgs e)
        {
           if (ListView1.SelectedItems.Count == 1)
           {
                DialogResult odpoved = MessageBox.Show("Jste si jistý/á ?", "Vymazání pacienta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
              if (odpoved == DialogResult.OK) {
                
                string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lekari.mdb";
                    OleDbConnection pripojeni = new OleDbConnection(ConnectionString);
                OleDbCommand prikaz;
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                String SqlPrikaz = "";
                SqlPrikaz = "DELETE FROM pacienti WHERE ID_pacienta=" + ListView1.SelectedItems[0].Text.ToString();
                prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
                pripojeni.Open();
                adapter.InsertCommand = new OleDbCommand(SqlPrikaz, pripojeni);
                adapter.InsertCommand.ExecuteNonQuery();
                pripojeni.Close();
                SQL_prikazy.ProvedSQLPrikaz("SELECT * FROM pacienti");
                MessageBox.Show("Pacient byl úspěšně odstraněn", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (ListViewItem item in ListView1.SelectedItems)
                {
                    ListView1.Items.Remove(item);
                }
              }
           }
            else
            {
                DialogResult odpoved2 = MessageBox.Show("Vyberte záznam", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsb_upravit_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count == 1)
            { 
                frm_upravit_pacienta frm_upravit_pacienta = new frm_upravit_pacienta();
                frm_upravit_pacienta.txt_ID.Text = ListView1.SelectedItems[0].SubItems[0].Text;
                frm_upravit_pacienta.mtxt_rodne_cislo.Text = ListView1.SelectedItems[0].SubItems[1].Text;
                frm_upravit_pacienta.txt_jmeno.Text = ListView1.SelectedItems[0].SubItems[2].Text;
                frm_upravit_pacienta.txt_prijmeni.Text = ListView1.SelectedItems[0].SubItems[3].Text;
                frm_upravit_pacienta.txt_datum_narozeni.Text = ListView1.SelectedItems[0].SubItems[4].Text;
                frm_upravit_pacienta.txt_bydliste.Text = ListView1.SelectedItems[0].SubItems[5].Text;
                frm_upravit_pacienta.ShowDialog();
            }
            else
            { 
              DialogResult odpoved = MessageBox.Show("Vyberte záznam", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        private void txt_vyhledavani_TextChanged(object sender, EventArgs e)
        {
            SQL_prikazy.ProvedSQLPrikaz("SELECT * FROM pacienti WHERE prijmeni & rodne_cislo LIKE '%" + txt_vyhledavani.Text + "%'");
        }

        private void tsb_lecba_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count == 1)
            {
                frm_slozka_pacienta frm_slozka_pacienta = new frm_slozka_pacienta();
                SQL_prikazy.ProvedSqlPrikaz2("SELECT lecba.ID_zaznamu, lecba.nemoc, lecba.priznaky, lecba.leky, lecba.kontrola, lecba.poznamka FROM lecba INNER JOIN pacienti ON lecba.id_pacienta = pacienti.id_pacienta WHERE pacienti.ID_pacienta=" + ListView1.SelectedItems[0].Text.ToString());
                frm_slozka_pacienta.ShowDialog();
            }
            else
            {
                DialogResult odpoved = MessageBox.Show("Vyberte záznam", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsb_kontrola_Click(object sender, EventArgs e)
        {
            frm_kontrola frm_kontrola = new frm_kontrola();
            SQL_prikazy.ProvedSqlprikaz3("SELECT pacienti.prijmeni, lecba.Kontrola FROM pacienti INNER JOIN lecba ON pacienti.ID_pacienta = lecba.ID_pacienta WHERE Kontrola Is Not NULL");
            frm_kontrola.ShowDialog();
        }
    }
}
