using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinus2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gary, lary;
            string str = Console.ReadLine();
            var res = str.Split(' ').Select(item => Convert.ToInt32(item)).ToArray();
            gary = res[0];
            lary = res[1];
            gary--;
            lary--;
            Console.Write(lary + " " + gary);
            Console.ReadKey();
        }
    }
}
