namespace _02_OOP._02_Classes
{
    class _08_Enumeration
    {
        public Seasons Seasons = Seasons.Fall;
        public WeekDay WeekDay = WeekDay.Saturday;

        string day = WeekDay.Friday.ToString();
        int dayNumber = (int)WeekDay.Monday;
    }
    enum Seasons
    {
        //indexes start from 0
        Spring, Summer, Fall, Winter
    }
    enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Friday,
        Saturday,
        Sunday
    }
}
