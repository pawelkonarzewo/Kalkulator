namespace Kalkulator
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
            this.TBerkan = new System.Windows.Forms.TextBox();
            this.bBsqrt = new System.Windows.Forms.Button();
            this.Bspace = new System.Windows.Forms.Button();
            this.Bdodawanie = new System.Windows.Forms.Button();
            this.Bodejmowanie = new System.Windows.Forms.Button();
            this.Bmnozenie = new System.Windows.Forms.Button();
            this.Bdzielenie = new System.Windows.Forms.Button();
            this.Bclear = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.Bzero = new System.Windows.Forms.Button();
            this.Bkropka = new System.Windows.Forms.Button();
            this.Bzmianaznaku = new System.Windows.Forms.Button();
            this.Bpotega = new System.Windows.Forms.Button();
            this.Bdata = new System.Windows.Forms.Button();
            this.Bmod = new System.Windows.Forms.Button();
            this.Bczas = new System.Windows.Forms.Button();
            this.Bwynik = new System.Windows.Forms.Button();
            this.TBekran2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBerkan
            // 
            this.TBerkan.Location = new System.Drawing.Point(9, 47);
            this.TBerkan.Name = "TBerkan";
            this.TBerkan.Size = new System.Drawing.Size(315, 20);
            this.TBerkan.TabIndex = 1;
            this.TBerkan.TextChanged += new System.EventHandler(this.TBerkan_TextChanged);
            // 
            // bBsqrt
            // 
            this.bBsqrt.Location = new System.Drawing.Point(237, 93);
            this.bBsqrt.Name = "bBsqrt";
            this.bBsqrt.Size = new System.Drawing.Size(90, 36);
            this.bBsqrt.TabIndex = 11;
            this.bBsqrt.Text = "SQRT";
            this.bBsqrt.UseVisualStyleBackColor = true;
            this.bBsqrt.Click += new System.EventHandler(this.bBsqrt_Click);
            // 
            // Bspace
            // 
            this.Bspace.Location = new System.Drawing.Point(55, 261);
            this.Bspace.Name = "Bspace";
            this.Bspace.Size = new System.Drawing.Size(80, 36);
            this.Bspace.TabIndex = 12;
            this.Bspace.Text = "SPACE";
            this.Bspace.UseVisualStyleBackColor = true;
            this.Bspace.Click += new System.EventHandler(this.Bspace_Click);
            // 
            // Bdodawanie
            // 
            this.Bdodawanie.Location = new System.Drawing.Point(194, 219);
            this.Bdodawanie.Name = "Bdodawanie";
            this.Bdodawanie.Size = new System.Drawing.Size(37, 36);
            this.Bdodawanie.TabIndex = 13;
            this.Bdodawanie.Text = "+";
            this.Bdodawanie.UseVisualStyleBackColor = true;
            this.Bdodawanie.Click += new System.EventHandler(this.Bdodawanie_Click);
            // 
            // Bodejmowanie
            // 
            this.Bodejmowanie.Location = new System.Drawing.Point(194, 177);
            this.Bodejmowanie.Name = "Bodejmowanie";
            this.Bodejmowanie.Size = new System.Drawing.Size(37, 36);
            this.Bodejmowanie.TabIndex = 14;
            this.Bodejmowanie.Text = "-";
            this.Bodejmowanie.UseVisualStyleBackColor = true;
            this.Bodejmowanie.Click += new System.EventHandler(this.Bodejmowanie_Click);
            // 
            // Bmnozenie
            // 
            this.Bmnozenie.Location = new System.Drawing.Point(194, 135);
            this.Bmnozenie.Name = "Bmnozenie";
            this.Bmnozenie.Size = new System.Drawing.Size(37, 36);
            this.Bmnozenie.TabIndex = 15;
            this.Bmnozenie.Text = "*";
            this.Bmnozenie.UseVisualStyleBackColor = true;
            this.Bmnozenie.Click += new System.EventHandler(this.Bmnozenie_Click);
            // 
            // Bdzielenie
            // 
            this.Bdzielenie.Location = new System.Drawing.Point(194, 93);
            this.Bdzielenie.Name = "Bdzielenie";
            this.Bdzielenie.Size = new System.Drawing.Size(37, 36);
            this.Bdzielenie.TabIndex = 16;
            this.Bdzielenie.Text = "/";
            this.Bdzielenie.UseVisualStyleBackColor = true;
            this.Bdzielenie.Click += new System.EventHandler(this.Bdzielenie_Click);
            // 
            // Bclear
            // 
            this.Bclear.Location = new System.Drawing.Point(12, 261);
            this.Bclear.Name = "Bclear";
            this.Bclear.Size = new System.Drawing.Size(37, 36);
            this.Bclear.TabIndex = 17;
            this.Bclear.Text = "C";
            this.Bclear.UseVisualStyleBackColor = true;
            this.Bclear.Click += new System.EventHandler(this.Bclear_Click);
            // 
            // B9
            // 
            this.B9.Location = new System.Drawing.Point(98, 93);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(37, 36);
            this.B9.TabIndex = 18;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // B8
            // 
            this.B8.Location = new System.Drawing.Point(55, 93);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(37, 36);
            this.B8.TabIndex = 19;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B7
            // 
            this.B7.Location = new System.Drawing.Point(12, 93);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(37, 36);
            this.B7.TabIndex = 20;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(12, 135);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(37, 36);
            this.B4.TabIndex = 23;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(55, 135);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(37, 36);
            this.B5.TabIndex = 22;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B6
            // 
            this.B6.Location = new System.Drawing.Point(98, 135);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(37, 36);
            this.B6.TabIndex = 21;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(12, 177);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(37, 36);
            this.B1.TabIndex = 26;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(55, 177);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(37, 36);
            this.B2.TabIndex = 25;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(98, 177);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(37, 36);
            this.B3.TabIndex = 24;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // Bzero
            // 
            this.Bzero.Location = new System.Drawing.Point(12, 219);
            this.Bzero.Name = "Bzero";
            this.Bzero.Size = new System.Drawing.Size(37, 36);
            this.Bzero.TabIndex = 29;
            this.Bzero.Text = "0";
            this.Bzero.UseVisualStyleBackColor = true;
            this.Bzero.Click += new System.EventHandler(this.Bzero_Click);
            // 
            // Bkropka
            // 
            this.Bkropka.Location = new System.Drawing.Point(55, 219);
            this.Bkropka.Name = "Bkropka";
            this.Bkropka.Size = new System.Drawing.Size(37, 36);
            this.Bkropka.TabIndex = 28;
            this.Bkropka.Text = ",";
            this.Bkropka.UseVisualStyleBackColor = true;
            this.Bkropka.Click += new System.EventHandler(this.Bkropka_Click);
            // 
            // Bzmianaznaku
            // 
            this.Bzmianaznaku.Location = new System.Drawing.Point(98, 219);
            this.Bzmianaznaku.Name = "Bzmianaznaku";
            this.Bzmianaznaku.Size = new System.Drawing.Size(37, 36);
            this.Bzmianaznaku.TabIndex = 27;
            this.Bzmianaznaku.Text = "neg";
            this.Bzmianaznaku.UseVisualStyleBackColor = true;
            this.Bzmianaznaku.Click += new System.EventHandler(this.Bzmianaznaku_Click);
            // 
            // Bpotega
            // 
            this.Bpotega.Location = new System.Drawing.Point(237, 135);
            this.Bpotega.Name = "Bpotega";
            this.Bpotega.Size = new System.Drawing.Size(90, 36);
            this.Bpotega.TabIndex = 30;
            this.Bpotega.Text = "POTĘGA";
            this.Bpotega.UseVisualStyleBackColor = true;
            this.Bpotega.Click += new System.EventHandler(this.Bpotega_Click);
            // 
            // Bdata
            // 
            this.Bdata.Location = new System.Drawing.Point(237, 219);
            this.Bdata.Name = "Bdata";
            this.Bdata.Size = new System.Drawing.Size(90, 36);
            this.Bdata.TabIndex = 32;
            this.Bdata.Text = "DATA";
            this.Bdata.UseVisualStyleBackColor = true;
            this.Bdata.Click += new System.EventHandler(this.Bdata_Click);
            // 
            // Bmod
            // 
            this.Bmod.Location = new System.Drawing.Point(237, 177);
            this.Bmod.Name = "Bmod";
            this.Bmod.Size = new System.Drawing.Size(90, 36);
            this.Bmod.TabIndex = 31;
            this.Bmod.Text = "MOD";
            this.Bmod.UseVisualStyleBackColor = true;
            this.Bmod.Click += new System.EventHandler(this.Bmod_Click);
            // 
            // Bczas
            // 
            this.Bczas.Location = new System.Drawing.Point(237, 261);
            this.Bczas.Name = "Bczas";
            this.Bczas.Size = new System.Drawing.Size(90, 36);
            this.Bczas.TabIndex = 33;
            this.Bczas.Text = "CZAS";
            this.Bczas.UseVisualStyleBackColor = true;
            this.Bczas.Click += new System.EventHandler(this.Bczas_Click);
            // 
            // Bwynik
            // 
            this.Bwynik.Location = new System.Drawing.Point(141, 261);
            this.Bwynik.Name = "Bwynik";
            this.Bwynik.Size = new System.Drawing.Size(80, 36);
            this.Bwynik.TabIndex = 34;
            this.Bwynik.Text = "WYNIK";
            this.Bwynik.UseVisualStyleBackColor = true;
            this.Bwynik.Click += new System.EventHandler(this.Bwynik_Click);
            // 
            // TBekran2
            // 
            this.TBekran2.Location = new System.Drawing.Point(12, 303);
            this.TBekran2.Name = "TBekran2";
            this.TBekran2.Size = new System.Drawing.Size(315, 20);
            this.TBekran2.TabIndex = 35;
            this.TBekran2.TextChanged += new System.EventHandler(this.TBekran2_TextChanged);
            this.TBekran2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBekran2_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 347);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TBekran2);
            this.Controls.Add(this.Bwynik);
            this.Controls.Add(this.Bczas);
            this.Controls.Add(this.Bdata);
            this.Controls.Add(this.Bmod);
            this.Controls.Add(this.Bpotega);
            this.Controls.Add(this.Bzero);
            this.Controls.Add(this.Bkropka);
            this.Controls.Add(this.Bzmianaznaku);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.Bclear);
            this.Controls.Add(this.Bdzielenie);
            this.Controls.Add(this.Bmnozenie);
            this.Controls.Add(this.Bodejmowanie);
            this.Controls.Add(this.Bdodawanie);
            this.Controls.Add(this.Bspace);
            this.Controls.Add(this.bBsqrt);
            this.Controls.Add(this.TBerkan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator RPN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBerkan;
        private System.Windows.Forms.Button bBsqrt;
        private System.Windows.Forms.Button Bspace;
        private System.Windows.Forms.Button Bdodawanie;
        private System.Windows.Forms.Button Bodejmowanie;
        private System.Windows.Forms.Button Bmnozenie;
        private System.Windows.Forms.Button Bdzielenie;
        private System.Windows.Forms.Button Bclear;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button Bzero;
        private System.Windows.Forms.Button Bkropka;
        private System.Windows.Forms.Button Bzmianaznaku;
        private System.Windows.Forms.Button Bpotega;
        private System.Windows.Forms.Button Bdata;
        private System.Windows.Forms.Button Bmod;
        private System.Windows.Forms.Button Bczas;
        private System.Windows.Forms.Button Bwynik;
        private System.Windows.Forms.TextBox TBekran2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
    }
}

