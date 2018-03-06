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
            this.cmb_Marke.Location = new System.Drawing.Point(12, 12);
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
            this.cmb_Farbe.Location = new System.Drawing.Point(12, 39);
            this.cmb_Farbe.Name = "cmb_Farbe";
            this.cmb_Farbe.Size = new System.Drawing.Size(121, 21);
            this.cmb_Farbe.TabIndex = 1;
            // 
            // txt_PS
            // 
            this.txt_PS.Location = new System.Drawing.Point(12, 66);
            this.txt_PS.Name = "txt_PS";
            this.txt_PS.Size = new System.Drawing.Size(121, 20);
            this.txt_PS.TabIndex = 5;
            // 
            // txt_Tankgröße
            // 
            this.txt_Tankgröße.Location = new System.Drawing.Point(139, 12);
            this.txt_Tankgröße.Name = "txt_Tankgröße";
            this.txt_Tankgröße.Size = new System.Drawing.Size(121, 20);
            this.txt_Tankgröße.TabIndex = 6;
            // 
            // txt_Verbrauch
            // 
            this.txt_Verbrauch.Location = new System.Drawing.Point(139, 38);
            this.txt_Verbrauch.Name = "txt_Verbrauch";
            this.txt_Verbrauch.Size = new System.Drawing.Size(121, 20);
            this.txt_Verbrauch.TabIndex = 7;
            // 
            // btm_erstellen
            // 
            this.btm_erstellen.Location = new System.Drawing.Point(139, 103);
            this.btm_erstellen.Name = "btm_erstellen";
            this.btm_erstellen.Size = new System.Drawing.Size(121, 23);
            this.btm_erstellen.TabIndex = 8;
            this.btm_erstellen.Text = "Auto erstellen";
            this.btm_erstellen.UseVisualStyleBackColor = true;
            this.btm_erstellen.Click += new System.EventHandler(this.btm_erstellen_Click);
            // 
            // rtxt_Ausgabe
            // 
            this.rtxt_Ausgabe.Location = new System.Drawing.Point(139, 132);
            this.rtxt_Ausgabe.Name = "rtxt_Ausgabe";
            this.rtxt_Ausgabe.Size = new System.Drawing.Size(121, 107);
            this.rtxt_Ausgabe.TabIndex = 9;
            this.rtxt_Ausgabe.Text = "";
            // 
            // txt_Tanken
            // 
            this.txt_Tanken.Location = new System.Drawing.Point(12, 148);
            this.txt_Tanken.Name = "txt_Tanken";
            this.txt_Tanken.Size = new System.Drawing.Size(100, 20);
            this.txt_Tanken.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
    }
}

