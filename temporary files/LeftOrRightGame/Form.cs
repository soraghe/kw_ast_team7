﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace LeftOrRightGame
{
    public partial class Form : System.Windows.Forms.Form
    {
        private DateTime startTime;
        private int score = 0;
        private double finalPercentage;
        private List<PictureBox> items = new List<PictureBox>();
        private Random random = new Random();

        public Form()
        {
            InitializeComponent();
            this.KeyPreview = true; 
            SetInitialState(); 
        }

        private void SetInitialState()
        {
            
            score = 0;
            finalPercentage = 0;
            lblScore1.Text = "Score: 0";
            lblTimer.Text = "제한시간 : 00:30";

           
            foreach (var item in items)
            {
                this.Controls.Remove(item);
                item.Dispose();
            }
            items.Clear();

            
            gameTimer.Stop();
        }

        private void InitializeGame()
        {
            LoadItems(); 
            UpdateScore(); 
        }

        private void LoadItems()
        {
            items.Clear(); 
            for (int i = 0; i < 6; i++) 
            {
                CreateNewItem();
            }
        }

        private void CreateNewItem()
        {
            PictureBox newItem = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point(ClientSize.Width / 2 - 25, -60), 
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (random.Next(2) == 0)
            {
                newItem.Image = Properties.Resources.civa3;
                newItem.Tag = "A"; 
            }
            else
            {
                newItem.Image = Properties.Resources.laughingcat3;
                newItem.Tag = "B"; 
            }

            
            Console.WriteLine($"New item created: Tag = {newItem.Tag}, Image = {(newItem.Image == Properties.Resources.civa3 ? "civa3" : "laughingcat3")}");

            this.Controls.Add(newItem);
            items.Add(newItem); // 새 아이템을 리스트의 끝에 추가
            UpdateItemsPosition(); // 아이템 위치 업데이트
        }

        private void CheckItem(string type)
        {
            if (items.Count > 0)
            {
               
                string actualTag = items[0].Tag as string;
                Console.WriteLine($"Checking item: Expected Tag = {type}, Actual Tag = {actualTag}");

                if (actualTag == type)
                {
                    Console.WriteLine("Correct item selected. Removing item.");

                    PictureBox itemToRemove = items[0];
                    this.Controls.Remove(itemToRemove);
                    items.RemoveAt(0);
                    itemToRemove.Dispose();

                    score += 1;
                    UpdateScore();

                   
                    CreateNewItem();
                }
                else
                {
                   
                    Console.WriteLine("Incorrect item selected.");

                }
            }

            UpdateItemsPosition();
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LEFT button clicked.");
            CheckItem("A"); 
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            Console.WriteLine("RIGHT button clicked.");
            CheckItem("B"); 
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (gameTimer.Enabled) 
            {
               
                if (e.KeyCode == Keys.A)
                {
                    BtnLeft.PerformClick();
                    e.Handled = true;
                }
                
                else if (e.KeyCode == Keys.D)
                {
                    BtnRight.PerformClick();
                    e.Handled = true; 
                }
            }
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

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            TimeSpan totalGameTime = TimeSpan.FromSeconds(30);
            TimeSpan remainingTime = totalGameTime - elapsed;

            if (remainingTime.TotalSeconds <= 0)
            {
                remainingTime = TimeSpan.Zero;
                gameTimer.Stop();

               
                finalPercentage = score / 2.0;

                MessageBox.Show($"게임 종료! 당신의 점수는 : {score}\n환산된 점수: {finalPercentage:F2}");
                lblTimer.Text = "제한시간 : 00:00";
            }
            else
            {
                lblTimer.Text = "제한시간 : " + remainingTime.ToString("mm\\:ss");
            }
        }

        private void TimerStart_Click(object sender, EventArgs e)
        {
            if (!gameTimer.Enabled) 
            {
               
                score = 0; 
                finalPercentage = 0; 
                lblScore1.Text = "Score: 0"; 
                lblTimer.Text = "제한시간 : 00:30";
                InitializeGame(); 

                gameTimer.Tick -= GameTimer_Tick;  
                gameTimer.Tick += GameTimer_Tick; 
                gameTimer.Interval = 1000; 
                startTime = DateTime.Now; 
                gameTimer.Start(); 
            }
        }
    }
}
