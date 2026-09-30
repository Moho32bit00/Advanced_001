using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_001_Assignment
{
    public class Container <T>
    {
        private T value;
        public T Value { get { return value; } set {this.value = value; } }
        public Container (T value)
        {
            this.value = value;
        }
        
    }
}
