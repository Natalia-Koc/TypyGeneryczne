using System;
using System.Collections.Generic;

namespace TemplatesForTypesAndMethods_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericMetodsTEST();
            Console.WriteLine();
            Console.WriteLine();
            GenericClassTEST();
            Console.WriteLine();
            Console.WriteLine();
            HybridCollectionTEST();
        }

        static public void GenericMetodsTEST()
        {
            Console.WriteLine("Generic metods:\n\nORIGINAL VERSION:");
            Person person1 = new Person("Natalia", "Koć", 21);
            Person person2 = new Person("Kamila", "Koć", 23);
            Console.WriteLine(person1.ToString() + "\n" + person2.ToString());

            Console.WriteLine("\nSPAW:");
            GenericMetods.Swap(ref person1, ref person2);
            Console.WriteLine(person1.ToString() + "\n" + person2.ToString());

            Console.WriteLine("\nGET BIGGER ONE:");
            Console.WriteLine(GenericMetods.GetBiggerOne(person1.Wiek, person2.Wiek).ToString());

            Console.WriteLine("\nSORT: (2, 3, 6, 4, 8, 1, 5, 7)");
            foreach (var item in GenericMetods.UseParamsAndSort(2, 3, 6, 4, 8, 1, 5, 7))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nQUEUE OR STACK? (2, 3, 6, 4, 8, 1, 5, 7)");
            Console.WriteLine(GenericMetods.ReturnQueueOrStack(2, 3, 6, 4, 8, 1, 5, 7).GetType().Name);
        }

        static public void GenericClassTEST()
        {
            List<GenericClass<int, int, int, int>> genericClasses = new List<GenericClass<int, int, int, int>>();
            genericClasses.Add(new GenericClass<int, int, int, int>(1, 1, 1, 1));
            genericClasses.Add(new GenericClass<int, int, int, int>(3, 2, 2, 2));
            genericClasses.Add(new GenericClass<int, int, int, int>(7, 3, 3, 3));
            genericClasses.Add(new GenericClass<int, int, int, int>(2, 4, 4, 4));

            Console.WriteLine("\n \nGeneric class\n\nORIGINAL VERSION:");
            foreach (var item in genericClasses)
            {
                Console.WriteLine(item);
            }

            genericClasses.Sort();

            Console.WriteLine("\nList sorted by identifier:");
            foreach (var item in genericClasses)
            {
                Console.WriteLine(item);
            }
        }

        static public void HybridCollectionTEST()
        {
            HybridCollection<int> vs = new HybridCollection<int>();
            vs.Enqueue(1);
            vs.Enqueue(2);
            vs.ShowList();
            Console.WriteLine(vs.QueuePeek());
            Console.WriteLine(vs.Dequeue());
            Console.WriteLine(vs.QueuePeek());
            Console.WriteLine(vs.Dequeue());
            Console.WriteLine();
            vs.Push(1);
            vs.Push(2);
            Console.WriteLine(vs.StackPeek());
            vs.Pop();
            Console.WriteLine(vs.StackPeek());
        }
    }
}
