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

            Console.ForegroundColor = ConsoleColor.Green;

            foreach(Grid grid in GridSaver.GetValids())
            {
                Console.WriteLine(grid.ToString());
            }

            Console.WriteLine($"I found: {GridSaver.ValidSolutions} valid solutions");

            ////Console.WriteLine(testGrid.ToString());
            ////Console.WriteLine(testGrid.IsBoardValid());



        }

     }
}


