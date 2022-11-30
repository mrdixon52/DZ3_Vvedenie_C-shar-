Console.Clear();
Console.Write("Enter coordinate A: ");
double x1 = Convert.ToDouble(Console.ReadLine()), 
       y1 = Convert.ToDouble(Console.ReadLine()),
       z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinate B: ");
double x2 = Convert.ToDouble(Console.ReadLine()), 
       y2 = Convert.ToDouble(Console.ReadLine()),
       z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)));