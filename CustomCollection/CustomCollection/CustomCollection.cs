using System.Collections;

namespace CustomCollection;

public class CustomCollection<T>:ICollection<T>
{
        private const int _defaultCapacity = 4;

        private T?[] _items;
        private int _size;

        static readonly T?[] _emptyArray = Array.Empty<T?>();

        public CustomCollection()
        {
            _items = _emptyArray;
        }
        public CustomCollection(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (capacity == 0)
            {
                _items = _emptyArray;
            }
            else
            {
                _items = new T[capacity];
            }
        }
        public int Capacity
        {
            get
            {
                return _items.Length;
            }
            set
            {
                if (value < _size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        T?[] newItems = new T[value];
                        if (_size > 0)
                        {
                            Array.Copy(_items, 0, newItems, 0, _size);
                        }
                        _items = newItems;
                    }
                    else
                    {
                        _items = _emptyArray;
                    }
                }
            }
        }
        public int Count
        {
            get
            {
                return _size;
            }
        }

        public bool IsReadOnly { get; }

        public T? this[int index]
        {
            get
            {
                if (index >= _size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _items[index];
            }
            set
            {
                if (index >= _size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _items[index] = value;
            }
        }
        private void EnsureCapacity(int min)
        {
            if (_items.Length < min)
            {
                int newCapacity;
                if (_items.Length == 0)
                {
                    newCapacity = _defaultCapacity;
                }
                else
                {
                    newCapacity = _items.Length * 2;
                }
                if (newCapacity < min)
                {
                    newCapacity = min;
                }
                Capacity = newCapacity;
            }
        }
        public void Add(T? item)
        {
            if (_size == _items.Length)
            {
                EnsureCapacity(_size + 1);
            }
            _items[_size++] = item;
        }
        public void Clear()
        {
            if (_size > 0)
            {
                Array.Clear(_items, 0, _size);
                _size = 0;
            }
        }
        public bool Contains(T item)
        {
            if (item == null)
            {
                for (int i = 0; i < _size; i++)
                {
                    if (_items[i] == null)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                for (int i = 0; i < _size; i++)
                {
                    if (Equals(_items[i], item))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public void CopyTo(T[] array)
        {
            CopyTo(array, 0);
        }
        public void CopyTo(T[] array, int index)
        {
            Array.Copy(_items, 0, array, index, _size);
        }
        public int IndexOf(T item)
        {
            return Array.IndexOf(_items, item, 0, _size);
        }
        public int IndexOf(T item, int index)
        {
            if (index > _size)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Array.IndexOf(_items, item, index, _size - index);
        }
        public int IndexOf(T item, int index, int count)
        {
            if (index > _size)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (count < 0 || index > _size - count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Array.IndexOf(_items, item, index, count);
        }
        public void Insert(int index, T? item)
        {
            if (index > _size)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (_size == _items.Length)
            {
                EnsureCapacity(_size + 1);
            }
            if (index < _size)
            {
                Array.Copy(_items, index, _items, index + 1, _size - index);
            }
            _items[index] = item;
            _size++;
        }
        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }
        public void RemoveAt(int index)
        {
            if (index >= _size)
            {
                throw new ArgumentOutOfRangeException();
            }
            _size--;
            if (index < _size)
            {
                Array.Copy(_items, index + 1, _items, index, _size - index);
            }
            _items[_size] = default(T);
        }
        public void RemoveRange(int index,int count)
        {
            if(index<0)
            {
                throw new ArgumentOutOfRangeException();
                
            }
            if(count<0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(_size-index<count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(count>0)
            {
                _size = _size - count;
                if (index < _size)
                {
                    Array.Copy(_items, index + count, _items, index, _size - index);
                }
                Array.Clear(_items, _size, count);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(_items, _size);
        }
        public class Enumerator:IEnumerator<T>
        {
            public T?[] _items;
            public int _count;
            public int _size;
            private T _current;

            public Enumerator(T?[] items, int size)
            {
                _items = items;
                _size = size;
            }
            public object? Current
            {
                get
                {
                    return _items[_count++];
                } 
            }
            public bool MoveNext()
            {
                return _size > _count;
            }
            public void Reset()
            {
                throw new NotImplementedException();
            }

            T IEnumerator<T>.Current => _current;

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
}