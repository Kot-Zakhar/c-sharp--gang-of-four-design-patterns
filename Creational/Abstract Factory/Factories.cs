using System;

namespace AbstractFactory {
    public interface IGUIFactory {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    public class LinuxGUIFactory : IGUIFactory {
        public IButton CreateButton() => new LinuxButton();
        public ICheckbox CreateCheckbox() => new LinuxCheckbox();
    }

    public class WindowsGUIFactory : IGUIFactory {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }

    public class MacGUIFactory : IGUIFactory {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
}