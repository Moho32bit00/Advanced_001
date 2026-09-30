using System.ComponentModel;

namespace Advanced_001_Assignment
{

    internal class Program
    {
        #region Q1
        //Q1) it is a class that decide the type of its fields or methods by the user 
        //so u don't re write the same code with another data type  , because it is reusable , type-safe , it does apply a cleaner code and better performance 
        #endregion


        #region Q4 
        //Q4) it is a method that takes any type in the parameters depending on the user using it can be applyied with or without a class .
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }
}
