
namespace Tic_Tac_Toe_Game
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.btn1_1 = new System.Windows.Forms.Button();
            this.btn2_1 = new System.Windows.Forms.Button();
            this.btn3_1 = new System.Windows.Forms.Button();
            this.btn1_2 = new System.Windows.Forms.Button();
            this.btn2_2 = new System.Windows.Forms.Button();
            this.b3_2 = new System.Windows.Forms.Button();
            this.btn1_3 = new System.Windows.Forms.Button();
            this.btn2_3 = new System.Windows.Forms.Button();
            this.btn3_3 = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.prgrssBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1_1
            // 
            this.btn1_1.Location = new System.Drawing.Point(476, 109);
            this.btn1_1.Name = "btn1_1";
            this.btn1_1.Size = new System.Drawing.Size(100, 100);
            this.btn1_1.TabIndex = 0;
            this.btn1_1.Text = "button1";
            this.btn1_1.UseVisualStyleBackColor = true;
            // 
            // btn2_1
            // 
            this.btn2_1.Location = new System.Drawing.Point(476, 215);
            this.btn2_1.Name = "btn2_1";
            this.btn2_1.Size = new System.Drawing.Size(100, 100);
            this.btn2_1.TabIndex = 1;
            this.btn2_1.Text = "button2";
            this.btn2_1.UseVisualStyleBackColor = true;
            // 
            // btn3_1
            // 
            this.btn3_1.Location = new System.Drawing.Point(476, 321);
            this.btn3_1.Name = "btn3_1";
            this.btn3_1.Size = new System.Drawing.Size(100, 100);
            this.btn3_1.TabIndex = 2;
            this.btn3_1.Text = "button3";
            this.btn3_1.UseVisualStyleBackColor = true;
            // 
            // btn1_2
            // 
            this.btn1_2.Location = new System.Drawing.Point(582, 109);
            this.btn1_2.Name = "btn1_2";
            this.btn1_2.Size = new System.Drawing.Size(100, 100);
            this.btn1_2.TabIndex = 3;
            this.btn1_2.Text = "button4";
            this.btn1_2.UseVisualStyleBackColor = true;
            // 
            // btn2_2
            // 
            this.btn2_2.Location = new System.Drawing.Point(582, 215);
            this.btn2_2.Name = "btn2_2";
            this.btn2_2.Size = new System.Drawing.Size(100, 100);
            this.btn2_2.TabIndex = 4;
            this.btn2_2.Text = "button5";
            this.btn2_2.UseVisualStyleBackColor = true;
            // 
            // b3_2
            // 
            this.b3_2.Location = new System.Drawing.Point(582, 321);
            this.b3_2.Name = "b3_2";
            this.b3_2.Size = new System.Drawing.Size(100, 100);
            this.b3_2.TabIndex = 5;
            this.b3_2.Text = "button6";
            this.b3_2.UseVisualStyleBackColor = true;
            // 
            // btn1_3
            // 
            this.btn1_3.Location = new System.Drawing.Point(688, 109);
            this.btn1_3.Name = "btn1_3";
            this.btn1_3.Size = new System.Drawing.Size(100, 100);
            this.btn1_3.TabIndex = 6;
            this.btn1_3.Text = "button7";
            this.btn1_3.UseVisualStyleBackColor = true;
            // 
            // btn2_3
            // 
            this.btn2_3.Location = new System.Drawing.Point(688, 215);
            this.btn2_3.Name = "btn2_3";
            this.btn2_3.Size = new System.Drawing.Size(100, 100);
            this.btn2_3.TabIndex = 7;
            this.btn2_3.Text = "button8";
            this.btn2_3.UseVisualStyleBackColor = true;
            // 
            // btn3_3
            // 
            this.btn3_3.Location = new System.Drawing.Point(688, 321);
            this.btn3_3.Name = "btn3_3";
            this.btn3_3.Size = new System.Drawing.Size(100, 100);
            this.btn3_3.TabIndex = 8;
            this.btn3_3.Text = "button9";
            this.btn3_3.UseVisualStyleBackColor = true;
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // prgrssBar1
            // 
            this.prgrssBar1.Location = new System.Drawing.Point(582, 451);
            this.prgrssBar1.Name = "prgrssBar1";
            this.prgrssBar1.Size = new System.Drawing.Size(100, 29);
            this.prgrssBar1.Step = -10;
            this.prgrssBar1.TabIndex = 9;
            this.prgrssBar1.Value = 100;
            this.prgrssBar1.Click += new System.EventHandler(this.prgrssBr1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(168, 213);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 48);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox1.Location = new System.Drawing.Point(476, 41);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(312, 34);
            this.txtBox1.TabIndex = 11;
            this.txtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(222, 267);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(93, 48);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(123, 267);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(93, 48);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.prgrssBar1);
            this.Controls.Add(this.btn3_3);
            this.Controls.Add(this.btn2_3);
            this.Controls.Add(this.btn1_3);
            this.Controls.Add(this.b3_2);
            this.Controls.Add(this.btn2_2);
            this.Controls.Add(this.btn1_2);
            this.Controls.Add(this.btn3_1);
            this.Controls.Add(this.btn2_1);
            this.Controls.Add(this.btn1_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1_1;
        private System.Windows.Forms.Button btn2_1;
        private System.Windows.Forms.Button btn3_1;
        private System.Windows.Forms.Button btn1_2;
        private System.Windows.Forms.Button btn2_2;
        private System.Windows.Forms.Button b3_2;
        private System.Windows.Forms.Button btn1_3;
        private System.Windows.Forms.Button btn2_3;
        private System.Windows.Forms.Button btn3_3;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.ProgressBar prgrssBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnRestart;
    }
}

