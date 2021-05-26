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

        static class Global
        {

            public static byte tmrCounter = 0;
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

                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    tmr1.Start();
                    if ((Global.tmrCounter % 2) != 0){

                        txtBox1.Text = "X Turn";
                    }
                    else if ((Global.tmrCounter % 2) == 0){

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
            Global.tmrCounter = (byte)(1 + Global.tmrCounter);
            txtBox1.Text = "X Turn";
            prgrssBar1.Visible = lbl1.Visible = btnReset.Visible = btn1_1.Visible = btn1_2.Visible = btn1_3.Visible = btn2_1.Visible = btn2_2.Visible = btn2_3.Visible = btn3_1.Visible = btn3_2.Visible = btn3_3.Visible = true;
            btnStart.Visible = false;
        }

        private void btn1_1_Click(object sender, EventArgs e)
        {
            if ((btn1_1.Text == "") && ((Global.tmrCounter % 2) != 0)){

                btn1_1.Text = "X";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "O Turn";
            }
            else if ((btn1_1.Text == "") && ((Global.tmrCounter % 2) == 0)){

                btn1_1.Text = "O";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "X Turn";
            }

            if ((btn1_1.Text == "X") && (btn1_2.Text == "X") && (btn1_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if(result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn2_1.Text == "X") && (btn2_2.Text == "X") && (btn2_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_3.Text == "O") && (btn2_2.Text == "O") && (btn3_1.Text == "O")){

                txtBox1.Text = "O Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X/O Draw!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            if ((btn2_1.Text == "") && ((Global.tmrCounter % 2) != 0))
            {

                btn2_1.Text = "X";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "O Turn";
            }
            else if ((btn2_1.Text == "") && ((Global.tmrCounter % 2) == 0))
            {

                btn2_1.Text = "O";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "X Turn";
            }

            if ((btn1_1.Text == "X") && (btn1_2.Text == "X") && (btn1_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
            else if ((btn1_3.Text == "X") && (btn2_2.Text == "X") && (btn3_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X/O Draw!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btn3_1_Click(object sender, EventArgs e)
        {
            if ((btn3_1.Text == "") && ((Global.tmrCounter % 2) != 0))
            {

                btn3_1.Text = "X";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "O Turn";
            }
            else if ((btn3_1.Text == "") && ((Global.tmrCounter % 2) == 0))
            {

                btn3_1.Text = "O";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "X Turn";
            }

            if ((btn1_1.Text == "X") && (btn1_2.Text == "X") && (btn1_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X/O Draw!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            if ((btn1_2.Text == "") && ((Global.tmrCounter % 2) != 0))
            {

                btn1_2.Text = "X";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "O Turn";
            }
            else if ((btn1_2.Text == "") && ((Global.tmrCounter % 2) == 0))
            {

                btn1_2.Text = "O";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "X Turn";
            }

            if ((btn1_1.Text == "X") && (btn1_2.Text == "X") && (btn1_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X/O Draw!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            if ((btn2_2.Text == "") && ((Global.tmrCounter % 2) != 0))
            {

                btn2_2.Text = "X";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "O Turn";
            }
            else if ((btn2_2.Text == "") && ((Global.tmrCounter % 2) == 0))
            {

                btn2_2.Text = "O";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "X Turn";
            }

            if ((btn1_1.Text == "X") && (btn1_2.Text == "X") && (btn1_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X/O Draw!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btn3_2_Click(object sender, EventArgs e)
        {
            if ((btn3_2.Text == "") && ((Global.tmrCounter % 2) != 0))
            {

                btn3_2.Text = "X";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "O Turn";
            }
            else if ((btn3_2.Text == "") && ((Global.tmrCounter % 2) == 0))
            {

                btn3_2.Text = "O";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "X Turn";
            }

            if ((btn1_1.Text == "X") && (btn1_2.Text == "X") && (btn1_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X/O Draw!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btn1_3_Click(object sender, EventArgs e)
        {
            if ((btn1_3.Text == "") && ((Global.tmrCounter % 2) != 0))
            {

                btn1_3.Text = "X";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "O Turn";
            }
            else if ((btn1_3.Text == "") && ((Global.tmrCounter % 2) == 0))
            {

                btn1_3.Text = "O";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "X Turn";
            }

            if ((btn1_1.Text == "X") && (btn1_2.Text == "X") && (btn1_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X/O Draw!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btn2_3_Click(object sender, EventArgs e)
        {
            if ((btn2_3.Text == "") && ((Global.tmrCounter % 2) != 0))
            {

                btn2_3.Text = "X";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "O Turn";
            }
            else if ((btn2_3.Text == "") && ((Global.tmrCounter % 2) == 0))
            {

                btn2_3.Text = "O";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "X Turn";
            }

            if ((btn1_1.Text == "X") && (btn1_2.Text == "X") && (btn1_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X/O Draw!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btn3_3_Click(object sender, EventArgs e)
        {
            if ((btn3_3.Text == "") && ((Global.tmrCounter % 2) != 0))
            {

                btn3_3.Text = "X";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "O Turn";
            }
            else if ((btn3_3.Text == "") && ((Global.tmrCounter % 2) == 0))
            {

                btn3_3.Text = "O";
                Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                prgrssBar1.Value = 100;
                txtBox1.Text = "X Turn";
            }

            if ((btn1_1.Text == "X") && (btn1_2.Text == "X") && (btn1_3.Text == "X"))
            {

                txtBox1.Text = "X Won!";
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                prgrssBar1.Value = 100;
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("O Won!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
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
                Global.tmrCounter = 0;
                tmr1.Stop();
                DialogResult result = MessageBox.Show("X/O Draw!\nPlay Again?", "Result", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    txtBox1.Text = "";
                    btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
                    tmr1.Start();
                    Global.tmrCounter = (byte)(1 + Global.tmrCounter);
                    txtBox1.Text = "X Turn";
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            prgrssBar1.Value = 100;
            Global.tmrCounter = 0;
            tmr1.Stop();
            txtBox1.Text = "";
            btn1_1.Text = btn1_2.Text = btn1_3.Text = btn2_1.Text = btn2_2.Text = btn2_3.Text = btn3_1.Text = btn3_2.Text = btn3_3.Text = "";
            btnStart.Visible = true;
            btnReset.Visible = false;
            prgrssBar1.Visible = lbl1.Visible = btnReset.Visible = btn1_1.Visible = btn1_2.Visible = btn1_3.Visible = btn2_1.Visible = btn2_2.Visible = btn2_3.Visible = btn3_1.Visible = btn3_2.Visible = btn3_3.Visible = false;
        }
    }
}
