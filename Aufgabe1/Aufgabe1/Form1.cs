//Aufgabe2 Töll Johannes 3BEL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aufgabe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_erstellen_Click(object sender, EventArgs e)
        {
            Marke();
            Farbe();
            rtxt_Ausgabe.Text += txt_PS.Text = txt_PS.Text + "\n";
            rtxt_Ausgabe.Text += txt_Tankgröße.Text + "\n";
            rtxt_Ausgabe.Text += txt_Verbrauch.Text + "\n";
        }


            public void Marke()
            {
                
                if (cmb_Marke.Text == "BMW")
                {
                    rtxt_Ausgabe.Text += "BMW \n";
                }
                else if (cmb_Marke.Text == "Porsche")
                {
                    rtxt_Ausgabe.Text += "Porsche \n";
                }
                else if (cmb_Marke.Text == "Ferrari")
                {
                    rtxt_Ausgabe.Text += "Ferrari \n";
                }
                else if (cmb_Marke.Text == "VW")
                {
                    rtxt_Ausgabe.Text += "VW \n";
                }
                else if (cmb_Marke.Text == "Audi")
                {
                    rtxt_Ausgabe.Text += "Audi \n";
                }
                
            }
            public void Farbe()
            {
                if (cmb_Farbe.Text == "Braun")
                {
                    rtxt_Ausgabe.Text += "Braun \n";
                }
                else if (cmb_Farbe.Text == "Rot")
                {
                    rtxt_Ausgabe.Text += "Rot \n";
                }
                else if (cmb_Farbe.Text == "Weiß")
                {
                    rtxt_Ausgabe.Text += "Weiß \n";
                }
                else if (cmb_Farbe.Text == "Schwarz")
                {
                    rtxt_Ausgabe.Text += "Schwarz \n";
                }
                else if (cmb_Farbe.Text == "Grün")
                {
                    rtxt_Ausgabe.Text += "Grün \n";
                }
                else if (cmb_Farbe.Text == "Blau")
                {
                    rtxt_Ausgabe.Text += "Blau \n";
                }
                else if (cmb_Farbe.Text == "Gelb")
                {
                    rtxt_Ausgabe.Text += "Gelb \n";
                }
                else if (cmb_Farbe.Text == "Grau")
                {
                    rtxt_Ausgabe.Text += "Grau \n";
                }
                
                
            }
        
    }
    
       
    
}
