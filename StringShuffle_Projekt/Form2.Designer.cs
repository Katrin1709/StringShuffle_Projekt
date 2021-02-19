namespace StringShuffle_Projekt
{
    partial class Form2
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
            this.txtEintrag = new System.Windows.Forms.TextBox();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEintrag
            // 
            this.txtEintrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEintrag.Location = new System.Drawing.Point(38, 34);
            this.txtEintrag.Name = "txtEintrag";
            this.txtEintrag.Size = new System.Drawing.Size(605, 27);
            this.txtEintrag.TabIndex = 0;
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(188, 80);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(129, 37);
            this.btnAbbrechen.TabIndex = 1;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(337, 80);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(129, 37);
            this.btnSpeichern.TabIndex = 2;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 138);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.txtEintrag);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEintrag;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnSpeichern;
    }
}