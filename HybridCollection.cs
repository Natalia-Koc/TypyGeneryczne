using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TemplatesForTypesAndMethods_5_
{
    class HybridCollection<T> : IList<T>, ICollection<T>, IEnumerable<T> 
    {
        public T[] tab = new T[100];
        int licznik = 0;
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(T item)
        {
            tab[licznik] = item;
            licznik++;
        }

        public T QueuePeek()
        {
            return tab[0];
        }
        public T Dequeue()
        {
            T tab0 = tab[0];
            for (int i = 0; i < licznik; i++)
            {
                tab[i] = tab[i+1];
            }
            licznik--;
            return tab0;
        }

        public void ShowList()
        {
            for (int i = 0; i < licznik; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        public void Push(T item)
        {
            tab[licznik] = item;
            licznik++;
        }
        public T StackPeek()
        {
            return tab[licznik-1];
        }

        public T Pop()
        {
            tab[licznik-1] = tab[licznik];
            licznik--;
            return tab[0];
        }
    }
}
