using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h_mx_l = new Human("Leon", "Maldonado", 25);

            Console.WriteLine($"New human's name: {h_mx_l.first_name}");

            // Get human's favorite number in 2 lines of code
            Console.WriteLine($"{h_mx_l.first_name}'s favorite number is: {h_mx_l.sayFavoriteNumber()}");

            // Create a food variable with any value and send it to a favoriteFood method and then print the human's favorite food
            string faveFood = "Pizza";
            h_mx_l.favoriteFoodIs(faveFood);
            Console.WriteLine($"{h_mx_l.first_name}'s favorite food is: {h_mx_l.favoriteFood}");

            // Create a boolean variable named closed_love_letter and send it to a openLoveLetter method, but don't allow the human to change the boolean value to false (to open the letter)
            
            
            bool closed_love_letter = true;
            h_mx_l.openLoveLetter(closed_love_letter);
        }

    }
}
