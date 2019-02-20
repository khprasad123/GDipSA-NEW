using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise_Starting
{
    class Section_H_Q3_And_Q4
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter Original String : ");
                string input = Console.ReadLine();
                Console.Write("Enter Checking String : ");
                string check = Console.ReadLine();
                int f = inString(input, check);
                if (f == -1)
                    Console.WriteLine("Not Found");
                else
                    Console.WriteLine(check + "  Found at " + (f)+"\n");
            }
        }
        static int inString(string A,string B)
        {
            A=A.ToLower();
            B = B.ToLower();
           char[] a = A.ToCharArray();
            char[] b = B.ToCharArray();
            int index=-1;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[0])
                {
                   int t = b.Length;
                   index = i;
                   int temp_i = i;
                   for(int j = 0; j < t; j++)
                    {
                        if (b[j] != a[temp_i])
                        {
                            index = -1;
                            goto next;
                        }
                        temp_i++;
                    }
                    goto end;
                }
             next:;
            }
            end:;
            return index;
        }
    }
}
