namespace _02_OOP._01_Methods
{
    public class _02_ValueVsReference
    {
        void getStringCopy(string str)
        {
            str = "New data won't change str outside method";
        }

        void getStringReference(ref string str)
        {
            str = "String will change outside the method";
        }

        int outString(out string str,int data)
        {
            str = "String will change outside the method";
            return data * 3;
        }
    }
}
