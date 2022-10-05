namespace kartoteka
{
    partial class frm_slozka_pacienta
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
            this.btn_upravit = new System.Windows.Forms.Button();
            this.btn_odebrat_zaznam = new System.Windows.Forms.Button();
            this.btn_pridat_zaznam = new System.Windows.Forms.Button();
            frm_slozka_pacienta.lv_slozka_pacienta = new System.Windows.Forms.ListView();
            this.ID_zaznamu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nemoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priznaky = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leky = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kontrola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.poznamka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_upravit
            // 
            this.btn_upravit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_upravit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_upravit.Location = new System.Drawing.Point(905, 183);
            this.btn_upravit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_upravit.Name = "btn_upravit";
            this.btn_upravit.Size = new System.Drawing.Size(120, 50);
            this.btn_upravit.TabIndex = 26;
            this.btn_upravit.Text = "Upravit záznam";
            this.btn_upravit.UseVisualStyleBackColor = false;
            this.btn_upravit.Click += new System.EventHandler(this.btn_upravit_Click);
            // 
            // btn_odebrat_zaznam
            // 
            this.btn_odebrat_zaznam.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_odebrat_zaznam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_odebrat_zaznam.Location = new System.Drawing.Point(905, 112);
            this.btn_odebrat_zaznam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_odebrat_zaznam.Name = "btn_odebrat_zaznam";
            this.btn_odebrat_zaznam.Size = new System.Drawing.Size(120, 50);
            this.btn_odebrat_zaznam.TabIndex = 25;
            this.btn_odebrat_zaznam.Text = "Odebrat záznam";
            this.btn_odebrat_zaznam.UseVisualStyleBackColor = false;
            this.btn_odebrat_zaznam.Click += new System.EventHandler(this.btn_odebrat_zaznam_Click);
            // 
            // btn_pridat_zaznam
            // 
            this.btn_pridat_zaznam.BackColor = System.Drawing.Color.LightGreen;
            this.btn_pridat_zaznam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pridat_zaznam.Location = new System.Drawing.Point(905, 35);
            this.btn_pridat_zaznam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pridat_zaznam.Name = "btn_pridat_zaznam";
            this.btn_pridat_zaznam.Size = new System.Drawing.Size(120, 50);
            this.btn_pridat_zaznam.TabIndex = 24;
            this.btn_pridat_zaznam.Text = "Přidat záznam";
            this.btn_pridat_zaznam.UseVisualStyleBackColor = false;
            this.btn_pridat_zaznam.Click += new System.EventHandler(this.btn_pridat_zaznam_Click);
            // 
            // lv_slozka_pacienta
            // 
            frm_slozka_pacienta.lv_slozka_pacienta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_zaznamu,
            this.nemoc,
            this.priznaky,
            this.leky,
            this.Kontrola,
            this.poznamka});
            frm_slozka_pacienta.lv_slozka_pacienta.FullRowSelect = true;
            frm_slozka_pacienta.lv_slozka_pacienta.GridLines = true;
            frm_slozka_pacienta.lv_slozka_pacienta.Location = new System.Drawing.Point(13, 13);
            frm_slozka_pacienta.lv_slozka_pacienta.Margin = new System.Windows.Forms.Padding(4);
            frm_slozka_pacienta.lv_slozka_pacienta.Name = "lv_slozka_pacienta";
            frm_slozka_pacienta.lv_slozka_pacienta.Size = new System.Drawing.Size(884, 395);
            frm_slozka_pacienta.lv_slozka_pacienta.TabIndex = 23;
            frm_slozka_pacienta.lv_slozka_pacienta.UseCompatibleStateImageBehavior = false;
            frm_slozka_pacienta.lv_slozka_pacienta.View = System.Windows.Forms.View.Details;
            // 
            // ID_zaznamu
            // 
            this.ID_zaznamu.Text = "ID_zaznamu";
            this.ID_zaznamu.Width = 49;
            // 
            // nemoc
            // 
            this.nemoc.Text = "nemoc";
            this.nemoc.Width = 123;
            // 
            // priznaky
            // 
            this.priznaky.Text = "příznaky";
            this.priznaky.Width = 118;
            // 
            // leky
            // 
            this.leky.Text = "léky";
            this.leky.Width = 114;
            // 
            // Kontrola
            // 
            this.Kontrola.Text = "Kontrola";
            this.Kontrola.Width = 120;
            // 
            // poznamka
            // 
            this.poznamka.Text = "poznámka";
            this.poznamka.Width = 168;
            // 
            // frm_slozka_pacienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 493);
            this.Controls.Add(this.btn_upravit);
            this.Controls.Add(this.btn_odebrat_zaznam);
            this.Controls.Add(this.btn_pridat_zaznam);
            this.Controls.Add(frm_slozka_pacienta.lv_slozka_pacienta);
            this.Name = "frm_slozka_pacienta";
            this.Text = "frm_slozka_pacienta";
            this.ResumeLayout(false);
            this.MaximizeBox = false;

        }

        #endregion

        internal System.Windows.Forms.Button btn_upravit;
        internal System.Windows.Forms.Button btn_odebrat_zaznam;
        internal System.Windows.Forms.Button btn_pridat_zaznam;
        static internal System.Windows.Forms.ListView lv_slozka_pacienta;
        internal System.Windows.Forms.ColumnHeader ID_zaznamu;
        internal System.Windows.Forms.ColumnHeader nemoc;
        internal System.Windows.Forms.ColumnHeader priznaky;
        internal System.Windows.Forms.ColumnHeader leky;
        internal System.Windows.Forms.ColumnHeader Kontrola;
        internal System.Windows.Forms.ColumnHeader poznamka;
    }
}