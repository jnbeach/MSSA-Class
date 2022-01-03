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
    switch (figure)
    {
        case "c":
            area = calculateCircleArea();
            break;
        case "t":
            area = calculateTriangleArea();
            break;
        case "r":
            area = calculateRectangleArea();
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

static double calculateTriangleArea()
{
    double a, b, c, s;
    double answer = -1;
    Console.WriteLine($"Triangle selected.");
    Console.WriteLine($"Please provide me the lengths for all 3 sides:");
    Console.WriteLine($"Side a");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Side b");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Side c");
    c = Convert.ToDouble(Console.ReadLine());

    //Heron's formula
    s = (a + b + c) / 2;
    answer = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

    return answer;
}

static double calculateRectangleArea()
{
    double a, b;
    Console.WriteLine($"Rectangle selected.");
    Console.WriteLine($"Please provide me the lengths for both sides:");
    Console.WriteLine($"Side a");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Side b");
    b = Convert.ToDouble(Console.ReadLine());

    double answer = a * b;
    return answer;
}

static double calculateCircleArea()
{
    double r;
    Console.WriteLine($"Circle selected.");
    Console.WriteLine($"Please provide me the radius of the circle:");
    Console.WriteLine($"Radius r");
    r = Convert.ToDouble(Console.ReadLine());

    double answer = Math.PI * (Math.Pow(r, 2));
    return answer;
}