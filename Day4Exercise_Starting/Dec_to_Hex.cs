using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise_Starting
{
    class Dec_to_Hex
    {
        static string[] HEX = { "A", "B", "C", "D","E","F"};
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter the Decimal number to Convert To HEX :");
                bool f = int.TryParse(Console.ReadLine(), out int n);
                if (f)
                {
                    PrintHex(n);
                }
                else
                    Console.WriteLine("Enter Only decimal Number");
            }
        }
        static void PrintHex(int n)
        {
            string output = "";
            int rem = 0;
            int res = n;
            while (res != 0)
            {
                rem = res % 16;
                res = res / 16;
                if (rem >= 10)
                {
                    output += HEX[rem % 10];
                }
                else
                    output += rem.ToString();
            }
            int i =output.Length-1;
            Console.Write("\t\t\t\t\t    ");
            while (i>=0)
            {
                Console.Write(output[i--]);
            }
            Console.Write("\n");
        }
    }
}
