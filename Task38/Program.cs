Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int i = 0;
for (i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101); 
Console.WriteLine($"[{string.Join(", ", array)}]");
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
        {
            max = array[j];
        }
    if (array[j] < min)
        {
            min = array[j];
        }
}
Console.WriteLine($"разница между максимальным и минимальным элементом массива = {max-min}");






//Console.WriteLine(max-min);