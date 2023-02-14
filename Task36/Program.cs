int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100,101); // [-100; 100]
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(array[1]+array[3]);
