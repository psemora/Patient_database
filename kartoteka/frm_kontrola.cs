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
    public partial class frm_kontrola : Form
    {
        public frm_kontrola()
        {
            InitializeComponent();

        }

       
        private void btn_podle_jmena_Click(object sender, EventArgs e)
        {
            SQL_prikazy.ProvedSqlprikaz3("SELECT pacienti.prijmeni, lecba.Kontrola FROM pacienti INNER JOIN lecba ON pacienti.ID_pacienta = lecba.ID_pacienta WHERE Kontrola Is Not NULL ORDER BY prijmeni");
        }

        private void btn_podle_data_Click(object sender, EventArgs e)
        {
            SQL_prikazy.ProvedSqlprikaz3("SELECT pacienti.prijmeni, lecba.Kontrola FROM pacienti INNER JOIN lecba ON pacienti.ID_pacienta = lecba.ID_pacienta WHERE Kontrola Is Not NULL ORDER BY kontrola");
        }
        
        private void btn_zavrit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
