// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

bool ValidNum(int num)
{
    if (num < 0)
    {
        Console.WriteLine("Введите натуральное число: ");
        return false;
    }
    return true;
}
double Exponent(int number, int degree)
{
    double result = 1;
    for (int i = 0; i < degree; i++)
    {
        result = result * number;
    }
    return result;
}
if (ValidNum(B)) Console.WriteLine($"Число {A} в степени {B} = {Exponent(A, B)}");



