using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensProgram
{
    public static class Backtracker
    {
        private static Grid workingGrid;
        private static Stack<int> Depth;

        public static void RunAI(Grid processedGrid)
        {
            workingGrid = processedGrid;
            Depth = new Stack<int>();
            GridSaver.pointer.pHeight = 0;
            GridSaver.pointer.pWidth = 0;
            GridSaver.Save(workingGrid);

            RunCol();

            Console.Write(processedGrid.ToString());
        }

        private static bool RunCol()
        {
            workingGrid.Place(GridSaver.pointer.pHeight, GridSaver.pointer.pWidth);
            Console.Write(workingGrid.ToString());
            Console.WriteLine($"Pointer at: {GridSaver.pointer.pHeight} , {GridSaver.pointer.pWidth}");

            if (workingGrid.IsBoardValid() && GridSaver.pointer.pWidth == workingGrid.Width - 1) //Found a solution
            {
                GridSaver.SaveValid(workingGrid);
                return true;
            }
            else if (workingGrid.IsBoardValid()) //Move to next line
            {
                GridSaver.Save(workingGrid);
                Depth.Push(GridSaver.pointer.pHeight);
                GridSaver.pointer.pWidth++;
                GridSaver.pointer.pHeight = 0;
                RunCol();
            }
            else if (GridSaver.pointer.pHeight != (workingGrid.Height - 1)) //Move down in current line
            {
                workingGrid = GridSaver.LoadAndUndo();
                GridSaver.Save(workingGrid);
                GridSaver.pointer.pHeight++;
                RunCol();
            }
            else //No possible ansewr in current line, go back
            {
                if (GridSaver.pointer.pHeight == (workingGrid.Height - 1))
                {
                    BreakOutOfBottom();

                }

                RunCol();

            }

            return false;
        }

        private static void BreakOutOfBottom()
        {
            if (GridSaver.pointer.pHeight == (workingGrid.Height - 1))
            {
                GridSaver.pointer.pHeight = Depth.Pop();
                workingGrid = GridSaver.LoadAndUndo();
                GridSaver.pointer.pWidth--;

                BreakOutOfBottom();
            }
            else
            {
                GridSaver.pointer.pHeight++;
            }
        }




    }
}

