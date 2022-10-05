namespace kartoteka
{
    partial class frm_kartoteka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kartoteka));
            this.Label2 = new System.Windows.Forms.Label();
            frm_kartoteka.txt_pocet_zaznamu = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_vyhledavani = new System.Windows.Forms.TextBox();
            this.btn_serad_ZA = new System.Windows.Forms.Button();
            this.btn_serad_AZ = new System.Windows.Forms.Button();
            frm_kartoteka.ListView1 = new System.Windows.Forms.ListView();
            this.ID_pacienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rodne_cislo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prijmeni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum_narozeni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bydliste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_vypis = new System.Windows.Forms.Button();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_pridat = new System.Windows.Forms.ToolStripButton();
            this.tsb_odebrat = new System.Windows.Forms.ToolStripButton();
            this.tsb_upravit = new System.Windows.Forms.ToolStripButton();
            this.tsb_lecba = new System.Windows.Forms.ToolStripButton();
            this.tsb_kontrola = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(805, 119);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(180, 17);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Počet vypsaných záznamů:";
            // 
            // txt_pocet_zaznamu
            // 
            frm_kartoteka.txt_pocet_zaznamu.Location = new System.Drawing.Point(855, 140);
            frm_kartoteka.txt_pocet_zaznamu.Margin = new System.Windows.Forms.Padding(4);
            frm_kartoteka.txt_pocet_zaznamu.Name = "txt_pocet_zaznamu";
            frm_kartoteka.txt_pocet_zaznamu.Size = new System.Drawing.Size(96, 22);
            frm_kartoteka.txt_pocet_zaznamu.TabIndex = 23;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(603, 48);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 17);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Vyhledávání:";
            // 
            // txt_vyhledavani
            // 
            this.txt_vyhledavani.Location = new System.Drawing.Point(700, 45);
            this.txt_vyhledavani.Margin = new System.Windows.Forms.Padding(4);
            this.txt_vyhledavani.Name = "txt_vyhledavani";
            this.txt_vyhledavani.Size = new System.Drawing.Size(251, 22);
            this.txt_vyhledavani.TabIndex = 21;
            this.txt_vyhledavani.TextChanged += new System.EventHandler(this.txt_vyhledavani_TextChanged);
            // 
            // btn_serad_ZA
            // 
            this.btn_serad_ZA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_serad_ZA.Location = new System.Drawing.Point(368, 45);
            this.btn_serad_ZA.Margin = new System.Windows.Forms.Padding(4);
            this.btn_serad_ZA.Name = "btn_serad_ZA";
            this.btn_serad_ZA.Size = new System.Drawing.Size(67, 37);
            this.btn_serad_ZA.TabIndex = 20;
            this.btn_serad_ZA.Text = "Z -> A";
            this.btn_serad_ZA.UseVisualStyleBackColor = true;
            this.btn_serad_ZA.Click += new System.EventHandler(this.btn_serad_ZA_Click);
            // 
            // btn_serad_AZ
            // 
            this.btn_serad_AZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_serad_AZ.Location = new System.Drawing.Point(293, 45);
            this.btn_serad_AZ.Margin = new System.Windows.Forms.Padding(4);
            this.btn_serad_AZ.Name = "btn_serad_AZ";
            this.btn_serad_AZ.Size = new System.Drawing.Size(67, 37);
            this.btn_serad_AZ.TabIndex = 19;
            this.btn_serad_AZ.Text = "A -> Z";
            this.btn_serad_AZ.UseVisualStyleBackColor = true;
            this.btn_serad_AZ.Click += new System.EventHandler(this.btn_serad_AZ_Click);
            // 
            // ListView1
            // 
            frm_kartoteka.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_pacienta,
            this.rodne_cislo,
            this.jmeno,
            this.prijmeni,
            this.datum_narozeni,
            this.Bydliste});
            frm_kartoteka.ListView1.FullRowSelect = true;
            frm_kartoteka.ListView1.GridLines = true;
            frm_kartoteka.ListView1.Location = new System.Drawing.Point(8, 90);
            frm_kartoteka.ListView1.Margin = new System.Windows.Forms.Padding(4);
            frm_kartoteka.ListView1.Name = "ListView1";
            frm_kartoteka.ListView1.Size = new System.Drawing.Size(793, 450);
            frm_kartoteka.ListView1.TabIndex = 18;
            frm_kartoteka.ListView1.UseCompatibleStateImageBehavior = false;
            frm_kartoteka.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ID_pacienta
            // 
            this.ID_pacienta.Text = "ID";
            this.ID_pacienta.Width = 25;
            // 
            // rodne_cislo
            // 
            this.rodne_cislo.Text = "Rodné číslo";
            this.rodne_cislo.Width = 91;
            // 
            // jmeno
            // 
            this.jmeno.Text = "Jméno";
            this.jmeno.Width = 89;
            // 
            // prijmeni
            // 
            this.prijmeni.Text = "Příjmení";
            this.prijmeni.Width = 114;
            // 
            // datum_narozeni
            // 
            this.datum_narozeni.Text = "datum narození";
            this.datum_narozeni.Width = 131;
            // 
            // Bydliste
            // 
            this.Bydliste.Text = "Bydliště";
            this.Bydliste.Width = 142;
            // 
            // btn_vypis
            // 
            this.btn_vypis.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_vypis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_vypis.Location = new System.Drawing.Point(8, 32);
            this.btn_vypis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_vypis.Name = "btn_vypis";
            this.btn_vypis.Size = new System.Drawing.Size(189, 50);
            this.btn_vypis.TabIndex = 17;
            this.btn_vypis.Text = "Vypiš pacienty";
            this.btn_vypis.UseVisualStyleBackColor = false;
            this.btn_vypis.Click += new System.EventHandler(this.btn_vypis_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_pridat,
            this.tsb_odebrat,
            this.tsb_upravit,
            this.ToolStripSeparator1,
            this.tsb_lecba,
            this.tsb_kontrola});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1026, 27);
            this.ToolStrip1.TabIndex = 25;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_pridat
            // 
            this.tsb_pridat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_pridat.Image = ((System.Drawing.Image)(resources.GetObject("tsb_pridat.Image")));
            this.tsb_pridat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_pridat.Name = "tsb_pridat";
            this.tsb_pridat.Size = new System.Drawing.Size(24, 24);
            this.tsb_pridat.Text = "Přidat pacienta";
            this.tsb_pridat.Click += new System.EventHandler(this.tsb_pridat_Click);
            // 
            // tsb_odebrat
            // 
            this.tsb_odebrat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_odebrat.Image = ((System.Drawing.Image)(resources.GetObject("tsb_odebrat.Image")));
            this.tsb_odebrat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_odebrat.Name = "tsb_odebrat";
            this.tsb_odebrat.Size = new System.Drawing.Size(24, 24);
            this.tsb_odebrat.Text = "Odebrat pacienta";
            this.tsb_odebrat.Click += new System.EventHandler(this.tsb_odebrat_Click);
            // 
            // tsb_upravit
            // 
            this.tsb_upravit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_upravit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_upravit.Image")));
            this.tsb_upravit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_upravit.Name = "tsb_upravit";
            this.tsb_upravit.Size = new System.Drawing.Size(24, 24);
            this.tsb_upravit.Text = "Upravit pacienta";
            this.tsb_upravit.Click += new System.EventHandler(this.tsb_upravit_Click);
            // 
            // tsb_lecba
            // 
            this.tsb_lecba.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_lecba.Image = global::kartoteka.Properties.Resources.lecba;
            this.tsb_lecba.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_lecba.Name = "tsb_lecba";
            this.tsb_lecba.Size = new System.Drawing.Size(24, 24);
            this.tsb_lecba.Text = "léčba";
            this.tsb_lecba.Click += new System.EventHandler(this.tsb_lecba_Click);
            // 
            // tsb_kontrola
            // 
            this.tsb_kontrola.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_kontrola.Image = ((System.Drawing.Image)(resources.GetObject("tsb_kontrola.Image")));
            this.tsb_kontrola.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_kontrola.Name = "tsb_kontrola";
            this.tsb_kontrola.Size = new System.Drawing.Size(24, 24);
            this.tsb_kontrola.Text = "Kontrola";
            this.tsb_kontrola.Click += new System.EventHandler(this.tsb_kontrola_Click);
            // 
            // Kartoteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 580);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(frm_kartoteka.txt_pocet_zaznamu);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txt_vyhledavani);
            this.Controls.Add(this.btn_serad_ZA);
            this.Controls.Add(this.btn_serad_AZ);
            this.Controls.Add(frm_kartoteka.ListView1);
            this.Controls.Add(this.btn_vypis);
            this.Name = "Kartoteka";
            this.Text = "Kartoteka";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.MaximizeBox = false;
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        static internal System.Windows.Forms.TextBox txt_pocet_zaznamu;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_vyhledavani;
        internal System.Windows.Forms.Button btn_serad_ZA;
        internal System.Windows.Forms.Button btn_serad_AZ;
        static internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ID_pacienta;
        internal System.Windows.Forms.ColumnHeader rodne_cislo;
        internal System.Windows.Forms.ColumnHeader jmeno;
        internal System.Windows.Forms.ColumnHeader prijmeni;
        internal System.Windows.Forms.ColumnHeader datum_narozeni;
        internal System.Windows.Forms.ColumnHeader Bydliste;
        internal System.Windows.Forms.Button btn_vypis;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsb_pridat;
        internal System.Windows.Forms.ToolStripButton tsb_odebrat;
        internal System.Windows.Forms.ToolStripButton tsb_upravit;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsb_lecba;
        internal System.Windows.Forms.ToolStripButton tsb_kontrola;
    }
}