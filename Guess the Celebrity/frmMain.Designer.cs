namespace Guess_the_Celebrity
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnA = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnB = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.lblD = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.lblTimeHeader = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbCelebrity = new System.Windows.Forms.PictureBox();
            this.lblScoreHeader = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCelebrity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.DarkViolet;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnA.Font = new System.Drawing.Font("Fira Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.Location = new System.Drawing.Point(65, 423);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(388, 64);
            this.btnA.TabIndex = 1;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA.Location = new System.Drawing.Point(26, 439);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(34, 28);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A)";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblB.Location = new System.Drawing.Point(26, 511);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(35, 28);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B)";
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnB.Font = new System.Drawing.Font("Fira Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.Location = new System.Drawing.Point(65, 495);
            this.btnB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(388, 64);
            this.btnB.TabIndex = 3;
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblC.Location = new System.Drawing.Point(27, 583);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(34, 28);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "C)";
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnC.Font = new System.Drawing.Font("Fira Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(65, 567);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(388, 64);
            this.btnC.TabIndex = 5;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Fira Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblD.Location = new System.Drawing.Point(25, 655);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(36, 28);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "D)";
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.Violet;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnD.Font = new System.Drawing.Font("Fira Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.Location = new System.Drawing.Point(65, 639);
            this.btnD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(388, 64);
            this.btnD.TabIndex = 7;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // lblTimeHeader
            // 
            this.lblTimeHeader.AutoSize = true;
            this.lblTimeHeader.Font = new System.Drawing.Font("Fira Sans", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimeHeader.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTimeHeader.Location = new System.Drawing.Point(100, 338);
            this.lblTimeHeader.Name = "lblTimeHeader";
            this.lblTimeHeader.Size = new System.Drawing.Size(65, 28);
            this.lblTimeHeader.TabIndex = 9;
            this.lblTimeHeader.Text = "Süre:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Fira Sans", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(170, 338);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 28);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "30";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Guess_the_Celebrity.Properties.Resources._076_remove;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(429, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbCelebrity
            // 
            this.pbCelebrity.Image = global::Guess_the_Celebrity.Properties.Resources.romanHelmet;
            this.pbCelebrity.Location = new System.Drawing.Point(105, 16);
            this.pbCelebrity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCelebrity.Name = "pbCelebrity";
            this.pbCelebrity.Size = new System.Drawing.Size(256, 318);
            this.pbCelebrity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCelebrity.TabIndex = 0;
            this.pbCelebrity.TabStop = false;
            // 
            // lblScoreHeader
            // 
            this.lblScoreHeader.AutoSize = true;
            this.lblScoreHeader.Font = new System.Drawing.Font("Fira Sans", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScoreHeader.ForeColor = System.Drawing.Color.Red;
            this.lblScoreHeader.Location = new System.Drawing.Point(251, 338);
            this.lblScoreHeader.Name = "lblScoreHeader";
            this.lblScoreHeader.Size = new System.Drawing.Size(68, 28);
            this.lblScoreHeader.TabIndex = 12;
            this.lblScoreHeader.Text = "Skor:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Fira Sans", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(323, 338);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 28);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "99";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(467, 788);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeHeader);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.pbCelebrity);
            this.Font = new System.Drawing.Font("Fira Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Celebrity Game";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCelebrity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbCelebrity;

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblTimeHeader;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblScoreHeader;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer;
    }
}