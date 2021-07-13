using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program shows dialog depending on OS (\"Linux\", \"Windows\", \"Mac\").");
            while(true) {
                Console.WriteLine();
                Console.WriteLine("Write your OS type:");
                string type = Console.ReadLine();
                Dialog dlg;
                if (type == "Linux") {
                    dlg = new LinuxDialog();
                } else if (type == "Windows") {
                    dlg = new WindowsDialog();
                } else if (type == "Mac") {
                    dlg = new MacDialog();
                } else {
                    Console.WriteLine("type is not supported.");
                    continue;
                }

                dlg.Render();
                dlg.ClickBtn();
            }   
        }
    }
}
