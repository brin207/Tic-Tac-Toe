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
            public bool tmrCounter = false;
            public byte winXCounter = 0;
            public byte winOCounter = 0;
        public void btnfxn(Button btn)
        {
            if ((btn.Text == "") && (tmrCounter == true))
            {
                btn.Text = "X";
                tmrCounter = !tmrCounter;
                prgrssBar1.Value = 100;
                txtBox1.Text = "O Turn";
            }
            else if ((btn.Text == "") && (tmrCounter == false))
            {
                btn.Text = "O";
                tmrCounter = !tmrCounter;
                prgrssBar1.Value = 100;
                txtBox1.Text = "X Turn";
            }

            if ((btn1_1.Text == "X") && (btn1_2.Text == "X") && (btn1_3.Text == "X"))
            {
                txtBox1.Text = "X Won!";
                btn1_1.FlatAppearance.BorderColor = btn1_2.FlatAppearance.BorderColor = btn1_3.FlatAppearance.BorderColor = Color.LightGreen;
                btn1_1.BackColor = btn1_2.BackColor = btn1_3.BackColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winXCounter++;
                txtBoxX.Text = winXCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_1.BackColor = btn1_2.BackColor = btn1_3.BackColor = Color.SteelBlue;
                    btn1_1.FlatAppearance.BorderColor = btn1_2.FlatAppearance.BorderColor = btn1_3.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";

                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn2_1.Text == "X") && (btn2_2.Text == "X") && (btn2_3.Text == "X"))
            {
                txtBox1.Text = "X Won!";
                btn2_1.BackColor = btn2_2.BackColor = btn2_3.BackColor = Color.LightGreen;
                btn2_1.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn2_3.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winXCounter++;
                txtBoxX.Text = winXCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn2_1.BackColor = btn2_2.BackColor = btn2_3.BackColor = Color.SteelBlue;
                    btn2_1.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn2_3.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn3_1.Text == "X") && (btn3_2.Text == "X") && (btn3_3.Text == "X"))
            {
                txtBox1.Text = "X Won!";
                btn3_1.BackColor = btn3_2.BackColor = btn3_3.BackColor = Color.LightGreen;
                btn3_1.FlatAppearance.BorderColor = btn3_2.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winXCounter++;
                txtBoxX.Text = winXCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn3_1.BackColor = btn3_2.BackColor = btn3_3.BackColor = Color.SteelBlue;
                    btn3_1.FlatAppearance.BorderColor = btn3_2.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_1.Text == "X") && (btn2_1.Text == "X") && (btn3_1.Text == "X"))
            {
                txtBox1.Text = "X Won!";
                btn1_1.BackColor = btn2_1.BackColor = btn3_1.BackColor = Color.LightGreen;
                btn1_1.FlatAppearance.BorderColor = btn2_1.FlatAppearance.BorderColor = btn3_1.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winXCounter++;
                txtBoxX.Text = winXCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_1.BackColor = btn2_1.BackColor = btn3_1.BackColor = Color.SteelBlue;
                    btn1_1.FlatAppearance.BorderColor = btn2_1.FlatAppearance.BorderColor = btn3_1.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_2.Text == "X") && (btn2_2.Text == "X") && (btn3_2.Text == "X"))
            {
                txtBox1.Text = "X Won!";
                btn1_2.BackColor = btn2_2.BackColor = btn3_2.BackColor = Color.LightGreen;
                btn1_2.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_2.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winXCounter++;
                txtBoxX.Text = winXCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_2.BackColor = btn2_2.BackColor = btn3_2.BackColor = Color.SteelBlue;
                    btn1_2.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_2.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_3.Text == "X") && (btn2_3.Text == "X") && (btn3_3.Text == "X"))
            {
                txtBox1.Text = "X Won!";
                btn1_3.BackColor = btn2_3.BackColor = btn3_3.BackColor = Color.LightGreen;
                btn1_3.FlatAppearance.BorderColor = btn2_3.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winXCounter++;
                txtBoxX.Text = winXCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_3.BackColor = btn2_3.BackColor = btn3_3.BackColor = Color.SteelBlue;
                    btn1_3.FlatAppearance.BorderColor = btn2_3.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_1.Text == "X") && (btn2_2.Text == "X") && (btn3_3.Text == "X"))
            {
                txtBox1.Text = "X Won!";
                btn1_1.BackColor = btn2_2.BackColor = btn3_3.BackColor = Color.LightGreen;
                btn1_1.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winXCounter++;
                txtBoxX.Text = winXCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_1.BackColor = btn2_2.BackColor = btn3_3.BackColor = Color.SteelBlue;
                    btn1_1.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_3.Text == "X") && (btn2_2.Text == "X") && (btn3_1.Text == "X"))
            {
                txtBox1.Text = "X Won!";
                btn1_3.BackColor = btn2_2.BackColor = btn3_1.BackColor = Color.LightGreen;
                btn1_3.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_1.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winXCounter++;
                txtBoxX.Text = winXCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_3.BackColor = btn2_2.BackColor = btn3_1.BackColor = Color.SteelBlue;
                    btn1_3.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_1.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_1.Text == "O") && (btn1_2.Text == "O") && (btn1_3.Text == "O"))
            {
                txtBox1.Text = "O Won!";
                btn1_1.FlatAppearance.BorderColor = btn1_2.FlatAppearance.BorderColor = btn1_3.FlatAppearance.BorderColor = Color.LightGreen;
                btn1_1.BackColor = btn1_2.BackColor = btn1_3.BackColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winOCounter++;
                txtBoxO.Text = winOCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_1.FlatAppearance.BorderColor = btn1_2.FlatAppearance.BorderColor = btn1_3.FlatAppearance.BorderColor = Color.SteelBlue;
                    btn1_1.BackColor = btn1_2.BackColor = btn1_3.BackColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn2_1.Text == "O") && (btn2_2.Text == "O") && (btn2_3.Text == "O"))
            {
                txtBox1.Text = "O Won!";
                btn2_1.BackColor = btn2_2.BackColor = btn2_3.BackColor = Color.LightGreen;
                btn2_1.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn2_3.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winOCounter++;
                txtBoxO.Text = winOCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn2_1.BackColor = btn2_2.BackColor = btn2_3.BackColor = Color.SteelBlue;
                    btn2_1.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn2_3.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn3_1.Text == "O") && (btn3_2.Text == "O") && (btn3_3.Text == "O"))
            {
                txtBox1.Text = "O Won!";
                btn3_1.BackColor = btn3_2.BackColor = btn3_3.BackColor = Color.LightGreen;
                btn3_1.FlatAppearance.BorderColor = btn3_2.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winOCounter++;
                txtBoxO.Text = winOCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn3_1.BackColor = btn3_2.BackColor = btn3_3.BackColor = Color.SteelBlue;
                    btn3_1.FlatAppearance.BorderColor = btn3_2.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_1.Text == "O") && (btn2_1.Text == "O") && (btn3_1.Text == "O"))
            {
                txtBox1.Text = "O Won!";
                btn1_1.BackColor = btn2_1.BackColor = btn3_1.BackColor = Color.LightGreen;
                btn1_1.FlatAppearance.BorderColor = btn2_1.FlatAppearance.BorderColor = btn3_1.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winOCounter++;
                txtBoxO.Text = winOCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_1.BackColor = btn2_1.BackColor = btn3_1.BackColor = Color.SteelBlue;
                    btn1_1.FlatAppearance.BorderColor = btn2_1.FlatAppearance.BorderColor = btn3_1.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_2.Text == "O") && (btn2_2.Text == "O") && (btn3_2.Text == "O"))
            {
                txtBox1.Text = "O Won!";
                btn1_2.BackColor = btn2_2.BackColor = btn3_2.BackColor = Color.LightGreen;
                btn1_2.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_2.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winOCounter++;
                txtBoxO.Text = winOCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_2.BackColor = btn2_2.BackColor = btn3_2.BackColor = Color.SteelBlue;
                    btn1_2.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_2.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_3.Text == "O") && (btn2_3.Text == "O") && (btn3_3.Text == "O"))
            {
                txtBox1.Text = "O Won!";
                btn1_3.BackColor = btn2_3.BackColor = btn3_3.BackColor = Color.LightGreen;
                btn1_3.FlatAppearance.BorderColor = btn2_3.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winOCounter++;
                txtBoxO.Text = winOCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_3.BackColor = btn2_3.BackColor = btn3_3.BackColor = Color.SteelBlue;
                    btn1_3.FlatAppearance.BorderColor = btn2_3.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_1.Text == "O") && (btn2_2.Text == "O") && (btn3_3.Text == "O"))
            {
                txtBox1.Text = "O Won!";
                btn1_1.BackColor = btn2_2.BackColor = btn3_3.BackColor = Color.LightGreen;
                btn1_1.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winOCounter++;
                txtBoxO.Text = winOCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_1.BackColor = btn2_2.BackColor = btn3_3.BackColor = Color.SteelBlue;
                    btn1_1.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_3.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_3.Text == "O") && (btn2_2.Text == "O") && (btn3_1.Text == "O"))
            {
                txtBox1.Text = "O Won!";
                btn1_3.BackColor = btn2_2.BackColor = btn3_1.BackColor = Color.LightGreen;
                btn1_3.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_1.FlatAppearance.BorderColor = Color.LightGreen;
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winOCounter++;
                txtBoxO.Text = winOCounter.ToString();
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    btn1_3.BackColor = btn2_2.BackColor = btn3_1.BackColor = Color.SteelBlue;
                    btn1_3.FlatAppearance.BorderColor = btn2_2.FlatAppearance.BorderColor = btn3_1.FlatAppearance.BorderColor = Color.SteelBlue;
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_1.Text == "") || (btn1_2.Text == "") || (btn1_3.Text == "")
             || (btn2_1.Text == "") || (btn2_2.Text == "") || (btn2_3.Text == "")
              || (btn3_1.Text == "") || (btn3_2.Text == "") || (btn3_3.Text == ""))
            {
                //None
            }
            else
            {
                txtBox1.Text = "X/O Draw!";
                prgrssBar1.Value = 100;
                tmrCounter = false;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X/O Draw!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    tmrCounter = !tmrCounter;
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
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
                    tmrCounter = !tmrCounter;
                    tmr1.Start();
                    if (tmrCounter == true)
                    {
                        txtBox1.Text = "X Turn";
                    }
                    else if (tmrCounter == false){
                        txtBox1.Text = "O Turn";
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmr1.Start();
            tmr1.Interval = 1000;
            tmrCounter = true;
            txtBox1.Text = "X Turn";
            grpBox1.Visible = txtBoxX.Visible = txtBoxO.Visible = lblXwns.Visible = lblOwns.Visible = prgrssBar1.Visible = lblTimer.Visible = btnReset.Visible = btn1_1.Visible = btn1_2.Visible = btn1_3.Visible = btn2_1.Visible = btn2_2.Visible = btn2_3.Visible = btn3_1.Visible = btn3_2.Visible = btn3_3.Visible = true;
            btnStart.Visible = false;
        }
        private void btn1_1_Click(object sender, EventArgs e)
        {
            btnfxn(btn1_1);
        }
        private void btn2_1_Click(object sender, EventArgs e)
        {
            btnfxn(btn2_1);
        }
        private void btn3_1_Click(object sender, EventArgs e)
        {
            btnfxn(btn3_1);
        }
        private void btn1_2_Click(object sender, EventArgs e)
        {
            btnfxn(btn1_2);
        }
        private void btn2_2_Click(object sender, EventArgs e)
        {
            btnfxn(btn2_2);
        }
        private void btn3_2_Click(object sender, EventArgs e)
        {
            btnfxn(btn3_2);
        }
        private void btn1_3_Click(object sender, EventArgs e)
        {
            btnfxn(btn1_3);
        }
        private void btn2_3_Click(object sender, EventArgs e)
        {
            btnfxn(btn2_3);
        }
        private void btn3_3_Click(object sender, EventArgs e)
        {
            btnfxn(btn3_3);
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            tmr1.Stop();
            DialogResult result = MessageBox.Show("Are you sure you want to reset the game?\nNote: It will also reset the scoreboard.", "Reset", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                prgrssBar1.Value = 100;
                tmrCounter = false;
                winXCounter = 0;
                winOCounter = 0;
                tmr1.Stop();
                txtBox1.Text = "";
                btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                btnStart.Visible = true;
                btnReset.Visible = false;
                txtBoxX.Text = txtBoxO.Text = "0";
                grpBox1.Visible = txtBoxX.Visible = txtBoxO.Visible = lblXwns.Visible = lblOwns.Visible = prgrssBar1.Visible = lblTimer.Visible = btnReset.Visible = btn1_1.Visible = btn1_2.Visible = btn1_3.Visible = btn2_1.Visible = btn2_2.Visible = btn2_3.Visible = btn3_1.Visible = btn3_2.Visible = btn3_3.Visible = false;
            }
            else if (result == DialogResult.No)
            {
                tmr1.Start();
            }
        }
    }
}
