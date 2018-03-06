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
            //Auto Neuauto = new Auto();
            Marke();
        }


            public void Marke()
            {
                
                if (cmb_Marke.Text == "BMW")
                {
                    rtxt_Ausgabe.Text = "BMW";
                }
                else if (cmb_Marke.Text == "Porsche")
                {
                    rtxt_Ausgabe.Text = "Porsche";
                }
                else if (cmb_Marke.Text == "Ferrari")
                {
                    rtxt_Ausgabe.Text = "Ferrari";
                }
                else if (cmb_Marke.Text == "VW")
                {
                    rtxt_Ausgabe.Text = "VW";
                }
                else
                {
                    rtxt_Ausgabe.Text = "Audi";
                }
                
            }
            public void Farbe()
            {
                if (cmb_Marke.Text == "Braun")
                {
                    rtxt_Ausgabe.Text = "Braun";
                }
                else if (cmb_Marke.Text == "Rot")
                {
                    rtxt_Ausgabe.Text = "Rot";
                }
                else if (cmb_Marke.Text == "Weiß")
                {
                    rtxt_Ausgabe.Text = "Weiß";
                }
                else if (cmb_Marke.Text == "Schwarz")
                {
                    rtxt_Ausgabe.Text = "Schwarz";
                }
                else if (cmb_Marke.Text == "Grün")
                {
                    rtxt_Ausgabe.Text = "Grün";
                }
                else if (cmb_Marke.Text == "Blau")
                {
                    rtxt_Ausgabe.Text = "Blau";
                }
                else if (cmb_Marke.Text == "Gelb")
                {
                    rtxt_Ausgabe.Text = "Gelb";
                }
                else if (cmb_Marke.Text == "Grau")
                {
                    rtxt_Ausgabe.Text = "Grau";
                }
                else
                {
                    rtxt_Ausgabe.Text = "Audi";
                }
                
            }
        
    }
    
       
    
}
