namespace InterfejsŚledzenia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.etykietaNaglowka = new System.Windows.Forms.Label();
            this.nazwaTurnieju = new System.Windows.Forms.Label();
            this.etykietaRundy = new System.Windows.Forms.Label();
            this.okragleMenuRozwijane = new System.Windows.Forms.ComboBox();
            this.tylkoNierozegraneCheckBox = new System.Windows.Forms.CheckBox();
            this.pojedynekListBox = new System.Windows.Forms.ListBox();
            this.nazwaTeamuPierwszego = new System.Windows.Forms.Label();
            this.wynikTeamuPierwszego = new System.Windows.Forms.Label();
            this.wartoscWynikuTeamuPierwszego = new System.Windows.Forms.TextBox();
            this.wartoscWynikuTeamuDrugiego = new System.Windows.Forms.TextBox();
            this.wynikTeamuDrugiego = new System.Windows.Forms.Label();
            this.nazwaTeamuDrugiego = new System.Windows.Forms.Label();
            this.etykietaVersus = new System.Windows.Forms.Label();
            this.przyciskWynik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etykietaNaglowka
            // 
            this.etykietaNaglowka.AutoSize = true;
            this.etykietaNaglowka.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.etykietaNaglowka.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.etykietaNaglowka.Location = new System.Drawing.Point(70, 16);
            this.etykietaNaglowka.Name = "etykietaNaglowka";
            this.etykietaNaglowka.Size = new System.Drawing.Size(131, 50);
            this.etykietaNaglowka.TabIndex = 0;
            this.etykietaNaglowka.Text = "Turniej:";
            // 
            // nazwaTurnieju
            // 
            this.nazwaTurnieju.AutoSize = true;
            this.nazwaTurnieju.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nazwaTurnieju.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nazwaTurnieju.Location = new System.Drawing.Point(231, 16);
            this.nazwaTurnieju.Name = "nazwaTurnieju";
            this.nazwaTurnieju.Size = new System.Drawing.Size(137, 50);
            this.nazwaTurnieju.TabIndex = 1;
            this.nazwaTurnieju.Text = "<brak>";
            this.nazwaTurnieju.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // etykietaRundy
            // 
            this.etykietaRundy.AutoSize = true;
            this.etykietaRundy.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.etykietaRundy.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.etykietaRundy.Location = new System.Drawing.Point(15, 88);
            this.etykietaRundy.Name = "etykietaRundy";
            this.etykietaRundy.Size = new System.Drawing.Size(99, 37);
            this.etykietaRundy.TabIndex = 2;
            this.etykietaRundy.Text = "Runda:";
            // 
            // okragleMenuRozwijane
            // 
            this.okragleMenuRozwijane.FormattingEnabled = true;
            this.okragleMenuRozwijane.Location = new System.Drawing.Point(152, 87);
            this.okragleMenuRozwijane.Name = "okragleMenuRozwijane";
            this.okragleMenuRozwijane.Size = new System.Drawing.Size(255, 38);
            this.okragleMenuRozwijane.TabIndex = 3;
            // 
            // tylkoNierozegraneCheckBox
            // 
            this.tylkoNierozegraneCheckBox.AutoSize = true;
            this.tylkoNierozegraneCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tylkoNierozegraneCheckBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tylkoNierozegraneCheckBox.Location = new System.Drawing.Point(152, 131);
            this.tylkoNierozegraneCheckBox.Name = "tylkoNierozegraneCheckBox";
            this.tylkoNierozegraneCheckBox.Size = new System.Drawing.Size(265, 41);
            this.tylkoNierozegraneCheckBox.TabIndex = 4;
            this.tylkoNierozegraneCheckBox.Text = "Tylko Nierozegrane";
            this.tylkoNierozegraneCheckBox.UseVisualStyleBackColor = true;
            // 
            // pojedynekListBox
            // 
            this.pojedynekListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pojedynekListBox.FormattingEnabled = true;
            this.pojedynekListBox.ItemHeight = 30;
            this.pojedynekListBox.Location = new System.Drawing.Point(16, 189);
            this.pojedynekListBox.Name = "pojedynekListBox";
            this.pojedynekListBox.Size = new System.Drawing.Size(392, 242);
            this.pojedynekListBox.TabIndex = 5;
            // 
            // nazwaTeamuPierwszego
            // 
            this.nazwaTeamuPierwszego.AutoSize = true;
            this.nazwaTeamuPierwszego.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nazwaTeamuPierwszego.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nazwaTeamuPierwszego.Location = new System.Drawing.Point(479, 145);
            this.nazwaTeamuPierwszego.Name = "nazwaTeamuPierwszego";
            this.nazwaTeamuPierwszego.Size = new System.Drawing.Size(127, 37);
            this.nazwaTeamuPierwszego.TabIndex = 6;
            this.nazwaTeamuPierwszego.Text = "<I team>";
            // 
            // wynikTeamuPierwszego
            // 
            this.wynikTeamuPierwszego.AutoSize = true;
            this.wynikTeamuPierwszego.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wynikTeamuPierwszego.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.wynikTeamuPierwszego.Location = new System.Drawing.Point(439, 210);
            this.wynikTeamuPierwszego.Name = "wynikTeamuPierwszego";
            this.wynikTeamuPierwszego.Size = new System.Drawing.Size(90, 37);
            this.wynikTeamuPierwszego.TabIndex = 7;
            this.wynikTeamuPierwszego.Text = "Wynik";
            // 
            // wartoscWynikuTeamuPierwszego
            // 
            this.wartoscWynikuTeamuPierwszego.Location = new System.Drawing.Point(535, 213);
            this.wartoscWynikuTeamuPierwszego.Name = "wartoscWynikuTeamuPierwszego";
            this.wartoscWynikuTeamuPierwszego.Size = new System.Drawing.Size(100, 35);
            this.wartoscWynikuTeamuPierwszego.TabIndex = 8;
            // 
            // wartoscWynikuTeamuDrugiego
            // 
            this.wartoscWynikuTeamuDrugiego.Location = new System.Drawing.Point(535, 391);
            this.wartoscWynikuTeamuDrugiego.Name = "wartoscWynikuTeamuDrugiego";
            this.wartoscWynikuTeamuDrugiego.Size = new System.Drawing.Size(100, 35);
            this.wartoscWynikuTeamuDrugiego.TabIndex = 11;
            // 
            // wynikTeamuDrugiego
            // 
            this.wynikTeamuDrugiego.AutoSize = true;
            this.wynikTeamuDrugiego.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wynikTeamuDrugiego.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.wynikTeamuDrugiego.Location = new System.Drawing.Point(439, 388);
            this.wynikTeamuDrugiego.Name = "wynikTeamuDrugiego";
            this.wynikTeamuDrugiego.Size = new System.Drawing.Size(90, 37);
            this.wynikTeamuDrugiego.TabIndex = 10;
            this.wynikTeamuDrugiego.Text = "Wynik";
            // 
            // nazwaTeamuDrugiego
            // 
            this.nazwaTeamuDrugiego.AutoSize = true;
            this.nazwaTeamuDrugiego.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nazwaTeamuDrugiego.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nazwaTeamuDrugiego.Location = new System.Drawing.Point(479, 323);
            this.nazwaTeamuDrugiego.Name = "nazwaTeamuDrugiego";
            this.nazwaTeamuDrugiego.Size = new System.Drawing.Size(134, 37);
            this.nazwaTeamuDrugiego.TabIndex = 9;
            this.nazwaTeamuDrugiego.Text = "<II team>";
            // 
            // etykietaVersus
            // 
            this.etykietaVersus.AutoSize = true;
            this.etykietaVersus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.etykietaVersus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.etykietaVersus.Location = new System.Drawing.Point(520, 272);
            this.etykietaVersus.Name = "etykietaVersus";
            this.etykietaVersus.Size = new System.Drawing.Size(70, 37);
            this.etykietaVersus.TabIndex = 12;
            this.etykietaVersus.Text = "-VS-";
            // 
            // przyciskWynik
            // 
            this.przyciskWynik.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.przyciskWynik.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.przyciskWynik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.przyciskWynik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.przyciskWynik.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.przyciskWynik.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.przyciskWynik.Location = new System.Drawing.Point(655, 285);
            this.przyciskWynik.Name = "przyciskWynik";
            this.przyciskWynik.Size = new System.Drawing.Size(114, 64);
            this.przyciskWynik.TabIndex = 13;
            this.przyciskWynik.Text = "Wynik";
            this.przyciskWynik.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 578);
            this.Controls.Add(this.przyciskWynik);
            this.Controls.Add(this.etykietaVersus);
            this.Controls.Add(this.wartoscWynikuTeamuDrugiego);
            this.Controls.Add(this.wynikTeamuDrugiego);
            this.Controls.Add(this.nazwaTeamuDrugiego);
            this.Controls.Add(this.wartoscWynikuTeamuPierwszego);
            this.Controls.Add(this.wynikTeamuPierwszego);
            this.Controls.Add(this.nazwaTeamuPierwszego);
            this.Controls.Add(this.pojedynekListBox);
            this.Controls.Add(this.tylkoNierozegraneCheckBox);
            this.Controls.Add(this.okragleMenuRozwijane);
            this.Controls.Add(this.etykietaRundy);
            this.Controls.Add(this.nazwaTurnieju);
            this.Controls.Add(this.etykietaNaglowka);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "PrzeglądarkaTurniejów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etykietaNaglowka;
        private System.Windows.Forms.Label nazwaTurnieju;
        private System.Windows.Forms.Label etykietaRundy;
        private System.Windows.Forms.ComboBox okragleMenuRozwijane;
        private System.Windows.Forms.CheckBox tylkoNierozegraneCheckBox;
        private System.Windows.Forms.ListBox pojedynekListBox;
        private System.Windows.Forms.Label nazwaTeamuPierwszego;
        private System.Windows.Forms.Label wynikTeamuPierwszego;
        private System.Windows.Forms.TextBox wartoscWynikuTeamuPierwszego;
        private System.Windows.Forms.TextBox wartoscWynikuTeamuDrugiego;
        private System.Windows.Forms.Label wynikTeamuDrugiego;
        private System.Windows.Forms.Label nazwaTeamuDrugiego;
        private System.Windows.Forms.Label etykietaVersus;
        private System.Windows.Forms.Button przyciskWynik;
    }
}
