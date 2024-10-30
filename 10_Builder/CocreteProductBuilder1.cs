using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Builder
{
    public class CocreteProductBuilder1 : Builder
    {
        public override void BuildPart1()
        {
            product.Part1 = "CocreteProductBuilder1.BuildPart1()";
        }

        public override void BuildPart2()
        {
            product.Part2 = "CocreteProductBuilder1.BuildPart2()";
        }
    }
}
