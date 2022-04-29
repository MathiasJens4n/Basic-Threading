using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Opgave_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(RandomTemperature);

            thread1.Start(thread1);
            
            while (true)
            {
                //Checks if thread1 is alive, and breaks with a warning if thread1 gets terminated
                if (!thread1.IsAlive)
                {
                    Console.WriteLine("Alarm tråd termineret!");
                    break;
                }
                Thread.Sleep(10000);
            }

            Console.Read();
        }
        public static void RandomTemperature(object t)
        {
            Random rnd = new Random();

            int alarmCount = 0;


            while (true)
            {
                //Generates a random number between -20 and 120
                int rnd_temp = rnd.Next(-20, 121);
                //Gives a warning of the temp get below 0 or above 100 degrees
                if(rnd_temp < 0 || rnd_temp > 100)
                {
                    Console.WriteLine("Ekstra alarmlinje");
                    alarmCount++;
                }
                //Breaks if alarm count exceeds 3
                if(alarmCount == 3)
                {
                    break;
                }

                Console.WriteLine(rnd_temp);

                Thread.Sleep(2000);
            }
        }
    }
}
