using System;
using System.Collections.Generic;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            // Flower shop
            FlowerStore myShop = new FlowerStore();
            List<Rose> bouquetOfRoses = myShop.createRoseBouquet();
            bouquetOfRoses.ForEach(r => Console.WriteLine(r.species));

            // -- Zoo -- //

            Bat henry = new Bat(){
                name = "Henry",
                maximumHeight = 100,
                speed=30,
                hasFeathers=false,
                isVampire=true,
            };

            henry.fly();

            Penguin harryTux = new Penguin(){
                name = "Harry Tux",
                isMammal = false,
                isSaltWater = true,
                maximumDepth = 10
            };

            harryTux.swim();
            harryTux.walk();
            harryTux.slide();


        }
    }
}
