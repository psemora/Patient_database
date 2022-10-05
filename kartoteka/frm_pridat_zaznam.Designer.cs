namespace kartoteka
{
    partial class frm_pridat_zaznam
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
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.btn_pridat_lek = new System.Windows.Forms.Button();
            this.txt_pridat_lek = new System.Windows.Forms.TextBox();
            this.lb_leky = new System.Windows.Forms.ListBox();
            this.dtp_kontrola = new System.Windows.Forms.DateTimePicker();
            this.txt_pridat_nemoc = new System.Windows.Forms.TextBox();
            this.btn_pridat_nemoc = new System.Windows.Forms.Button();
            this.lb_nemoci = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btn_zavrit = new System.Windows.Forms.Button();
            this.btn_uloz_zaznam = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_poznamka = new System.Windows.Forms.TextBox();
            this.txt_leky = new System.Windows.Forms.TextBox();
            this.txt_priznaky = new System.Windows.Forms.TextBox();
            this.txt_nemoc = new System.Windows.Forms.TextBox();
            this.btn_odstranit_nemoc = new System.Windows.Forms.Button();
            this.btn_odstranit_lek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label7.Location = new System.Drawing.Point(601, 24);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(89, 17);
            this.Label7.TabIndex = 60;
            this.Label7.Text = "Seznam léků";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(401, 25);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(112, 17);
            this.Label6.TabIndex = 59;
            this.Label6.Text = "Seznam nemocí:";
            // 
            // btn_pridat_lek
            // 
            this.btn_pridat_lek.BackColor = System.Drawing.Color.Silver;
            this.btn_pridat_lek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pridat_lek.Location = new System.Drawing.Point(591, 390);
            this.btn_pridat_lek.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pridat_lek.Name = "btn_pridat_lek";
            this.btn_pridat_lek.Size = new System.Drawing.Size(73, 50);
            this.btn_pridat_lek.TabIndex = 58;
            this.btn_pridat_lek.Text = "Přidat lék";
            this.btn_pridat_lek.UseVisualStyleBackColor = false;
            this.btn_pridat_lek.Click += new System.EventHandler(this.btn_pridat_lek_Click);
            // 
            // txt_pridat_lek
            // 
            this.txt_pridat_lek.Location = new System.Drawing.Point(604, 364);
            this.txt_pridat_lek.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pridat_lek.Name = "txt_pridat_lek";
            this.txt_pridat_lek.Size = new System.Drawing.Size(157, 22);
            this.txt_pridat_lek.TabIndex = 57;
            // 
            // lb_leky
            // 
            this.lb_leky.FormattingEnabled = true;
            this.lb_leky.ItemHeight = 16;
            this.lb_leky.Location = new System.Drawing.Point(604, 48);
            this.lb_leky.Margin = new System.Windows.Forms.Padding(4);
            this.lb_leky.Name = "lb_leky";
            this.lb_leky.Size = new System.Drawing.Size(157, 308);
            this.lb_leky.TabIndex = 56;
            this.lb_leky.SelectedIndexChanged += new System.EventHandler(this.lb_leky_SelectedIndexChanged);
            // 
            // dtp_kontrola
            // 
            this.dtp_kontrola.CustomFormat = "dd. M. yyyy H:m";
            this.dtp_kontrola.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_kontrola.Location = new System.Drawing.Point(160, 174);
            this.dtp_kontrola.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_kontrola.Name = "dtp_kontrola";
            this.dtp_kontrola.Size = new System.Drawing.Size(219, 22);
            this.dtp_kontrola.TabIndex = 55;
            // 
            // txt_pridat_nemoc
            // 
            this.txt_pridat_nemoc.Location = new System.Drawing.Point(401, 364);
            this.txt_pridat_nemoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pridat_nemoc.Name = "txt_pridat_nemoc";
            this.txt_pridat_nemoc.Size = new System.Drawing.Size(165, 22);
            this.txt_pridat_nemoc.TabIndex = 54;
            // 
            // btn_pridat_nemoc
            // 
            this.btn_pridat_nemoc.BackColor = System.Drawing.Color.Silver;
            this.btn_pridat_nemoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pridat_nemoc.Location = new System.Drawing.Point(390, 394);
            this.btn_pridat_nemoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pridat_nemoc.Name = "btn_pridat_nemoc";
            this.btn_pridat_nemoc.Size = new System.Drawing.Size(85, 43);
            this.btn_pridat_nemoc.TabIndex = 53;
            this.btn_pridat_nemoc.Text = "Přidat nemoc";
            this.btn_pridat_nemoc.UseVisualStyleBackColor = false;
            this.btn_pridat_nemoc.Click += new System.EventHandler(this.btn_pridat_nemoc_Click);
            // 
            // lb_nemoci
            // 
            this.lb_nemoci.FormattingEnabled = true;
            this.lb_nemoci.ItemHeight = 16;
            this.lb_nemoci.Location = new System.Drawing.Point(401, 47);
            this.lb_nemoci.Margin = new System.Windows.Forms.Padding(4);
            this.lb_nemoci.Name = "lb_nemoci";
            this.lb_nemoci.Size = new System.Drawing.Size(165, 308);
            this.lb_nemoci.TabIndex = 52;
            this.lb_nemoci.SelectedIndexChanged += new System.EventHandler(this.lb_nemoci_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(52, 180);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 17);
            this.Label1.TabIndex = 48;
            this.Label1.Text = "Kontrola:";
            // 
            // btn_zavrit
            // 
            this.btn_zavrit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_zavrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zavrit.Location = new System.Drawing.Point(224, 300);
            this.btn_zavrit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_zavrit.Name = "btn_zavrit";
            this.btn_zavrit.Size = new System.Drawing.Size(120, 50);
            this.btn_zavrit.TabIndex = 50;
            this.btn_zavrit.Text = "ZAVŘÍT";
            this.btn_zavrit.UseVisualStyleBackColor = false;
            this.btn_zavrit.Click += new System.EventHandler(this.btn_zavrit_Click);
            // 
            // btn_uloz_zaznam
            // 
            this.btn_uloz_zaznam.BackColor = System.Drawing.Color.LightGreen;
            this.btn_uloz_zaznam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_uloz_zaznam.Location = new System.Drawing.Point(56, 300);
            this.btn_uloz_zaznam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_uloz_zaznam.Name = "btn_uloz_zaznam";
            this.btn_uloz_zaznam.Size = new System.Drawing.Size(120, 50);
            this.btn_uloz_zaznam.TabIndex = 51;
            this.btn_uloz_zaznam.Text = "ULOŽIT";
            this.btn_uloz_zaznam.UseVisualStyleBackColor = false;
            this.btn_uloz_zaznam.Click += new System.EventHandler(this.btn_uloz_zaznam_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label5.Location = new System.Drawing.Point(52, 226);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 17);
            this.Label5.TabIndex = 49;
            this.Label5.Text = "Poznámka:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label4.Location = new System.Drawing.Point(52, 137);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 17);
            this.Label4.TabIndex = 47;
            this.Label4.Text = "Léky:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label3.Location = new System.Drawing.Point(52, 92);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 17);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "Příznaky:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.Location = new System.Drawing.Point(52, 47);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 17);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "Nemoc:";
            // 
            // txt_poznamka
            // 
            this.txt_poznamka.Location = new System.Drawing.Point(160, 214);
            this.txt_poznamka.Margin = new System.Windows.Forms.Padding(4);
            this.txt_poznamka.Name = "txt_poznamka";
            this.txt_poznamka.Size = new System.Drawing.Size(219, 22);
            this.txt_poznamka.TabIndex = 44;
            // 
            // txt_leky
            // 
            this.txt_leky.Location = new System.Drawing.Point(160, 134);
            this.txt_leky.Margin = new System.Windows.Forms.Padding(4);
            this.txt_leky.Name = "txt_leky";
            this.txt_leky.Size = new System.Drawing.Size(219, 22);
            this.txt_leky.TabIndex = 43;
            // 
            // txt_priznaky
            // 
            this.txt_priznaky.Location = new System.Drawing.Point(160, 92);
            this.txt_priznaky.Margin = new System.Windows.Forms.Padding(4);
            this.txt_priznaky.Name = "txt_priznaky";
            this.txt_priznaky.Size = new System.Drawing.Size(219, 22);
            this.txt_priznaky.TabIndex = 42;
            // 
            // txt_nemoc
            // 
            this.txt_nemoc.Location = new System.Drawing.Point(160, 47);
            this.txt_nemoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nemoc.Name = "txt_nemoc";
            this.txt_nemoc.Size = new System.Drawing.Size(219, 22);
            this.txt_nemoc.TabIndex = 41;
            // 
            // btn_odstranit_nemoc
            // 
            this.btn_odstranit_nemoc.BackColor = System.Drawing.Color.Silver;
            this.btn_odstranit_nemoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_odstranit_nemoc.Location = new System.Drawing.Point(483, 394);
            this.btn_odstranit_nemoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_odstranit_nemoc.Name = "btn_odstranit_nemoc";
            this.btn_odstranit_nemoc.Size = new System.Drawing.Size(90, 43);
            this.btn_odstranit_nemoc.TabIndex = 61;
            this.btn_odstranit_nemoc.Text = "Odstranit nemoc";
            this.btn_odstranit_nemoc.UseVisualStyleBackColor = false;
            this.btn_odstranit_nemoc.Click += new System.EventHandler(this.btn_odstranit_nemoc_Click);
            // 
            // btn_odstranit_lek
            // 
            this.btn_odstranit_lek.BackColor = System.Drawing.Color.Silver;
            this.btn_odstranit_lek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_odstranit_lek.Location = new System.Drawing.Point(672, 390);
            this.btn_odstranit_lek.Margin = new System.Windows.Forms.Padding(4);
            this.btn_odstranit_lek.Name = "btn_odstranit_lek";
            this.btn_odstranit_lek.Size = new System.Drawing.Size(89, 50);
            this.btn_odstranit_lek.TabIndex = 62;
            this.btn_odstranit_lek.Text = "Odstranit lék";
            this.btn_odstranit_lek.UseVisualStyleBackColor = false;
            this.btn_odstranit_lek.Click += new System.EventHandler(this.btn_odstranit_lek_Click);
            // 
            // frm_pridat_zaznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_odstranit_lek);
            this.Controls.Add(this.btn_odstranit_nemoc);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.btn_pridat_lek);
            this.Controls.Add(this.txt_pridat_lek);
            this.Controls.Add(this.lb_leky);
            this.Controls.Add(this.dtp_kontrola);
            this.Controls.Add(this.txt_pridat_nemoc);
            this.Controls.Add(this.btn_pridat_nemoc);
            this.Controls.Add(this.lb_nemoci);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btn_zavrit);
            this.Controls.Add(this.btn_uloz_zaznam);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_poznamka);
            this.Controls.Add(this.txt_leky);
            this.Controls.Add(this.txt_priznaky);
            this.Controls.Add(this.txt_nemoc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_pridat_zaznam";
            this.Text = "frm_pridat_zaznam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btn_pridat_lek;
        internal System.Windows.Forms.TextBox txt_pridat_lek;
        internal System.Windows.Forms.ListBox lb_leky;
        internal System.Windows.Forms.DateTimePicker dtp_kontrola;
        internal System.Windows.Forms.TextBox txt_pridat_nemoc;
        internal System.Windows.Forms.Button btn_pridat_nemoc;
        internal System.Windows.Forms.ListBox lb_nemoci;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btn_zavrit;
        internal System.Windows.Forms.Button btn_uloz_zaznam;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_poznamka;
        internal System.Windows.Forms.TextBox txt_leky;
        internal System.Windows.Forms.TextBox txt_priznaky;
        internal System.Windows.Forms.TextBox txt_nemoc;
        internal System.Windows.Forms.Button btn_odstranit_nemoc;
        internal System.Windows.Forms.Button btn_odstranit_lek;
    }
}