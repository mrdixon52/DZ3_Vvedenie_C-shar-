Console.Clear();
Console.WriteLine("Enter number greater than 1: ");
int n = Convert.ToInt32(Console.ReadLine());
int d = 2;
while (n <= 1)
{
    Console.WriteLine("Wrong! Please enter a number greater than 1!");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Cubes of numbers from 1 to N: ");
for (int i = 1; i <= n; i++)
Console.Write($"{Math.Pow(i, 3)}, ");