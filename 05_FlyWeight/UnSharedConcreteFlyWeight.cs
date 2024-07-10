namespace _05_FlyWeight
{
    public class UnSharedConcreteFlyWeight
    {
        private IEnumerable<FlyWeight> _flyWeights;

        public UnSharedConcreteFlyWeight(IEnumerable<FlyWeight> flyWeights)
        {
            _flyWeights = flyWeights;
        }


        public void Operation(string extrinsicState)
        {
            foreach (var flyWeight in _flyWeights)
            {
                flyWeight.Operation(extrinsicState);
            }
        }
    }
}
