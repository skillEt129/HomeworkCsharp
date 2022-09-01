// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.WriteLine("Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[3,4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i,j] = new Random().Next(10);
        Console.Write(matrix[i,j]+ "\t");
    }
    Console.WriteLine();
}
if (num1 < 0 || num1 > 3 && num2<0 || num2 > 4)
    Console.WriteLine("такого числа в массиве нет");
else
    Console.WriteLine($" {matrix[num1,num2]} ");