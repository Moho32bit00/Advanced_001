using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Advanced_001_Assignment
{
    #region Q11 
    //Q11) T must inherit from a specific class .
    public class Q11B
    {
        public int test { get; set; }
    }
    public class Q11C<T> where T : Q11B
    {
    }
    #endregion

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

        #region Q5 
        public void findnmax<T> (T []arr)where T : IComparable<T>
        {
            T max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
            }
        }
        #endregion

        #region Q13
        //Q13) it does return the default value of the T depending on the T Type.
        #endregion


        #region Q15
        /*
        Q15) covariance allows a method to return a type that is more derived than the type specified 
        in the generic parameter , out is the keyword 
        that is used to apply a covariance explicitly and it does mean that u can only
        use this generic type to return value.
        */
        #endregion

        #region Q16 
        /*
         Q16) it allows a method to accept an argument of a less derived 
        type than the one specified by the generic parameter ,in is the keyword 
        that is used to apply a contravariance explicitly and it means that u 
        can only take input with this generic type .
        */
        #endregion

        #region Q17
        /*
        Q17) the difference is that the contravarience does take IN keyword ("NO return type with the gemeric type ") , 
        while covariance does take out as the keyword ("you can not tale input using this generic type ").
        */
        #endregion

        #region Q18 
        /*
        Q18) Static fields, properties, and constructors are Created per closed generic type, not shared across all generic types.
        */
        #endregion

        #region Q19 
        /*
        Q19)lets say we have "derived class" and "base class" and 
        the derived does inherit for the base and they both have generic types , 
        the derived has to handle the base generic type by " :Base<T> " and also while making the constructor .
       */
        #endregion
    }
}
