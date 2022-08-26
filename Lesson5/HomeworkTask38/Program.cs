// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[30];
int arraySize = array.Length;
int max = 0, min = 100;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100);
}
Console.WriteLine($"[{string.Join(",", array)}]");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}


Console.WriteLine($"max: {max} min: {min}");
Console.WriteLine("Разница максимального и минимального:  " + (max - min));
