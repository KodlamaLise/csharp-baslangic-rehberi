using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList arr = new ArrayList();

            arr.Add(5);
            arr.Add("strValue");
            arr.Add("vidobu");
            arr.Add(12.3d);
            arr.Add(56.8m);
            arr.Add(true);

            foreach (var item in arr)
            {
                Console.WriteLine(string.Format("Type  : {0}\nValue : {1}\n", item.GetType(), item));
            }

            Console.ReadKey();

        }
    }
}
