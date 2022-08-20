// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 0; num / 10 != 0; i++)
{
    result += num % 10;
    num /= 10;
}

result += num;
Console.WriteLine(result);
