using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fearandmalice
{
    public partial class cool : Form
    {

        //stuff to make stuff function sometimes 

        Rectangle player1 = new Rectangle(10, 170, 25, 25);
        Rectangle player2 = new Rectangle(450, 170, 25, 25);
        Rectangle point = new Rectangle(295, 195, 10, 10);
        Rectangle speedbuff = new Rectangle(250, 70, 10, 10);

        int player1Score = 0;
        int player2Score = 0;


        int playerSpeed = 4;
        int player2Speed = 4;

        Random finland = new Random(); 


        bool dDown = false;
        bool aDown = false;
        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;

        Random mover = new Random(); 

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        public cool()
        {
            InitializeComponent();
             point.X = finland.Next(0, this.Width - 10 ); 
            point.Y  = finland.Next(0, this.Height - 10);

            speedbuff.X = finland.Next(0, this.Width - 10);
            speedbuff.Y = finland.Next(0, this.Width - 10); 

            
        } 

       
            private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;


            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(yellowBrush, speedbuff);
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(blueBrush, player2);
            e.Graphics.FillRectangle(greenBrush, point);
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerSpeed;
            }

            if (aDown == true && player1.X > 0)

            {
                player1.X -= playerSpeed;
            }

            if (dDown == true && player1.X < this.Width - player1.Width)
            {
                player1.X += playerSpeed;
            }

            //p2
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }

            if (leftArrowDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }
            
            if (rightArrowDown == true && player2.X < this.Width - player2.Width)
            {
                player2.X += player2Speed;
            }
            //point system
            if (player1.IntersectsWith(point))
            {
                player1Score++;
                Scoring.Text = $"{player1Score}";
                point.X = finland.Next(0, this.Width - 10);
                point.Y = finland.Next(0, this.Height - 10);

            }

            if (player2.IntersectsWith(point))
            {
                player2Score++;
                label2.Text = $"{player2Score}";
                point.X = finland.Next(0, this.Width);
                point.Y = finland.Next(0, this.Height);
            }

            if (player1.IntersectsWith(speedbuff))
            {
                playerSpeed++;
                speedbuff.X = finland.Next(0, this.Width - 10);
                speedbuff.Y = finland.Next(0, this.Height - 10);

            }

            if (player2.IntersectsWith(speedbuff))
            {
                player2Speed++;
                speedbuff.X = finland.Next(0, this.Width);
                speedbuff.Y = finland.Next(0, this.Height);
            }

            if (player1Score  >= 10)
            {
                hah.Text = "PLAYER 1 WINS!!";
               
                time.Stop();
            }

            if (player2Score >= 10)
            {
                hah.Text = "PLAYER 2 WINS!!";

                time.Stop();
            }

            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
