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
            getCalc(Report);
           

        }
        static int[,] getArray(int nStudent,int nSubject) //FOR INPUTIINF THE ITEMS
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

        static void getCalc(int[,] Report)//ALL THE CALCULATIONS WILL DONE HERE
        {
            //FOR NORMAL OUTPUT
            double[] SubAvg = new double[Report.GetLength(1)];
            avgOutput(ref Report, ref SubAvg);
            //FOR EACH SUbJECT AVERAGE AND STANDARD DEVIATIOn
            stDeviation(ref Report,ref SubAvg);
        }
        static void PrintMatrix(int[,] A)
        {
            
            Console.Write("Student".PadRight(10, ' '));

            for (int k = 0; k <A.GetLength(1); k++)
            {
                Console.Write("Sub" + (k + 1).ToString().PadRight(10,' '));
            }
            Console.WriteLine("\n");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                Console.Write((i + 1).ToString().PadRight(10,' '));
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j].ToString().PadRight(10,' '));
                }
                Console.Write("\n\n");
            }
        }


        static void avgOutput( ref int [,] Report,ref double[] SubAvg)
        {
            Console.WriteLine("Student".PadRight(10, ' ') + "Total".PadRight(10, ' ') + "Avg".PadRight(10, ' '));
            for (int i = 0; i < Report.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < Report.GetLength(1); j++)
                {
                    sum += Report[i, j];
                    SubAvg[j] += Report[i, j]; //calculate sum of each subject PUT IT AN ARRAY
                }
                //PRINTING THE TOTAL AND AVERAGE
                Console.Write((i + 1).ToString().PadRight(10,' ') + sum.ToString().PadRight(10,' '));
                Console.Write(Math.Round(sum / (Report.GetLength(1))) + "\n\n\n");
            }
        }

        static void stDeviation(ref int[,] Report,ref double[] SubAvg)
        {
            double[] Avg = new double[Report.GetLength(1)];
            double SumOfx_m_square = 0, variance;
            Console.WriteLine("Subject".PadRight(10, ' ')+"Avg Mark".PadRight(10,' ')+"StdDev".PadRight(10,' '));
            for (int i = 0; i < SubAvg.Length; i++)
            {
                Avg[i] = SubAvg[i] / (Report.GetLength(0));
                Console.Write((i + 1).ToString().PadRight(10,' ') +Math.Round(Avg[i],4).ToString().PadRight(10,' ')); //will find the avg of each subject
                for (int k = 0; k < Report.GetLength(0); k++)
                {
                        SumOfx_m_square += Math.Pow((Report[k, i] - Avg[i]), 2);   ///
                }
                variance = SumOfx_m_square / Report.GetLength(0);
                //Console.WriteLine(" Varience for Subject " + (i + 1) + " is " + variance + "\n\n");
                Console.Write(Math.Round(Math.Sqrt(variance),4).ToString().PadRight(10,' ')+"\n");
            }
            Console.WriteLine("\n\n");
        }

    }
}
