using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise_Starting
{
    class Day4_exercise_G_4_Student_Mark
    {   
        static void Main()
        {
            Console.Write("Enter the number of students :");
            int nStudent = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of Subjects : ");
            int nSubject = int.Parse(Console.ReadLine());
            
            int[,] Report = getArray(nStudent, nSubject);
            PrintMatrix(Report);
            getCalc(Report);
           

        }
        static int[,] getArray(int nStudent,int nSubject)
        {   
            int[,] A = new int[nStudent, nSubject];
            for(int i = 0; i < nStudent; i++)
            {
                Console.WriteLine("Enter the Marks for Student " + (i + 1) + " ");
                for(int j = 0; j < nSubject; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            PrintMatrix(A);
            return A;
        }
        static void getCalc(int[,] Report)
        {
            int[] SubAvg = new int[Report.GetLength(1)];
            for (int i = 0; i < Report.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < Report.GetLength(1); j++)
                {
                    sum += Report[i, j];
                    SubAvg[j] += Report[i, j]; //calculate sum of wach subject
                }
               
                Console.Write("Student " + (i + 1) + " total Marks : " + sum + "\t");
                Console.Write("Average Marks : " + (sum / (Report.GetLength(1))) + "\n\n\n");
            }

            for(int i = 0; i < SubAvg.Length; i++)
            {
                Console.Write("Subject " + (i + 1) + " : Average Marks : " + (SubAvg[i]/Report.GetLength(0))+ "\t"); //will find the avg of each subject
                //total sum of each sub mark /total number of students
            }
            Console.WriteLine();
            
        }
        static void PrintMatrix(int[,] A)
        {
            Console.Write("\t\t");
            for(int k = 0; k <A.GetLength(1); k++)
            {
                Console.Write("Sub" + (k + 1) + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                Console.Write("Student " + (i + 1));
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(" \t" + A[i, j]);
                }
                Console.Write("\n\n");
            }
        }


    }
}
