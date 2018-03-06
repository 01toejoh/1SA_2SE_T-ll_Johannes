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
            Auto Neuauto = new Auto();
        }

        public int Marke()
        {
            string rück;
            if (cmb_Marke.Text == "BMW")
            {
                rück = "BMW";
            }
            else if (cmb_Marke.Text == "Porsche")
            {
                rück = "Porsche";
            }
            else if (cmb_Marke.Text == "Ferrari")
            {
                rück = "Ferrari";
            }
            else if (cmb_Marke.Text == "VW")
            {
                rück = "VW";
            }
            else
            {
                rück = "Audi";
            }
            return Convert.ToInt32(rück);
        }
            
        
    }
    class Auto
    {
        
    }
    
       
    
}
