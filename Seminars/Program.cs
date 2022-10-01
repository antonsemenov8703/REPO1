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

/*
// Task 3.1 второй вариант с оператором "switch case"
Console.WriteLine("Введите число от 1 до 7 ");
int weakDay = Convert.ToInt32(Console.ReadLine());
while (weakDay<1|weakDay>7)
{
    Console.WriteLine("Вы ввели недопустимый номер. Введите число от 1 до 7 ");
    weakDay = Convert.ToInt32(Console.ReadLine());
}
switch(weakDay)
{
    case 1:Console.WriteLine("понедельник");
    break;
    case 2:Console.WriteLine("вторник");
    break;
    case 3:Console.WriteLine("среда");
    break;
    case 4:Console.WriteLine("четверг");
    break;
    case 5:Console.WriteLine("пятница");
    break;
    case 6:Console.WriteLine("суббота");
    break;
    case 7:Console.WriteLine("воскресенье");
    break;
        /*  "Эти две строчки оказались ненужными. И без них корректно работает.
        default:Console.WriteLine("Вы ввели недопустимый номер. Введите число от 1 до 7 ");
        break;
        
}
*/

/*
// Task 5
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежуткеот -N до N
// 4-> "-4 -3 -2 -1 0 1 2 3 4"
// 2-> "-2 -1 0 1 2"
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int i= -n;
while (i<=n)
{
    Console.Write(Convert.ToString(i)+" ");
    i++;
}
*/

/*
// Task 7
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
// 456->6, 782->2, 918->8
Console.WriteLine("Введите трёхзначное число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<100|n>999)
{
    Console.WriteLine("Вы ввели неправильное число. Введите трёхзначное число ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Convert.ToString(n%10));
}
else 
{
    Console.WriteLine(Convert.ToString(n%10));
}
*/

// Task 7.1 через While
Console.WriteLine("Введите трёхзначное число ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<100|n>999)
{
    Console.WriteLine("Вы ввели неправильное число. Введите трёхзначное число ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Последняя цифра числа"+" "+ n +" " +Convert.ToString(n%10));
