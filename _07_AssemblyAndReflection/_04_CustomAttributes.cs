using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_AssemblyAndReflection
{
    class _04_CustomAttributes
    {

    }
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class Developer : System.Attribute
    {
        private string developerName;
        private bool isReviewed;
        private string message;

        public Developer(string name,bool reveiewd,string msg)
        {
            developerName = name;
            isReviewed = reveiewd;
            message = msg;
        }

        public string DeveloperName
        { get => developerName;set=> developerName = value; }
        public bool IsReviewed
        {get => isReviewed;set => isReviewed = value;}
        public string Message
        { get => message; set => message = value; }
    }

    [Developer("Ali",false,"This need to be finishe")]
    class anotherClass
    {

    }
}
