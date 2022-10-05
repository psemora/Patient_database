namespace kartoteka
{
    partial class frm_upravit_pacienta
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.btn_storno = new System.Windows.Forms.Button();
            this.btn_upravit_zaznam = new System.Windows.Forms.Button();
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
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(195, 28);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(132, 22);
            this.txt_ID.TabIndex = 47;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label6.Location = new System.Drawing.Point(27, 28);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(28, 17);
            this.Label6.TabIndex = 46;
            this.Label6.Text = "ID:";
            // 
            // btn_storno
            // 
            this.btn_storno.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_storno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_storno.Location = new System.Drawing.Point(29, 262);
            this.btn_storno.Margin = new System.Windows.Forms.Padding(4);
            this.btn_storno.Name = "btn_storno";
            this.btn_storno.Size = new System.Drawing.Size(120, 50);
            this.btn_storno.TabIndex = 45;
            this.btn_storno.Text = "Zavřít";
            this.btn_storno.UseVisualStyleBackColor = false;
            this.btn_storno.Click += new System.EventHandler(this.btn_storno_Click);
            // 
            // btn_upravit_zaznam
            // 
            this.btn_upravit_zaznam.BackColor = System.Drawing.Color.LightGreen;
            this.btn_upravit_zaznam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_upravit_zaznam.Location = new System.Drawing.Point(195, 262);
            this.btn_upravit_zaznam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_upravit_zaznam.Name = "btn_upravit_zaznam";
            this.btn_upravit_zaznam.Size = new System.Drawing.Size(120, 50);
            this.btn_upravit_zaznam.TabIndex = 44;
            this.btn_upravit_zaznam.Text = "Upravit pacienta";
            this.btn_upravit_zaznam.UseVisualStyleBackColor = false;
            this.btn_upravit_zaznam.Click += new System.EventHandler(this.btn_upravit_zaznam_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label5.Location = new System.Drawing.Point(29, 215);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(70, 17);
            this.Label5.TabIndex = 43;
            this.Label5.Text = "Bydliště:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label4.Location = new System.Drawing.Point(27, 177);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(127, 17);
            this.Label4.TabIndex = 42;
            this.Label4.Text = "Datum narození:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label3.Location = new System.Drawing.Point(27, 138);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 17);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Přijmení:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.Location = new System.Drawing.Point(27, 103);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 17);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "Jméno:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(27, 65);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(98, 17);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "Rodné číslo:";
            // 
            // txt_bydliste
            // 
            this.txt_bydliste.Location = new System.Drawing.Point(195, 215);
            this.txt_bydliste.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bydliste.Name = "txt_bydliste";
            this.txt_bydliste.Size = new System.Drawing.Size(132, 22);
            this.txt_bydliste.TabIndex = 38;
            // 
            // txt_datum_narozeni
            // 
            this.txt_datum_narozeni.Location = new System.Drawing.Point(195, 177);
            this.txt_datum_narozeni.Margin = new System.Windows.Forms.Padding(4);
            this.txt_datum_narozeni.Name = "txt_datum_narozeni";
            this.txt_datum_narozeni.Size = new System.Drawing.Size(132, 22);
            this.txt_datum_narozeni.TabIndex = 37;
            // 
            // txt_prijmeni
            // 
            this.txt_prijmeni.Location = new System.Drawing.Point(195, 138);
            this.txt_prijmeni.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prijmeni.Name = "txt_prijmeni";
            this.txt_prijmeni.Size = new System.Drawing.Size(132, 22);
            this.txt_prijmeni.TabIndex = 36;
            // 
            // txt_jmeno
            // 
            this.txt_jmeno.Location = new System.Drawing.Point(195, 103);
            this.txt_jmeno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jmeno.Name = "txt_jmeno";
            this.txt_jmeno.Size = new System.Drawing.Size(132, 22);
            this.txt_jmeno.TabIndex = 35;
            // 
            // mtxt_rodne_cislo
            // 
            this.mtxt_rodne_cislo.Location = new System.Drawing.Point(195, 65);
            this.mtxt_rodne_cislo.Mask = "000000\\/9999";
            this.mtxt_rodne_cislo.Name = "mtxt_rodne_cislo";
            this.mtxt_rodne_cislo.Size = new System.Drawing.Size(132, 22);
            this.mtxt_rodne_cislo.TabIndex = 48;
            // 
            // frm_upravit_pacienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 358);
            this.Controls.Add(this.mtxt_rodne_cislo);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.btn_storno);
            this.Controls.Add(this.btn_upravit_zaznam);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txt_bydliste);
            this.Controls.Add(this.txt_datum_narozeni);
            this.Controls.Add(this.txt_prijmeni);
            this.Controls.Add(this.txt_jmeno);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_upravit_pacienta";
            this.Text = "frm_upravit_pacienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txt_ID;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btn_storno;
        internal System.Windows.Forms.Button btn_upravit_zaznam;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_bydliste;
        internal System.Windows.Forms.TextBox txt_datum_narozeni;
        internal System.Windows.Forms.TextBox txt_prijmeni;
        internal System.Windows.Forms.TextBox txt_jmeno;
        internal System.Windows.Forms.MaskedTextBox mtxt_rodne_cislo;
    }
}