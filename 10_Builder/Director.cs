using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Builder
{
    public class Director
    {
        private Builder _builder;

        public void SetProductBuilder(Builder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
               _builder.BuildPart2();
            _builder.BuildPart1();
        }

    }
}
