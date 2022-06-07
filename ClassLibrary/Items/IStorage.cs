using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Items
{
    public interface IStorage
    {
        float Capacity { get; }
        float MaxCapacity { get; }
    }
}
