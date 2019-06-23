using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _zz_OtherTopics
{
    class _09_ReadonlyKeyword
    {
        void ThisIsMain()
        {
           
        }
    }
    class ReadonlyClassEx
    {
        //Readonly fields can't be used in assigning values , and
        //set in properties
        readonly string animalName;
        public string AnimalName
        {
            get => animalName;
            //Error
            //set => animalName = value;
        }
        public ReadonlyClassEx(string name)
        {
            animalName = name;
        }

    }
}
