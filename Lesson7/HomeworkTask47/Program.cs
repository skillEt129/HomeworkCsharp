// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


 Console.Write("Введите количество строк: ");
 int rows = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите количество столбцов: ");
 int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetArray(int m, int n)
 {
     double[,] randomArray = new double[m, n];
     for (int i = 0; i < randomArray.GetLength(0); i++)
     {
        for (int j = 0; j < randomArray.GetLength(1); j++)
         {
             randomArray[i, j] = new Random().NextDouble();
         }
     }
     return randomArray;
 }
 PrintArray(GetArray(rows, columns));
 void PrintArray(double[,] arr)
 {
     for (int i = 0; i < arr.GetLength(0); i++)
     {
         for (int m = 0; m < arr.GetLength(1); m++)
         {
             Console.Write(Math.Round(arr[i, m], 2) + "\t");
         }
         Console.WriteLine();
     }
 }