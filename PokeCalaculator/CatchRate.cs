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

        
        void calculateCatchRate(float generation, float maxHp, float currentHp, float rate, float bonusBall, float bonusStatus)
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
