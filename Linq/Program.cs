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
                         orderby i ascending
                         select i;

            foreach( var i in output)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("####################");


            var output2 = from i in input
                          where i % 2 == 0
                          select new
                          {
                              A = i * 2,
                              B = i * i,
                              C = 100,
                              name = "사람" + i
                          };

            foreach(var i in output2)
            {
                Console.WriteLine(i.A);
            }

        }
    }
}
