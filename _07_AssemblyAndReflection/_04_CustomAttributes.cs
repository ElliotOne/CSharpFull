using System;

namespace _07_AssemblyAndReflection
{
    class _04_CustomAttributes
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class Developer : Attribute
    {
        public Developer(string name, bool reviewed, string msg)
        {
            DeveloperName = name;
            IsReviewed = reviewed;
            Message = msg;
        }

        public string DeveloperName { get; set; }
        public bool IsReviewed { get; set; }
        public string Message { get; set; }
    }

    [Developer("Elliot", false, "This need to be finished")]
    class AnotherClass
    {

    }
}
