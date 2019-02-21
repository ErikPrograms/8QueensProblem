using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensProgram
{
    public static class AI
    {
        private static Grid workingGrid;

        public static void Run(Grid myGrid)
        {
            GridSaver.pointer.pHeight = 0;
            GridSaver.pointer.pWidth = 0;
            workingGrid = myGrid;

            while (RunCol(0))
            {

            }
            
        }


        private static bool RunCol(int col)
        {
            if(col >= workingGrid.Width)
            {
                GridSaver.SaveValid(workingGrid);
                workingGrid = new Grid(workingGrid.Height, workingGrid.Width);
                return true;
            }
            for (int i = 0; i < workingGrid.Width; i++)
            {
                workingGrid.Place(i, col);
                if (workingGrid.IsBoardValid() && GridSaver.IsNotADoup(workingGrid))
                {
                    if (RunCol(col + 1))
                    {
                        return true;
                    }

                    
                }
                workingGrid.Remove(i, col);
            }

            return false;
        }
    }
}
