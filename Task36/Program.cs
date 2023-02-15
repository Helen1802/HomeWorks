Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int i = 0;
for (i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101); 
Console.WriteLine($"[{string.Join(", ", array)}]");
int sum = 0;

for (int z = 1; z < array.Length; z+=2)
    sum = sum + array[z];

    Console.WriteLine($"сумма элементов cтоящих на нечётных позициях = {sum}");

