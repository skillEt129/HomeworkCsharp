﻿// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
string NUMBERS(int num)
{
    string result = String.Empty;
    while (num > 0)
    {
        result += Convert.ToString((num % 2));
        num /= 2;
    }
    result = new string (result.Reverse().ToArray());
    return  result;
}
Console.Write("Input number to convert in NUMBERS: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your number in the binary numeral system = {NUMBERS(num2)}");