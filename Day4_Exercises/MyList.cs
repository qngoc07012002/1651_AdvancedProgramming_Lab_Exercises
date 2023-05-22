using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class MyList : IAddable, IRemovable, ICountable
    {
        private List<string> collection;

        public MyList()
        {
            collection = new List<string>();
        }

        public int Add(string item)
        {
            collection.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            if (collection.Count == 0)
                throw new InvalidOperationException("The collection is empty.");

            string removedItem = collection.First();
            collection.RemoveAt(0);
            return removedItem;
        }

        public int Used => collection.Count;

        public override string ToString()
        {
            return string.Join(" ", collection);
        }
    }
}
