namespace carRacingApp
{
    partial class frmCarRacing
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
            this.pnlBackGround = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.pctAI1 = new System.Windows.Forms.PictureBox();
            this.pctAI2 = new System.Windows.Forms.PictureBox();
            this.pctAward = new System.Windows.Forms.PictureBox();
            this.pctExplosion = new System.Windows.Forms.PictureBox();
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackGround
            // 
            this.pnlBackGround.BackColor = System.Drawing.Color.Black;
            this.pnlBackGround.Controls.Add(this.pctPlayer);
            this.pnlBackGround.Controls.Add(this.pctExplosion);
            this.pnlBackGround.Controls.Add(this.pctAward);
            this.pnlBackGround.Controls.Add(this.pctAI2);
            this.pnlBackGround.Controls.Add(this.pctAI1);
            this.pnlBackGround.Controls.Add(this.roadTrack2);
            this.pnlBackGround.Controls.Add(this.roadTrack1);
            this.pnlBackGround.Location = new System.Drawing.Point(12, 12);
            this.pnlBackGround.Name = "pnlBackGround";
            this.pnlBackGround.Size = new System.Drawing.Size(310, 356);
            this.pnlBackGround.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(118, 405);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.ForeColor = System.Drawing.Color.Maroon;
            this.lblScore.Location = new System.Drawing.Point(12, 379);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(310, 23);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirection
            // 
            this.lblDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDirection.Location = new System.Drawing.Point(13, 454);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(309, 58);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "Press Left and Right to move the car.\r\n\r\nDon\'t hit any others car in the game.\r\n";
            this.lblDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::carRacingApp.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, -356);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(310, 356);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::carRacingApp.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(310, 356);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 1;
            this.roadTrack2.TabStop = false;
            // 
            // pctAI1
            // 
            this.pctAI1.Image = global::carRacingApp.Properties.Resources.carGreen;
            this.pctAI1.Location = new System.Drawing.Point(58, 33);
            this.pctAI1.Name = "pctAI1";
            this.pctAI1.Size = new System.Drawing.Size(35, 69);
            this.pctAI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAI1.TabIndex = 2;
            this.pctAI1.TabStop = false;
            this.pctAI1.Tag = "carLeft";
            // 
            // pctAI2
            // 
            this.pctAI2.Image = global::carRacingApp.Properties.Resources.carGrey;
            this.pctAI2.Location = new System.Drawing.Point(267, 24);
            this.pctAI2.Name = "pctAI2";
            this.pctAI2.Size = new System.Drawing.Size(38, 69);
            this.pctAI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAI2.TabIndex = 2;
            this.pctAI2.TabStop = false;
            this.pctAI2.Tag = "carRight";
            // 
            // pctAward
            // 
            this.pctAward.Image = global::carRacingApp.Properties.Resources.bronze;
            this.pctAward.Location = new System.Drawing.Point(106, 131);
            this.pctAward.Name = "pctAward";
            this.pctAward.Size = new System.Drawing.Size(92, 44);
            this.pctAward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAward.TabIndex = 2;
            this.pctAward.TabStop = false;
            // 
            // pctExplosion
            // 
            this.pctExplosion.Image = global::carRacingApp.Properties.Resources.explosion;
            this.pctExplosion.Location = new System.Drawing.Point(40, 206);
            this.pctExplosion.Name = "pctExplosion";
            this.pctExplosion.Size = new System.Drawing.Size(42, 43);
            this.pctExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExplosion.TabIndex = 2;
            this.pctExplosion.TabStop = false;
            // 
            // pctPlayer
            // 
            this.pctPlayer.Image = global::carRacingApp.Properties.Resources.carYellow;
            this.pctPlayer.Location = new System.Drawing.Point(141, 270);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(40, 73);
            this.pctPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPlayer.TabIndex = 2;
            this.pctPlayer.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // frmCarRacing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 521);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlBackGround);
            this.Name = "frmCarRacing";
            this.Text = "Car Racing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.pnlBackGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackGround;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.PictureBox pctPlayer;
        private System.Windows.Forms.PictureBox pctExplosion;
        private System.Windows.Forms.PictureBox pctAward;
        private System.Windows.Forms.PictureBox pctAI2;
        private System.Windows.Forms.PictureBox pctAI1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.Timer gameTimer;
    }
}

