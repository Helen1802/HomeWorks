int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100,101); // [-100; 100]
Console.WriteLine($"[{string.Join(", ", array)}]");
int max = array[0];
if(array[1] > max) max = array[1];
if(array[2] > max) max = array[2];
if(array[3] > max) max = array[3];
if(array[4] > max) max = array[4];
if(array[5] > max) max = array[5];
int min = array[0];
if(array[1] < min) min = array[1];
if(array[2] < min) min = array[2];
if(array[3] < min) min = array[3];
if(array[4] < min) min = array[4];
if(array[5] < min) min = array[5];
Console.WriteLine(max-min);