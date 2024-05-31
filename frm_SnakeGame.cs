using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_WindowsFomsApp
{

    public partial class frm_SnakeGame : Form
    {
        public frm_SnakeGame()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            random = new Random();
            snake = new LinkedList(new Point(random.Next(Constants.BoardSize.Width), random.Next(Constants.BoardSize.Height)));
            food = generateFood();
            score = 0;
            direction = Direction.LEFT;
        }
        private readonly Graphics graphics;
        private readonly LinkedList snake;
        private Point food;
        private readonly Random random;
        private int score;
        private Direction direction;
        private enum Direction { LEFT, RIGHT, UP, DOWN }

        // Generates a random point as food that is not on the snake
        // If there is not any place on the board to put the food, end the game.
        private Point generateFood()
        {
            Point result = new Point();
            if (snake.count == Constants.BoardSize.Width * Constants.BoardSize.Height)
            {
                tmr_Clock.Enabled = false;
                btn_Pause.Enabled = false;
                lbl_Score.Text = "Score: " + score;
                MessageBox.Show("Congrads! You win. Your score is " + score);
            }
            else
            {
                bool control;
                do
                {
                    result = new Point(random.Next(Constants.BoardSize.Width), random.Next(Constants.BoardSize.Height));
                    control = false;
                    Node temp = snake.head;
                    for (int i = 0; i < snake.count; i++)
                    {
                        if (temp.data == result)
                        {
                            control = true;
                            break;
                        }
                        temp = temp.next;
                    }
                } while (control);
                if (food != null)
                {
                    DrawPiece(food, Constants.ScreenColor);// Erase old food
                }
                DrawPiece(result, Constants.FoodColor);// Draw new food
            }
            return result;
        }

        // Draws a single piece to the board
        private void DrawPiece(Point p, Color c)
        {
            graphics.FillEllipse(new Pen(c).Brush,
                Constants.Board.Left + p.X * Constants.PieceSize + Constants.PieceMargin,
                Constants.Board.Top + p.Y * Constants.PieceSize + Constants.PieceMargin,
                Constants.PieceSize - 2 * Constants.PieceMargin,
                Constants.PieceSize - 2 * Constants.PieceMargin
                );
        }

        // Draws the snake and the food to the board
        private void Draw()
        {
            lbl_Score.Text = "Score: " + score;
            DrawPiece(snake.head.data, Constants.HeadColor);
            if (snake.count > 1)
            {
                Node temp = snake.head.next;
                for (int i = 1; i < snake.count; i++)
                {
                    DrawPiece(temp.data, Constants.TailColor);
                    temp = temp.next;
                }
            }
        }

        // Erases the snake and the food from board
        private void Erase()
        {
            Node temp = snake.head;
            for (int i = 0; i < snake.count; i++)
            {
                DrawPiece(temp.data, Constants.ScreenColor);
                temp = temp.next;
            }
        }

        // Ends the game if snake's head collide to tail
        private void TailCollisionCheck(Point next)
        {
            Node temp = snake.head;
            for (int i = 0; i < snake.count; i++)
            {
                if (temp.data == next)
                {
                    tmr_Clock.Enabled = false;
                    btn_Pause.Enabled = false;
                    MessageBox.Show("Game over! Your score is " + score);
                }
                temp = temp.next;
            }
        }

        // Ends the game if snake's head collide to a border
        private void BorderCollisionCheck(Point next)
        {
            if (next.X < 0 || next.X > 24 || next.Y < 0 || next.Y > 24)
            {
                tmr_Clock.Enabled = false;
                btn_Pause.Enabled = false;
                MessageBox.Show("Game over! Your score is " + score);
            }
        }

        // Makes the snake grow if snake's head collides to food
        // If no coolision, each piece of the snake move one unit
        private void FoodCollisionCheck(Point next)
        {
            if (next == food)
            {
                snake.Add(next);
                food = generateFood();
                score++;
            }
            else
            {
                snake.Add(next);
                snake.Remove();
            }
        }

        // Determines next square that the snake's head will go according to the direction
        // Sends the next square to tail,border and food collision check functions
        private void ChangePosition()
        {
            Point head = snake.head.data;
            Point next = new Point(0, 0);
            switch (direction)
            {
                case Direction.LEFT:
                    next = new Point(head.X - 1, head.Y);
                    break;
                case Direction.RIGHT:
                    next = new Point(head.X + 1, head.Y);
                    break;
                case Direction.UP:
                    next = new Point(head.X, head.Y - 1);
                    break;
                case Direction.DOWN:
                    next = new Point(head.X, head.Y + 1);
                    break;
                default:
                    break;
            }
            TailCollisionCheck(next);
            BorderCollisionCheck(next);
            FoodCollisionCheck(next);
        }

        // Runs once when form is created
        private void Frm_SnakeGame_Paint(object sender, PaintEventArgs e)
        {
            lbl_Score.Text = "Score: " + score;
            graphics.FillRectangle(new Pen(Constants.ScreenColor).Brush, Constants.Screen);
            DrawPiece(food, Constants.FoodColor);
            for (int i = 0; i <= Constants.BoardSize.Height; i++)
            {
                graphics.DrawLine(new Pen(Constants.GridColor),
                    Constants.Board.Left,
                    Constants.Board.Top + i * Constants.PieceSize,
                    Constants.Board.Right,
                    Constants.Board.Top + i * Constants.PieceSize);
            }
            for (int i = 0; i <= Constants.BoardSize.Width; i++)
            {
                graphics.DrawLine(new Pen(Constants.GridColor),
                    Constants.Board.Left + i * Constants.PieceSize,
                    Constants.Board.Top,
                    Constants.Board.Left + i * Constants.PieceSize,
                    Constants.Board.Bottom);
            }
            Draw();
        }

        // Runs twice a second if it is enabled
        private void Tmr_Clock_Tick(object sender, EventArgs e)
        {
            Erase();
            ChangePosition();
            Draw();
        }

        // Restart button
        private void Btn_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Pause-Resume button
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            if (tmr_Clock.Enabled)
            {
                tmr_Clock.Enabled = false;
                btn_Pause.Text = "Resume";
            }
            else
            {
                tmr_Clock.Enabled = true;
                btn_Pause.Text = "Pause";
            }
        }

        // Down direction button
        private void Btn_Down_Click(object sender, EventArgs e)
        {
            direction = Direction.DOWN;
        }

        // Right direction button
        private void Btn_Right_Click(object sender, EventArgs e)
        {
            direction = Direction.RIGHT;
        }

        // Left direction button
        private void Btn_Left_Click(object sender, EventArgs e)
        {
            direction = Direction.LEFT;
        }

        // Up direction button
        private void Btn_Up_Click(object sender, EventArgs e)
        {
            direction = Direction.UP;
        }

    }
}
