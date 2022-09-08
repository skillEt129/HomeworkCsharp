// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int SumNumber(int m, int n, int sum)
{
    sum = n;
    if (m == n)
        return sum;
    return (sum + SumNumber(m, n - 1, sum));
}
Console.WriteLine($"{SumNumber(m, n, 0)}");