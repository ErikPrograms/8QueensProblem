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
        private bool[,] Spaces;

        public Grid(int Height, int Width)
        {
            height = Height;
            width = Width;

            Spaces = new bool[height,width];
        }

        public void Place(int Height, int Width)
        {
            Spaces[Height - 1, Width - 1] = true;
        }

        public override string ToString()
        {

            StringBuilder outString = new StringBuilder();
            outString.Append("  ");
            for(int i = 1; i<=width; i++)
            {
                outString.Append(" " + i + " ");
            }
            outString.AppendLine();

            for(int loopcount = 0; loopcount < height; loopcount++)
            {
                outString.Append((loopcount + 1) + " ");
                for(int innerloopcount = 0; innerloopcount < width; innerloopcount ++)
                {
                    if(Spaces[loopcount,innerloopcount] == true)
                    {
                        outString.Append("|X|");
                    }
                    else
                    {
                        outString.Append("| |");
                    }
                }
                outString.AppendLine();
            }

            return outString.ToString();
        }

        public bool IsBoardValid()
        {
            //todo: Check if current grid layout is legal, if legal return true, else you return false
            throw new NotImplementedException();
        }


    }
}
