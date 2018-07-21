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
    public partial class PayDay : Form
    {
        public PayDay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            try
            {
                result = int.Parse(level.Text) * 5;
                if(result > 500)
                {
                    this.result.Text = "Error: Thats greater than any pokemon level!";
                }else
                {
                    this.result.Text = "Result: " + result.ToString();
                }
            } catch(FormatException)
            {
                this.result.Text = "Error: That's not a number!";
            }
        }

        private void PayDay_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }
    }
}
