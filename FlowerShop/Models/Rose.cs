using System;
using System.Collections.Generic;

namespace interfaces
{
    class Rose : IWeddingFlower
    {
        public string color {get; set;}

        public string species {get ; set;}

        public bool isItThorny {get; set;}

        public bool doesItSmellNice {get; set;}

        public int stemLength {get; set;}

    }
}
