using NutshellConsole.Ch7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace NutshellConsole
{
    [MemoryDiagnoser()]
    public class BenchmarkTester
    {
        [Benchmark]
        public void ProcessCustomer()
        {
            var customers = GetCustomers(1000000);
            foreach (var c in customers)
            {
                if (c.Id < 1000)
                {
                    Console.WriteLine($"Customer ID {c.Id}, Customer Name: {c.Name}");
                }
                else
                {
                    break;
                }
            }
        }

        [Benchmark]
        public void ProcessCustomerYield()
        {
            var customers = GetCustomersYield(1000000);
            foreach (var c in customers)
            {
                if (c.Id < 1000)
                {
                    Console.WriteLine($"Customer ID {c.Id}, Customer Name: {c.Name}");
                }
                else
                {
                    break;
                }
            }
        }

        static IEnumerable<Customer> GetCustomers(int count)
        {
            var customers = new List<Customer>();
            for (int i = 0; i < count; i++)
            {
                customers.Add(new Customer(i, $"Alex{i}", $"Location{i}"));
            }
            return customers;
        }

        static IEnumerable<Customer> GetCustomersYield(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Customer(i, $"Alex{i}", $"Location{i}");
            }
        }
    }
}
