using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelse_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Test);
            Thread thread2 = new Thread(Test1);

            thread1.Start();
            thread2.Start();

            Console.Read();
        }
        public static void Test()
        {
            //Prints 5 times, with 1 sec interval
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
                Thread.Sleep(1000);
            }
        }
        public static void Test1()
        {
            //Prints 5 times, with 1 sec interval
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde...");
                Thread.Sleep(1000);
            }
        }
    }
}
