namespace GameWithSumpsAndCollisions
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
            player = new PictureBox();
            platform = new PictureBox();
            coin = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            labelForTime = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)platform).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Chartreuse;
            player.Location = new Point(70, 341);
            player.Name = "player";
            player.Size = new Size(63, 52);
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // platform
            // 
            platform.BackColor = SystemColors.ActiveCaptionText;
            platform.Location = new Point(369, 199);
            platform.Name = "platform";
            platform.Size = new Size(146, 41);
            platform.TabIndex = 1;
            platform.TabStop = false;
            // 
            // coin
            // 
            coin.BackColor = Color.Yellow;
            coin.Location = new Point(422, 52);
            coin.Name = "coin";
            coin.Size = new Size(63, 39);
            coin.TabIndex = 2;
            coin.TabStop = false;
            coin.Click += coin_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // labelForTime
            // 
            labelForTime.AutoSize = true;
            labelForTime.Location = new Point(683, 40);
            labelForTime.Name = "labelForTime";
            labelForTime.Size = new Size(42, 20);
            labelForTime.TabIndex = 3;
            labelForTime.Text = "Time";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelForTime);
            Controls.Add(coin);
            Controls.Add(platform);
            Controls.Add(player);
            Name = "Form1";
            Text = "GameWithJumpsAndCollisions";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)platform).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private PictureBox platform;
        private PictureBox coin;
        private System.Windows.Forms.Timer timer;
        private Label labelForTime;
    }
}
