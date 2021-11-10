using System;

namespace Zoo
{
    // Derived class
    class Bird : Pet, IPet
    {
        public string petTrait1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string petTrait2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string petTrait3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IPet.name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IPet.owner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void communicate()
        {
            Console.WriteLine(this.voice);
        }
    }
}