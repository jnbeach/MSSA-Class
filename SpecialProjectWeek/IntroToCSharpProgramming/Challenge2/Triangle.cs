namespace Challenge2
{
    class Triangle : Shape
    {
        public override double CalculateArea()
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
    }
}
