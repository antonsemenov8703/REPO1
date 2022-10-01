// Task 0
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)
// Например 4->16, -3->9, -7->49

/*
Console.WriteLine("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine()); //ToInt32-конвертирует строчно записанное значение в цифровое целое
Console.WriteLine(n*n);
*/

// Task 1
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// a=25, b=5 ->да  a=2, b=10 ->нет, a=9, b=-3 ->да, a=-3, b=9 -> нет

/*
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == (b*b))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
*/

// Task 3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3->среда, 5->пятница

/*
Console.WriteLine("Введите число от 1 до 7 ");
int weakDay = Convert.ToInt32(Console.ReadLine());
while (weakDay<1|weakDay>7)
{
    Console.WriteLine("Вы ввели недопустимый номер. Введите число от 1 до 7 ");
    weakDay = Convert.ToInt32(Console.ReadLine());
}
if (weakDay==1) Console.WriteLine("Понедельник");
if (weakDay==2) Console.WriteLine("Вторник");
if (weakDay==3) Console.WriteLine("Среда");
if (weakDay==4) Console.WriteLine("Четверг");
if (weakDay==5) Console.WriteLine("Пятница");
if (weakDay==6) Console.WriteLine("Суббота");
if (weakDay==7) Console.WriteLine("Воскресенье");

*/