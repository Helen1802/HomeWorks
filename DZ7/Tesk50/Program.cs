void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите индекс строки: ");
int rows= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int colums= Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[6, 6];// Console.WriteLine("Введите размер массива: "); //int[] matrix = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
InputMatrix(matrix);
PrintMatrix(matrix);
if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) 
    Console.WriteLine(matrix[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");



