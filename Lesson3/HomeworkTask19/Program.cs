// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
void Palindrome(int num)
{
    Console.Write(num + " -> ");
    int xa = num;
    int xb = 0;
    while (num > 0)
    {
        xb = xb * 10 + num % 10;
        num = num / 10;

    }
    if (xa == xb)
        Console.Write("Палиндром");
    else
        Console.Write("Не палиндром");
}
Palindrome(num);