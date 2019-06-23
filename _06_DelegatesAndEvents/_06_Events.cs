using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DelegatesAndEvents
{
    public delegate void myDelegate(string name);
    class _06_Events
    {
        public event myDelegate myEvent;

        private DisplayInformation displayInformation;
        public _06_Events()
        {
            myEvent += new myDelegate(sayHi);
            myEvent += new myDelegate(sayHi2);

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
            myObj.myEvent("Hello");
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

        public void displayClub(string clubName,string country)
        {
            Console.WriteLine($"{clubName} from {country}");
            DisplayDateAfterEvent();
            Console.WriteLine();
        }

        public void displayPlayer(string playerName,string clubName)
        {
            Console.WriteLine($"{playerName} from {clubName}");
            DisplayDateAfterEvent();
        }
    }
}
