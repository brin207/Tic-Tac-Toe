using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void prgrssBr1_Click(object sender, EventArgs e)
        {

        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (prgrssBar1.Value > prgrssBar1.Minimum){

                prgrssBar1.PerformStep();
            }
            if (prgrssBar1.Value == prgrssBar1.Minimum)
            {

                prgrssBar1.Value = 100;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("Time is up!");
                if (result == DialogResult.OK){

                    tmr1.Start();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmr1.Start();
            tmr1.Interval = 1000;
        }
    }
}
