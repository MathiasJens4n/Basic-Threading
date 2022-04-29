using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelse_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Test);
            thread1.Start();

            Console.Read();
        }
        public static void Test()
        {
            //Prints 5 times
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
            }
        }
    }
}
