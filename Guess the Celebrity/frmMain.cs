using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Guess_the_Celebrity
{
    public partial class frmMain : Form
    {     
        private int countdown = 30;
        private int score = 0;
        private string answer = null;
        private Button[] choiceButtons = new Button[4];
        List<string> celebrityList = new List<string>();
        List<string> asked = new List<string>();
        List<string> wrongAnswers = new List<string>();


        public frmMain()
        {
            InitializeComponent();
            celebrityList.Add("Tom_Cruise");       //0
            celebrityList.Add("Roger_Federer");
            celebrityList.Add("Cristiano_Ronaldo");
            celebrityList.Add("Lionel_Messi");
            celebrityList.Add("LeBron_James");
            celebrityList.Add("Dwayne_Johnson");
            celebrityList.Add("Ryan_Reynolds");
            celebrityList.Add("Taylor_Swift");
            celebrityList.Add("Rolling_Stones");    //BUG
            celebrityList.Add("Ben_Affleck");
            celebrityList.Add("Lewis_Hamilton");   //10
            celebrityList.Add("Jennifer_Lopez");   //11
            celebrityList.Add("Will_Smith");
            celebrityList.Add("Celine_Dion");
            celebrityList.Add("Jackie_Chan");
            celebrityList.Add("Rafael_Nadal");
            celebrityList.Add("Lady_Gaga");
            celebrityList.Add("Naomi_Osaka");
            celebrityList.Add("Oprah_Winfrey");
            celebrityList.Add("Angelina_Jolie");
            celebrityList.Add("Serena_Williams");  //20
            choiceButtons[0] = btnA;
            choiceButtons[1] = btnB;
            choiceButtons[2] = btnC;
            choiceButtons[3] = btnD;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            startGame();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (countdown == 0)
            {
                MessageBox.Show("Time is up!", "Info");
                timer.Stop();
            } else
            {
                lblTime.Text = countdown--.ToString();
            } 
            
        }

        private void startGame()    //TODO: Oyunu başlatacak
        {
            lblScore.Text = "00";
            generateQuestion();
            generateChoices();
            timer.Start();

        }

        private void generateChoices()
        {
            int[] choiceIndexes = new int[4];
            Random random = new Random();
            int answerIndex = random.Next(0, 3);

            for (int i = 0; i <= 3; i++)
            {
                if (i == answerIndex)
                {
                    continue;
                } else
                {
                    choiceIndexes[i] = random.Next(0, celebrityList.Count);
                    choiceButtons[i].Text = celebrityList[(choiceIndexes[i])].Replace("_", " ");
                    wrongAnswers.Add(celebrityList[choiceIndexes[i]]);
                    celebrityList.Remove(celebrityList[choiceIndexes[i]]);
                }
            }
            choiceButtons[answerIndex].Text = answer;
            wrongAnswers.Remove(celebrityList[answerIndex]);
        }

        private void generateQuestion()
        {
            Random random = new Random();
            int answerIndex = random.Next(0, celebrityList.Count);
            string randomCelebrity = celebrityList[answerIndex];
            string questionLink = "https://en.wikipedia.org/w/api.php?action=query&titles=" +
                randomCelebrity + "&prop=pageimages&format=json&pithumbsize=500";
            
            string json = new WebClient().DownloadString(questionLink);

            JsonTextReader jsonTextReader = new JsonTextReader(new StringReader(json));

            while (jsonTextReader.Read())
            {
                if (jsonTextReader.Value != null)
                {
                    if (jsonTextReader.Value.ToString().Contains("https"))
                    {
                        pbCelebrity.ImageLocation = jsonTextReader.Value.ToString();
                        //Debug.WriteLine("Token: {0}, Value: {1}", jsonTextReader.TokenType, jsonTextReader.Value);
                    }
                }
            }
            answer = randomCelebrity.Replace("_", " ");
            asked.Add(celebrityList[answerIndex]);
            celebrityList.Remove(celebrityList[answerIndex]);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == answer)
            {
                btnA.BackColor = Color.Green;
                score++;
            } else
            {
                btnA.BackColor = Color.Red;
                score--;
            }
            lblScore.Text = score.ToString();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == answer)
            {
                btnB.BackColor = Color.Green;
                score++;
            } else
            {
                btnB.BackColor = Color.Red;
                score--;
            }
            lblScore.Text = score.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == answer)
            {
                btnC.BackColor = Color.Green;
                score++;
            } else
            {
                btnC.BackColor = Color.Red;
                score--;
            }
            lblScore.Text = score.ToString();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == answer)
            {
                btnD.BackColor = Color.Green;
                score++;
            } else
            {
                btnD.BackColor = Color.Red;
                score--;
            }
            lblScore.Text = score.ToString();
        }
    }
}