namespace kartoteka
{
    partial class frm_prihlaseni
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
            this.btn_storno = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_heslo = new System.Windows.Forms.TextBox();
            this.btn_prihlasit = new System.Windows.Forms.Button();
            this.txt_jmeno = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_storno
            // 
            this.btn_storno.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_storno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_storno.Location = new System.Drawing.Point(188, 114);
            this.btn_storno.Margin = new System.Windows.Forms.Padding(4);
            this.btn_storno.Name = "btn_storno";
            this.btn_storno.Size = new System.Drawing.Size(92, 34);
            this.btn_storno.TabIndex = 10;
            this.btn_storno.Text = "Storno";
            this.btn_storno.UseVisualStyleBackColor = false;
            this.btn_storno.Click += new System.EventHandler(this.btn_storno_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(28, 73);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Heslo";
            // 
            // txt_heslo
            // 
            this.txt_heslo.Location = new System.Drawing.Point(167, 68);
            this.txt_heslo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_heslo.Name = "txt_heslo";
            this.txt_heslo.PasswordChar = '*';
            this.txt_heslo.Size = new System.Drawing.Size(132, 22);
            this.txt_heslo.TabIndex = 8;
            this.txt_heslo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_heslo_KeyDown);
            // 
            // btn_prihlasit
            // 
            this.btn_prihlasit.BackColor = System.Drawing.Color.LightGreen;
            this.btn_prihlasit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_prihlasit.Location = new System.Drawing.Point(68, 114);
            this.btn_prihlasit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_prihlasit.Name = "btn_prihlasit";
            this.btn_prihlasit.Size = new System.Drawing.Size(91, 34);
            this.btn_prihlasit.TabIndex = 9;
            this.btn_prihlasit.Text = "Přihlásit";
            this.btn_prihlasit.UseVisualStyleBackColor = false;
            this.btn_prihlasit.Click += new System.EventHandler(this.btn_prihlasit_Click);
            // 
            // txt_jmeno
            // 
            this.txt_jmeno.Location = new System.Drawing.Point(167, 28);
            this.txt_jmeno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jmeno.Name = "txt_jmeno";
            this.txt_jmeno.Size = new System.Drawing.Size(132, 22);
            this.txt_jmeno.TabIndex = 7;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(28, 31);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(126, 17);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Přihlašovací jméno";
            // 
            // frm_prihlaseni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 202);
            this.Controls.Add(this.btn_storno);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_heslo);
            this.Controls.Add(this.btn_prihlasit);
            this.Controls.Add(this.txt_jmeno);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_prihlaseni";
            this.Text = "frm_prihlaseni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_storno;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_heslo;
        internal System.Windows.Forms.Button btn_prihlasit;
        internal System.Windows.Forms.TextBox txt_jmeno;
        internal System.Windows.Forms.Label Label1;
    }
}