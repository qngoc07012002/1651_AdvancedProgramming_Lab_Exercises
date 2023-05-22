using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class AddRemoveCollection : IAddable, IRemovable
    {
        private List<string> collection;

        public AddRemoveCollection()
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

            string removedItem = collection.Last();
            collection.RemoveAt(collection.Count - 1);
            return removedItem;
        }

        public override string ToString()
        {
            return string.Join(" ", collection);
        }
    }
}
