Console.Clear();
Console.Write("Enter a five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 9999 || n > 100000)
{
    Console.Write("Wrong!\nEnter a five-digit number: ");
    n = Convert.ToInt32(Console.ReadLine());    
}

int n1 = (n / 10000) % 10;
int n2 = (n / 1000) % 10; 
int n4 = (n / 10) % 10; 
int n5 = n % 10; 

if (n1 == n5 && n2 == n4)
{
    Console.WriteLine("Yes! It's a palindrome!");
}
else 
{
    Console.WriteLine("No");
}