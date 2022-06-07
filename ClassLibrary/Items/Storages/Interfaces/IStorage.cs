using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Items.Storages.Interfaces
{
    public interface IStorage
    {
        float Capacity { get; }
        float MaxCapacity { get; }
    }
}
