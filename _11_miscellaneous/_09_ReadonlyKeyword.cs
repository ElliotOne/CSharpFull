namespace _11_Miscellaneous
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
