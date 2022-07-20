// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
 



int [] array = new int [4];

     var rnd = new Random();
     int index = 0;
    while(index < array.Length){
         array[index] = rnd.Next(-30, 100);
         Console.Write($"{array[index]} ");
         index++;
     }
int i = 1;
int sum = 0;
foreach (int z in array){
    if ((i % 2)==1)
    sum +=z;
    i ++;

}
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна = " + sum);