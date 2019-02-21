using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EightQueensProgram
{
    public static class GridSaver
    {
        private static Stack<Grid> grids = new Stack<Grid>();
        private static ArrayList validGrids = new ArrayList();
        public static int ValidSolutions = 0;
        public static Pointer pointer = new Pointer(0, 0);

        /// <summary>
        /// Saves current state of grid to GridSaver
        /// </summary>
        /// <param name="SavedGrid"></param>
        public static void Save(Grid SavedGrid)
        {
            grids.Push(new Grid(SavedGrid));
        }

        /// <summary>
        /// Returns last grid without removing it from storage
        /// </summary>
        /// <returns></returns>
        public static Grid Load()
        {
            return grids.Peek();
        }


        /// <summary>
        /// Returns last grid and removes it from storage
        /// </summary>
        /// <returns></returns>
        public static Grid LoadAndUndo()
        {
            return grids.Pop();
        }

        /// <summary>
        /// Removes last saved state and returns the next one
        /// </summary>
        /// <returns></returns>
        public static Grid Undo()
        {
            grids.Pop();
            return grids.Peek();
        }

        public static void SaveValid(Grid Valid)
        {
            ValidSolutions++;
            validGrids.Add(Valid);
        }

        public static ArrayList GetValids()
        {
            return validGrids;
        }
    }
}
