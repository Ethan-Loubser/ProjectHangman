using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace ProjectHangman
{
    public partial class Form1 : Form
    {
        private string word;          
        private int YourScore;
        private int LoopCount;
        int word1BS = 10;
        int word2BS = 10;
        int word3BS = 10;

        SortedList<string, int> BestScores = new SortedList<string, int>();
        SortedList CorLetters = new SortedList();
        ArrayList IncorLetters = new ArrayList();
        ArrayList Pictures = new ArrayList();
        ArrayList words = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            BestScores.Add("Word1 best score", word1BS);
            BestScores.Add("Word2 best score", word2BS);
            BestScores.Add("Word3 best score", word3BS);
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            //Each time the NewGameButton is clicked, a random word is chosen from an array.
            //The best score of that word is then displayed on the interface and all others labels,
            //on the interface is reset.

            HangManPB.Image = null;

            CorLetters.Clear();
            IncorLetters.Clear();

            words.Add("HANGING");
            words.Add("GALLOWS");
            words.Add("SWINGIN");

            #region HangMan pictures
            Pictures.Add("HangMan1.png");
            Pictures.Add("HangMan2.png");
            Pictures.Add("HangMan3.png");
            Pictures.Add("HangMan4.png");
            Pictures.Add("HangMan5.png");
            Pictures.Add("HangMan6.png");
            Pictures.Add("HangMan7.png");
            Pictures.Add("HangMan8.png");
            Pictures.Add("HangMan9.png");
            Pictures.Add("HangMan10.png");
            #endregion
            
            YourScore = 0;
            LoopCount = 0;

            #region Label reset
            lblBestScore.Text = " ";
            lblYourScore.Text = " ";
            
            lblLetter1.Text = "?";
            lblLetter2.Text = "?";
            lblLetter3.Text = "?";
            lblLetter4.Text = "?";
            lblLetter5.Text = "?";
            lblLetter6.Text = "?";
            lblLetter7.Text = "?";

            lblStrike1.Text = " ";
            lblStrike2.Text = " ";
            lblStrike3.Text = " ";
            lblStrike4.Text = " ";
            lblStrike5.Text = " ";
            lblStrike6.Text = " ";
            lblStrike7.Text = " ";
            lblStrike8.Text = " ";
            lblStrike9.Text = " ";
            lblStrike10.Text = " ";
            #endregion

            for (int i = 0; i < 10; i++)
            {
                IncorLetters.Add(" ");
            }

            Random rnd = new Random();
            int r = rnd.Next(0, 3);
            word = (string)words[r];

            #region Score label reset
            if (word == "HANGING" )
            {
                lblBestScore.Text = word1BS.ToString();
            }
            else if (word == "GALLOWS")
            {
                lblBestScore.Text = word2BS.ToString();
            }
            else
            {
                lblBestScore.Text = word3BS.ToString();
            }
            #endregion

        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //When a Key is pressed a switch case statement compares the key pressed with the letters
            // In the word to be guesses. If correct then the label exposes the letter within the word
            //on the interface. If incorrect then that letter is displayd as an incorrect letter on the
            //interface
            
            char letter = (char)e.KeyData;

            if (word == "HANGING")
            {
                switch (letter)
                {
                    case (char)Keys.H:
                        lblLetter1.Text = "H";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter1", letter);
                        break;
                    case (char)Keys.A:
                        lblLetter2.Text = "A";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter2", letter);
                        break;
                    case (char)Keys.N:
                        lblLetter3.Text = "N";
                        lblLetter6.Text = "N";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter3", letter);
                        CorLetters.Add("Letter6", letter);
                        break;
                    case (char)Keys.I:
                        lblLetter5.Text = "I";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter5", letter);
                        break;
                    case (char)Keys.G:
                        lblLetter4.Text = "G";
                        lblLetter7.Text = "G";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter4", letter);
                        CorLetters.Add("Letter7", letter);
                        break;
                    default:
                        for (int loop = 0; loop < 1; loop++)
                        {
                            IncorLetters[LoopCount] = string.Copy(letter.ToString());
                            HangManPB.Image = Image.FromFile(Pictures[LoopCount].ToString());
                            LoopCount += 1;
                        }
                        lblStrike1.Text = IncorLetters[0].ToString();
                        lblStrike2.Text = IncorLetters[1].ToString();
                        lblStrike3.Text = IncorLetters[2].ToString();
                        lblStrike4.Text = IncorLetters[3].ToString();
                        lblStrike5.Text = IncorLetters[4].ToString();
                        lblStrike6.Text = IncorLetters[5].ToString();
                        lblStrike7.Text = IncorLetters[6].ToString();
                        lblStrike8.Text = IncorLetters[7].ToString();
                        lblStrike9.Text = IncorLetters[8].ToString();
                        lblStrike10.Text = IncorLetters[9].ToString();
                        break;
                }
            }
            else if (word == "GALLOWS" )
            {
                switch (letter)
                {
                    case (char)Keys.G:
                        lblLetter1.Text = "G";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter1", letter);
                        break;
                    case (char)Keys.A:
                        lblLetter2.Text = "A";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter2", letter);
                        break;
                    case (char)Keys.L:
                        lblLetter3.Text = "L";
                        lblLetter4.Text = "L";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter3", letter);
                        CorLetters.Add("Letter4", letter);
                        break;
                    case (char)Keys.O:
                        lblLetter5.Text = "O";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter5", letter);
                        break;
                    case (char)Keys.W:
                        lblLetter6.Text = "W";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter6", letter);
                        break;
                    case (char)Keys.S:
                        lblLetter7.Text = "S";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter7", letter);
                        break;
                    default:
                        for (int loop = 0; loop < 1; loop++)
                        {
                            IncorLetters[LoopCount] = string.Copy(letter.ToString());
                            HangManPB.Image = Image.FromFile(Pictures[LoopCount].ToString());
                            LoopCount += 1;
                        }
                        lblStrike1.Text = IncorLetters[0].ToString();
                        lblStrike2.Text = IncorLetters[1].ToString();
                        lblStrike3.Text = IncorLetters[2].ToString();
                        lblStrike4.Text = IncorLetters[3].ToString();
                        lblStrike5.Text = IncorLetters[4].ToString();
                        lblStrike6.Text = IncorLetters[5].ToString();
                        lblStrike7.Text = IncorLetters[6].ToString();
                        lblStrike8.Text = IncorLetters[7].ToString();
                        lblStrike9.Text = IncorLetters[8].ToString();
                        lblStrike10.Text = IncorLetters[9].ToString();
                        break;
                }
            }
            else if (word == "SWINGIN")
            {
                switch (letter)
                {
                    case (char)Keys.S:
                        lblLetter1.Text = "S";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter1", letter);
                        break;
                    case (char)Keys.W:
                        lblLetter2.Text = "W";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter2", letter);
                        break;
                    case (char)Keys.I:
                        lblLetter3.Text = "I";
                        lblLetter6.Text = "I";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter3", letter);
                        CorLetters.Add("Letter6", letter);
                        break;
                    case (char)Keys.N:
                        lblLetter4.Text = "N";
                        lblLetter7.Text = "N";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter4", letter);
                        CorLetters.Add("Letter7", letter);
                        break;
                    case (char)Keys.G:
                        lblLetter5.Text = "G";
                        YourScore += 1;
                        lblYourScore.Text = YourScore.ToString();
                        CorLetters.Add("Letter5", letter);
                        break;
                    default:
                        for (int loop = 0; loop < 1; loop++)
                        {
                            IncorLetters[LoopCount] = string.Copy(letter.ToString());
                            HangManPB.Image = Image.FromFile(Pictures[LoopCount].ToString());
                            LoopCount += 1;
                        }
                        lblStrike1.Text = IncorLetters[0].ToString();
                        lblStrike2.Text = IncorLetters[1].ToString();
                        lblStrike3.Text = IncorLetters[2].ToString();
                        lblStrike4.Text = IncorLetters[3].ToString();
                        lblStrike5.Text = IncorLetters[4].ToString();
                        lblStrike6.Text = IncorLetters[5].ToString();
                        lblStrike7.Text = IncorLetters[6].ToString();
                        lblStrike8.Text = IncorLetters[7].ToString();
                        lblStrike9.Text = IncorLetters[8].ToString();
                        lblStrike10.Text = IncorLetters[9].ToString();
                        break;
                }
            }
            // With each key press a check is made to see if all letters have been guessed.After all
            // the letters have been guessed an if statement checks if user has beat the best score
            // of that word.
            if (CorLetters.Count == 7)
            {
                if (word == "HANGING")
                {
                    if (YourScore < word1BS)
                    {
                        word1BS = YourScore;
                    }

                }
                else if (word == "GALLOWS")
                {
                    if (YourScore < word2BS)
                    {
                        word2BS = YourScore;
                    }
                }
                else
                {
                    if (YourScore < word3BS)
                    {
                        word3BS = YourScore;
                    }
                }
                // Message boxes to display whether a person has won or lost the game.

                MessageBox.Show("YOU HAVE BEEN PARDONED!");
            }
            else if (LoopCount == 10)
            {
                MessageBox.Show("YOU HAVE BEEN HANGED!");
            }
        }
        
    }
}
