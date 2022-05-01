using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Opgave_4
{
    public class Program
    {
        public static char Ch { get; set; }

        static void Main(string[] args)
        {
            Ch = '*';
            Thread printer = new Thread(Print);
            Thread reader = new Thread(ReadInput);

            reader.Start();
            printer.Start();

        }
        public static void ReadInput()
        {

            while (true)
            {
                //Remembers  last key pressed
                char chosenKey = Convert.ToChar(Console.ReadKey(true).KeyChar);

                //Sets the ch field to the chosen key, if the enter key gets pressed
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Ch = chosenKey;
                    Console.Write("\n");
                }
            }
            
        }
        public static void Print()
        {
            //Continuously print the ch character
            while (true)
            {
                Console.Write(Ch);

                Thread.Sleep(100);
            }
        }
    }
}
