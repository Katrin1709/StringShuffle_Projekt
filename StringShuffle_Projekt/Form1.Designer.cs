namespace StringShuffle_Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnEntfernen = new System.Windows.Forms.Button();
            this.btnAlleEntfernen = new System.Windows.Forms.Button();
            this.btnSortieren = new System.Windows.Forms.Button();
            this.btnVermischen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(544, 415);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nummer";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 400;
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(603, 34);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(191, 47);
            this.btnHinzufügen.TabIndex = 1;
            this.btnHinzufügen.Text = "Eintrag hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(603, 94);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(191, 47);
            this.btnBearbeiten.TabIndex = 2;
            this.btnBearbeiten.Text = "Eintrag bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // btnEntfernen
            // 
            this.btnEntfernen.Location = new System.Drawing.Point(603, 154);
            this.btnEntfernen.Name = "btnEntfernen";
            this.btnEntfernen.Size = new System.Drawing.Size(191, 47);
            this.btnEntfernen.TabIndex = 3;
            this.btnEntfernen.Text = "Eintrag entfernen";
            this.btnEntfernen.UseVisualStyleBackColor = true;
            this.btnEntfernen.Click += new System.EventHandler(this.btnEntfernen_Click);
            // 
            // btnAlleEntfernen
            // 
            this.btnAlleEntfernen.Location = new System.Drawing.Point(603, 214);
            this.btnAlleEntfernen.Name = "btnAlleEntfernen";
            this.btnAlleEntfernen.Size = new System.Drawing.Size(191, 47);
            this.btnAlleEntfernen.TabIndex = 4;
            this.btnAlleEntfernen.Text = "Alle Einträge entfernen";
            this.btnAlleEntfernen.UseVisualStyleBackColor = true;
            this.btnAlleEntfernen.Click += new System.EventHandler(this.btnAlleEntfernen_Click);
            // 
            // btnSortieren
            // 
            this.btnSortieren.Location = new System.Drawing.Point(603, 326);
            this.btnSortieren.Name = "btnSortieren";
            this.btnSortieren.Size = new System.Drawing.Size(191, 47);
            this.btnSortieren.TabIndex = 5;
            this.btnSortieren.Text = "Alle Einträge sortieren";
            this.btnSortieren.UseVisualStyleBackColor = true;
            this.btnSortieren.Click += new System.EventHandler(this.btnSortieren_Click);
            // 
            // btnVermischen
            // 
            this.btnVermischen.Location = new System.Drawing.Point(603, 379);
            this.btnVermischen.Name = "btnVermischen";
            this.btnVermischen.Size = new System.Drawing.Size(191, 47);
            this.btnVermischen.TabIndex = 6;
            this.btnVermischen.Text = "Alle Einträge vermischen";
            this.btnVermischen.UseVisualStyleBackColor = true;
            this.btnVermischen.Click += new System.EventHandler(this.btnVermischen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 457);
            this.Controls.Add(this.btnVermischen);
            this.Controls.Add(this.btnSortieren);
            this.Controls.Add(this.btnAlleEntfernen);
            this.Controls.Add(this.btnEntfernen);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnEntfernen;
        private System.Windows.Forms.Button btnAlleEntfernen;
        private System.Windows.Forms.Button btnSortieren;
        private System.Windows.Forms.Button btnVermischen;
        internal System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

