// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите число А");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i != secondNumber; i++)
{
    result *= firstNumber;

}
Console.WriteLine(result);