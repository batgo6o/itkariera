using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster_3.BaseEntities
{
    abstract class Storage
    {
        private string name;
        private int capacity;
        private int garageSlots;
        private bool isFull;
        private IReadOnlyCollection<Vehicle> garage;
        private IReadOnlyCollection<Product> products;

        protected Storage(string nameInput, int capacityInput, int garageSlotsInput, IEnumerable<Vehicle> vehiclesInput)
        {
            name = nameInput;
            capacity = capacityInput;
            garageSlots = garageSlotsInput;
            garage = (IReadOnlyCollection<Vehicle>)vehiclesInput;
        }

        public Vehicle GetVehicle(int slotNumberInput)
        {
            if (garageSlots == 0)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            else if (slotNumberInput >= garageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            else
            {
                return garage.ElementAt(slotNumberInput);
            }
        }
        public int SendVehicleTo(int slotNumberInput, Storage deliveryLocationInput)
        {
            
            return 0;
        }
    }
}