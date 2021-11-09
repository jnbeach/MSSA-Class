using System;

namespace School
{
    struct Address
    {
        // Fields
        public string Street;
        public string City;
        public string State;
        public string ZipCode;

        public void printAddress()
        {
            Console.WriteLine($"{this.Street}");
            Console.WriteLine($"{this.City}, {this.State} {this.ZipCode}");
        }

    }
    struct Contact
    {
        public string PhoneNumber;
        public string Email;
        public void printContact()
        {
            Console.WriteLine($"{this.PhoneNumber} {this.Email}");
        }
    }

}