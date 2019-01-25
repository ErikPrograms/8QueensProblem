using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensProgram
{
    public class Grid
    {
        private int height;
        private int width;
        public int[,] Spaces;

        public Grid(int Height, int Width)
        {
            height = Height;
            width = Width;

            Spaces = new int[height,width];
        }
    }
}
