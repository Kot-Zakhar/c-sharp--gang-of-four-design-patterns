using System;

namespace AbstractFactory {
    public interface ICheckbox {
        void Check();
    }

    public class LinuxCheckbox : ICheckbox {
        public void Check() {
            Console.WriteLine("Checking linux checkbox");
        }

        public override string ToString()
        {
            return "Linux checkbox";
        }
    }
    
    public class MacCheckbox : ICheckbox {
        public void Check() {
            Console.WriteLine("Checking mac checkbox");
        }

        public override string ToString()
        {
            return "Mac checkbox";
        }
    }
    
    public class WindowsCheckbox : ICheckbox {
        public void Check() {
            Console.WriteLine("Checking windows checkbox");
        }

        public override string ToString()
        {
            return "Windows checkbox";
        }
    }
}