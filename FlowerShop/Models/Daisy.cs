using System;
using System.Collections.Generic;

namespace interfaces
{
    class Daisy : IMothersDayFlower, IWeddingFlower
    {
       public int petalCount { get; set;}

        public bool doesItSmellNice {get; set;}

        public int stemLength {get; set;}
        public string color { get; set; }
    }
}
