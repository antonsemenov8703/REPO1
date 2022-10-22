// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

double a = (b2-b1);
double b = (k1-k2);
double x = a/b;

double c = (k2*b1 - k1*b2);
double d = (k2-k1);
double y = c/d;
if (b==0 || d==0) Console.WriteLine("Введены неверные значения");
else Console.WriteLine($"Точка пересечения прямых ({x} ; {y})");
