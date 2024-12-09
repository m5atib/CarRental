using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BL
{
    public class CustomerRepo
    {
        private List<Customer> customers = [];

        // Indexer
        public Customer this[int index]
        {
            get
            {
                if (index < 0 || index >= customers.Count)
                    throw new IndexOutOfRangeException("Invalid index.");
                return customers[index];
            }
            set
            {
                if (index < 0 || index >= customers.Count)
                    throw new IndexOutOfRangeException("Invalid index.");
                customers[index] = value;
            }
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
