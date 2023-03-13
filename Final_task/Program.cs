//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
//клавиатуры, либо задать на старте выполнения алгоритма.При решении не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] words = {"1234", "1567","-2", "computer science"};
var shortWords=new string[words.Length];
var count = 0;
foreach(var element in words)
{ 
    if(element.Length <= 3)
       {
         shortWords[count]=element;
         count++;
       }
   }    
Console.WriteLine(string.Join(Environment.NewLine, shortWords, 0, count));  
