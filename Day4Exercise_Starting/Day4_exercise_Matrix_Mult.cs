using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise_Starting
{
    class Day4_exercise_Matrix_Mult
    {
        static int i = 0;
        static void Main()
        {
            Console.WriteLine("Enter No of Row And Coloumn in A matrix : ");
            int row1 = int.Parse(Console.ReadLine());
            int col1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter No of Row And Coloumn in B matrix : ");
            int row2 = int.Parse(Console.ReadLine());
            int col2 = int.Parse(Console.ReadLine());

            if (col1 != row2)
            {
                Console.WriteLine("\nViolation of matrix multiplication ");
                return;
            }
            Console.WriteLine("Enter Matrix A :");
            int[,] A = getMatrix(row1, col1);

            PrintMatrix(A);
            Console.WriteLine("Enter Matrix B :");
            int[,] B = getMatrix(row2, col2);

            PrintMatrix(B);

            int[,] C = MatrixMult(A, B,row1,col1,row2,col2);

            Console.WriteLine("After Multiplication :");
            PrintMatrix(C);

        }
        static int[,] getMatrix(int row,int col)
        {
           int[,] A = new int[row, col];
           for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    A[i, j] =int.Parse(Console.ReadLine());
                }
            }
            return A;
        }
        static int[,] MatrixMult(int [,] A,int [,] B,int row1,int col1,int row2,int col2)
        {
            int[,] C = new int[row1, col2];

      
            for(int i = 0; i < row1; i++)
            {
                for(int j = 0; j < col1; j++)
                {

                    for(int k = 0; k < col2; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }



            return C;
        }
        static void PrintMatrix(int[,] A)
        {
            for(int i = 0; i < A.GetLength(0); i++)
            {
                 for(int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(" \t" + A[i, j]);
                }
                Console.Write("\n\n");
            }
        }
    }
}
