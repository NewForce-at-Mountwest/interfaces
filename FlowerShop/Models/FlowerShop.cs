using System;
using System.Collections.Generic;

namespace interfaces
{
    class FlowerStore
    {
        public List<Rose> createRoseBouquet()
        {
            return new List<Rose>(){
                new Rose(){
                    color = "Red",
                    species = "Florabunda",
                    stemLength = 4,
                    doesItSmellNice = true,
                    isItThorny = true
                },
                 new Rose(){
                    color = "White",
                    species = "Florabunda",
                    stemLength = 6,
                    doesItSmellNice = true,
                    isItThorny = true
                },
            };

        }

        public List<Daisy> createDaisyBouquet()
        {
            return new List<Daisy>(){
                new Daisy(){
                    stemLength = 4,
                    doesItSmellNice = true,
                },
                 new Daisy(){
                    stemLength = 6,
                    doesItSmellNice = true,
                },
            };
        }

        public List<Carnation> createCarnationBouquet()
        {
            return new List<Carnation>(){
                new Carnation(){
                    stemLength = 4,
                    doesItSmellNice = true,

                },
                 new Carnation(){
                    stemLength = 6,
                    doesItSmellNice = true,

                },
            };
        }

        public List<Tulip> createTulipBouquet()
        {
            return new List<Tulip>(){
                new Tulip(){
                    stemLength = 4,
                    doesItSmellNice = true,
                },
                 new Tulip(){
                    stemLength = 6,
                    doesItSmellNice = true,
                },
            };
        }

        public List<IMothersDayFlower> createMothersDayBouquet(){
            return new List<IMothersDayFlower>(){
                new Daisy(){
                    stemLength = 6,
                    doesItSmellNice = true
                },
                new Carnation(){
                    stemLength = 7,
                    doesItSmellNice = false
                }
            };
        }

        public List<IWeddingFlower> createWeddingBouquet(){
            return new List<IWeddingFlower>(){
                new Daisy(){
                    stemLength = 6,
                    doesItSmellNice = true
                },
                new Rose(){
                    stemLength = 7,
                    doesItSmellNice = false
                }
            };
        }



    }
}
