using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class MainWindow : Form
    {

        // 48, 25
        const int SIZE_X = 48;
        const int SIZE_Y = 25;

        const int START_GAME_TIMER_INTERVAL = 500;

        const int IMAGE_SIZE_X = 32;
        const int IMAGE_SIZE_Y = 32;

        const int RED_HEAD = 1;
        const int GREEN_BODY = 2;
        const int APPLE = 3;

        const int MOVE_RIGHT = 1;
        const int MOVE_LEFT = 2;
        const int MOVE_UP = 3;
        const int MOVE_DOWN = 4;

        int moving_to; // current snake moving direction
        int current_x, current_y; // snake head current location

        int[,] board = new int[SIZE_X, SIZE_Y]; // all items on the board

        Random random_generator = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        void DrawImage(int boardX, int boardY, int imageType)
        {
            string imageName = "";

            switch (imageType)
            {
                case RED_HEAD:
                    imageName = "red1.png";
                    break;
                case GREEN_BODY:
                    imageName = "green1.png";
                    break;
                case APPLE:
                    break;
            }

            PictureBox picture = new PictureBox
            {
                Name = $"pictureBox{boardX}{boardY}",
                Size = new Size(IMAGE_SIZE_X, IMAGE_SIZE_Y),
                Location = new Point(IMAGE_SIZE_X * boardX, IMAGE_SIZE_Y * boardY),
                Image = Image.FromFile($"images/{imageName}"),

            };
            this.Controls.Add(picture);
        }

        void GameOver()
        {
            // game over
            gameTimer.Enabled = false;
            MessageBox.Show("Game Over!");
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int diffx = 0;
            int diffy = 0;
            switch (moving_to)
            {
                case MOVE_RIGHT:
                    diffx = +1;
                    break;
                case MOVE_LEFT:
                    diffx = -1;
                    break;
                case MOVE_UP:
                    diffy = -1;
                    break;
                case MOVE_DOWN:
                    diffy = +1;
                    break;
            }

            // current_x and current_y point to the next location
            current_x = current_x + diffx;
            current_y = current_y + diffy;

            // before moving snake to next locatiom check if next location is legal?
            if (current_x < 0 || current_y < 0 || current_x == SIZE_X || current_y == SIZE_Y)
            {
                // game over
                GameOver();
                return;
            }

            // TO-DO :
            // head should be red and body green
            if (board[current_x, current_y] == GREEN_BODY || board[current_x, current_y] == RED_HEAD)
            {
                // game over
                GameOver();
                return;
            }


            // TO-DO :
            // head should be red and body green
            // the destination of next square is free... turn it into green body
            board[current_x, current_y] = GREEN_BODY;

            // TO-DO :
            // head should be red and body green
            DrawImage(current_x, current_y, GREEN_BODY);

            if (gameTimer.Interval >= 30)
                gameTimer.Interval -= 20;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    moving_to = MOVE_LEFT;
                    break;
                case Keys.Right:
                    moving_to = MOVE_RIGHT;
                    break;
                case Keys.Up:
                    moving_to = MOVE_UP;
                    break;
                case Keys.Down:
                    moving_to = MOVE_DOWN;
                    break;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // place read head in board center
            int middle_x = SIZE_X / 2 - 1;
            int middle_y = SIZE_Y / 2;

            board[middle_x, middle_y] = RED_HEAD;
            DrawImage(middle_x, middle_y, RED_HEAD);

            // random start moving direction
            int statr_direction = random_generator.Next(1, 5);
            moving_to = statr_direction;

            // where read head of snake starts
            current_x = middle_x;
            current_y = middle_y;

            gameTimer.Interval = START_GAME_TIMER_INTERVAL;
            gameTimer.Enabled = true;

            // this will tell the main form to listen to key clicked
            this.KeyPreview = true;

            // TODO:
            // calculate the size of x and y instead of consts
            // depennd on window size + image size!!

            //int ycounter = 0;
            //for (int i = 0; i + 64 < this.Size.Height; i=i+32)
            //{
            //    var picture = new PictureBox
            //    {
            //        Name = "pictureBox",
            //        Size = new Size(32, 32),
            //        Location = new Point(0, i),
            //        Image = Image.FromFile("images/green1.png"),

            //    };
            //    this.Controls.Add(picture);
            //    ycounter++;
            //}

            //int xcounter = 0;
            //for (int i = 0; i + 32 < this.Size.Width; i = i + 32)
            //{
            //    var picture = new PictureBox
            //    {
            //        Name = "pictureBox",
            //        Size = new Size(32, 32),
            //        Location = new Point(i, 0),
            //        Image = Image.FromFile("images/green1.png"),

            //    };
            //    this.Controls.Add(picture);
            //    xcounter++;
            //}

            //MessageBox.Show(this.Size.Width + " , " + this.Size.Height);
        }
    }
}
