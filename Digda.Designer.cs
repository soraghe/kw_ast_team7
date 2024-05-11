namespace CatchDigda
{
    partial class Digda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Digda));
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrRound = new System.Windows.Forms.Timer(this.components);
            this.lblRoundTimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pgbTime = new System.Windows.Forms.ProgressBar();
            this.grbRule = new System.Windows.Forms.GroupBox();
            this.picExDugtrio = new System.Windows.Forms.PictureBox();
            this.picExDigda = new System.Windows.Forms.PictureBox();
            this.lblRule2 = new System.Windows.Forms.Label();
            this.lblRule1 = new System.Windows.Forms.Label();
            this.lblRule3 = new System.Windows.Forms.Label();
            this.lblRule4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.grbRule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExDugtrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExDigda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lblScore.Location = new System.Drawing.Point(38, 34);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(101, 30);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score : 0";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnStart.Location = new System.Drawing.Point(656, 547);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(208, 70);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrRound
            // 
            this.tmrRound.Interval = 1000;
            this.tmrRound.Tick += new System.EventHandler(this.tmrRound_Tick);
            // 
            // lblRoundTimer
            // 
            this.lblRoundTimer.AutoSize = true;
            this.lblRoundTimer.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.lblRoundTimer.Location = new System.Drawing.Point(700, 35);
            this.lblRoundTimer.Name = "lblRoundTimer";
            this.lblRoundTimer.Size = new System.Drawing.Size(148, 54);
            this.lblRoundTimer.TabIndex = 17;
            this.lblRoundTimer.Text = "01 : 00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::CatchDigda.Properties.Resources.emptyground;
            this.pictureBox1.Location = new System.Drawing.Point(133, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = global::CatchDigda.Properties.Resources.emptyground;
            this.pictureBox2.Location = new System.Drawing.Point(306, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = global::CatchDigda.Properties.Resources.emptyground;
            this.pictureBox3.Location = new System.Drawing.Point(476, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox6.Image = global::CatchDigda.Properties.Resources.emptyground;
            this.pictureBox6.Location = new System.Drawing.Point(476, 319);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(125, 125);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox5.Image = global::CatchDigda.Properties.Resources.emptyground;
            this.pictureBox5.Location = new System.Drawing.Point(306, 319);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(125, 125);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = global::CatchDigda.Properties.Resources.emptyground;
            this.pictureBox4.Location = new System.Drawing.Point(133, 319);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 125);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox7.Image = global::CatchDigda.Properties.Resources.emptyground;
            this.pictureBox7.Location = new System.Drawing.Point(133, 492);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(125, 125);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox8.Image = global::CatchDigda.Properties.Resources.emptyground;
            this.pictureBox8.Location = new System.Drawing.Point(306, 492);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(125, 125);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox9.Image = global::CatchDigda.Properties.Resources.emptyground;
            this.pictureBox9.Location = new System.Drawing.Point(476, 492);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(125, 125);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // pgbTime
            // 
            this.pgbTime.Location = new System.Drawing.Point(43, 662);
            this.pgbTime.Maximum = 60;
            this.pgbTime.Name = "pgbTime";
            this.pgbTime.Size = new System.Drawing.Size(1388, 43);
            this.pgbTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbTime.TabIndex = 26;
            // 
            // grbRule
            // 
            this.grbRule.Controls.Add(this.lblRule4);
            this.grbRule.Controls.Add(this.lblRule3);
            this.grbRule.Controls.Add(this.picExDugtrio);
            this.grbRule.Controls.Add(this.picExDigda);
            this.grbRule.Controls.Add(this.lblRule2);
            this.grbRule.Controls.Add(this.lblRule1);
            this.grbRule.Font = new System.Drawing.Font("나눔고딕", 10F);
            this.grbRule.Location = new System.Drawing.Point(941, 129);
            this.grbRule.Name = "grbRule";
            this.grbRule.Size = new System.Drawing.Size(489, 488);
            this.grbRule.TabIndex = 28;
            this.grbRule.TabStop = false;
            this.grbRule.Text = "게임 규칙 (How to Play?)";
            // 
            // picExDugtrio
            // 
            this.picExDugtrio.Image = global::CatchDigda.Properties.Resources.Dugtrio;
            this.picExDugtrio.Location = new System.Drawing.Point(289, 173);
            this.picExDugtrio.Name = "picExDugtrio";
            this.picExDugtrio.Size = new System.Drawing.Size(125, 125);
            this.picExDugtrio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExDugtrio.TabIndex = 31;
            this.picExDugtrio.TabStop = false;
            // 
            // picExDigda
            // 
            this.picExDigda.Image = global::CatchDigda.Properties.Resources.Digda;
            this.picExDigda.Location = new System.Drawing.Point(90, 173);
            this.picExDigda.Name = "picExDigda";
            this.picExDigda.Size = new System.Drawing.Size(125, 125);
            this.picExDigda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExDigda.TabIndex = 30;
            this.picExDigda.TabStop = false;
            // 
            // lblRule2
            // 
            this.lblRule2.AutoSize = true;
            this.lblRule2.Location = new System.Drawing.Point(34, 127);
            this.lblRule2.Name = "lblRule2";
            this.lblRule2.Size = new System.Drawing.Size(419, 23);
            this.lblRule2.TabIndex = 29;
            this.lblRule2.Text = "+ 두더지는 총 2종류로 다른 점수가 부여됩니다.";
            // 
            // lblRule1
            // 
            this.lblRule1.AutoSize = true;
            this.lblRule1.Location = new System.Drawing.Point(33, 71);
            this.lblRule1.Name = "lblRule1";
            this.lblRule1.Size = new System.Drawing.Size(266, 23);
            this.lblRule1.TabIndex = 0;
            this.lblRule1.Text = "+ 총 1분, 60초간 진행됩니다.";
            // 
            // lblRule3
            // 
            this.lblRule3.AutoSize = true;
            this.lblRule3.Location = new System.Drawing.Point(34, 327);
            this.lblRule3.Name = "lblRule3";
            this.lblRule3.Size = new System.Drawing.Size(321, 23);
            this.lblRule3.TabIndex = 30;
            this.lblRule3.Text = "+ 시간이 지날수록 점점 빨라집니다!";
            // 
            // lblRule4
            // 
            this.lblRule4.AutoSize = true;
            this.lblRule4.Location = new System.Drawing.Point(33, 380);
            this.lblRule4.Name = "lblRule4";
            this.lblRule4.Size = new System.Drawing.Size(230, 23);
            this.lblRule4.TabIndex = 31;
            this.lblRule4.Text = "+ 점수와 학점 전환 기준 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.grbRule);
            this.Controls.Add(this.pgbTime);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRoundTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox9);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CatchDigda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.grbRule.ResumeLayout(false);
            this.grbRule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExDugtrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExDigda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Timer tmrRound;
        private System.Windows.Forms.Label lblRoundTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ProgressBar pgbTime;
        private System.Windows.Forms.GroupBox grbRule;
        private System.Windows.Forms.Label lblRule1;
        private System.Windows.Forms.PictureBox picExDugtrio;
        private System.Windows.Forms.PictureBox picExDigda;
        private System.Windows.Forms.Label lblRule2;
        private System.Windows.Forms.Label lblRule3;
        private System.Windows.Forms.Label lblRule4;
    }
}

