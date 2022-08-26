// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



int[] array = new int[4];
int arraySize = array.Length;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
}
Console.WriteLine($"[{string.Join(",", array)}]");
 int sum = 0;
 
    for(int i = 1; i < array.Length; i +=2)
    {
        sum += array[i];
    
    }
    Console.Write("Сумма на нечетных позициях: " + sum);
