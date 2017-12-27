using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // (initialize; condition; increment aka loop control variable)
            for (int x = 10; x < 15; x++)
            {
                Console.WriteLine("Value of x: {0}", x);
            }
            /*
            Value of x: 10
            Value of x: 11
            Value of x: 12
            Value of x: 13
            Value of x: 14
            */
        }
    }
}
