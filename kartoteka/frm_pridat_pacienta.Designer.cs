namespace kartoteka
{
    partial class frm_pridat_pacienta
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
            this.btn_zavrit = new System.Windows.Forms.Button();
            this.btn_vloz_pacienta = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_bydliste = new System.Windows.Forms.TextBox();
            this.txt_datum_narozeni = new System.Windows.Forms.TextBox();
            this.txt_prijmeni = new System.Windows.Forms.TextBox();
            this.txt_jmeno = new System.Windows.Forms.TextBox();
            this.mtxt_rodne_cislo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_zavrit
            // 
            this.btn_zavrit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_zavrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zavrit.Location = new System.Drawing.Point(73, 311);
            this.btn_zavrit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_zavrit.Name = "btn_zavrit";
            this.btn_zavrit.Size = new System.Drawing.Size(120, 50);
            this.btn_zavrit.TabIndex = 32;
            this.btn_zavrit.Text = "Zavřít";
            this.btn_zavrit.UseVisualStyleBackColor = false;
            this.btn_zavrit.Click += new System.EventHandler(this.btn_zavrit_Click);
            // 
            // btn_vloz_pacienta
            // 
            this.btn_vloz_pacienta.BackColor = System.Drawing.Color.LightGreen;
            this.btn_vloz_pacienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_vloz_pacienta.Location = new System.Drawing.Point(257, 311);
            this.btn_vloz_pacienta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_vloz_pacienta.Name = "btn_vloz_pacienta";
            this.btn_vloz_pacienta.Size = new System.Drawing.Size(120, 50);
            this.btn_vloz_pacienta.TabIndex = 31;
            this.btn_vloz_pacienta.Text = "Přidat pacienta";
            this.btn_vloz_pacienta.UseVisualStyleBackColor = false;
            this.btn_vloz_pacienta.Click += new System.EventHandler(this.btn_vloz_pacienta_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label5.Location = new System.Drawing.Point(52, 254);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(129, 17);
            this.Label5.TabIndex = 30;
            this.Label5.Text = "Zadejte bydliště:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label4.Location = new System.Drawing.Point(52, 204);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(185, 17);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "Zadejte datum narození:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label3.Location = new System.Drawing.Point(52, 156);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(130, 17);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "Zadejte příjmení:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.Location = new System.Drawing.Point(52, 104);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 17);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Zadejte jméno:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(52, 57);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(153, 17);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Zadejte rodné číslo:";
            // 
            // txt_bydliste
            // 
            this.txt_bydliste.Location = new System.Drawing.Point(257, 250);
            this.txt_bydliste.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bydliste.Name = "txt_bydliste";
            this.txt_bydliste.Size = new System.Drawing.Size(132, 22);
            this.txt_bydliste.TabIndex = 25;
            // 
            // txt_datum_narozeni
            // 
            this.txt_datum_narozeni.Location = new System.Drawing.Point(257, 201);
            this.txt_datum_narozeni.Margin = new System.Windows.Forms.Padding(4);
            this.txt_datum_narozeni.Name = "txt_datum_narozeni";
            this.txt_datum_narozeni.Size = new System.Drawing.Size(132, 22);
            this.txt_datum_narozeni.TabIndex = 24;
            // 
            // txt_prijmeni
            // 
            this.txt_prijmeni.Location = new System.Drawing.Point(257, 152);
            this.txt_prijmeni.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prijmeni.Name = "txt_prijmeni";
            this.txt_prijmeni.Size = new System.Drawing.Size(132, 22);
            this.txt_prijmeni.TabIndex = 23;
            // 
            // txt_jmeno
            // 
            this.txt_jmeno.Location = new System.Drawing.Point(257, 103);
            this.txt_jmeno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jmeno.Name = "txt_jmeno";
            this.txt_jmeno.Size = new System.Drawing.Size(132, 22);
            this.txt_jmeno.TabIndex = 22;
            // 
            // mtxt_rodne_cislo
            // 
            this.mtxt_rodne_cislo.Location = new System.Drawing.Point(257, 52);
            this.mtxt_rodne_cislo.Mask = "000000\\/9999";
            this.mtxt_rodne_cislo.Name = "mtxt_rodne_cislo";
            this.mtxt_rodne_cislo.Size = new System.Drawing.Size(132, 22);
            this.mtxt_rodne_cislo.TabIndex = 33;
            // 
            // frm_pridat_pacienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 408);
            this.Controls.Add(this.mtxt_rodne_cislo);
            this.Controls.Add(this.btn_zavrit);
            this.Controls.Add(this.btn_vloz_pacienta);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txt_bydliste);
            this.Controls.Add(this.txt_datum_narozeni);
            this.Controls.Add(this.txt_prijmeni);
            this.Controls.Add(this.txt_jmeno);
            this.MaximizeBox = false;
            this.Name = "frm_pridat_pacienta";
            this.Text = "frm_pridat_pacienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_zavrit;
        internal System.Windows.Forms.Button btn_vloz_pacienta;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_bydliste;
        internal System.Windows.Forms.TextBox txt_datum_narozeni;
        internal System.Windows.Forms.TextBox txt_prijmeni;
        internal System.Windows.Forms.TextBox txt_jmeno;
        private System.Windows.Forms.MaskedTextBox mtxt_rodne_cislo;
    }
}