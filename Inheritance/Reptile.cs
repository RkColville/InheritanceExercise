using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        
        public bool ColdBlooded { get; set; }

        public int lungs { get; set; }

        public bool Scales { get; set; }

        public bool LayEggs { get; set; }

        public Reptile()
        {

        }
        public Reptile(string name, int eyes, int nose, int legs, bool coldBlooded, int lungs, bool Scales, bool layEggs);
        {

            Name = name;
            Eyes = eyes;
            Nose = nose;
            Legs = legs;
            ColdBlooded = coldBlooded;
            Lungs = lungs;
            Scales = scales;
            LayEggs = layEggs;
        }

    }
}
