using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
       public enum Player 
        {
            X,O
        }
        int PlayerWinCounts = 0;
        int Player2WinCount = 0;
        List<Button> buttons;
        Player currentPlayer = Player.X;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void PlayerClickButtons(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button == null || !button.Enabled)
                return;

            if (currentPlayer == Player.X)
                button.Text = "X";
            else
                button.Text = "O";

                button.BackColor = DefaultBackColor;
                button.Enabled = false;
                buttons.Remove(button);
                CheckingGame();
            currentPlayer =( currentPlayer == Player.X )? Player.O : Player.X;
        }
        private void CheckingGame()
        {
            if(button0.Text=="X"&& button1.Text == "X" && button2.Text == "X" ||
                button3.Text == "X" && button4.Text == "X" && button5.Text == "X" ||
                button6.Text == "X" && button7.Text == "X" && button8.Text == "X" ||
                button0.Text == "X" && button3.Text == "X" && button6.Text == "X" ||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button0.Text == "X" && button4.Text == "X" && button8.Text == "X" ||
                button2.Text == "X" && button4.Text == "X" && button6.Text == "X")
            {
                PlayerWinCounts++;
                lblPlayer1.Text = $"巴石 Wins: {PlayerWinCounts}";
                MessageBox.Show("巴石 Wins!");
               
                
            }
            else if (button0.Text=="O" && button1.Text == "O" && button2.Text =="O" ||
               button3.Text == "O" && button4.Text == "O" && button5.Text == "O" ||
               button6.Text == "O" && button7.Text == "O" && button8.Text == "O" ||
               button0.Text == "O" && button3.Text == "O" && button6.Text == "O" ||
               button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
               button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
               button0.Text == "O" && button4.Text == "O" && button8.Text == "O" ||
               button2.Text == "O" && button4.Text == "O" && button6.Text == "O")
            {
                Player2WinCount++;
                MessageBox.Show("Player2 Wins!");
                lblPlayer2.Text = $"萨姆 Wins: {Player2WinCount}";
                

            }
            else if(buttons.Count==0)
            {
                MessageBox.Show("Draw!");
                lblDrawG.Text = $"Draws: {PlayerWinCounts+ Player2WinCount}";
            
            }

        }
        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            buttons = new List<Button> { button0,button1,button2,button3,button4,
               button5,button6,button7,button8};

            foreach(Button x in buttons)
            {
                x.Enabled = true;
                x.Text="?";
                x.BackColor = DefaultBackColor;
            }
        }

        
    }
}
