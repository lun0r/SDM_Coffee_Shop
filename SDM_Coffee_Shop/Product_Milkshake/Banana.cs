﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    internal class Banana : Milkshake
    {
        public bool IsFrozenFruit { get; set; }

        public Banana()
        {
            
            Name = "Banana Shake";
            Price = 5.99;
            Image = "banana";
            Description = "With a few ingredients, a banana milkshake is easy to make and is super satisfying. It can be made in minutes. What's not to like?! Now the question is, with dairy or without?";
        }
    }
}