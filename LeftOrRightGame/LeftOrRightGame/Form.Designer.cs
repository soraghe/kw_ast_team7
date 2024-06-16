namespace LeftOrRightGame
{
    partial class Form
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
            this.lblScore1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.TimerStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("굴림", 12F);
            this.lblScore1.Location = new System.Drawing.Point(500, 50);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(74, 24);
            this.lblScore1.TabIndex = 2;
            this.lblScore1.Text = "점수 :";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // BtnRight
            // 
            this.BtnRight.Image = global::LeftOrRightGame.Properties.Resources.laughingcat3;
            this.BtnRight.Location = new System.Drawing.Point(456, 323);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(75, 73);
            this.BtnRight.TabIndex = 1;
            this.BtnRight.Tag = "B";
            this.BtnRight.Text = "RIGHT";
            this.BtnRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Image = global::LeftOrRightGame.Properties.Resources.civa3;
            this.BtnLeft.Location = new System.Drawing.Point(145, 323);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnLeft.Size = new System.Drawing.Size(77, 73);
            this.BtnLeft.TabIndex = 0;
            this.BtnLeft.Tag = "A";
            this.BtnLeft.Text = "LEFT";
            this.BtnLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("굴림", 12F);
            this.lblTimer.Location = new System.Drawing.Point(468, 85);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(122, 24);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "제한시간 :";
            this.lblTimer.TextChanged += new System.EventHandler(this.TimerStart_Click);
            // 
            // TimerStart
            // 
            this.TimerStart.Font = new System.Drawing.Font("굴림", 12F);
            this.TimerStart.Location = new System.Drawing.Point(12, 356);
            this.TimerStart.Name = "TimerStart";
            this.TimerStart.Size = new System.Drawing.Size(86, 40);
            this.TimerStart.TabIndex = 4;
            this.TimerStart.Text = "시작";
            this.TimerStart.UseVisualStyleBackColor = true;
            this.TimerStart.Click += new System.EventHandler(this.TimerStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(157, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(463, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "D";
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(672, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerStart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Name = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button TimerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

