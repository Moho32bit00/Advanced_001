using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_001_Assignment
{
    #region Q12
    public  class MultipleC <T> where T : Example<T>, IExample<T>,  new() 
    {

    }
    #endregion 
}
