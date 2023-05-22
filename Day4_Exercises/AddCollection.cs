using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class AddCollection : IAddable
    {
        private List<string> collection;

        public AddCollection()
        {
            collection = new List<string>();
        }

        public int Add(string item)
        {
            collection.Add(item);
            return collection.Count - 1;
        }

        public override string ToString()
        {
            return string.Join(" ", collection);
        }
    }
}
