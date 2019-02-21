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
        private static ArrayList validGrids = new ArrayList();
        public static int ValidSolutions = 0;
        public static Pointer pointer = new Pointer(0, 0);


        public static void SaveValid(Grid Valid)
        {
            ValidSolutions++;
            validGrids.Add(Valid);
        }

        public static ArrayList GetValids()
        {
            return validGrids;
        }

        public static bool IsNotADoup(Grid grid)
        {
            foreach(Grid g in validGrids)
            {
                if (g.Equals(grid))
                {
                    return false;
                }
            }

            return true;
        }
}
    }

