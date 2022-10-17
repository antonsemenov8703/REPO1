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

/*
// Task 7.1 через While
Console.WriteLine("Введите трёхзначное число ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<100|n>999)
{
    Console.WriteLine("Вы ввели неправильное число. Введите трёхзначное число ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Последняя цифра числа"+" "+ n +" " +Convert.ToString(n%10));
*/

/*
Console.WriteLine("enter number");
int n = Convert.ToInt32(Console.ReadLine());
int max = n;
while(-n<=max)
{
    if(n%2 == 0)
    {
        Console.Write(-n + " ");
        n--;
    }
    else 
    {
        Console.Write(-n + " ");
        n--;
    }
}
*/

/*
// Task №9 Написать программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

int a = new Random().Next(10,99);
    Console.WriteLine(a);
int first = a / 10;
int second = a %10;
if (first > second)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(second);
}
*/

/*
// Task №11 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цыфру.
int a = new Random().Next(100,999);
    Console.WriteLine(a);
int first = a/100;
int third = a%10;
int number = first*10+third;
    Console.WriteLine(number);
*/

/*
//Task №12 Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
//if(a==0) Console.WriteLine("Введите число отличным от нуля ");
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
//if(b==0) Console.WriteLine("Введите число отличным от нуля ");
if (b%a==0)
{
    Console.WriteLine(b + " делится на " + a);
}
else 
{
    Console.WriteLine(b + " не делится на " + a);
    Console.WriteLine(b%a);
}
*/

/*
// Task №14 
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a%7==0 & a%23==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}
*/

/*
//Task №16 Напишите программу, которая принимает на вход 2 числа и определяет, является ли одно число квадратом другого.
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if(a*a==b|b*b==a)
{
    Console.WriteLine("Да ");
}
else
{
    Console.WriteLine("Нет ");
}
*/

//Task 
/*
Console.WriteLine("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());
if(x>0&y>0)
{
    Console.WriteLine("Область 1  ");
}
else if(x<0&y>0)
{
    Console.WriteLine("Область 2  ");
}
else if(x<0 & y<0)
{
    Console.WriteLine("Область 3  ");
}
else if(x>0&y<0)
{
    Console.WriteLine("Область 4  ");
}
*/

/*
//Task 18 По номеру четверти показать диапазон

Console.WriteLine("Введите номер четверти ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<=0|n>4)
{
    Console.WriteLine("Введите число от 1 - 4 ");
}
else
{
    switch(n)
    {   
    case 1: Console.WriteLine("Диапазон x>0, y>0 ");
    break;
    case 2: Console.WriteLine("Диапазон x<0, y>0 ");
    break;
    case 3: Console.WriteLine("Диапазон x<0, y<0 ");
    break;
    case 4: Console.WriteLine("Диапазон x>0, y<0 ");
    break;
    }
}
*/

/*
//Task №21 На вход координаты 2 точек и найдём расстояние между ними
// a(3.6) b(2.1) -> 5.09  формула АВ=/(xb-xa) в квадрате + (ya-yb)в квадрате
Console.WriteLine("Введите координаты точки A ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Расстояние между точками" + Math.Round(Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)),2)); // двойка в конце - это для округления
*/


/*
//Task №22 на вход N и выдаёт квадраты чисел от 1 до N

bool one = true; //это означает, что если не корректный ввод, то мы ещё раз запрашиваем ввод
while (one) // это потому, что в try есть приравнивание к false
{
    try
    {
        Console.WriteLine("Введите число ");
        int N = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        while (count<=N)
        {
            Console.Write( Math.Pow (count, 2)+" ");
            count++;
        }
        one = false;
    }
    catch
    {
        Console.WriteLine("Введите число ");
        // если бы тут был false, то уже не выволнялась бы проверка
    }
}
*/
/*
//Задача 24 на вход А и выдаёт сумму чисел от 1 до А

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
//int a = int.Parse(Console.ReadLine()); ещё один способ выполнить конвертацию. отличие что мы парсим в тип интеджер. а в конверт мы указываем куда ещё мы можем конвертировать
int sum = 0;
for(int i = 1;i<=a;i++)
{
    sum = sum + i;
   // sum +=i; другой вариант записи этого выражения
}
Console.WriteLine($"Сумма  :{sum} ");// доллар говорит о том, что внутри есть переменная!! в нашем случае sum
*/

/*
//Задача 26 программа принимает число и выдаёт кол-во цифр в числе
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());
int count = 0;
while (N>0)
{
    count+=1;
    N = N/10;
}
Console.WriteLine($"{count}");
*/

/*
//Это второй вариант записи
Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int length = number.Length;
Console.WriteLine(length);
*/
/*
//Задача 28 принимает N и выдаёт произведение от 1 до N
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
int result = multiply(num); //вызвали функцию и вернулись в неё и пошли дальше
Console.WriteLine(result);
int multiply(int number) //объявили функцию, она может быть в любом месте кода-в данном случае в конце кода
{
    int count = 1;
    for(int i=1;i<=number;i++)
    {
        count *=i;
    }
    return count;
}
*/


//Задача 30 выводит массив из 8 элементов, заполненный в случайном порядке нулями и единицами
//объявим массив
//заполним массив последовательно
//первая функция - заполняющая массив 0 и 1

//вторая функция, которая выводит массив

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2); //new создаёт новый объект
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        if (position < count - 1) Console.Write(", ");
        position++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);


/*


// Задача № 31 массив из 12 элементов, рандомными числами из промежутка (-9,9) включительно. Найти сумму положительных и отрицательных элементов массива.
// не доделана!!!

void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index]=new Random().Next(-9,10); //new создаёт новый объект
        index++;
    }
}

void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position]+" ");
        position++;
    }
}


void SumPositive(int[]col)
{
for(int i =0; i < length; i++)
{
    if (array[i] < 0)
    {

    }
}

    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position]+" ");
        position++;
    }
}


int[]array = new int[12];
FillArray(array);
PrintArray(array);

Недоделана задача 

*/

// Задача № 32 Замена элемента массива: положительные элементы заменить на соответствующие отрицательные, и наоборот.
// [-4,-8,8,2]>[4, 8.-8,-2]