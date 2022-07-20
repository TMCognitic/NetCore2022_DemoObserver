using DemoObserver_UML.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver_UML
{
    public class Customer : Observer
    {
        public string Name { get; init; }

        public Customer(string name)
        {
            Name = name;
        }

        public override void Update(Subject subject)
        {
            Product? product = subject as Product;

            if(product is not null)
            {
                Console.WriteLine($"{Name} say the product price of {product.Name} changed! (new price : {product.Price})");
            }

        }
    }
}
