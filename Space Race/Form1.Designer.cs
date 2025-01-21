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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.playerOneWinnerLabel = new System.Windows.Forms.Label();
            this.playerTwoWinnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player1ScoreLabel.Location = new System.Drawing.Point(12, 420);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(104, 92);
            this.player1ScoreLabel.TabIndex = 0;
            this.player1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player2ScoreLabel.Location = new System.Drawing.Point(656, 420);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(104, 92);
            this.player2ScoreLabel.TabIndex = 1;
            this.player2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(216, 168);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(359, 116);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "3 ...";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Enabled = true;
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // playerOneWinnerLabel
            // 
            this.playerOneWinnerLabel.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneWinnerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerOneWinnerLabel.Location = new System.Drawing.Point(64, 186);
            this.playerOneWinnerLabel.Name = "playerOneWinnerLabel";
            this.playerOneWinnerLabel.Size = new System.Drawing.Size(235, 92);
            this.playerOneWinnerLabel.TabIndex = 3;
            this.playerOneWinnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerOneWinnerLabel.Visible = false;
            // 
            // playerTwoWinnerLabel
            // 
            this.playerTwoWinnerLabel.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoWinnerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerTwoWinnerLabel.Location = new System.Drawing.Point(459, 186);
            this.playerTwoWinnerLabel.Name = "playerTwoWinnerLabel";
            this.playerTwoWinnerLabel.Size = new System.Drawing.Size(259, 92);
            this.playerTwoWinnerLabel.TabIndex = 4;
            this.playerTwoWinnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerTwoWinnerLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(772, 512);
            this.Controls.Add(this.playerTwoWinnerLabel);
            this.Controls.Add(this.playerOneWinnerLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Space Race ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label playerOneWinnerLabel;
        private System.Windows.Forms.Label playerTwoWinnerLabel;
    }
}

