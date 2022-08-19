// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату по оси Х точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y точки А: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Х точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси Y точки А: ");
int zB = Convert.ToInt32(Console.ReadLine());

// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2).
double distance = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));

Console.WriteLine($"distance = {Math.Round(distance, 2)}");
