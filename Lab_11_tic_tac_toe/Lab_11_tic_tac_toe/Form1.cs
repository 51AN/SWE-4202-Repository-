using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11_tic_tac_toe
{
    public partial class Form1 : Form
    {

        bool turn = true;
        double turn_count = 0;

        bool player1Win = false;
        bool player2Win = false;

        double player1score = 0;
        double player2score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_onClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(turn)
            {
                btn.Text = "X";
                turn = false;
                turn_count++;
                
                
                if(turn_count == 9)
                {
                    MessageBox.Show("Draw!!");
                    UpdateLabel.Text = "--- --- --- --- ---";
                    refresh();
                    turn_count = 0;

                }

                winner_algo();
                


            }
            else
            {
                btn.Text = "O";
                turn = true;
                turn_count++;
                
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");
                    UpdateLabel.Text = "--- --- --- --- ---";
                    refresh();
                    turn_count = 0;

                }

                winner_algo();
                
                
            }

            if (player2Win == true)
            {
                
                player2score++;
                Player2Label.Text = player2score.ToString();
                turn_count = 0;
                player2Win = false;

            }
            else if(player1Win == true)
            {
                
                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }

            
        }

        public void refresh()
        {
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";
        }

        public void winner_algo()
        {


            if ((button11.Text == button12.Text) && (button12.Text == button13.Text) && (button11.Text != "")&& (button12.Text != "")&& (button13.Text != ""))
            {
                if (button11.Text == "X")
                {

                    MessageBox.Show("Player 1 wins!!!");
                    UpdateLabel.Text = "Player 1 has won";
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Player 2 wins!!!");
                    player2Win=true;
                }

                refresh();


            }

            if ((button21.Text == button22.Text) && (button22.Text == button23.Text) && (button21.Text != "") && (button22.Text != "") && (button23.Text != ""))
            {
                if (button21.Text == "X")
                {
                    MessageBox.Show("Player 1 wins!!!");
                    UpdateLabel.Text = "Player 1 has won";
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Player 2 wins!!!");
                    UpdateLabel.Text = "Player 2 has won";
                    player2Win = true;
                }
                refresh();

            }

            if ((button31.Text == button32.Text) && (button32.Text == button33.Text) && (button31.Text != "") && (button32.Text != "") && (button33.Text != ""))
            {
                if (button31.Text == "X")
                {
                    MessageBox.Show("Player 1 wins!!!");
                    UpdateLabel.Text = "Player 1 has won";
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Player 2 wins!!!");
                    UpdateLabel.Text = "Player 2 has won";
                    player2Win = true;
                }
                refresh();
            }

            if ((button11.Text == button21.Text) && (button21.Text == button31.Text) && (button11.Text != "") && (button21.Text != "") && (button31.Text != ""))
            {
                if (button11.Text == "X")
                {
                    MessageBox.Show("Player 1 wins!!!");
                    UpdateLabel.Text = "Player 1 has won";
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Player 2 wins!!!");
                    UpdateLabel.Text = "Player 2 has won";
                    player2Win = true;
                }
                refresh();
            }

            if ((button12.Text == button22.Text) && (button22.Text == button32.Text) && (button12.Text != "") && (button22.Text != "") && (button32.Text != ""))
            {
                if (button12.Text == "X")
                {
                    MessageBox.Show("Player 1 wins!!!");
                    UpdateLabel.Text = "Player 1 has won";
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Player 2 wins!!!");
                    UpdateLabel.Text = "Player 2 has won";
                    player2Win = true;
                }
                refresh();
            }
            if ((button13.Text == button23.Text) && (button23.Text == button33.Text) && (button13.Text != "") && (button23.Text != "") && (button33.Text != ""))
            {
                if (button13.Text == "X")
                {
                    MessageBox.Show("Player 1 wins!!!");
                    UpdateLabel.Text = "Player 1 has won";
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Player 2 wins!!!");
                    UpdateLabel.Text = "Player 2 has won";
                    player2Win = true;
                }
                refresh();
            }
            if ((button11.Text == button22.Text) && (button22.Text == button33.Text) && (button11.Text != "") && (button22.Text != "") && (button33.Text != ""))
            {
                if (button11.Text == "X")
                {
                    MessageBox.Show("Player 1 wins!!!");
                    UpdateLabel.Text = "Player 1 has won";
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Player 2 wins!!!");
                    UpdateLabel.Text = "Player 2 has won";
                    player2Win = true;
                }
                refresh();
            }
            if ((button13.Text == button22.Text) && (button22.Text == button31.Text) && (button13.Text != "") && (button22.Text != "") && (button31.Text != ""))
            {
                if (button13.Text == "X")
                {
                    MessageBox.Show("Player 1 wins!!!");
                    UpdateLabel.Text = "Player 1 has won";
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Player 2 wins!!!");
                    UpdateLabel.Text = "Player 2 has won";
                    player2Win = true;
                }
                refresh();

            }
        }

        
    }
}
