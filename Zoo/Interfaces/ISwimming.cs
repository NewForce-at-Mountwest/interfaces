using System;

namespace interfaces{
    public interface ISwimming{

      void swim();

      int maximumDepth {get; set;}

      bool isMammal {get; set;}

      bool isSaltWater {get; set;}
    }
}