namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Ground = new PictureBox();
            PipeDown = new PictureBox();
            PipeUp = new PictureBox();
            Timer = new System.Windows.Forms.Timer(components);
            Score = new Label();
            Flappy = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Flappy).BeginInit();
            SuspendLayout();
            // 
            // Ground
            // 
            Ground.Image = Properties.Resources.ground;
            Ground.Location = new Point(0, 331);
            Ground.Margin = new Padding(3, 2, 3, 2);
            Ground.Name = "Ground";
            Ground.Size = new Size(697, 40);
            Ground.SizeMode = PictureBoxSizeMode.StretchImage;
            Ground.TabIndex = 1;
            Ground.TabStop = false;
            // 
            // PipeDown
            // 
            PipeDown.Image = Properties.Resources.pipedown;
            PipeDown.Location = new Point(311, 203);
            PipeDown.Margin = new Padding(3, 2, 3, 2);
            PipeDown.Name = "PipeDown";
            PipeDown.Size = new Size(70, 130);
            PipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            PipeDown.TabIndex = 2;
            PipeDown.TabStop = false;
            // 
            // PipeUp
            // 
            PipeUp.Image = Properties.Resources.pipe;
            PipeUp.Location = new Point(570, -2);
            PipeUp.Margin = new Padding(3, 2, 3, 2);
            PipeUp.Name = "PipeUp";
            PipeUp.Size = new Size(71, 124);
            PipeUp.SizeMode = PictureBoxSizeMode.StretchImage;
            PipeUp.TabIndex = 3;
            PipeUp.TabStop = false;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 20;
            Timer.Tick += GameTimerEvent;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Score.ForeColor = Color.DarkSlateGray;
            Score.Location = new Point(311, 356);
            Score.Margin = new Padding(4, 0, 4, 0);
            Score.Name = "Score";
            Score.Size = new Size(56, 17);
            Score.TabIndex = 4;
            Score.Text = "Score:";
            // 
            // Flappy
            // 
            Flappy.Image = Properties.Resources.bird;
            Flappy.Location = new Point(21, 79);
            Flappy.Margin = new Padding(3, 2, 3, 2);
            Flappy.Name = "Flappy";
            Flappy.Size = new Size(127, 58);
            Flappy.SizeMode = PictureBoxSizeMode.Zoom;
            Flappy.TabIndex = 5;
            Flappy.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(700, 398);
            Controls.Add(Flappy);
            Controls.Add(Score);
            Controls.Add(PipeUp);
            Controls.Add(Ground);
            Controls.Add(PipeDown);
            ForeColor = Color.DeepSkyBlue;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)Flappy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Ground;
        private PictureBox PipeDown;
        private PictureBox PipeUp;
        private System.Windows.Forms.Timer Timer;
        private Label Score;
        private PictureBox Flappy;
    }
}
