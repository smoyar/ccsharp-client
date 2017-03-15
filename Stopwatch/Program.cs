using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStopwatch = new Stopwatch();

            /* Console.WriteLine("Please enter to start stopwatch");
             Console.ReadLine();
             myStopwatch.Start();

             Console.WriteLine("Please enter to start stopwatch");
             Console.ReadLine();
             myStopwatch.Start();
             */
            Console.WriteLine("Please enter to start stopwatch");
            Console.ReadLine();
            myStopwatch.Start();

            Console.WriteLine("Please enter to stop stopwatch");
            Console.ReadLine();
            myStopwatch.Stop();

            Console.WriteLine("Please enter to stop stopwatch");
            Console.ReadLine();
            myStopwatch.Stop();

            Console.WriteLine($"Duration is : {myStopwatch.Duration}");
            }
        }
    }