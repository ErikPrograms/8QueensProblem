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

        public int Height
        {
            get
            {
                return height;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public Grid(int Height, int Width)
        {
            height = Height;
            width = Width;

            Spaces = new bool[height, width];
        }

        public Grid(Grid copy)
        {
            height = copy.height;
            width = copy.width;

            Spaces = new bool[height, width];

            for(int x = 0; x < height; x++)
            {
                for(int y = 0; y < width; y++)
                {
                    this.Spaces[x, y] = copy.Spaces[x, y];
                }
            }

        }

        /// <summary>
        /// Puts a queen on the board at that spot
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        public void Place(int Height, int Width)
        {
            Spaces[Height, Width] = true;
        }

        /// <summary>
        /// Printable view of grid
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            StringBuilder outString = new StringBuilder();
            outString.Append("  ");
            for (int i = 1; i <= width; i++)
            {
                outString.Append(" " + i + " ");
            }
            outString.AppendLine();

            for (int loopcount = 0; loopcount < height; loopcount++)
            {
                outString.Append((loopcount + 1) + " ");
                for (int innerloopcount = 0; innerloopcount < width; innerloopcount++)
                {
                    if (Spaces[loopcount, innerloopcount] == true)
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


        /// <summary>
        /// Checks if current grid is in a valid state, if its not, it return false
        /// </summary>
        /// <returns></returns>
        public bool IsBoardValid()
        {
            bool ValidBoard = true;
            bool FoundOne = false;

            for (int i = height - 1; i >= 0; i--)
            {
                for (int y = width - 1; y >= 0; y--)
                {
                    if (Spaces[i, y] == true)
                    {
                        if (FoundOne == true)
                        {
                            ValidBoard = false;
                        }
                        else
                        {
                            FoundOne = true;
                        }
                    }
                }

                FoundOne = false;

            }

            if (ValidBoard)
            {
                for (int i = width - 1; i >= 0; i--)
                {
                    for (int y = height - 1; y >= 0; y--)
                    {
                        if (Spaces[y, i] == true)
                        {
                            if (FoundOne == true)
                            {
                                ValidBoard = false;
                            }
                            else
                            {
                                FoundOne = true;
                            }
                        }
                    }

                    FoundOne = false;
                }
            }

            if (ValidBoard)
            {
                for (int h = height - 1; h >= 0; h--)
                {
                    for (int w = width - 1; w >= 0; w--)
                    {
                        if (Spaces[h, w] == true)
                        {
                            if (CheckUp(h, w) || CheckDown(h, w))
                            {
                                ValidBoard = false;
                            }
                        }
                    }
                }
            }



            return ValidBoard;

            //todo: Check if current grid layout is legal, if legal return true, else you return false
            throw new NotImplementedException();
        }

        private bool CheckDown(int h, int w)
        {
            if (h == height - 1 || w == 0)
            {
                return false;
            }

            if (Spaces[h + 1, w - 1] == true)
            {
                return true;
            }
            else if (h != 0 || w != 0)
            {
                return CheckDown(h + 1, w - 1);
            }
            else
            {
                return false;
            }

            return false;
        }

        private bool CheckUp(int h, int w)
        {
            if (h == 0 || w == 0)
            {
                return false;
            }

            if (Spaces[h - 1, w - 1] == true)
            {
                return true;
            }
            else if (h != 0 || w != 0)
            {
                return CheckUp(h - 1, w - 1);
            }
            else
            {
                return false;
            }

            return false;
        }

    }
}
