using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var toyBuilder = new ToyHouseBuilder();
            var realBuilder = new RealHouseBuilder();

            IHouseDirector director = new SimpleHouseDirector(toyBuilder);
            director.make(5);
            Console.WriteLine("Creating simple toy house:\n{0}\n", toyBuilder.GetResult());

            director.changeBuilder(realBuilder);
            director.make(3);
            Console.WriteLine("Creating simple real house:\n{0}\n", realBuilder.GetResult());

            director = new ExpensiveHouseDirector(toyBuilder);
            director.make(1);
            Console.WriteLine("Creating expensive toy house:\n{0}\n", toyBuilder.GetResult());

            director.changeBuilder(realBuilder);
            director.make(2);
            Console.WriteLine("Creating expensive real house:\n{0}\n", realBuilder.GetResult());
            
        }
    }
}
