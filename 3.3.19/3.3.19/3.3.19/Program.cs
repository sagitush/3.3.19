using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mobile> mobiles = new List<Mobile>() { new Mobile(1940, 5, 60, 700), new Mobile(1999, 6, 70, 900), new Mobile(2011, 5, 50, 600), new Mobile(2020, 8, 100, 1000) };
            mobiles.Sort();
            foreach(Mobile num in mobiles)
            {
                Console.WriteLine(num);
            }



        }
    }
}
