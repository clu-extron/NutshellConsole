using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutshellConsole.Ch7
{
    public class Bank : IEnumerable<Customer>
    {
        public MyList<Customer> Customers { get; set; } = new MyList<Customer>(4);

        public Bank()
        {
            Customers.Add(new Customer(1, "Tom", "Corona"));
            Customers.Add(new Customer(2, "Andrew", "Eastvale"));
            Customers.Add(new Customer(3, "Jacob", "Chino"));
            Customers.Add(new Customer(4, "Greg", "Anaheim"));
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            return Customers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
