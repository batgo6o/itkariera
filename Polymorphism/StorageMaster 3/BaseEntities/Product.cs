using System;
namespace StorageMaster_3.BaseEntities
{
    abstract class Product
    {
        private double price;
        private double weight;

        public Product(double price, double weight)
        {
            this.price = price;
            this.weight = weight;
        }

        public double Price 
        { 
            get => price; 
            private set
            {
                if(price < 0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }
            }   
        }
        public double Weight 
        { 
            get => weight; 
            private set => weight = value; 
        }
    }
}