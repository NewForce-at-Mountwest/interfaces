using System;

namespace interfaces{

    class Penguin : IWalking, ISwimming
    {
        public int numberOfLegs { get; set; }
        public int maximumDepth { get; set; }
        public bool isMammal { get; set; }
        public bool isSaltWater { get; set; }

        public string name {get; set;}
        public void slide(){
            Console.WriteLine($"{name} the penguin is sliding.");
        }

        public void swim()
        {
            Console.WriteLine($"{name} the penguin is swimming.");

        }

        public void walk()
        {
            Console.WriteLine($"{name} the penguin is walking.");

        }
    }

}