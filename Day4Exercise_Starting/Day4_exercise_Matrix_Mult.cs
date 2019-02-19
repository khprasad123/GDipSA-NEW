using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise_Starting
{
    class Day4_exercise_Matrix_Mult
    {
        static void Main()
        {
            int row1 = int.Parse(Console.ReadLine());
            int col1 = int.Parse(Console.ReadLine());
            int row2 = int.Parse(Console.ReadLine());
            int col2 = int.Parse(Console.ReadLine());

            if (col1 != row2)
            {
                Console.WriteLine("\nViolation of matrix multiplication ");
                return;
            }



        }
    }
}
