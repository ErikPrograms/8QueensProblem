using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int GridHeight = 8;
            int GridWidth = 8;
            Console.Title = "Queens Program";
            Console.SetWindowSize(60, 32);
            Grid testGrid = new Grid(GridHeight, GridWidth);

            

            Backtracker.RunAI(testGrid);

            ////Console.WriteLine(testGrid.ToString());
            ////Console.WriteLine(testGrid.IsBoardValid());



        }

     }
}


