using System;
using StorageMaster_3.BaseEntities;
using StorageMaster_3.EntitiesProduct;
using StorageMaster_3.EntitiesVehicle;

namespace StorageMaster_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product gpu = new GPU(1200);
            System.Console.WriteLine(gpu.Weight);
            Vehicle van = new Van();
            van.LoadProduct(gpu);
        }
    }
}
