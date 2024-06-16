namespace Team_Final
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_JS = new System.Windows.Forms.PictureBox();
            this.picBox_HJ = new System.Windows.Forms.PictureBox();
            this.picBox_RH = new System.Windows.Forms.PictureBox();
            this.picBox_TW = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_JS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_RH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_TW)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_JS
            // 
            this.picBox_JS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_JS.Image = ((System.Drawing.Image)(resources.GetObject("picBox_JS.Image")));
            this.picBox_JS.Location = new System.Drawing.Point(54, 110);
            this.picBox_JS.Name = "picBox_JS";
            this.picBox_JS.Size = new System.Drawing.Size(234, 161);
            this.picBox_JS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_JS.TabIndex = 1;
            this.picBox_JS.TabStop = false;
            // 
            // picBox_HJ
            // 
            this.picBox_HJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_HJ.Image = ((System.Drawing.Image)(resources.GetObject("picBox_HJ.Image")));
            this.picBox_HJ.Location = new System.Drawing.Point(160, 277);
            this.picBox_HJ.Name = "picBox_HJ";
            this.picBox_HJ.Size = new System.Drawing.Size(234, 161);
            this.picBox_HJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HJ.TabIndex = 2;
            this.picBox_HJ.TabStop = false;
            // 
            // picBox_RH
            // 
            this.picBox_RH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_RH.Image = ((System.Drawing.Image)(resources.GetObject("picBox_RH.Image")));
            this.picBox_RH.Location = new System.Drawing.Point(394, 110);
            this.picBox_RH.Name = "picBox_RH";
            this.picBox_RH.Size = new System.Drawing.Size(234, 161);
            this.picBox_RH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_RH.TabIndex = 3;
            this.picBox_RH.TabStop = false;
            this.picBox_RH.Click += new System.EventHandler(this.picBox_RH_Click);
            // 
            // picBox_TW
            // 
            this.picBox_TW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_TW.Image = ((System.Drawing.Image)(resources.GetObject("picBox_TW.Image")));
            this.picBox_TW.Location = new System.Drawing.Point(506, 277);
            this.picBox_TW.Name = "picBox_TW";
            this.picBox_TW.Size = new System.Drawing.Size(234, 161);
            this.picBox_TW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_TW.TabIndex = 4;
            this.picBox_TW.TabStop = false;
            this.picBox_TW.Click += new System.EventHandler(this.picBox_TW_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.picBox_TW);
            this.Controls.Add(this.picBox_RH);
            this.Controls.Add(this.picBox_HJ);
            this.Controls.Add(this.picBox_JS);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "졸업 평가";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_JS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_RH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_TW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_JS;
        private System.Windows.Forms.PictureBox picBox_HJ;
        private System.Windows.Forms.PictureBox picBox_RH;
        private System.Windows.Forms.PictureBox picBox_TW;
    }
}