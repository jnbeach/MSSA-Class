namespace Challenge2
{
    class Rectangle : Shape
    {
        public override double CalculateArea()
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
    }
}

