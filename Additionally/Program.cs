Console.Clear();
int N = new Random().Next(3, 1001);
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 1001); 
int s = array[0] + array[1] + array[2];
for (int a = 1; a < N - 1; a++)
if (array[a-1]+array[a]+array[a+1]>s) s = array[a-1]+array[a]+array[a+1];

for (int j = 0; j < array.Length; j++)
Console.Write($"{array[j]}, "); //выводил массив для проверки
Console.WriteLine();
Console.WriteLine($"Maximum number of berries: {s}");