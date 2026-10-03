using System;
using System.Collections.Generic;
using System.Text;
#region Q14
namespace Advanced_001_Assignment
{
    public  class SafeList<T>
    {
        private List<T> _list;
        public SafeList(int size )
        {
            _list  = new List<T>(size); 
        }
        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < _list.Count;
        }
        public void Add(T item) => _list.Add(item);
        public int Count => _list.Count;
        public T this[int index]
        {
            get
            {
                if (!IsValidIndex(index))
                {
                    return default!;
                }
                return _list[index];
            }
            set
            {
                if (IsValidIndex(index))
                {
                    _list[index] = value;
                }
            }
        }
    }
}
#endregion 