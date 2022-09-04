// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int rowsAmt, int colsAmt, int minVal, int maxVal)
{
    int[,] array = new int[rowsAmt, colsAmt];
    for (int i = 0; i < rowsAmt; i++)
    {
        for (int j = 0; j < colsAmt; j++)
        {
            array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    PrintArray(array);
    Console.WriteLine();
    return array;
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[] ArrayParametersInput()
{
    int rows = 0, cols = 0;

    while (true)
    {
        Console.Write("Введите количество строк (начиная с 1): ");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов (начиная с 1): ");
        cols = Convert.ToInt32(Console.ReadLine());
        if (rows > 0 && cols > 0)
            break;
        else
            Console.WriteLine("Количество и строк и столбцов должно быть больше 0. Пожалуйста повторите попытку.");
    }

    Console.Write("Введите нижнюю границу диапазона значений: ");
    int lowerValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите верхнюю границу диапазона значений: ");
    int upperValue = Convert.ToInt32(Console.ReadLine());

    int[] paramsOut = { rows, cols, lowerValue, upperValue };
    return paramsOut;
}

int LesserStringSum(int[,] matrix)
{
    int stringSum = 0, minStringSum = 0, rowIndex = 1;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        stringSum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == 0)
            {                
                minStringSum += matrix[i, j];
                stringSum += matrix[i, j];
            }
            else
                stringSum += matrix[i, j];
        }
        if(minStringSum > stringSum)
        {
            rowIndex = i + 1;
            minStringSum = stringSum;
        }
     }
    return rowIndex;
}
int[] arrayParameters = ArrayParametersInput();
int result = LesserStringSum(CreateArray(arrayParameters[0],    
                                         arrayParameters[1],    
                                         arrayParameters[2],    
                                         arrayParameters[3]     
                                         ));
Console.WriteLine($"Наименьшая сумма элементов в {result} строке.");