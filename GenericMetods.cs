using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TemplatesForTypesAndMethods_5_
{
    public static class GenericMetods 
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public static void TwoParameters<T, S>(ref T x, ref S y)
        {
            Console.WriteLine($"x: {x.GetType().Name}, {x.GetType().ToString()} \n" +
                            $"y: {y.GetType().Name}, {y.GetType().ToString()}");

            x = default(T);
            y = default(S);
        }
        public static T GetBiggerOne<T>(T x, T y) where T : IComparable<T>
        {
            if(x.CompareTo(y) > 0)
            {
                return x;
            }
            return y;
        }
        public static List<T> UseParamsAndSort<T>(params T[] tab) where T : IComparable<T>
        {
            List<T> a = tab.ToList();
            a.Sort();
            return a;
        }
        public static Dictionary<T, S> CreateDictionary<T, S>(T key, S value) where T: struct where S: class
        {
            Dictionary<T, S> dictionary = new Dictionary<T, S>(); 
            dictionary [key] = value;

            return dictionary;
        }
        public static void ReadDictionary<T, S>(Dictionary<T , S> dictionary) 
        {
            Console.WriteLine(dictionary);
        }
        public static ICollection ReturnQueueOrStack<T>(params T[] tab)
        {
            if (tab.Length < 3)
            {
                Queue<T> queue = new Queue<T>();
                foreach (var item in tab)
                {
                    queue.Enqueue(item);
                }
                return queue;
            }
            Stack<T> stack = new Stack<T>();
            foreach (var item in tab)
            {
                stack.Push(item);
            }
            return stack;
        }
    }
}
