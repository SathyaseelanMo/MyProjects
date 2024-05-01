namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int speed = 5;
        int gravity = 5;
        int score = 0;

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Flappy.Top += gravity;
            PipeUp.Left -= speed;
            PipeDown.Left -= speed;
            
            if (PipeUp.Left < -80)
            {
                PipeUp.Left = 1500;
                score++;
                
            }
            if (PipeDown.Left < -80)
            {
                PipeDown.Left = 1000;
                score++;    
            }

            Score.Text = "Score:" + score;
            if (Flappy.Bounds.IntersectsWith(PipeUp.Bounds)|| Flappy.Bounds.IntersectsWith(PipeDown.Bounds) || Flappy.Bounds.IntersectsWith(Ground.Bounds) ||Flappy.Top<-25)
            {
                endgame();
            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Space)
            {
                gravity = -10;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }


        }
        public void endgame()
        {
            Timer.Stop();
            Score.Text = "Game Over! Score:" + score;

        }
    }
}
