// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int [] array = new int[4];
int index = 0;
while(index< array.Length)
{
    array[index] = new Random().Next(100, 999);
    index++;
}

var rnd = new Random();
while(index < array.Length)
{
    array[index] = rnd.Next(100, 999);
    index++;
}
for (int i = 0; i < array.Length; i++)
{
    if (i==0) Console.Write("[");
    if (i< array.Length -1) Console.Write(array [i] + ", ");
    else Console.Write(array[i] + "]");
}
Console.WriteLine();
int evensCount = array.Count(n => n% 2 == 0);

Console.WriteLine($"Количество положительных чисел в массиве равна = {evensCount}");
