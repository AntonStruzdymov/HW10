using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10Library
{
    public class ItemsEnum : IEnumerator<MyItem>
    {
        private MyItem[] _items;
        public ItemsEnum(MyItem[] item)
        {
            _items = item;
        }
        int position = -1;
        public MyItem Current
        {
            get
            {
                try
                {
                    return _items[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
       

        public bool MoveNext()
        {
            position++;
            return (position < _items.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
    