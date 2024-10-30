namespace _10_Builder
{
    public class CocreteProductBuilder2 : Builder
    {
        public override void BuildPart1()
        {
            product.Part1 = "CocreteProductBuilder2.BuildPart1()";
        }

        public override void BuildPart2()
        {
            product.Part2 = "CocreteProductBuilder2.BuildPart2()";
        }
    }
}
