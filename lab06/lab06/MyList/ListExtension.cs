using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06.MyList
{
    internal static class ListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];

            int i = 0;
            foreach (var a in list)
            {
                array[i] = (T)a;
                i++;
            }

            return array;
        }
    }
}
