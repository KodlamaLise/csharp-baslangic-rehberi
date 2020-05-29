using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //İlk ilk çıkar

            var fk = new Queue();

            fk.Enqueue("Adnan");
            fk.Enqueue("Zehra");
            fk.Enqueue("Selim");
            fk.Enqueue("Mehmet");

            Console.WriteLine(fk.Dequeue());
            Console.WriteLine(fk.Dequeue());
            Console.WriteLine(fk.Dequeue());
            Console.WriteLine(fk.Dequeue());


            Console.ReadKey();
        }
    }
}
