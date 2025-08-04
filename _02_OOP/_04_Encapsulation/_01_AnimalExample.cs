namespace _02_OOP._04_Encapsulation
{
    public class _01_AnimalExample
    {
        private string privateVariable;
        public string publicVariable;
        protected string protectedVariable;
        internal string internalVariable;

        private void PrivateMethod() { }
        public void PublicMethod() { }
        protected void ProtectedMethod() { }
        internal void InternalMethod() { }
    }

    class Dogs : _01_AnimalExample
    {
        Dogs dog = new Dogs();
        void FeedDog()
        {
            dog.ProtectedMethod();
            dog.protectedVariable = "protected";
            dog.PublicMethod();
            dog.publicVariable = "public";
            dog.InternalMethod();
            dog.internalVariable = "internal";
        }
    }

    class Cats
    {
        _01_AnimalExample animal = new _01_AnimalExample();
        void FeedCat()
        {
            animal.publicVariable = "public";
            animal.PublicMethod();
            animal.InternalMethod();
            animal.internalVariable = "internal";
        }
    }
}
