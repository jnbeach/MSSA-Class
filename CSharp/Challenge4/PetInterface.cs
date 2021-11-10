using System;

namespace Zoo
{
    // Interface example
    interface IPet
    {
        string name { get; set; }
        string owner { get; set; }
        string petTrait1 { get; set; }
        string petTrait2 { get; set; }
        string petTrait3 { get; set; }

        void readCollar() { }
        void communicate() { }
    }
}