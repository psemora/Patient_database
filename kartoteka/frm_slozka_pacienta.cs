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
    public partial class frm_slozka_pacienta : Form
    {
        OleDbConnection pripojeni;
        public frm_slozka_pacienta()
        {
            InitializeComponent();
            string ConnectionString;
            ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lekari.mdb";
            pripojeni = new OleDbConnection(ConnectionString);
        }

        private void btn_pridat_zaznam_Click(object sender, EventArgs e)
        {
            frm_pridat_zaznam frm_pridat_zaznam = new frm_pridat_zaznam();
            frm_pridat_zaznam.ShowDialog();
        }

       private void btn_odebrat_zaznam_Click(object sender, EventArgs e)
            {
            
            if (lv_slozka_pacienta.SelectedItems.Count == 1)
            {
                DialogResult odpoved = MessageBox.Show("Jste si jistý/á ?", "Vymazání pacienta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
              if (odpoved == DialogResult.OK)
              {
                  OleDbCommand prikaz;
                  OleDbDataAdapter adapter = new OleDbDataAdapter();
                  String SqlPrikaz = "";
                  SqlPrikaz = "DELETE FROM lecba WHERE ID_zaznamu=" + lv_slozka_pacienta.SelectedItems[0].Text.ToString();
                  prikaz = new OleDbCommand(SqlPrikaz, pripojeni);
                  pripojeni.Open();
                  adapter.InsertCommand = new OleDbCommand(SqlPrikaz, pripojeni);
                  adapter.InsertCommand.ExecuteNonQuery(); 
                  pripojeni.Close();
                foreach (ListViewItem item in lv_slozka_pacienta.SelectedItems)
                {
                    lv_slozka_pacienta.Items.Remove(item);
                }

                MessageBox.Show("Záznam byl úspěšně odebrán", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
              }
            }
            else
            {
                DialogResult odpoved = MessageBox.Show("Vyberte záznam", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
       }

        private void btn_upravit_Click(object sender, EventArgs e)
            {

            frm_upravit_zaznam frm_upravit_zaznam = new frm_upravit_zaznam();
            if (lv_slozka_pacienta.SelectedItems.Count == 1)
            {
                frm_upravit_zaznam.txt_ID.Text = lv_slozka_pacienta.SelectedItems[0].SubItems[0].Text;
                frm_upravit_zaznam.txt_nemoc.Text = lv_slozka_pacienta.SelectedItems[0].SubItems[1].Text;
                frm_upravit_zaznam.txt_priznaky.Text = lv_slozka_pacienta.SelectedItems[0].SubItems[2].Text;
                frm_upravit_zaznam.txt_leky.Text = lv_slozka_pacienta.SelectedItems[0].SubItems[3].Text;
                frm_upravit_zaznam.dtp_kontrola.Text = lv_slozka_pacienta.SelectedItems[0].SubItems[4].Text;
                frm_upravit_zaznam.txt_poznamka.Text = lv_slozka_pacienta.SelectedItems[0].SubItems[5].Text;
                frm_upravit_zaznam.ShowDialog();
            }
            else
            {
                DialogResult odpoved = MessageBox.Show("Vyberte záznam", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
