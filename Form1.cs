using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte PlayersCounter = 0;

        struct Blocks
        {
           public static bool Btn1 = false;
           public static bool Btn2 = false;
           public static bool Btn3 = false;
           public static bool Btn4 = false;
           public static bool Btn5 = false;
           public static bool Btn6 = false;
           public static bool Btn7 = false;
           public static bool Btn8 = false;
           public static bool Btn9 = false;
        }
        void UpdatePlayerTurns()
        {
            if (PlayersCounter == 0)
            {
                lblPlayer.Text = "Player 2";
            }
            else
                lblPlayer.Text = "Player 1";
            if (PlayersCounter == 0)
            {
                PlayersCounter++;
            }
            else
            PlayersCounter = 0;

        }
        void WarningMessage() 
        {
            MessageBox.Show("You Can't Select This Box", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        byte CheckGameWinner()
        {
            if ((btnBlock1.Tag as string == "Player1" && btnBlock2.Tag as string == "Player1" && btnBlock3.Tag as string == "Player1") ||
               (btnBlock1.Tag as string == "Player2" && btnBlock2.Tag as string == "Player2" && btnBlock3.Tag as string == "Player2"))
            {
                if (btnBlock1.Tag as string == "Player1")
                    return 0;
                else
                    return 1;
            }
            else if ((btnBlock4.Tag as string == "Player1" && btnBlock5.Tag as string == "Player1" && btnBlock6.Tag as string == "Player1") ||
               (btnBlock4.Tag as string == "Player2" && btnBlock5.Tag as string == "Player2" && btnBlock6.Tag as string == "Player2"))
            {
                if (btnBlock4.Tag as string == "Player1")
                    return 0;
                else
                    return 1;
            }
            else if ((btnBlock7.Tag as string == "Player1" && btnBlock8.Tag as string == "Player1" && btnBlock9.Tag as string == "Player1") ||
               (btnBlock7.Tag as string == "Player2" && btnBlock8.Tag as string == "Player2" && btnBlock9.Tag as string == "Player2"))
            {
                if (btnBlock7.Tag as string == "Player1")
                    return 0;
                else
                    return 1;
            }
            else if ((btnBlock1.Tag as string == "Player1" && btnBlock4.Tag as string == "Player1" && btnBlock7.Tag as string == "Player1") ||
               (btnBlock1.Tag as string == "Player2" && btnBlock4.Tag as string == "Player2" && btnBlock7.Tag as string == "Player2"))
            {
                if (btnBlock1.Tag as string == "Player1")
                    return 0;
                else
                    return 1;
            }
            else if ((btnBlock2.Tag as string == "Player1" && btnBlock5.Tag as string == "Player1" && btnBlock8.Tag as string == "Player1") ||
               (btnBlock2.Tag as string == "Player2" && btnBlock5.Tag as string == "Player2" && btnBlock8.Tag as string == "Player2"))
            {
                if (btnBlock2.Tag as string == "Player1")
                    return 0;
                else
                    return 1;
            }
            else if ((btnBlock3.Tag as string == "Player1" && btnBlock6.Tag as string == "Player1" && btnBlock9.Tag as string == "Player1") ||
               (btnBlock3.Tag as string == "Player2" && btnBlock6.Tag as string == "Player2" && btnBlock9.Tag as string == "Player2"))
            {
                if (btnBlock3.Tag as string == "Player1")
                    return 0;
                else
                    return 1;
            }
            else if ((btnBlock1.Tag as string == "Player1" && btnBlock5.Tag as string == "Player1" && btnBlock9.Tag as string == "Player1") ||
               (btnBlock1.Tag as string == "Player2" && btnBlock5.Tag as string == "Player2" && btnBlock9.Tag as string == "Player2"))
            {
                if (btnBlock1.Tag as string == "Player1")
                    return 0;
                else
                    return 1;
            }
            else if ((btnBlock3.Tag as string == "Player1" && btnBlock5.Tag as string == "Player1" && btnBlock7.Tag as string == "Player1") ||
               (btnBlock3.Tag as string == "Player2" && btnBlock5.Tag as string == "Player2" && btnBlock7.Tag as string == "Player2"))
            {
                if (btnBlock3.Tag as string == "Player1")
                    return 0;
                else
                    return 1;
            }
            else if(Blocks.Btn1 && Blocks.Btn2 && Blocks.Btn3 && Blocks.Btn4 && Blocks.Btn5 
                && Blocks.Btn6&& Blocks.Btn7&& Blocks.Btn8&& Blocks.Btn9)
            {
                return 2;
            }
            else return 3;

        }
        void GameOver()
        {
           Blocks.Btn1 = true;
           Blocks.Btn2 = true;
           Blocks.Btn3 = true;
           Blocks.Btn4 = true;
           Blocks.Btn5 = true;
           Blocks.Btn6 = true;
           Blocks.Btn7 = true;
           Blocks.Btn8 = true;
           Blocks.Btn9 = true;
        }
        void PrintWinnerAndMessage()
        {
            if (CheckGameWinner() == 0)
            {
                GameOver();
                lblWinner.Text = "Player 1";
                MessageBox.Show("Winner Is : Player 1", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CheckGameWinner() == 1)
            {
                GameOver();
                lblWinner.Text = "Player 2";
                MessageBox.Show("Winner Is : Player 2", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CheckGameWinner() == 2)
            {
                GameOver();
                lblWinner.Text = "Draw";
                MessageBox.Show("Draw", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void RestartGame()
        {
            //restart Counter
            PlayersCounter = 0;
            //restart player
            lblPlayer.Text = "Player 1";
            //restart Winner
            lblWinner.Text = "In Progress";
            //restart Buttons
            btnBlock1.BackgroundImage = Resources.question_mark_96;
            btnBlock2.BackgroundImage = Resources.question_mark_96;
            btnBlock3.BackgroundImage = Resources.question_mark_96;
            btnBlock4.BackgroundImage = Resources.question_mark_96;
            btnBlock5.BackgroundImage = Resources.question_mark_96;
            btnBlock6.BackgroundImage = Resources.question_mark_96;
            btnBlock7.BackgroundImage = Resources.question_mark_96;
            btnBlock8.BackgroundImage = Resources.question_mark_96;
            btnBlock9.BackgroundImage = Resources.question_mark_96;
            //restart Permissions
            Blocks.Btn1 = false;
            Blocks.Btn2 = false;
            Blocks.Btn3 = false;
            Blocks.Btn4 = false;
            Blocks.Btn5 = false;
            Blocks.Btn6 = false;
            Blocks.Btn7 = false;
            Blocks.Btn8 = false;
            Blocks.Btn9 = false;
            //Restart Tags
            btnBlock1.Tag = null;
            btnBlock2.Tag = null;
            btnBlock3.Tag = null;
            btnBlock4.Tag = null;
            btnBlock5.Tag = null;
            btnBlock6.Tag = null;
            btnBlock7.Tag = null;
            btnBlock8.Tag = null;
            btnBlock9.Tag = null;
        }

       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;

            Pen Pen = new Pen(White);
            Pen.Width = 10;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //Draw horizental Lines
            e.Graphics.DrawLine(Pen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(Pen, 400, 460, 1050, 460);
            //Draw Vertical Lines
            e.Graphics.DrawLine(Pen, 610, 140, 610, 620);
            e.Graphics.DrawLine(Pen, 840, 140, 840, 620);

        }

        private void btnBlock1_Click(object sender, EventArgs e)
        {
            
            if (Blocks.Btn1 != true)
            {
              
                if (PlayersCounter == 0)
                {
                    btnBlock1.BackgroundImage = Resources.X;
                    btnBlock1.Tag = "Player1";
                }
                else
                {
                    btnBlock1.BackgroundImage = Resources.O;
                    btnBlock1.Tag = "Player2";
                }
                    Blocks.Btn1 = true;
                UpdatePlayerTurns();
                PrintWinnerAndMessage();;
            }
            else
                WarningMessage();
            }

        private void btnBlock2_Click(object sender, EventArgs e)
        {
            if (Blocks.Btn2 != true)
            {
                if (PlayersCounter == 0)
                {
                    btnBlock2.BackgroundImage = Resources.X;
                    btnBlock2.Tag = "Player1";
                }
                else
                    {
                    btnBlock2.BackgroundImage = Resources.O;
                    btnBlock2.Tag = "Player2";
                }

                Blocks.Btn2 = true;
                UpdatePlayerTurns();
                PrintWinnerAndMessage();;
            }
            else
                WarningMessage();
        }

        private void btnBlock3_Click(object sender, EventArgs e)
        {
            if (Blocks.Btn3 != true)
            {
                
                if (PlayersCounter == 0)
                {
                    btnBlock3.BackgroundImage = Resources.X;
                    btnBlock3.Tag = "Player1";
                }
                else
                   { btnBlock3.BackgroundImage = Resources.O;
                    btnBlock3.Tag = "Player2";
                }
                Blocks.Btn3 = true;
                UpdatePlayerTurns();
                PrintWinnerAndMessage();;
            }
            else
                WarningMessage();
        }

        private void btnBlock4_Click(object sender, EventArgs e)
        {
            if (Blocks.Btn4 != true)
            {
               
                if (PlayersCounter == 0)
                {
                    btnBlock4.BackgroundImage = Resources.X;
                    btnBlock4.Tag = "Player1";
                }
                else
                   { btnBlock4.BackgroundImage = Resources.O;
                    btnBlock4.Tag = "Player2";
                }
                Blocks.Btn4 = true;
                PrintWinnerAndMessage();;
                UpdatePlayerTurns();
            }
            else
                WarningMessage();
        }

        private void btnBlock5_Click(object sender, EventArgs e)
        {
            if (Blocks.Btn5 != true)
            {
               
                if (PlayersCounter == 0)
                {
                    btnBlock5.BackgroundImage = Resources.X;
                    btnBlock5.Tag = "Player1";
                }
                else
                    { btnBlock5.BackgroundImage = Resources.O;
                    btnBlock5.Tag = "Player2";
                }
                Blocks.Btn5 = true;
                PrintWinnerAndMessage();;
                UpdatePlayerTurns();
            }
            else
                WarningMessage();
        }

        private void btnBlock6_Click(object sender, EventArgs e)
        {
            if (Blocks.Btn6 != true)
            {
               
                if (PlayersCounter == 0)
                {
                    btnBlock6.BackgroundImage = Resources.X;
                    btnBlock6.Tag = "Player1";
                }
                else
                    { btnBlock6.BackgroundImage = Resources.O;
                    btnBlock6.Tag = "Player2";
                }
                Blocks.Btn6 = true;
                PrintWinnerAndMessage();;
                UpdatePlayerTurns();
            }
            else
                WarningMessage();
        }

        private void btnBlock7_Click(object sender, EventArgs e)
        {
            if (Blocks.Btn7 != true)
            {
                
                if (PlayersCounter == 0)
                {
                    btnBlock7.BackgroundImage = Resources.X;
                    btnBlock7.Tag = "Player1";
                }
                else
                   { btnBlock7.BackgroundImage = Resources.O;
                    btnBlock7.Tag = "Player2";
                }
                Blocks.Btn7 = true;
                PrintWinnerAndMessage();;
                UpdatePlayerTurns();
            }
            else
                WarningMessage();
        }

        private void btnBlock8_Click(object sender, EventArgs e)
        {
            if (Blocks.Btn8 != true)
            {
                
                if (PlayersCounter == 0)
                {
                    btnBlock8.BackgroundImage = Resources.X;
                    btnBlock8.Tag = "Player1";
                }
                else
                  { btnBlock8.BackgroundImage = Resources.O;
                    btnBlock8.Tag = "Player2";
                }
                Blocks.Btn8 = true;
                PrintWinnerAndMessage();;
                UpdatePlayerTurns();
            }
            else
                WarningMessage();
        }

        private void btnBlock9_Click(object sender, EventArgs e)
        {
            if (Blocks.Btn9 != true)
            {
                
                if (PlayersCounter == 0)
                {
                    btnBlock9.BackgroundImage = Resources.X;
                    btnBlock9.Tag = "Player1";
                }
                else
                   { btnBlock9.BackgroundImage = Resources.O;
                    btnBlock9.Tag = "Player2";
                }
                Blocks.Btn9 = true;
                PrintWinnerAndMessage();;
                UpdatePlayerTurns();
            }
            else
                WarningMessage();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        
    }
}
