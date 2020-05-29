using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueKeyword
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
