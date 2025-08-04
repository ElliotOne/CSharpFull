using System;

namespace _02_OOP_CountryExample_Full
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldNameSpace.Country Japan = new WorldNameSpace.Country();
            WorldNameSpace.CountryLanguages languages = new WorldNameSpace.CountryLanguages();

            languages.FirstLanguage = WorldNameSpace.Languages.Japanese;
            languages.SecondLanguage = WorldNameSpace.Languages.EnglishUS;

            Japan.CountryLanguages = languages;
            Japan.Capital = "Tokyo";
            Japan.Name = "Japan";
            Japan.Currency = WorldNameSpace.Currencies.JPY;
            Japan.PlanetName = "Earth";
            Japan.SayHi();
            Japan.SayHi(Japan.Name);

            Console.ReadLine();
        }
    }
}
