using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{

    public class Enumerator<T> : IEnumerator
    {
        private T[] _date = new T[0];
        private int _position = -1;
        public Enumerator(T[] date)
        {
            _date = date;
        }

        public T Current
        {
            get
            {
                if (_position == -1 || _position >= _date.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return _date[_position];
            }
        }

        object IEnumerator.Current => _date[_position];

        public bool MoveNext()
        {
            if (_position < _date.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
