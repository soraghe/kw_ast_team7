namespace ESCAPE_project
{
    partial class Description
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Description));
            this.grpGame = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGame
            // 
            this.grpGame.Controls.Add(this.label5);
            this.grpGame.Controls.Add(this.label4);
            this.grpGame.Controls.Add(this.label3);
            this.grpGame.Controls.Add(this.label2);
            this.grpGame.Controls.Add(this.label1);
            this.grpGame.Font = new System.Drawing.Font("나눔고딕", 20F);
            this.grpGame.Location = new System.Drawing.Point(77, 148);
            this.grpGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpGame.Name = "grpGame";
            this.grpGame.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpGame.Size = new System.Drawing.Size(591, 283);
            this.grpGame.TabIndex = 0;
            this.grpGame.TabStop = false;
            this.grpGame.Text = "게임 설명 (How to Play?)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label4.Location = new System.Drawing.Point(36, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "+ 최대한 많은 점수를 획득해 졸업요건을 만족하세요!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label3.Location = new System.Drawing.Point(36, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "+ 개별 점수의 합계로 통과 여부가 결정됩니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label2.Location = new System.Drawing.Point(36, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "+ 4개의 게임을 모두 완료해야, 최종 화면으로 넘어갈 수 있습니다.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "+ 총 4개의 게임으로 구성되어 있습니다.";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("나눔고딕", 10F);
            this.btnReturn.Location = new System.Drawing.Point(734, 407);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(175, 49);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "게임으로 돌아가기";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label5.Location = new System.Drawing.Point(95, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "(푸시푸시, 좌로우로, 두더지게임, 메모리게임)";
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grpGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Description";
            this.Text = "Game Description";
            this.grpGame.ResumeLayout(false);
            this.grpGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGame;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}