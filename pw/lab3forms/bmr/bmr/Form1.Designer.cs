namespace bmr
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.Label();
            this.waga = new System.Windows.Forms.TextBox();
            this.wzrost = new System.Windows.Forms.TextBox();
            this.wiek = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.RadioButton();
            this.k = new System.Windows.Forms.RadioButton();
            this.plec = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.plec.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(334, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waga [kg]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wzrost [cm]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wiek [lata]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Płeć";
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.wynik.Location = new System.Drawing.Point(109, 317);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(0, 31);
            this.wynik.TabIndex = 5;
            this.wynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waga
            // 
            this.waga.Location = new System.Drawing.Point(203, 129);
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(100, 20);
            this.waga.TabIndex = 6;
            // 
            // wzrost
            // 
            this.wzrost.Location = new System.Drawing.Point(203, 162);
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(100, 20);
            this.wzrost.TabIndex = 7;
            // 
            // wiek
            // 
            this.wiek.Location = new System.Drawing.Point(203, 196);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(100, 20);
            this.wiek.TabIndex = 8;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(3, 3);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(77, 17);
            this.m.TabIndex = 9;
            this.m.TabStop = true;
            this.m.Text = "mężczyzna";
            this.m.UseVisualStyleBackColor = true;
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.k.Location = new System.Drawing.Point(86, 3);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(60, 17);
            this.k.TabIndex = 10;
            this.k.TabStop = true;
            this.k.Text = "kobieta";
            this.k.UseVisualStyleBackColor = true;
            // 
            // plec
            // 
            this.plec.Controls.Add(this.k);
            this.plec.Controls.Add(this.m);
            this.plec.Location = new System.Drawing.Point(179, 230);
            this.plec.Name = "plec";
            this.plec.Size = new System.Drawing.Size(143, 24);
            this.plec.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(493, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(511, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Wyczyść";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plec);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.wzrost);
            this.Controls.Add(this.waga);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.plec.ResumeLayout(false);
            this.plec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.TextBox waga;
        private System.Windows.Forms.TextBox wzrost;
        private System.Windows.Forms.TextBox wiek;
        private System.Windows.Forms.RadioButton m;
        private System.Windows.Forms.RadioButton k;
        private System.Windows.Forms.Panel plec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

