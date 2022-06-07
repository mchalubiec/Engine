﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Items
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
