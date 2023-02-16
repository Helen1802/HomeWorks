Console.Clear();
Console.Write("Введите колиство чисел: ");
int n = Convert.ToInt32(Console.ReadLine()),count = 0;
for (int i = 0; i < n; i++)
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
	    count ++;
}	
Console.WriteLine($"количество положительных чисел равно: {count}");
