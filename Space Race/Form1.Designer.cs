namespace Space_Race
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.winTitle = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player1Ins = new System.Windows.Forms.Label();
            this.player2Ins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.startButton.Font = new System.Drawing.Font("Pixelify Sans Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(410, 312);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(304, 107);
            this.startButton.TabIndex = 0;
            this.startButton.Text = " START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.AutoSize = true;
            this.quitButton.BackColor = System.Drawing.Color.Black;
            this.quitButton.Font = new System.Drawing.Font("Pixelify Sans Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(442, 474);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(247, 107);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = " QUIT";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Pixelify Sans", 100.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.Color.White;
            this.gameTitle.Location = new System.Drawing.Point(41, 35);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(1001, 202);
            this.gameTitle.TabIndex = 2;
            this.gameTitle.Text = "SPACE RACE";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Pixelify Sans Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.player1ScoreLabel.Location = new System.Drawing.Point(98, 593);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(90, 97);
            this.player1ScoreLabel.TabIndex = 5;
            this.player1ScoreLabel.Text = "0";
            this.player1ScoreLabel.Visible = false;
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.Font = new System.Drawing.Font("Pixelify Sans Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.player2ScoreLabel.Location = new System.Drawing.Point(962, 593);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(90, 97);
            this.player2ScoreLabel.TabIndex = 6;
            this.player2ScoreLabel.Text = "0";
            this.player2ScoreLabel.Visible = false;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Pixelify Sans Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(516, 312);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 97);
            this.winLabel.TabIndex = 7;
            this.winLabel.Visible = false;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Pixelify Sans Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(463, 620);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 97);
            this.timerLabel.TabIndex = 8;
            this.timerLabel.Visible = false;
            // 
            // winTitle
            // 
            this.winTitle.AutoSize = true;
            this.winTitle.Font = new System.Drawing.Font("Pixelify Sans Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winTitle.ForeColor = System.Drawing.Color.White;
            this.winTitle.Location = new System.Drawing.Point(490, 398);
            this.winTitle.Name = "winTitle";
            this.winTitle.Size = new System.Drawing.Size(0, 97);
            this.winTitle.TabIndex = 9;
            this.winTitle.Visible = false;
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Font = new System.Drawing.Font("Pixelify Sans Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.ForeColor = System.Drawing.Color.White;
            this.timeLeftLabel.Location = new System.Drawing.Point(442, 604);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(138, 97);
            this.timeLeftLabel.TabIndex = 10;
            this.timeLeftLabel.Text = "60";
            this.timeLeftLabel.Visible = false;
            // 
            // player2
            // 
            this.player2.Image = global::Space_Race.Properties.Resources.spaceships;
            this.player2.Location = new System.Drawing.Point(796, 620);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(52, 47);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 4;
            this.player2.TabStop = false;
            this.player2.Visible = false;
            // 
            // player1
            // 
            this.player1.Image = global::Space_Race.Properties.Resources.spaceships;
            this.player1.Location = new System.Drawing.Point(300, 620);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(52, 47);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 3;
            this.player1.TabStop = false;
            this.player1.Visible = false;
            // 
            // player1Ins
            // 
            this.player1Ins.AutoSize = true;
            this.player1Ins.Font = new System.Drawing.Font("Pixelify Sans Medium", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Ins.ForeColor = System.Drawing.Color.White;
            this.player1Ins.Location = new System.Drawing.Point(61, 358);
            this.player1Ins.Name = "player1Ins";
            this.player1Ins.Size = new System.Drawing.Size(403, 79);
            this.player1Ins.TabIndex = 11;
            this.player1Ins.Text = "P1 Controls";
            this.player1Ins.Visible = false;
            // 
            // player2Ins
            // 
            this.player2Ins.AutoSize = true;
            this.player2Ins.Font = new System.Drawing.Font("Pixelify Sans Medium", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Ins.ForeColor = System.Drawing.Color.White;
            this.player2Ins.Location = new System.Drawing.Point(667, 358);
            this.player2Ins.Name = "player2Ins";
            this.player2Ins.Size = new System.Drawing.Size(415, 79);
            this.player2Ins.TabIndex = 12;
            this.player2Ins.Text = "P2 Controls";
            this.player2Ins.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1123, 720);
            this.Controls.Add(this.player2Ins);
            this.Controls.Add(this.player1Ins);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.winTitle);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Space Race - 1973";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label winTitle;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label player1Ins;
        private System.Windows.Forms.Label player2Ins;
    }
}

