using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program draws GUI depending on OS (\"Linux\", \"Windows\", \"Mac\").");
            while(true) {
                Console.WriteLine();
                Console.WriteLine("Write your OS type:");
                string type = Console.ReadLine();
                IGUIFactory factory;
                if (type == "Linux") {
                    factory = new LinuxGUIFactory();
                } else if (type == "Windows") {
                    factory = new WindowsGUIFactory();
                } else if (type == "Mac") {
                    factory = new MacGUIFactory();
                } else {
                    Console.WriteLine("type is not supported.");
                    continue;
                }

                BusinessLogic(factory);
            }
            
        }

        static void BusinessLogic(IGUIFactory factory) {
            Console.WriteLine("Drawing window using factory:");

            IButton btn = factory.CreateButton();
            Console.WriteLine("Drawing \"{0}\"", btn);
            btn.Click();

            ICheckbox chk = factory.CreateCheckbox();
            Console.WriteLine("Drawing \"{0}\"", chk);
            chk.Check();            
        }
    }
}
