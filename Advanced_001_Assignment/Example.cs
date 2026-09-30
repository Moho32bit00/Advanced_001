using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_001_Assignment
{

    #region Q10
    //Q10)  T must implement IExample .
   
    public class Example<T> where T : IExample<T>
    {
    }
     #endregion
}
