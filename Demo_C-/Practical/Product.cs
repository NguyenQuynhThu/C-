using System;

namespace Practical
{
    public class Product
    {
        public int id;
        public string name;
        public decimal price;

        public Product()
        {
        }

        public Product(int id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }
        
    }
}