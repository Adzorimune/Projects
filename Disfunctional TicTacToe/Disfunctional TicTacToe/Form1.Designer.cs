namespace Disfunctional_TicTacToe
{
    partial class DTTT
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AITimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 113);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 113);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 113);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 113);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(133, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 113);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(254, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 113);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 250);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 113);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(133, 250);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 113);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(254, 250);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 113);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.PlayerMove);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(12, 377);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(94, 29);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.RestartGame);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 377);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 27);
            this.textBox1.TabIndex = 2;
            // 
            // AITimer
            // 
            this.AITimer.Interval = 1000;
            this.AITimer.Tick += new System.EventHandler(this.AIMove);
            // 
            // DTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 418);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DTTT";
            this.ShowIcon = false;
            this.Text = "DTTT";
            this.Load += new System.EventHandler(this.DTTT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonRestart;
        private TextBox textBox1;
        private System.Windows.Forms.Timer AITimer;
    }
}