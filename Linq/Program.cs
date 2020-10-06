using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input =
                new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var output = from i in input
                         where i>5 && i%2 == 0 
                         select i;

            foreach( var i in output)
            {
                Console.WriteLine(i);
            }

        }
    }
}
