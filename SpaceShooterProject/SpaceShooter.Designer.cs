
namespace SpaceShooterProject
{
    partial class SpaceShooter
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
            this.labelScore = new System.Windows.Forms.Label();
            this.labelShields = new System.Windows.Forms.Label();
            this.ShieldsBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(12, 816);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(131, 36);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score : 0";
            this.labelScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelShields
            // 
            this.labelShields.AutoSize = true;
            this.labelShields.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShields.ForeColor = System.Drawing.Color.White;
            this.labelShields.Location = new System.Drawing.Point(861, 777);
            this.labelShields.Name = "labelShields";
            this.labelShields.Size = new System.Drawing.Size(111, 36);
            this.labelShields.TabIndex = 1;
            this.labelShields.Text = "Shields";
            // 
            // ShieldsBar
            // 
            this.ShieldsBar.Location = new System.Drawing.Point(765, 816);
            this.ShieldsBar.Name = "ShieldsBar";
            this.ShieldsBar.Size = new System.Drawing.Size(198, 23);
            this.ShieldsBar.TabIndex = 2;
            this.ShieldsBar.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(446, 646);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SpaceShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShieldsBar);
            this.Controls.Add(this.labelShields);
            this.Controls.Add(this.labelScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpaceShooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter - w1828309";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.isKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.isKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelShields;
        private System.Windows.Forms.ProgressBar ShieldsBar;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

