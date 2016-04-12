using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntenProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Punten, MaxPunten, Resultaat;
            Punten = float.Parse(txtbPunten.Text);
            MaxPunten = float.Parse(txtbMaxPunten.Text);

            Resultaat = Punten / MaxPunten * 100;

            if (Resultaat >= 50)
            {
                lblResultaat.Text = "Proficiat! Je hebt een filmticket gewonnen!\nJe resultaat is " + Resultaat + "%.";
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
