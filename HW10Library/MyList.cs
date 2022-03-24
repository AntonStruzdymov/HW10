using System.Collections;

namespace HW10Library
{
    public class MyList : IList<MyItem>
    {
        
        private int _count;
        private MyItem[] _items = new MyItem[0];
        public MyList()
        {
            _count = 0;            
        }
        public MyItem this[int index] 
        { 
            get 
            {
                return _items[index];
            } 
            set 
            {
                _items[index] = value; 
            }
        }
       
        public int Count
        {
            get { return _count; }         
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(MyItem item)
        {
            Array.Resize(ref _items, ++_count );
            _items[_count - 1] = item;      
            
        }

        public void Clear()
        {
            Array.Clear(_items, 0, _count);
            _count = 0;
            Array.Resize(ref _items, _count);
        }

        public bool Contains(MyItem item)
        {
            foreach (var listitem in _items)
            {
                if(listitem == item)
                {
                    return true;
                }         
            }
            return false;
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                array.SetValue(_items[i], arrayIndex++);
            }
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            return  new ItemsEnum(_items);
        }

        public int IndexOf(MyItem item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, MyItem item)
        {
            Array.Resize(ref _items, ++_count );
            for (int i = _items.Length-2; i != 0 ; i--)
            {
                if (i > index)
                {
                    _items[i+1] = _items[i];
                }
                if(i == index)
                {
                    _items[i + 1] = _items[i];
                    _items[i] = item;
                }
            }
        }

        public bool Remove(MyItem item)
        {
            foreach (var listitem in _items)
            {
                if(listitem == item)
                {
                    RemoveAt(IndexOf(item));
                    return true;
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (i == _items.Length - 1)
                {
                    break;
                }
                if (i >= index)
                {
                    _items[i] = _items[i + 1];
                }
            }
            Array.Resize(ref _items, --_count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    
}