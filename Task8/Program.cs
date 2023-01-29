Console.Clear();
Console.Write("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=0;
while(i+1<N)
{
    i+=2;
    Console.Write(i);
}

