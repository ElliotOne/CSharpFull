namespace _01_Basic
{
    public class _08_LogicalOperators
    {
        void SimpleMethod()
        {

            int a = 2, b = 4;
            bool isEqaul = a == b;
            bool isABigger = a > b;
            bool isASmaller = a < b;

            //&& : And
            //|| : Or
            // ! : Not
            string msg = string.Empty;
            if (2 == 2 || 3 < 6)
            {
                msg = "It is true!";
            }
            if (2 > 3 && 1 == 1 && true)
            {
                msg = "It is false!";
            }
            if (!false)
            {
                msg = "It is true!";
            }
        }
    }
}
