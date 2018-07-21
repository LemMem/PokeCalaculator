using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeCalaculator
{
    public partial class CatchRate : Form
    {
        public CatchRate()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OpponentsCatchRateLabelG34.LinkVisited = true;

            System.Diagnostics.Process.Start("https://bulbapedia.bulbagarden.net/wiki/List_of_Pok%C3%A9mon_by_catch_rate");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcG34_Click(object sender, EventArgs e)
        {
            
            try
            {
                float result = 0;
                float c = (3 * float.Parse(OpponentsMaxHPG34.Text) - 2 * float.Parse(OpponentsCurrentHpG34.Text)) * float.Parse(OpponentsCatchRateG34.Text) * float.Parse(PokeballG34.Text);
                float d = 3 * float.Parse(OpponentsMaxHPG34.Text);
                result = c / d * float.Parse(StatG34.Text);
                resultText.Text = "Result: " + result.ToString() + "%!";
            } catch(FormatException)
            {
                resultText.Text = "Error: That's not a number!";
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.PokeballMultiplierG34.LinkVisited = true;

            System.Diagnostics.Process.Start("https://bulbapedia.bulbagarden.net/wiki/Catch_rate#Pok.C3.A9_Ball_effectiveness_rates");
        }

        private void StatG34_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }
    }
}
