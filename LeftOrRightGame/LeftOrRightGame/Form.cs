using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LeftOrRightGame
{
    public partial class Form : System.Windows.Forms.Form
    {

        private DateTime startTime;

        private int score = 0;
        private List<PictureBox> items = new List<PictureBox>();
        private Random random = new Random();

        public Form()
        {
            InitializeComponent();
            this.KeyPreview = true;
            InitializeGame();

            TimerStart_Click(this, EventArgs.Empty); // 타이머 초기화 및 시작

        }

        private void InitializeGame()
        {
            LoadItems();
            UpdateScore();
            TimerStart_Click(this, EventArgs.Empty); // 타이머 초기화 및 시작
        }

        private void LoadItems()
        {
            items.Clear(); // 기존 아이템 리스트를 클리어
            for (int i = 0; i < 6; i++) // 초기에 6개의 아이템을 생성
            {
                CreateNewItem();
            }
        }

        private void CreateNewItem()
        {
            PictureBox newItem = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point(ClientSize.Width / 2 - 25, -60), // 초기 위치 (화면 위로 숨김)
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = random.Next(2) == 0 ? Properties.Resources.civa3 : Properties.Resources.laughingcat3
            };

            newItem.Tag = newItem.Image == Properties.Resources.civa3 ? "A" : "B";
            this.Controls.Add(newItem);
            items.Add(newItem); // 새 아이템을 리스트의 끝에 추가
            UpdateItemsPosition(); // 아이템 위치 업데이트
        }

        private void CheckItem(string type)
        {
            // 맨 아래 아이템(리스트의 첫 번째 아이템) 검사
            if (items.Count > 0 && (string)items[0].Tag == type)
            {
                PictureBox itemToRemove = items[0];
                this.Controls.Remove(itemToRemove);
                items.RemoveAt(0); // 가장 아래 아이템 제거
                itemToRemove.Dispose();

                score += 1;
                UpdateScore();
            }

            CreateNewItem(); // 맨 위에 새 아이템 추가
        }
        private void UpdateItemsPosition()
        {

            for (int i = 0; i < items.Count; i++)
            {
                items[i].Location = new Point(items[i].Location.X, (5 - i) * 60);
            }
        }

        private void UpdateScore()
        {
            lblScore1.Text = $"Score: {score}";
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            CheckItem("A");
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            CheckItem("B");
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Left)
            {
                BtnLeft.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                BtnRight.PerformClick();
                e.Handled = true;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            TimeSpan totalGameTime = TimeSpan.FromSeconds(30);
            TimeSpan remainingTime = totalGameTime - elapsed;

            if (remainingTime.TotalSeconds <= 0)
            {
                remainingTime = TimeSpan.Zero;
                gameTimer.Stop();
                MessageBox.Show($"게임 종료! 당신의 점수는 : {score}");
                lblTimer.Text = "제한시간 : 00:00";
            }
            else
            {
                lblTimer.Text = "제한시간 : " + remainingTime.ToString("mm\\:ss");
            }
        }

        private void TimerStart_Click(object sender, EventArgs e)
        {
            if (!gameTimer.Enabled)  // 타이머가 이미 실행 중이지 않다면 시작
            {
                gameTimer.Tick -= GameTimer_Tick;  // 이전 핸들러 제거
                gameTimer.Tick += GameTimer_Tick;  // 핸들러 등록
                gameTimer.Interval = 1000;  // 1초마다 Tick 이벤트 발생
                startTime = DateTime.Now;  // 타이머 시작 시간 기록
                gameTimer.Start();
            }
        }
    }
}
