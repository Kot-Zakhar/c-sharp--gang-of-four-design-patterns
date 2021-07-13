using System;

namespace FactoryMethod {
    public abstract class Dialog {
        private IButton _btn;
        public void Render() {
            _btn = this.createButton();
            Console.WriteLine("Creating and rendering \"{0}\".", _btn);
        }

        public void ClickBtn() {
            _btn.Click();
        }

        public abstract IButton createButton();
    }

    public class LinuxDialog : Dialog {
        public override IButton createButton() => new LinuxButton();
    }

    public class MacDialog : Dialog {
        public override IButton createButton() => new MacButton();
    }

    public class WindowsDialog : Dialog {
        public override IButton createButton() => new WindowsButton();
    }

}