using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Builder
{
    public class Product
    {
        public string Part1 { get; set; }

        public string Part2 { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Part1:{Part1} Part2:{Part2}");
        }

    }
}
