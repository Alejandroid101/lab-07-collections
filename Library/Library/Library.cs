using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Library<T>: IEnumerable<T>
    {
        private T[] storage = new T[6];
        private int currentIndex = 0;

        public void Add(T item)
        {
            if (storage.Length == currentIndex)
            {
                Array.Resize(ref storage, storage.Length * 2);
            }
            storage[currentIndex] = item;
            currentIndex++;
        }



        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return storage[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
