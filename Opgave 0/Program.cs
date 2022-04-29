using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_tråd_øvelser
{
    public class Program
    {
        public void WorkThreadFunction()
        {

            //Prints 5 times
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Simple Thread");
            }
            //Prints the thread name
            Console.WriteLine(Thread.CurrentThread.Name); 
        }
    }
    public class TheProg
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Thread thread1 = new Thread(p.WorkThreadFunction);
            Thread thread2 = new Thread(p.WorkThreadFunction);

            //Naming the threads
            thread1.Name = "thread1";
            thread2.Name = "thread2";

            //Starts the threads
            thread1.Start();
            thread2.Start();

            Console.Read();
        }

    }
}
