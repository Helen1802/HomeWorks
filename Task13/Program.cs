Console.Clear();
Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
if (n<100)
   Console.WriteLine("Третьей цифры нет");
      else
      {
        while (n>=1000)
        {
        //уменьшаем порядок числа
           int n1=n/10;
           n=n1;
        }
      Console.WriteLine(n%10);
      }

