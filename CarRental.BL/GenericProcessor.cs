using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BL
{
    public class GenericProcessor<T>
    {
        private List<T> items = [];

        // Indexer
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= items.Count)
                    throw new IndexOutOfRangeException("Invalid index.");
                return items[index];
            }
            set
            {
                if (index < 0 || index >= items.Count)
                    throw new IndexOutOfRangeException("Invalid index.");
                items[index] = value;
            }
        }
        public void Add(T el)
        {
            items.Add(el);
        }
    }
}
