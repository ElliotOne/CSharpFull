using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNameSpace
{
    public abstract class World
    {
        private string planetName;
        private Contienents contienents;

        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }
        public Contienents Contienents
        {
            get { return contienents; }
            set { contienents = value; }
        }
    }

    public class Country : World
    {
        private string countryName;
        private string capital;
        private Currecncies currecncy;
        private CountryLanguges countryLanguges;
        
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public Currecncies Currecncy
        {
            get { return currecncy; }
            set { currecncy = value; }
        }

        public CountryLanguges CountryLanguges
        {
            get { return countryLanguges; }
            set { countryLanguges = value; }
        }

        public Country()
        {
            countryName = "Unknown";
            capital = "Unknown";
        }
        public string SayHi()
        {
            return "Wlcome there ...";
        }
        public string SayHi(string country)
        {
            return $"Welcome to {country} !";
        }
    }

    public struct CountryLanguges
    {
        private string firstLanguage;
        private string secondLanguage;
        public string FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }

        public string SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }
    }
    public enum Contienents
    {
        Asia,
        Africa,
        Antractica,
        Europe,
        NorthAmerica,
        SouthAmerica
    }

    public enum Currecncies
    {
        USD,
        ELR,
        GBP,
        CNY,
        SEK,
        PLN,
        EGP,
        INR,
        Rial
    }

    public enum Languages
    {
        Arabic,
        EnglishUS,
        Perian,
        Polish,
        Greek,
        Dutch
    }
}
