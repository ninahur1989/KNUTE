using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06.MyList
{
    internal class MyList<T>
    {
        private T[] _date = new T[0];

        public IEnumerator GetEnumerator()
        {
            return new Enumerator<T>(_date);
        }

        public void Add(T item)
        {
            Array.Resize(ref _date, _date.Length + 1);
            _date[_date.Length - 1] = item;
        }

        public void AddRange(T[] your)
        {
            if (your.Length == 0)
            {
                throw new NullReferenceException();
            }

            Array.Resize(ref _date, _date.Length + your.Length);
            int p = _date.Length;
            for (int i = 0; i < your.Length; i++)
            {
                _date[p - your.Length] = your[i];
                p++;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < _date.Length)
            {
                Array.Copy(_date, index + 1, _date, index, _date.Length - index - 1);
                Array.Resize(ref _date, _date.Length - 1);
            }
        }

        public int IndexOf(T item)
        {
            Contract.Ensures(Contract.Result<int>() >= -1);
            Contract.Ensures(Contract.Result<int>() < _date.Length);
            return Array.IndexOf(_date, item, 0, _date.Length);
        }

        public void Sort()
        {
            Array.Sort(_date);
        }

        public void Remove(T your)
        {
            for (int i = 0; i < _date.Length; i++)
            {
                if (_date.Contains(your))
                {
                    RemoveAt(IndexOf(your));
                }
            }
        }
    }
}

