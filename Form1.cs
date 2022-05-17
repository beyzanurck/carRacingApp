using System;
using System.Drawing;
using System.Windows.Forms;

namespace carRacingApp
{
    public partial class frmCarRacing : Form
    {
        public frmCarRacing()
        {
            InitializeComponent();
            ResetGame();
        }

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 10;
        int score;
        int carImage;

        Random random = new Random();
        Random carPosition = new Random();

        bool goLeft, goRight;

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            score++;

            if (goLeft == true && pctPlayer.Location.X > 16)
            {
                pctPlayer.Left -= playerSpeed;
            }

            if (goRight == true && pctPlayer.Location.X < 251)
            {
                pctPlayer.Left += playerSpeed;
            }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 356)
            {
                roadTrack2.Top = -356;
            }

            if (roadTrack1.Top > 356)
            {
                roadTrack1.Top = -356;
            }

            pctAI1.Top += trafficSpeed;
            pctAI2.Top += trafficSpeed;

            if (pctAI1.Top > 356)
            {
                changeAICars(pctAI1);
            }

            if (pctAI2.Top > 356)
            {
                changeAICars(pctAI2);
            }

            if (pctPlayer.Bounds.IntersectsWith(pctAI1.Bounds) || pctPlayer.Bounds.IntersectsWith(pctAI2.Bounds))
            {
                gameOver();
            }

            if (score > 40 && score < 500)
            {
                pctAward.Image = Properties.Resources.bronze;
            }

            if (score > 500 && score < 2000)
            {
                pctAward.Image = Properties.Resources.silver;
                roadSpeed = 15;
                trafficSpeed = 17;
            }

            if (score > 2000)
            {
                pctAward.Image = Properties.Resources.gold;
                roadSpeed = 20;
                trafficSpeed = 22;
            }

        }

        private void changeAICars(PictureBox tempCar)
        {
            carImage = random.Next(1, 9);

            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }

            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Top = carPosition.Next(200, 500) * -1;
                tempCar.Left = carPosition.Next(4, 124);
            }

            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Top = carPosition.Next(200, 500) * -1;
                tempCar.Left = carPosition.Next(160, 267);
            }
        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            pctExplosion.Visible = true;
            pctPlayer.Controls.Add(pctExplosion);
            pctExplosion.Location = new Point(-2,5);
            pctExplosion.BackColor = Color.Transparent;

            pctAward.Visible = true;
            pctAward.BringToFront();

            btnStart.Enabled = true;
        }

        private void ResetGame()
        {
            btnStart.Enabled = false;
            pctExplosion.Visible = false;
            pctAward.Visible = false;
            goLeft = false; goRight = false;
            score = 0;
            pctAward.Image = Properties.Resources.bronze; //initially will be bronze.

            roadSpeed = 10;
            trafficSpeed = 12;

            pctAI1.Top = carPosition.Next(200, 500) * -1;
            pctAI1.Left = carPosition.Next(4, 124);

            pctAI2.Top = carPosition.Next(200, 500) * -1;
            pctAI2.Left = carPosition.Next(160, 267);

            gameTimer.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void playSound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Properties.Resources.hit);
            sound.Play();
        }
    }
}
