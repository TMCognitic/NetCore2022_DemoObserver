using DemoObserver_UML.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver_UML
{
    public class Product : Subject
    {
        public string Name { get; init; }

        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public Product(string name)
        {
            Name = name;
        }
    }
}
