using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace structure
{
    class Program
{
    static void Main(string[] args)
    {
            Store store = new Store();
            store.AddToStore(1, 2, "a");
            store.AddToStore(3, 4, "b");
            store.AddToStore(5, 6, "c");
            int index = 0;
            Tuple<int, int, string> query = store.GetFromStoreAtIndex(index);
            Console.WriteLine($"x is {query.Item1} and y is {query.Item2} while data is {query.Item3}");
            Console.ReadKey();
        }

        public class Store
        {
            private List<Tuple<int, int, string>> _store = new List<Tuple<int, int, string>>();

            public void AddToStore(int firstint, int secondint, string stringtostore)
            {
                _store.Add(new Tuple<int, int, string>(firstint, secondint, stringtostore));
            }
            
            public Tuple<int, int, string> GetFromStoreAtIndex(int index)
            { 
                return _store.ElementAt(index);
            }
        }
}
}

