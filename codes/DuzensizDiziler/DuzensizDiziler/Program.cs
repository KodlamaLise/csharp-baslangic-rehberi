using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzensizDiziler
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new int[4][];

            arr[0] = new int[2];
            arr[0][0] = 1;
            arr[0][1] = 2;

            arr[1] = new int[1];
            arr[1][0] = 3;

            arr[2] = new int[3];
            arr[2][0] = 4;
            arr[2][1] = 5;
            arr[2][2] = 6;

            arr[3] = new int[4];
            arr[3][0] = 7;
            arr[3][1] = 8;
            arr[3][2] = 9;
            arr[3][3] = 10;

            foreach (var innerArr in arr)
            {
                foreach (var arrItem in innerArr)
                {
                    Console.Write(arrItem);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
