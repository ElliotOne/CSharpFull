namespace WorldNameSpace
{
    public abstract class World
    {
        private string planetName;
        private Continents continent;

        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }

        public Continents Continent
        {
            get { return continent; }
            set { continent = value; }
        }
    }

    public class Country : World
    {
        private string countryName;
        private string capital;
        private Currencies currency;
        private CountryLanguages languages;

        public string Name
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public Currencies Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public CountryLanguages CountryLanguages
        {
            get { return languages; }
            set { languages = value; }
        }

        public Country()
        {
            countryName = "Unknown";
            capital = "Unknown";
        }

        public string SayHi()
        {
            return "Welcome there ...";
        }

        public string SayHi(string country)
        {
            return $"Welcome to {country}!";
        }
    }

    public struct CountryLanguages
    {
        private Languages firstLanguage;
        private Languages secondLanguage;

        public Languages FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }

        public Languages SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }
    }

    public enum Continents
    {
        Asia,
        Africa,
        Antarctica,
        Europe,
        NorthAmerica,
        SouthAmerica,
        Australia
    }

    public enum Currencies
    {
        USD,  // US Dollar
        EUR,  // Euro
        GBP,  // British Pound
        CNY,  // Chinese Yuan
        JPY,  // Japanese Yen
        SEK,  // Swedish Krona
        PLN,  // Polish Zloty
        EGP,  // Egyptian Pound
        INR   // Indian Rupee
    }

    public enum Languages
    {
        Arabic,
        EnglishUS,
        EnglishUK,
        Japanese,
        Polish,
        Greek,
        Dutch,
        French,
        Spanish,
        German,
        Chinese
    }
}
