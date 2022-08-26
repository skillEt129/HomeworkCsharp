// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[4];
int arraySize = array.Length;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine($"[{string.Join(",", array)}]");
 int m = 0;
for (int j = 0; j < arraySize; j++)
{

    array[j] = array[j] % 2;
    Console.WriteLine($" {array[j]}");
             if(array[j] % 2 == 0)
             m++;
}
Console.Write("Количество четных чисел в массиве: " + m);