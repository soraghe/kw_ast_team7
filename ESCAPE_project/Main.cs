using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using CatchDigda;
using MemoryGame;
using sokoban;
using LeftOrRightGame;

namespace ESCAPE_project
{
    public partial class Main : System.Windows.Forms.Form
    {
        private PictureBox Introscreen;
        private PictureBox passImage;
        private PictureBox failImage;
        private Image Mainscreen = Properties.Resources.pj_mainpage;

        private bool game1_finished = false;
        private bool game2_finished = false;
        private bool game3_finished = false;
        private bool game4_finished = false;

        private int game1_score = 0;
        private int game2_score = 0;
        private int game3_score = 0;
        private int game4_score = 0;

        public Main()
        {
            InitializeComponent();
            InitializeIntroScreen();
            SetBackGroundImage();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.ClientSize = new Size(1280, 720);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            totalTimer.Start();
        }

        private void InitializeIntroScreen()
        {
            Introscreen = new PictureBox();
            Introscreen.Image = Properties.Resources.pj_startpage;
            Introscreen.Dock = DockStyle.Fill;
            Introscreen.Size = new Size(1280, 720);
            Introscreen.SizeMode = PictureBoxSizeMode.Normal;
            Introscreen.Click += new EventHandler(Introscreen_Click);

            Introscreen.Location = new Point((this.ClientSize.Width - Introscreen.Width) / 2, (this.ClientSize.Height - Introscreen.Height) / 2);

            this.Controls.Add(Introscreen);
            this.Controls.SetChildIndex(Introscreen, 0);
        }

        private void Introscreen_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(Introscreen);
            Introscreen.Dispose();
        }

        private void SetBackGroundImage()
        {
            Bitmap bitmap = new Bitmap(Mainscreen.Width, Mainscreen.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = 0.8f;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(Mainscreen, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                            0, 0, Mainscreen.Width, Mainscreen.Height,
                            GraphicsUnit.Pixel, attributes);
            }
            this.BackgroundImage = bitmap;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void picGame1_Click(object sender, EventArgs e)
        {
            sokoban.Form1 sokoban = new sokoban.Form1();
            DialogResult d1Result = sokoban.ShowDialog();
            if (d1Result == DialogResult.Cancel)
            {
                MessageBox.Show("푸시푸시 종료!", "Game01 Finished!");
                game1_score = sokoban.final_score;
                lblGame1Score.Text = "SCORE: " + game1_score.ToString();
                game1_finished = true;
                ButtonState();
            }
        }

        private void picGame2_Click(object sender, EventArgs e)
        {
            LeftOrRightGame.Form LorR = new LeftOrRightGame.Form();
            DialogResult d2Result = LorR.ShowDialog();
            if (d2Result == DialogResult.Cancel)
            {
                MessageBox.Show("좌로우로 종료!", "Game02 Finished!");
                game2_score = LorR.final_score;
                lblGame2Score.Text = "SCORE: " + game2_score.ToString();

                game2_finished = true;
                ButtonState();
            }
        }
        private void picGame3_Click(object sender, EventArgs e)
        {
            Digda digda = new Digda();
            DialogResult d3Result = digda.ShowDialog();
            if (d3Result == DialogResult.Cancel)
            {
                MessageBox.Show("두더지 잡기 종료!", "Game03 Finished!");
                game3_score = digda.final_score;
                lblGame3Score.Text = "SCORE: " + game3_score.ToString();

                game3_finished = true;
                ButtonState();
            }
        }
        private void picGame4_Click(object sender, EventArgs e)
        {
            MemoryGame.Form1 memorygame = new MemoryGame.Form1();
            DialogResult d4Result = memorygame.ShowDialog();
            if (d4Result == DialogResult.Cancel)
            {
                MessageBox.Show("메모리 게임 종료!", "Game04 Finished!");
                game4_score = memorygame.finalScore;
                lblGame4Score.Text = "SCORE: " + game4_score.ToString();
                game4_finished = true;
                ButtonState();
            }
        }

        private void totalTimer_Tick(object sender, EventArgs e)
        {
            ButtonState();
        }
        private void ButtonState()
        {
            if (game1_finished && game2_finished && game3_finished && game4_finished)
            {
                btnGOTOfinal.Enabled = true;
            }
            else
            {
                btnGOTOfinal.Enabled = false;
            }
        }

        private void Checkscores()
        {
            int total_score = game1_score + game2_score + game3_score + game4_score;

            // 기준 점수 변동 가능
            if (total_score >= 300)
            {
                string message = string.Format("Game 1 Score: {0}\nGame 2 Score: {1}\nGame 3 Score: {2}\nGame 4 Score: {3}\n\nTotal Score: {4}\n\nCongratulations! You passed!",
                                       game1_score, game2_score, game3_score, game4_score, total_score);
                MessageBox.Show(message, "Pass!");

                passImage = new PictureBox();
                passImage.Image = Properties.Resources.pj_pass;
                passImage.Dock = DockStyle.Fill;
                passImage.SizeMode = PictureBoxSizeMode.Zoom;
                passImage.Click += (sender, e) => { Application.Exit(); };

                this.Controls.Add(passImage);
                passImage.BringToFront();
            }
            else
            {
                string message = string.Format("Game 1 Score: {0}\nGame 2 Score: {1}\nGame 3 Score: {2}\nGame 4 Score: {3}\n\nTotal Score: {4}\n\nSorry, you did not pass.",
                                       game1_score, game2_score, game3_score, game4_score, total_score);
                MessageBox.Show(message, "Fail!");

                failImage = new PictureBox();
                failImage.Image = Properties.Resources.pj_fail;
                failImage.Dock = DockStyle.Fill;
                failImage.SizeMode = PictureBoxSizeMode.Zoom;
                failImage.Click += (sender, e) => { Application.Exit(); };

                this.Controls.Add(failImage);
                failImage.BringToFront();
            }
        }

        private void btnGOTOfinal_Click(object sender, EventArgs e)
        {
            Checkscores();
        }

        private void btnIntroduction_Click(object sender, EventArgs e)
        {
            Description ds = new Description();
            DialogResult dsResult = ds.ShowDialog();
            if (dsResult == DialogResult.OK)
            {
                MessageBox.Show("그럼 최선을 다해주세요!", "Cheering Message!");
            }
            else if (dsResult == DialogResult.Cancel)
            {
                MessageBox.Show("제대로 확인하셨나요?", "Checking Message!");
            }
        }
    }
}
