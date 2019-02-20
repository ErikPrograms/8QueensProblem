using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensProgram
{
    public static class GridSaver
    {
        private static Stack<Grid> grids = new Stack<Grid>();


        /// <summary>
        /// Saves current state of grid to GridSaver
        /// </summary>
        /// <param name="SavedGrid"></param>
        static void Save(Grid SavedGrid)
        {
            grids.Push(SavedGrid);
        }

        /// <summary>
        /// Returns last grid without removing it from storage
        /// </summary>
        /// <returns></returns>
        static Grid Load()
        {
            return grids.Peek();
        }


        /// <summary>
        /// Returns last grid and removes it from storage
        /// </summary>
        /// <returns></returns>
        static Grid LoadAndUndo()
        {
            return grids.Pop();
        }

        /// <summary>
        /// Removes last saved state and returns the next one
        /// </summary>
        /// <returns></returns>
        static Grid Undo()
        {
            grids.Pop();
            return grids.Peek();
        }
    }
}
