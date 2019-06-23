using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_CountryExample_Full
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldNameSpace.Country Iran = new WorldNameSpace.Country();
            WorldNameSpace.CountryLanguges languges = new WorldNameSpace.CountryLanguges();
            languges.FirstLanguage = WorldNameSpace.Languages.Perian.ToString();
            languges.SecondLanguage = WorldNameSpace.Languages.Arabic.ToString();
            Iran.CountryLanguges = languges;
            Iran.Capital = "Tehran";
            Iran.CountryName = "Islamic Rebulic Of Iran";
            Iran.Currecncy = WorldNameSpace.Currecncies.Rial;
            Iran.PlanetName = "Earth";
            Iran.SayHi();
            Iran.SayHi(Iran.CountryName);


            Console.ReadLine();
        }
    }
}
