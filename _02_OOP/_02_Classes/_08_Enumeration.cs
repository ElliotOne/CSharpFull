using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._02_Classes
{
    class _08_Enumeration
    {
        public Seasons seasons = Seasons.Fall;
        public WeekDay weekDay = WeekDay.Saturday;

        string day = WeekDay.Friday.ToString();
        int dayNumber = (int)WeekDay.Monday;
    }
    enum Seasons
    {
        //indexes start from 0
        Spring,Summer,Fall,Winter
    }
    enum WeekDay
    {
        Monday,
        Tuesaday,
        Wednesday,
        Friday,
        Saturday,
        Sunday
    }
}
