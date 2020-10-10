using System.Collections.Generic;
namespace StorageMaster_3.BaseEntities
{
    abstract class Storage
    {
        private string name;
        private int capacity;
        private int garageSlots;
        private bool isFull;
        private IReadOnlyCollection garage;
    }
}