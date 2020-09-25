using System;
using System.Collections.Generic;
namespace StorageMaster_3.BaseEntities
{
    abstract class Vehicle
    {
        private int capacity;
        private List<Product> trunkTemp;
        private IReadOnlyCollection<Product> trunk;
        private bool isFull;
        private bool isEmpty;
        private double capacityLeft;

        public Vehicle(int capacityInput)
        {
            capacity = capacityInput;
            capacityLeft = capacity;
            trunkTemp = new List<Product>();
            trunk = trunkTemp;
            isFull = false;
            isEmpty = true;
        }

        internal void LoadProduct(Product product)
        {
            if (isFull == true)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            else
            {
                if (isEmpty == true)
                {
                    isEmpty = false;
                }
                if (capacityLeft >= product.Weight)
                {
                    trunkTemp.Add(product);
                    capacityLeft -= product.Weight;
                    
                }
                else
                {
                    isFull = true;
                }
            }
        }
    }
}