using _05_FlyWeight;

FlyWeightFactory flyWeightFactory= new FlyWeightFactory();

var result_1=flyWeightFactory.GetFlyWeight("Ali");
var result_2=flyWeightFactory.GetFlyWeight("Iman");
var result_3=flyWeightFactory.GetFlyWeight("Ali");

result_1.Operation("Result 1 Extrinsic State");
result_2.Operation("Result 2 Extrinsic State");
result_3.Operation("Result 3 Extrinsic State");

UnSharedConcreteFlyWeight unSharedConcreteFlyWeight = new UnSharedConcreteFlyWeight(new List<FlyWeight>()
{
    flyWeightFactory.GetFlyWeight("Ali"),
    flyWeightFactory.GetFlyWeight("Iman"),
    flyWeightFactory.GetFlyWeight("Sara"),
    flyWeightFactory.GetFlyWeight("Reza"),
});

unSharedConcreteFlyWeight.Operation("unSharedConcreteFlyWeight");