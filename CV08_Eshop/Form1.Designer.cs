namespace CV08_eshop
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox_SKLAD = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ListBox_KOSIK = new System.Windows.Forms.ListBox();
            this.ListBox_UZIVATELE = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox_SKLAD
            // 
            this.ListBox_SKLAD.FormattingEnabled = true;
            this.ListBox_SKLAD.Location = new System.Drawing.Point(51, 38);
            this.ListBox_SKLAD.Name = "ListBox_SKLAD";
            this.ListBox_SKLAD.Size = new System.Drawing.Size(330, 303);
            this.ListBox_SKLAD.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "<---";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Vrat_Na_Sklad);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 283);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "--->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Dej_Do_Kosiku);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Přidej uživatele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Pridani_noveho_uzivatele);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(539, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 25);
            this.button4.TabIndex = 4;
            this.button4.Text = "Suma košíku";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Suma);
            // 
            // ListBox_KOSIK
            // 
            this.ListBox_KOSIK.FormattingEnabled = true;
            this.ListBox_KOSIK.Location = new System.Drawing.Point(539, 207);
            this.ListBox_KOSIK.Name = "ListBox_KOSIK";
            this.ListBox_KOSIK.Size = new System.Drawing.Size(212, 134);
            this.ListBox_KOSIK.TabIndex = 5;
            // 
            // ListBox_UZIVATELE
            // 
            this.ListBox_UZIVATELE.FormattingEnabled = true;
            this.ListBox_UZIVATELE.Location = new System.Drawing.Point(539, 38);
            this.ListBox_UZIVATELE.Name = "ListBox_UZIVATELE";
            this.ListBox_UZIVATELE.Size = new System.Drawing.Size(212, 134);
            this.ListBox_UZIVATELE.TabIndex = 6;
            this.ListBox_UZIVATELE.Click += new System.EventHandler(this.ListBox_UZIVATELE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "SKLAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "UŽIVATELE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "KOŠÍK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox_UZIVATELE);
            this.Controls.Add(this.ListBox_KOSIK);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListBox_SKLAD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_SKLAD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox ListBox_KOSIK;
        private System.Windows.Forms.ListBox ListBox_UZIVATELE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

