using _10_Builder;

Director director = new Director();
var builder_1 = new CocreteProductBuilder1();
var builder_2 = new CocreteProductBuilder2();

director.SetProductBuilder(builder_1);
director.Construct();

var product_01 = builder_1.GetResult();
product_01.PrintInfo();


director.SetProductBuilder(builder_2);
director.Construct();

var product_02 = builder_2.GetResult();
product_02.PrintInfo();