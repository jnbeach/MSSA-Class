namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape Calculator");
            Console.WriteLine("---------------------------------\n");
            string? figure;
            string? state = "y";
            double area;

            Console.WriteLine($"This is a Shape Calculator");

            while (state != "n")
            {
                Console.WriteLine($"What figure do you wish to calculate? C = Circle, T = Triangle, R = Rectangle");
                figure = Console.ReadLine().ToLower();
                Circle newCircle = new Circle();
                Triangle newTriangle = new Triangle();
                Rectangle newRectangle = new Rectangle();

                switch (figure)
                {
                    case "c":
                        area = newCircle.CalculateArea();
                        break;
                    case "t":
                        area = newTriangle.CalculateArea();
                        break;
                    case "r":
                        area = newRectangle.CalculateArea();
                        break;
                    default:
                        Console.WriteLine($"I did not understand your input. Please try again.");
                        area = -1;
                        break;
                }
                Console.WriteLine($"The area of the shape is equal to: {area}");

                Console.WriteLine($"Would you like to continue calculating areas? y/n");
                state = Console.ReadLine();
            }
        }
    }
}


