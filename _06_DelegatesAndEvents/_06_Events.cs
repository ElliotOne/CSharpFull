using System;

namespace _06_DelegatesAndEvents
{
    public delegate void MyDelegate(string name);

    class _06_Events
    {
        public event MyDelegate MyEvent;

        private DisplayInformation displayInformation;
        public _06_Events()
        {
            MyEvent += new MyDelegate(sayHi);
            MyEvent += new MyDelegate(sayHi2);

            displayInformation = new DisplayInformation();
            displayInformation.DisplayDateAfterEvent += DisplayHello;
        }

        private void DisplayHello()
        {
            Console.WriteLine("Hello");
        }

        public void ThisIsMain()
        {
            _06_Events myObj = new _06_Events();
            myObj.MyEvent("Hello");
        }

        public void sayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void sayHi2(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
    }

    public class DisplayInformation
    {
        public delegate void DisplayDateAfterDelegate();
        public event DisplayDateAfterDelegate DisplayDateAfterEvent;

        public void DisplayClub(string clubName, string country)
        {
            Console.WriteLine($"{clubName} from {country}");

            if (DisplayDateAfterEvent != null)
            {
                DisplayDateAfterEvent();
            }

            //or use the below syntax:
            //DisplayDateAfterEvent?.Invoke();

            Console.WriteLine();
        }

        public void DisplayPlayer(string playerName, string clubName)
        {
            Console.WriteLine($"{playerName} from {clubName}");

            if (DisplayDateAfterEvent != null)
            {
                DisplayDateAfterEvent();
            }
        }
    }
}
