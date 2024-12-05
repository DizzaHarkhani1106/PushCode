namespace GameWithSumpsAndCollisions
{

    public partial class Form1 : Form
    {


        //Jumping Variables
        private bool isJumping = false;
        int jumpHeight = 24;//jump height 
        int gravity = 1;//gravity effect
        int groundHeight;//height of the ground to be used for resetting the player to the ground
        bool isCoinCaptured = false;

        //right movement 
        private bool isGoingRight = false;

        //left movement
        private bool isGoingLeft = false;

        //time related variable
        private DateTime startTime;





        public Form1()
        {
            InitializeComponent();
            groundHeight = this.ClientSize.Height - player.Height;
            timer.Start();
            startTime = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && !isGoingLeft)// start moving left
            {
                isGoingLeft = true;

            }
            if (e.KeyCode == Keys.Right && !isGoingRight)// start moving right
            {
                isGoingRight = true;

            }
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)// stop going left
            {
                isGoingLeft = false;

            }
            if (e.KeyCode == Keys.Right)// stop going right
            {
                isGoingRight = false;

            }


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //calculating of time elapsing
            TimeSpan elapsedTime = DateTime.Now - startTime;

            //jumping logic 
            if (isJumping)
            {
                player.Top -= jumpHeight;//move the player up
                jumpHeight -= gravity;// bringing the player downwards slowly under gravity

                //check if the player has landed
                if (player.Top >= groundHeight)//check against ground height
                {
                    player.Top = groundHeight;//reset the player to the ground
                    isJumping = false;//reset the jumping flag
                    jumpHeight = 24;//reset the jump height for the next jump on the press of space key again


                }




            }
            else
            {
                if (player.Top < groundHeight)
                {
                    player.Top += gravity;
                }
            }

            if (isGoingRight)
            {
                player.Left += 5;

            }
            if (isGoingLeft)
            {
                player.Left -= 5;


            }
            if (player.Bounds.IntersectsWith(platform.Bounds))
            {
                player.Top = platform.Top - player.Height;
                isJumping = false;
                jumpHeight = 25;


            }
            //check if the player is falling off the edges of the platform 
            if (player.Top == platform.Top - player.Height && (player.Left < platform.Left || player.Right > platform.Right))
            {
                isJumping = false;

            }
            labelForTime.Text = "Time Elapsed:" + elapsedTime.Seconds + "seconds";
            //check for collision with the coin 
            if (!isCoinCaptured && coin.Bounds.IntersectsWith(player.Bounds))
            {
                isCoinCaptured = true;
                coin.Visible = false;
                gameOver(elapsedTime.Seconds);


            }

        }
        private void gameOver(int timeTook)
        {
            timer.Stop();
            player.Visible = false;
            coin.Visible = false;
            platform.Visible = false;
            isJumping = false;
            isGoingLeft = false;
            isGoingRight = false;
            MessageBox.Show("Coin Captured! Game Over, It took you");

        }

        private void coin_Click(object sender, EventArgs e)
        {

        }
    }
}
