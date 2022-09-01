
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

 int[,] GetArray()
{
    int[,] arr = new int[new Random().Next(5), new Random().Next(5)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(11);
            Console.Write(arr[i, j] + "\t ");
        }
        Console.WriteLine();
    }
    return arr;
}
double[] MAS(int[,] ar)
{
    double sum = 0;
    int size = ar.GetLength(0);
    double[] average = new double[ar.GetLength(1)];
    int x = 0;
    for (int i = 0; i < average.Length; i++)
    {
        for (int j = 0; j < ar.GetLength(0); j++)
        {
            sum += ar[j, x];
            for (int g = 0; g < ar.GetLength(1); g++)
            {
                average[i] = sum / size;
            }
        }
        x++;
        sum = 0;
    }
    return average;
}
void PrintMAS(double[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(Math.Round(a[i], 2) + "\t ");
    }
    Console.WriteLine();
}
PrintMAS(MAS(GetArray()));