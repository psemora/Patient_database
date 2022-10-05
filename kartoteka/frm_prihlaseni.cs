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
    public partial class frm_prihlaseni : Form
    {
        public frm_prihlaseni()
        {
            InitializeComponent();
        }

        private void btn_prihlasit_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=lekari.mdb";
            OleDbConnection pripojeni = new OleDbConnection(ConnectionString);
            OleDbCommand sql_dotaz;
            OleDbDataReader zaznamy;
            String SQLprikaz = "SELECT * FROM uzivatele WHERE jmeno='" + txt_jmeno.Text + "'";
            sql_dotaz = new OleDbCommand(SQLprikaz, pripojeni);
            pripojeni.Open();
            zaznamy = sql_dotaz.ExecuteReader();

            if (zaznamy.HasRows)
            {
                while (zaznamy.Read())
                {
                    if (zaznamy.GetString(1) == txt_heslo.Text)
                    {
                        frm_kartoteka frm_kartoteka = new frm_kartoteka();
                        this.Hide();
                        frm_kartoteka.Show();
                    }
                    else
                    { 
                    DialogResult odpoved = MessageBox.Show("Śpatné heslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            { 
              DialogResult odpoved2 = MessageBox.Show("Neznámý uživatel", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        
        pripojeni.Close();
        }

        private void btn_storno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_heslo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_prihlasit.PerformClick();
            }
        }
    }
}
