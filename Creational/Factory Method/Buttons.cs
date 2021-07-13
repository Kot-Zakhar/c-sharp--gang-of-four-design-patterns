using System;

namespace FactoryMethod {
    public interface IButton {
        void Click();
    }

    public class LinuxButton : IButton {
        public void Click() {
            Console.WriteLine("Clicking linux button");
        }

        public override string ToString()
        {
            return "Linux button";
        }
    }
    
    public class MacButton : IButton {
        public void Click() {
            Console.WriteLine("Clicking mac button");
        }

        public override string ToString()
        {
            return "Mac button";
        }
    }
    
    public class WindowsButton : IButton {
        public void Click() {
            Console.WriteLine("Clicking windows button");
        }

        public override string ToString()
        {
            return "Windows button";
        }
    }
}