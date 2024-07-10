namespace _05_FlyWeight
{
    public class FlyWeightFactory
    {
        private readonly Dictionary<string, FlyWeight> _flyWeightDictionary=new Dictionary<string, FlyWeight>();

        public FlyWeight GetFlyWeight(string key)
        {
            FlyWeight? flyWeight;

            if(!_flyWeightDictionary.TryGetValue(key, out flyWeight))
            {
                flyWeight = new ConcreteFlyWeight(key);

                _flyWeightDictionary.Add(key, flyWeight);
            }

            return flyWeight;
        }
    }
}
