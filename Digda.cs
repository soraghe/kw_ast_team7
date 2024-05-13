using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchDigda
{
    public partial class Digda : Form
    {
        private bool started = false;

        private int remainingSeconds = 60;
        private int score = 0;
        private int CreatenormalMoleCount = 0;
        private int CreateadvancedMoleCount = 0;
        private int ClickednoramlMoleCount = 0;
        private int ClickedadvancedMoleCount = 0;

        private List<PictureBox> holes = new List<PictureBox>();
        private Image moleImage = Properties.Resources.Digda;
        private Image advancedMoleImage = Properties.Resources.Dugtrio;
        private Image emptyGroundImage = Properties.Resources.emptyground;
        private Random random = new Random();

        public Digda()
        {
            InitializeComponent();
            InitializeHoles();
        }

        private void InitializeHoles()
        {
            holes.Add(pictureBox1);
            holes.Add(pictureBox2);
            holes.Add(pictureBox3);
            holes.Add(pictureBox4);
            holes.Add(pictureBox5);
            holes.Add(pictureBox6);
            holes.Add(pictureBox7);
            holes.Add(pictureBox8);
            holes.Add(pictureBox9);

            pgbTime.Minimum = 0;
            pgbTime.Maximum = remainingSeconds;
            pgbTime.Value = (60 - remainingSeconds);

            foreach (PictureBox p in holes) {
                p.Image = emptyGroundImage;
                p.Click += HoleClicked;
            }
        }

        private void tmrRound_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            lblRoundTimer.Text = string.Format("{0:D2} : {1:D2}", remainingSeconds / 60, remainingSeconds % 60);
            pgbTime.Value = 60 - remainingSeconds;
        }

        private void HoleClicked(object sender, EventArgs e)
        {
            PictureBox clickedHole = (PictureBox)sender;

            if (clickedHole.Image == emptyGroundImage) { 
                return;
            }

            if (clickedHole.Image == moleImage) {
                ClickednoramlMoleCount++;
            } else if (clickedHole.Image == advancedMoleImage) {
                ClickedadvancedMoleCount++;
            }

            int clickedscore = (int)clickedHole.Tag;
            this.score += clickedscore;

            lblScore.Text = "Score : " + this.score.ToString() + " ( +" + clickedscore.ToString() + " ! )";
            lblNormalCount.Text = ": " + ClickednoramlMoleCount.ToString() + " / " + CreatenormalMoleCount.ToString();
            lblAdvanceCount.Text = ": " + ClickedadvancedMoleCount.ToString() + " / " + CreateadvancedMoleCount.ToString();

            // 점수 반영 이후, 사라지는 과정 (순서 변경 x)
            clickedHole.Image = emptyGroundImage;
            clickedHole.Tag = null;
        }

        private void ShowMole(PictureBox hole, Image molePic, int score) {
            hole.Image = molePic;
            hole.Tag = score;
            
            if (molePic == moleImage)
            {
                CreatenormalMoleCount++;
            }
            else if (molePic == advancedMoleImage)
            {
                CreateadvancedMoleCount++;
            }
        }
        private async void StartGame()
        {
            started = true;
            score = 0;
            foreach (PictureBox mole in holes) {
                mole.Visible = true;
                mole.Enabled = true;
            }
            if (remainingSeconds != 0) { 
                btnStart.Enabled = false;
            }

            while (true)
            {
                int remainingTime = remainingSeconds;
                int waitTime = 0;

                if (remainingTime > 30) {
                    waitTime = 1000;
                } 
                else if (remainingTime > 15) {
                    waitTime = 700;
                }
                else {
                    waitTime = 500;
                }

                List<PictureBox> selectedHoles = new List<PictureBox>();

                while (selectedHoles.Count < 2) {
                    PictureBox moleHole = holes[random.Next(holes.Count)];
                    if (!selectedHoles.Contains(moleHole))
                    {
                        selectedHoles.Add(moleHole);
                    }
                }

                foreach (PictureBox hole in selectedHoles)
                {
                    int moletype = random.Next(100);
                    if (moletype < 20) { // 20% 확률
                        ShowMole(hole, advancedMoleImage, 3);
                    }
                    else { // 80% 확률
                        ShowMole(hole, moleImage, 1);
                    }
                }
                await Task.Delay(waitTime);

                foreach (PictureBox hole in holes) {
                    hole.Image = emptyGroundImage;
                }

                if (remainingSeconds == 0)
                {
                    ResetGame();
                    MessageBox.Show("Time Finished!\n\nScore : " + (score).ToString(), "Finished!", MessageBoxButtons.OK);
                    btnStart.Enabled = true;
                }
            }
        }

        private void ResetGame()
        {
            started = false;

            tmrRound.Stop();
            remainingSeconds = 60;
            foreach (PictureBox mole in holes) {
                mole.Visible = false;
                mole.Enabled = false;
            }
            CreatenormalMoleCount = 0;
            CreateadvancedMoleCount = 0;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            tmrRound.Start();
            StartGame();
        }
    }
}
