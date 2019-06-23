using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._04_Encapsulation
{
    public class _01_AnimalExample
    {
        private string privateVariable;
        public string publicVariable;
        protected string protectedVariable;
        internal string internalVariable;

        private void privateMethod(){}
        public void publicMethod(){}
        protected void protectedMethod(){}
        internal void internalMethod(){}
    }

    class Dogs :_01_AnimalExample
    {
        Dogs dog = new Dogs();
        void FeedDog()
        {
            dog.protectedMethod();
            dog.protectedVariable = "protected";
            dog.publicMethod();
            dog.publicVariable = "public";
            dog.internalMethod();
            dog.internalVariable = "internal";
        }
    }

    class Cats
    {
        _01_AnimalExample animal = new _01_AnimalExample();
        void FeedCat()
        {
            animal.publicVariable = "public";
            animal.publicMethod();
            animal.internalMethod();
            animal.internalVariable = "internal";
        }
    }
}
