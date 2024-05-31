using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_WindowsFomsApp
{
    internal class Constants
    {
        public static Color ScreenColor = Color.Green;
        public static Color GridColor = Color.Black;
        public static Color FoodColor = Color.Red;
        public static Color HeadColor = Color.Yellow;
        public static Color TailColor = Color.Blue;
        public static int PieceMargin = 1;
        public static int PieceSize = 20;
        public static Rectangle Screen = new Rectangle(0, 0, 540, 540);
        public static Rectangle Board = new Rectangle(20, 20, 500, 500);
        public static Size BoardSize = new Size(Board.Width / PieceSize, Board.Height / PieceSize);
    }
}
