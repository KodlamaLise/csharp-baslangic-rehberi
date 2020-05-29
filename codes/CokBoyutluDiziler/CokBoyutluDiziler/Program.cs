using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr2 = new int[3, 3];

            arr2[0, 0] = 1;
            arr2[0, 1] = 2;
            arr2[0, 2] = 3;

            arr2[1, 0] = 4;
            arr2[1, 1] = 5;
            arr2[1, 2] = 6;

            arr2[2, 0] = 7;
            arr2[2, 1] = 8;
            arr2[2, 2] = 9;

            var arr2_ = new int[,] { 
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            //Console.WriteLine(arr2[1,2]);
            //Console.WriteLine(arr2_[1, 2]);

            for (int i = 0; i < arr2_.GetLength(0); i++)
            {
                for (int j = 0; j < arr2_.GetLength(1); j++)
                {
                    Console.Write(arr2_[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
