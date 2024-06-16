namespace ESCAPE_project
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnInstruction = new System.Windows.Forms.Button();
            this.btnGOTOfinal = new System.Windows.Forms.Button();
            this.totalTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblGame1Score = new System.Windows.Forms.Label();
            this.lblGame2Score = new System.Windows.Forms.Label();
            this.lblGame3Score = new System.Windows.Forms.Label();
            this.lblGame4Score = new System.Windows.Forms.Label();
            this.picGame4 = new System.Windows.Forms.PictureBox();
            this.picGame3 = new System.Windows.Forms.PictureBox();
            this.picGame2 = new System.Windows.Forms.PictureBox();
            this.picGame1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGame4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstruction
            // 
            this.btnInstruction.BackColor = System.Drawing.SystemColors.Info;
            this.btnInstruction.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnInstruction.Location = new System.Drawing.Point(1052, 556);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(200, 50);
            this.btnInstruction.TabIndex = 4;
            this.btnInstruction.Text = "설명 확인하기";
            this.btnInstruction.UseVisualStyleBackColor = false;
            this.btnInstruction.Click += new System.EventHandler(this.btnIntroduction_Click);
            // 
            // btnGOTOfinal
            // 
            this.btnGOTOfinal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGOTOfinal.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnGOTOfinal.Location = new System.Drawing.Point(1052, 619);
            this.btnGOTOfinal.Name = "btnGOTOfinal";
            this.btnGOTOfinal.Size = new System.Drawing.Size(200, 50);
            this.btnGOTOfinal.TabIndex = 5;
            this.btnGOTOfinal.Text = "학점 확인하기";
            this.btnGOTOfinal.UseVisualStyleBackColor = false;
            this.btnGOTOfinal.Click += new System.EventHandler(this.btnGOTOfinal_Click);
            // 
            // totalTimer
            // 
            this.totalTimer.Interval = 1;
            this.totalTimer.Tick += new System.EventHandler(this.totalTimer_Tick);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("나눔고딕", 10F);
            this.lbl3.Location = new System.Drawing.Point(123, 412);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(215, 23);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "Game03 :: 두더지 잡기";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Font = new System.Drawing.Font("나눔고딕", 10F);
            this.lbl2.Location = new System.Drawing.Point(630, 164);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(190, 23);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Game02 :: 좌로우로";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Font = new System.Drawing.Font("나눔고딕", 10F);
            this.lbl4.Location = new System.Drawing.Point(630, 412);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(215, 23);
            this.lbl4.TabIndex = 12;
            this.lbl4.Text = "Game04 :: 메모리 게임";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("나눔고딕", 10F);
            this.lbl1.Location = new System.Drawing.Point(123, 164);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(208, 23);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "Game01 :: Push Push";
            // 
            // lblGame1Score
            // 
            this.lblGame1Score.AutoSize = true;
            this.lblGame1Score.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lblGame1Score.Location = new System.Drawing.Point(374, 330);
            this.lblGame1Score.Name = "lblGame1Score";
            this.lblGame1Score.Size = new System.Drawing.Size(155, 30);
            this.lblGame1Score.TabIndex = 14;
            this.lblGame1Score.Text = "SCORE : NULL";
            // 
            // lblGame2Score
            // 
            this.lblGame2Score.AutoSize = true;
            this.lblGame2Score.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lblGame2Score.Location = new System.Drawing.Point(881, 330);
            this.lblGame2Score.Name = "lblGame2Score";
            this.lblGame2Score.Size = new System.Drawing.Size(155, 30);
            this.lblGame2Score.TabIndex = 16;
            this.lblGame2Score.Text = "SCORE : NULL";
            // 
            // lblGame3Score
            // 
            this.lblGame3Score.AutoSize = true;
            this.lblGame3Score.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lblGame3Score.Location = new System.Drawing.Point(374, 578);
            this.lblGame3Score.Name = "lblGame3Score";
            this.lblGame3Score.Size = new System.Drawing.Size(155, 30);
            this.lblGame3Score.TabIndex = 18;
            this.lblGame3Score.Text = "SCORE : NULL";
            // 
            // lblGame4Score
            // 
            this.lblGame4Score.AutoSize = true;
            this.lblGame4Score.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lblGame4Score.Location = new System.Drawing.Point(881, 578);
            this.lblGame4Score.Name = "lblGame4Score";
            this.lblGame4Score.Size = new System.Drawing.Size(155, 30);
            this.lblGame4Score.TabIndex = 20;
            this.lblGame4Score.Text = "SCORE : NULL";
            // 
            // picGame4
            // 
            this.picGame4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGame4.Image = global::ESCAPE_project.Properties.Resources._memory;
            this.picGame4.Location = new System.Drawing.Point(625, 439);
            this.picGame4.Name = "picGame4";
            this.picGame4.Size = new System.Drawing.Size(250, 160);
            this.picGame4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGame4.TabIndex = 9;
            this.picGame4.TabStop = false;
            this.picGame4.Click += new System.EventHandler(this.picGame4_Click);
            // 
            // picGame3
            // 
            this.picGame3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGame3.Image = global::ESCAPE_project.Properties.Resources._fast;
            this.picGame3.Location = new System.Drawing.Point(118, 439);
            this.picGame3.Name = "picGame3";
            this.picGame3.Size = new System.Drawing.Size(250, 160);
            this.picGame3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGame3.TabIndex = 8;
            this.picGame3.TabStop = false;
            this.picGame3.Click += new System.EventHandler(this.picGame3_Click);
            // 
            // picGame2
            // 
            this.picGame2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGame2.Image = global::ESCAPE_project.Properties.Resources._focus;
            this.picGame2.Location = new System.Drawing.Point(625, 191);
            this.picGame2.Name = "picGame2";
            this.picGame2.Size = new System.Drawing.Size(250, 160);
            this.picGame2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGame2.TabIndex = 7;
            this.picGame2.TabStop = false;
            this.picGame2.Click += new System.EventHandler(this.picGame2_Click);
            // 
            // picGame1
            // 
            this.picGame1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGame1.Image = global::ESCAPE_project.Properties.Resources._solve;
            this.picGame1.Location = new System.Drawing.Point(118, 191);
            this.picGame1.Name = "picGame1";
            this.picGame1.Size = new System.Drawing.Size(250, 160);
            this.picGame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGame1.TabIndex = 6;
            this.picGame1.TabStop = false;
            this.picGame1.Click += new System.EventHandler(this.picGame1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblGame4Score);
            this.Controls.Add(this.lblGame3Score);
            this.Controls.Add(this.lblGame2Score);
            this.Controls.Add(this.lblGame1Score);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.picGame4);
            this.Controls.Add(this.picGame3);
            this.Controls.Add(this.picGame2);
            this.Controls.Add(this.picGame1);
            this.Controls.Add(this.btnGOTOfinal);
            this.Controls.Add(this.btnInstruction);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "ESCAPE :: SAEBIT";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGame4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.Button btnGOTOfinal;
        private System.Windows.Forms.Timer totalTimer;
        private System.Windows.Forms.PictureBox picGame1;
        private System.Windows.Forms.PictureBox picGame2;
        private System.Windows.Forms.PictureBox picGame3;
        private System.Windows.Forms.PictureBox picGame4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblGame1Score;
        private System.Windows.Forms.Label lblGame2Score;
        private System.Windows.Forms.Label lblGame3Score;
        private System.Windows.Forms.Label lblGame4Score;
    }
}

