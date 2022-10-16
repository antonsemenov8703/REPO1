// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А и Б: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

double Exponent(int number, int degree)
{
    double result = 1;
    if(B < 0)
    {
        Console.WriteLine("Было введено ненатуральное число.");
    } 
    else
    {
        for (int i = 0; i < degree; i++)
        {
            result = result * number;
        }
    }
    return result;
}
Console.WriteLine(Exponent(A, B));
// Пока при отрецательном значении степени выводится надпись, но кроме неё значение result=1