namespace KostkaDoGry
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.Location = new System.Drawing.Point(240, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kostka do gry";
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ToClipboard);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(123, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wciśnij \"r\" aby uruchomić losowanie";
            this.label2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ToClipboard);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.wynik.ForeColor = System.Drawing.Color.Blue;
            this.wynik.Location = new System.Drawing.Point(190, 267);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(0, 46);
            this.wynik.TabIndex = 2;
            this.wynik.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ToClipboard);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wynik;
    }
}

