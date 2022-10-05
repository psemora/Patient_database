namespace kartoteka
{
    partial class frm_upravit_zaznam
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
            this.Label8 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txt_pridat_lek = new System.Windows.Forms.TextBox();
            this.lb_leky = new System.Windows.Forms.ListBox();
            this.dtp_kontrola = new System.Windows.Forms.DateTimePicker();
            this.txt_pridat_nemoc = new System.Windows.Forms.TextBox();
            this.lb_nemoci = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btn_storno = new System.Windows.Forms.Button();
            this.btn_upravit_zaznam = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_poznamka = new System.Windows.Forms.TextBox();
            this.txt_leky = new System.Windows.Forms.TextBox();
            this.txt_priznaky = new System.Windows.Forms.TextBox();
            this.txt_nemoc = new System.Windows.Forms.TextBox();
            this.btn_odstranit_lek = new System.Windows.Forms.Button();
            this.btn_odstranit_nemoc = new System.Windows.Forms.Button();
            this.btn_pridat_lek = new System.Windows.Forms.Button();
            this.btn_pridat_nemoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label8.Location = new System.Drawing.Point(50, 49);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(28, 17);
            this.Label8.TabIndex = 84;
            this.Label8.Text = "ID:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(158, 44);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(219, 22);
            this.txt_ID.TabIndex = 83;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label7.Location = new System.Drawing.Point(589, 24);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(89, 17);
            this.Label7.TabIndex = 82;
            this.Label7.Text = "Seznam léků";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(402, 24);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(112, 17);
            this.Label6.TabIndex = 81;
            this.Label6.Text = "Seznam nemocí:";
            // 
            // txt_pridat_lek
            // 
            this.txt_pridat_lek.Location = new System.Drawing.Point(593, 364);
            this.txt_pridat_lek.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pridat_lek.Name = "txt_pridat_lek";
            this.txt_pridat_lek.Size = new System.Drawing.Size(157, 22);
            this.txt_pridat_lek.TabIndex = 79;
            // 
            // lb_leky
            // 
            this.lb_leky.FormattingEnabled = true;
            this.lb_leky.ItemHeight = 16;
            this.lb_leky.Location = new System.Drawing.Point(593, 48);
            this.lb_leky.Margin = new System.Windows.Forms.Padding(4);
            this.lb_leky.Name = "lb_leky";
            this.lb_leky.Size = new System.Drawing.Size(157, 308);
            this.lb_leky.TabIndex = 78;
            this.lb_leky.SelectedIndexChanged += new System.EventHandler(this.lb_leky_SelectedIndexChanged);
            // 
            // dtp_kontrola
            // 
            this.dtp_kontrola.CustomFormat = "dd.mm.yyy";
            this.dtp_kontrola.Location = new System.Drawing.Point(158, 208);
            this.dtp_kontrola.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_kontrola.Name = "dtp_kontrola";
            this.dtp_kontrola.Size = new System.Drawing.Size(219, 22);
            this.dtp_kontrola.TabIndex = 77;
            // 
            // txt_pridat_nemoc
            // 
            this.txt_pridat_nemoc.Location = new System.Drawing.Point(402, 364);
            this.txt_pridat_nemoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pridat_nemoc.Name = "txt_pridat_nemoc";
            this.txt_pridat_nemoc.Size = new System.Drawing.Size(157, 22);
            this.txt_pridat_nemoc.TabIndex = 76;
            // 
            // lb_nemoci
            // 
            this.lb_nemoci.FormattingEnabled = true;
            this.lb_nemoci.ItemHeight = 16;
            this.lb_nemoci.Location = new System.Drawing.Point(402, 48);
            this.lb_nemoci.Margin = new System.Windows.Forms.Padding(4);
            this.lb_nemoci.Name = "lb_nemoci";
            this.lb_nemoci.Size = new System.Drawing.Size(157, 308);
            this.lb_nemoci.TabIndex = 74;
            this.lb_nemoci.SelectedIndexChanged += new System.EventHandler(this.lb_nemoci_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(50, 215);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 17);
            this.Label1.TabIndex = 70;
            this.Label1.Text = "Kontrola:";
            // 
            // btn_storno
            // 
            this.btn_storno.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_storno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_storno.Location = new System.Drawing.Point(246, 306);
            this.btn_storno.Margin = new System.Windows.Forms.Padding(4);
            this.btn_storno.Name = "btn_storno";
            this.btn_storno.Size = new System.Drawing.Size(120, 50);
            this.btn_storno.TabIndex = 72;
            this.btn_storno.Text = "Zavřít";
            this.btn_storno.UseVisualStyleBackColor = false;
            this.btn_storno.Click += new System.EventHandler(this.btn_storno_Click);
            // 
            // btn_upravit_zaznam
            // 
            this.btn_upravit_zaznam.BackColor = System.Drawing.Color.LightGreen;
            this.btn_upravit_zaznam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_upravit_zaznam.Location = new System.Drawing.Point(94, 306);
            this.btn_upravit_zaznam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_upravit_zaznam.Name = "btn_upravit_zaznam";
            this.btn_upravit_zaznam.Size = new System.Drawing.Size(120, 50);
            this.btn_upravit_zaznam.TabIndex = 73;
            this.btn_upravit_zaznam.Text = "Upravit záznam";
            this.btn_upravit_zaznam.UseVisualStyleBackColor = false;
            this.btn_upravit_zaznam.Click += new System.EventHandler(this.btn_upravit_zaznam_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label5.Location = new System.Drawing.Point(50, 261);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 17);
            this.Label5.TabIndex = 71;
            this.Label5.Text = "Poznámka:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label4.Location = new System.Drawing.Point(50, 172);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 17);
            this.Label4.TabIndex = 69;
            this.Label4.Text = "Léky:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label3.Location = new System.Drawing.Point(50, 127);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 17);
            this.Label3.TabIndex = 68;
            this.Label3.Text = "Příznaky:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.Location = new System.Drawing.Point(50, 82);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 17);
            this.Label2.TabIndex = 67;
            this.Label2.Text = "Nemoc:";
            // 
            // txt_poznamka
            // 
            this.txt_poznamka.Location = new System.Drawing.Point(158, 248);
            this.txt_poznamka.Margin = new System.Windows.Forms.Padding(4);
            this.txt_poznamka.Name = "txt_poznamka";
            this.txt_poznamka.Size = new System.Drawing.Size(219, 22);
            this.txt_poznamka.TabIndex = 66;
            // 
            // txt_leky
            // 
            this.txt_leky.Location = new System.Drawing.Point(158, 168);
            this.txt_leky.Margin = new System.Windows.Forms.Padding(4);
            this.txt_leky.Name = "txt_leky";
            this.txt_leky.Size = new System.Drawing.Size(219, 22);
            this.txt_leky.TabIndex = 65;
            // 
            // txt_priznaky
            // 
            this.txt_priznaky.Location = new System.Drawing.Point(158, 127);
            this.txt_priznaky.Margin = new System.Windows.Forms.Padding(4);
            this.txt_priznaky.Name = "txt_priznaky";
            this.txt_priznaky.Size = new System.Drawing.Size(219, 22);
            this.txt_priznaky.TabIndex = 64;
            // 
            // txt_nemoc
            // 
            this.txt_nemoc.Location = new System.Drawing.Point(158, 82);
            this.txt_nemoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nemoc.Name = "txt_nemoc";
            this.txt_nemoc.Size = new System.Drawing.Size(219, 22);
            this.txt_nemoc.TabIndex = 63;
            // 
            // btn_odstranit_lek
            // 
            this.btn_odstranit_lek.BackColor = System.Drawing.Color.Silver;
            this.btn_odstranit_lek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_odstranit_lek.Location = new System.Drawing.Point(673, 390);
            this.btn_odstranit_lek.Margin = new System.Windows.Forms.Padding(4);
            this.btn_odstranit_lek.Name = "btn_odstranit_lek";
            this.btn_odstranit_lek.Size = new System.Drawing.Size(89, 50);
            this.btn_odstranit_lek.TabIndex = 88;
            this.btn_odstranit_lek.Text = "Odstranit lék";
            this.btn_odstranit_lek.UseVisualStyleBackColor = false;
            this.btn_odstranit_lek.Click += new System.EventHandler(this.btn_odstranit_lek_Click);
            // 
            // btn_odstranit_nemoc
            // 
            this.btn_odstranit_nemoc.BackColor = System.Drawing.Color.Silver;
            this.btn_odstranit_nemoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_odstranit_nemoc.Location = new System.Drawing.Point(484, 394);
            this.btn_odstranit_nemoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_odstranit_nemoc.Name = "btn_odstranit_nemoc";
            this.btn_odstranit_nemoc.Size = new System.Drawing.Size(90, 43);
            this.btn_odstranit_nemoc.TabIndex = 87;
            this.btn_odstranit_nemoc.Text = "Odstranit nemoc";
            this.btn_odstranit_nemoc.UseVisualStyleBackColor = false;
            this.btn_odstranit_nemoc.Click += new System.EventHandler(this.btn_odstranit_nemoc_Click);
            // 
            // btn_pridat_lek
            // 
            this.btn_pridat_lek.BackColor = System.Drawing.Color.Silver;
            this.btn_pridat_lek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pridat_lek.Location = new System.Drawing.Point(592, 390);
            this.btn_pridat_lek.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pridat_lek.Name = "btn_pridat_lek";
            this.btn_pridat_lek.Size = new System.Drawing.Size(73, 50);
            this.btn_pridat_lek.TabIndex = 86;
            this.btn_pridat_lek.Text = "Přidat lék";
            this.btn_pridat_lek.UseVisualStyleBackColor = false;
            this.btn_pridat_lek.Click += new System.EventHandler(this.btn_pridat_lek_Click);
            // 
            // btn_pridat_nemoc
            // 
            this.btn_pridat_nemoc.BackColor = System.Drawing.Color.Silver;
            this.btn_pridat_nemoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_pridat_nemoc.Location = new System.Drawing.Point(391, 394);
            this.btn_pridat_nemoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pridat_nemoc.Name = "btn_pridat_nemoc";
            this.btn_pridat_nemoc.Size = new System.Drawing.Size(85, 43);
            this.btn_pridat_nemoc.TabIndex = 85;
            this.btn_pridat_nemoc.Text = "Přidat nemoc";
            this.btn_pridat_nemoc.UseVisualStyleBackColor = false;
            this.btn_pridat_nemoc.Click += new System.EventHandler(this.btn_pridat_nemoc_Click);
            // 
            // frm_upravit_zaznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_odstranit_lek);
            this.Controls.Add(this.btn_odstranit_nemoc);
            this.Controls.Add(this.btn_pridat_lek);
            this.Controls.Add(this.btn_pridat_nemoc);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txt_pridat_lek);
            this.Controls.Add(this.lb_leky);
            this.Controls.Add(this.dtp_kontrola);
            this.Controls.Add(this.txt_pridat_nemoc);
            this.Controls.Add(this.lb_nemoci);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btn_storno);
            this.Controls.Add(this.btn_upravit_zaznam);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_poznamka);
            this.Controls.Add(this.txt_leky);
            this.Controls.Add(this.txt_priznaky);
            this.Controls.Add(this.txt_nemoc);
            this.MinimizeBox = false;
            this.Name = "frm_upravit_zaznam";
            this.Text = "frm_upravit_zaznam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txt_ID;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txt_pridat_lek;
        internal System.Windows.Forms.ListBox lb_leky;
        internal System.Windows.Forms.DateTimePicker dtp_kontrola;
        internal System.Windows.Forms.TextBox txt_pridat_nemoc;
        internal System.Windows.Forms.ListBox lb_nemoci;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btn_storno;
        internal System.Windows.Forms.Button btn_upravit_zaznam;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_poznamka;
        internal System.Windows.Forms.TextBox txt_leky;
        internal System.Windows.Forms.TextBox txt_priznaky;
        internal System.Windows.Forms.TextBox txt_nemoc;
        internal System.Windows.Forms.Button btn_odstranit_lek;
        internal System.Windows.Forms.Button btn_odstranit_nemoc;
        internal System.Windows.Forms.Button btn_pridat_lek;
        internal System.Windows.Forms.Button btn_pridat_nemoc;
    }
}