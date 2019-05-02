using System;

namespace interfaces{
    public interface IFlying{
        void fly();

        int maximumHeight {get; set;}

        int speed {get; set;}

        bool hasFeathers {get; set;}
    }
}