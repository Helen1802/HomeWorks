Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 1000;
int n2 = n /100 % 10;
int n3 = n /10 % 10;
int n4 = n % 10;
Console.WriteLine(n1+n2+n3+n4); 