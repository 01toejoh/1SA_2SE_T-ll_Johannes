namespace Aufgabe1
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
            this.cmb_Marke = new System.Windows.Forms.ComboBox();
            this.cmb_Farbe = new System.Windows.Forms.ComboBox();
            this.txt_PS = new System.Windows.Forms.TextBox();
            this.txt_Tankgröße = new System.Windows.Forms.TextBox();
            this.txt_Verbrauch = new System.Windows.Forms.TextBox();
            this.btm_erstellen = new System.Windows.Forms.Button();
            this.rtxt_Ausgabe = new System.Windows.Forms.RichTextBox();
            this.txt_Tanken = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_Marke = new System.Windows.Forms.Label();
            this.lbl_Farbe = new System.Windows.Forms.Label();
            this.lbl_PS = new System.Windows.Forms.Label();
            this.lbl_Tankgröße = new System.Windows.Forms.Label();
            this.lbl_Verbrauch = new System.Windows.Forms.Label();
            this.lbl_Tanken = new System.Windows.Forms.Label();
            this.txt_Fahren = new System.Windows.Forms.TextBox();
            this.lbl_Fahren = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Marke
            // 
            this.cmb_Marke.FormattingEnabled = true;
            this.cmb_Marke.Items.AddRange(new object[] {
            "BMW",
            "Porsche",
            "Ferrari",
            "VW",
            "Audi"});
            this.cmb_Marke.Location = new System.Drawing.Point(12, 66);
            this.cmb_Marke.Name = "cmb_Marke";
            this.cmb_Marke.Size = new System.Drawing.Size(121, 21);
            this.cmb_Marke.TabIndex = 0;
            // 
            // cmb_Farbe
            // 
            this.cmb_Farbe.FormattingEnabled = true;
            this.cmb_Farbe.Items.AddRange(new object[] {
            "Braun",
            "Rot",
            "Weiß",
            "Schwarz",
            "Grün",
            "Blau",
            "Gelb",
            "Grau"});
            this.cmb_Farbe.Location = new System.Drawing.Point(12, 115);
            this.cmb_Farbe.Name = "cmb_Farbe";
            this.cmb_Farbe.Size = new System.Drawing.Size(121, 21);
            this.cmb_Farbe.TabIndex = 1;
            // 
            // txt_PS
            // 
            this.txt_PS.Location = new System.Drawing.Point(12, 172);
            this.txt_PS.Name = "txt_PS";
            this.txt_PS.Size = new System.Drawing.Size(121, 20);
            this.txt_PS.TabIndex = 5;
            // 
            // txt_Tankgröße
            // 
            this.txt_Tankgröße.Location = new System.Drawing.Point(139, 66);
            this.txt_Tankgröße.Name = "txt_Tankgröße";
            this.txt_Tankgröße.Size = new System.Drawing.Size(121, 20);
            this.txt_Tankgröße.TabIndex = 6;
            // 
            // txt_Verbrauch
            // 
            this.txt_Verbrauch.Location = new System.Drawing.Point(139, 115);
            this.txt_Verbrauch.Name = "txt_Verbrauch";
            this.txt_Verbrauch.Size = new System.Drawing.Size(121, 20);
            this.txt_Verbrauch.TabIndex = 7;
            // 
            // btm_erstellen
            // 
            this.btm_erstellen.Location = new System.Drawing.Point(139, 169);
            this.btm_erstellen.Name = "btm_erstellen";
            this.btm_erstellen.Size = new System.Drawing.Size(121, 23);
            this.btm_erstellen.TabIndex = 8;
            this.btm_erstellen.Text = "Auto erstellen";
            this.btm_erstellen.UseVisualStyleBackColor = true;
            this.btm_erstellen.Click += new System.EventHandler(this.btm_erstellen_Click);
            // 
            // rtxt_Ausgabe
            // 
            this.rtxt_Ausgabe.Location = new System.Drawing.Point(139, 213);
            this.rtxt_Ausgabe.Name = "rtxt_Ausgabe";
            this.rtxt_Ausgabe.Size = new System.Drawing.Size(121, 107);
            this.rtxt_Ausgabe.TabIndex = 9;
            this.rtxt_Ausgabe.Text = "";
            // 
            // txt_Tanken
            // 
            this.txt_Tanken.Location = new System.Drawing.Point(12, 225);
            this.txt_Tanken.Name = "txt_Tanken";
            this.txt_Tanken.Size = new System.Drawing.Size(100, 20);
            this.txt_Tanken.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 251);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // lbl_Marke
            // 
            this.lbl_Marke.AutoSize = true;
            this.lbl_Marke.Location = new System.Drawing.Point(32, 32);
            this.lbl_Marke.Name = "lbl_Marke";
            this.lbl_Marke.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marke.TabIndex = 12;
            this.lbl_Marke.Text = "Marke";
            // 
            // lbl_Farbe
            // 
            this.lbl_Farbe.AutoSize = true;
            this.lbl_Farbe.Location = new System.Drawing.Point(33, 94);
            this.lbl_Farbe.Name = "lbl_Farbe";
            this.lbl_Farbe.Size = new System.Drawing.Size(34, 13);
            this.lbl_Farbe.TabIndex = 13;
            this.lbl_Farbe.Text = "Farbe";
            // 
            // lbl_PS
            // 
            this.lbl_PS.AutoSize = true;
            this.lbl_PS.Location = new System.Drawing.Point(55, 151);
            this.lbl_PS.Name = "lbl_PS";
            this.lbl_PS.Size = new System.Drawing.Size(21, 13);
            this.lbl_PS.TabIndex = 14;
            this.lbl_PS.Text = "PS";
            // 
            // lbl_Tankgröße
            // 
            this.lbl_Tankgröße.AutoSize = true;
            this.lbl_Tankgröße.Location = new System.Drawing.Point(171, 38);
            this.lbl_Tankgröße.Name = "lbl_Tankgröße";
            this.lbl_Tankgröße.Size = new System.Drawing.Size(59, 13);
            this.lbl_Tankgröße.TabIndex = 15;
            this.lbl_Tankgröße.Text = "Tankgröße";
            // 
            // lbl_Verbrauch
            // 
            this.lbl_Verbrauch.AutoSize = true;
            this.lbl_Verbrauch.Location = new System.Drawing.Point(171, 94);
            this.lbl_Verbrauch.Name = "lbl_Verbrauch";
            this.lbl_Verbrauch.Size = new System.Drawing.Size(56, 13);
            this.lbl_Verbrauch.TabIndex = 16;
            this.lbl_Verbrauch.Text = "Verbrauch";
            // 
            // lbl_Tanken
            // 
            this.lbl_Tanken.AutoSize = true;
            this.lbl_Tanken.Location = new System.Drawing.Point(42, 208);
            this.lbl_Tanken.Name = "lbl_Tanken";
            this.lbl_Tanken.Size = new System.Drawing.Size(44, 13);
            this.lbl_Tanken.TabIndex = 17;
            this.lbl_Tanken.Text = "Tanken";
            // 
            // txt_Fahren
            // 
            this.txt_Fahren.Location = new System.Drawing.Point(12, 300);
            this.txt_Fahren.Name = "txt_Fahren";
            this.txt_Fahren.Size = new System.Drawing.Size(100, 20);
            this.txt_Fahren.TabIndex = 18;
            // 
            // lbl_Fahren
            // 
            this.lbl_Fahren.AutoSize = true;
            this.lbl_Fahren.Location = new System.Drawing.Point(42, 277);
            this.lbl_Fahren.Name = "lbl_Fahren";
            this.lbl_Fahren.Size = new System.Drawing.Size(40, 13);
            this.lbl_Fahren.TabIndex = 19;
            this.lbl_Fahren.Text = "Fahren";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 375);
            this.Controls.Add(this.lbl_Fahren);
            this.Controls.Add(this.txt_Fahren);
            this.Controls.Add(this.lbl_Tanken);
            this.Controls.Add(this.lbl_Verbrauch);
            this.Controls.Add(this.lbl_Tankgröße);
            this.Controls.Add(this.lbl_PS);
            this.Controls.Add(this.lbl_Farbe);
            this.Controls.Add(this.lbl_Marke);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txt_Tanken);
            this.Controls.Add(this.rtxt_Ausgabe);
            this.Controls.Add(this.btm_erstellen);
            this.Controls.Add(this.txt_Verbrauch);
            this.Controls.Add(this.txt_Tankgröße);
            this.Controls.Add(this.txt_PS);
            this.Controls.Add(this.cmb_Farbe);
            this.Controls.Add(this.cmb_Marke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Marke;
        private System.Windows.Forms.ComboBox cmb_Farbe;
        private System.Windows.Forms.TextBox txt_PS;
        private System.Windows.Forms.TextBox txt_Tankgröße;
        private System.Windows.Forms.TextBox txt_Verbrauch;
        private System.Windows.Forms.Button btm_erstellen;
        private System.Windows.Forms.RichTextBox rtxt_Ausgabe;
        private System.Windows.Forms.TextBox txt_Tanken;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_Marke;
        private System.Windows.Forms.Label lbl_Farbe;
        private System.Windows.Forms.Label lbl_PS;
        private System.Windows.Forms.Label lbl_Tankgröße;
        private System.Windows.Forms.Label lbl_Verbrauch;
        private System.Windows.Forms.Label lbl_Tanken;
        private System.Windows.Forms.TextBox txt_Fahren;
        private System.Windows.Forms.Label lbl_Fahren;
    }
}

