namespace kartoteka
{
    partial class frm_kontrola
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
            this.btn_podle_data = new System.Windows.Forms.Button();
            this.btn_podle_jmena = new System.Windows.Forms.Button();
            this.btn_zavrit = new System.Windows.Forms.Button();
            frm_kontrola.lv_kontrola = new System.Windows.Forms.ListView();
            this.pacient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kontrola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_podle_data
            // 
            this.btn_podle_data.BackColor = System.Drawing.Color.Tan;
            this.btn_podle_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_podle_data.Location = new System.Drawing.Point(428, 92);
            this.btn_podle_data.Margin = new System.Windows.Forms.Padding(4);
            this.btn_podle_data.Name = "btn_podle_data";
            this.btn_podle_data.Size = new System.Drawing.Size(120, 50);
            this.btn_podle_data.TabIndex = 38;
            this.btn_podle_data.Text = "seřadit podle data";
            this.btn_podle_data.UseVisualStyleBackColor = false;
            this.btn_podle_data.Click += new System.EventHandler(this.btn_podle_data_Click);
            // 
            // btn_podle_jmena
            // 
            this.btn_podle_jmena.BackColor = System.Drawing.Color.Tan;
            this.btn_podle_jmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_podle_jmena.Location = new System.Drawing.Point(428, 22);
            this.btn_podle_jmena.Margin = new System.Windows.Forms.Padding(4);
            this.btn_podle_jmena.Name = "btn_podle_jmena";
            this.btn_podle_jmena.Size = new System.Drawing.Size(120, 50);
            this.btn_podle_jmena.TabIndex = 37;
            this.btn_podle_jmena.Text = "seřadit podle jména";
            this.btn_podle_jmena.UseVisualStyleBackColor = false;
            this.btn_podle_jmena.Click += new System.EventHandler(this.btn_podle_jmena_Click);
            // 
            // btn_zavrit
            // 
            this.btn_zavrit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_zavrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_zavrit.Location = new System.Drawing.Point(428, 167);
            this.btn_zavrit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_zavrit.Name = "btn_zavrit";
            this.btn_zavrit.Size = new System.Drawing.Size(120, 50);
            this.btn_zavrit.TabIndex = 36;
            this.btn_zavrit.Text = "ZAVŘÍT";
            this.btn_zavrit.UseVisualStyleBackColor = false;
            this.btn_zavrit.Click += new System.EventHandler(this.btn_zavrit_Click);
            // 
            // lv_kontrola
            // 
            frm_kontrola.lv_kontrola.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pacient,
            this.Kontrola});
            frm_kontrola.lv_kontrola.FullRowSelect = true;
            frm_kontrola.lv_kontrola.GridLines = true;
            frm_kontrola.lv_kontrola.Location = new System.Drawing.Point(13, 13);
            frm_kontrola.lv_kontrola.Margin = new System.Windows.Forms.Padding(4);
            frm_kontrola.lv_kontrola.Name = "lv_kontrola";
            frm_kontrola.lv_kontrola.Size = new System.Drawing.Size(400, 400);
            frm_kontrola.lv_kontrola.TabIndex = 23;
            frm_kontrola.lv_kontrola.UseCompatibleStateImageBehavior = false;
            frm_kontrola.lv_kontrola.View = System.Windows.Forms.View.Details;
            // 
            // pacient
            // 
            this.pacient.Text = "Pacient";
            this.pacient.Width = 131;
            // 
            // Kontrola
            // 
            this.Kontrola.Text = "Kontrola";
            this.Kontrola.Width = 236;
            // 
            // frm_kontrola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 460);
            this.Controls.Add(this.btn_podle_data);
            this.Controls.Add(this.btn_podle_jmena);
            this.Controls.Add(this.btn_zavrit);
            this.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(frm_kontrola.lv_kontrola);
            this.Name = "frm_kontrola";
            this.Text = "frm_kontrola";
            this.ResumeLayout(false);
            this.MaximizeBox = false;

        }

        #endregion

        internal System.Windows.Forms.Button btn_podle_data;
        internal System.Windows.Forms.Button btn_podle_jmena;
        internal System.Windows.Forms.Button btn_zavrit;
        static internal System.Windows.Forms.ListView lv_kontrola;
        internal System.Windows.Forms.ColumnHeader pacient;
        internal System.Windows.Forms.ColumnHeader Kontrola;
    }
}