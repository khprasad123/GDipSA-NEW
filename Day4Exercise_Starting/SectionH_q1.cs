using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise_Starting
{
    class SectionH_q1
    {
        static void Main()
        {
            int num = ReadInteger();
           Console.WriteLine("Entered Integer:"+num);
        }

        static int ReadInteger()
        {
            
            while (true)
            {
                Console.Write("Enter an Integer : ");
                var num =int.TryParse( Console.ReadLine(),out int n);
                if (num)
                    return n;
            }
        }
    }
}
