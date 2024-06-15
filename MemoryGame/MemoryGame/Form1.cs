using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {

        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>(); // 픽쳐박스 객체의 리스트
        PictureBox picA;
        PictureBox picB;
        int totalTime = 60;
        int countDownTime;
        bool gameOver = false;


        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("졸업 시험 시작합니다.");
            LoadPictures();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            countDownTime--;

            lblTimeLeft.Text = "Time Left : " + countDownTime;

            if (countDownTime < 1)
            {
                GameOver("이대로 졸업은 불가합니다. 재도전하세요.");

                foreach (PictureBox x in pictures)
                {
                    if (x.Tag != null)
                    {
                            string fileName = (string)x.Tag + ".png";
                            string filePath = @"C:\C#project(3-1)\MemoryGame\MemoryGame\bin\Debug\" + fileName;
                            x.Image = Image.FromFile(filePath);   
                    }
                }
            }
        }

        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void LoadPictures()
        {
            int leftPos = 30;
            int topPos = 30;
            int rows = 0;

            for (int i = 0; i < 20; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 50;
                newPic.Width = 50;
                newPic.BackColor = Color.LightGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 4)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 60;
                }

                if (rows == 4)
                {
                    leftPos = 30;
                    topPos += 60;
                    rows = 0;
                }
            }

            RestartGame();
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return; // dont register a click if the game is over
            }

            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    string fileName = (string)picA.Tag + ".png";
                    string filePath = @"C:\C#project(3-1)\MemoryGame\MemoryGame\bin\Debug\" + fileName;
                    picA.Image = Image.FromFile(filePath);

                    firstChoice = (string)picA.Tag;
                }
            }
            else if (secondChoice == null)
            {
                picB = sender as PictureBox;

                if (picB.Tag != null && picB.Image == null)
                {
                    string fileName = (string)picB.Tag + ".png";
                    string filePath = @"C:\C#project(3-1)\MemoryGame\MemoryGame\bin\Debug\" + fileName;
                    picB.Image = Image.FromFile(filePath);

                    secondChoice = (string)picB.Tag;
                }
            }
            else
            {
                CheckPictures(picA, picB);
            }
        }

        private void RestartGame()
        {
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList(); // randomise the original list
            numbers = randomList;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }

            tries = 0;
            lblStatus.Text = "Mismatched: " + tries + " times.";
            lblTimeLeft.Text = "Time Left: " + totalTime;
            gameOver = false;
            GameTimer.Start();
            countDownTime = totalTime;
        }

        private void CheckPictures(PictureBox A, PictureBox B)
        {
            if (firstChoice == secondChoice)
            {
                A.Tag = null;
                B.Tag = null;
            }
            else
            {
                tries++;
                lblStatus.Text = "Mismatched " + tries + " times.";
            }

            firstChoice = null;
            secondChoice = null;

            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            // lets check if all of the items have been solved
            if (pictures.All(o => o.Tag == pictures[0].Tag))
            {
                GameOver("졸업 요건 달성 !");
            }
        }

        private void GameOver(string msg)
        {
            GameTimer.Stop();
            gameOver = true;
            MessageBox.Show(msg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}