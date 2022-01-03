namespace Challenge2
{
    class Circle : Shape
    {
        public override double CalculateArea()
        {
            double r;
            Console.WriteLine($"Circle selected.");
            Console.WriteLine($"Please provide me the radius of the circle:");
            Console.WriteLine($"Radius r");
            r = Convert.ToDouble(Console.ReadLine());

            double answer = Math.PI * (Math.Pow(r, 2));
            return answer;
        }
    }
}

