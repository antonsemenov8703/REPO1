﻿// Task 0
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

/*
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
*/



/*
// Задача № 31 массив из 12 элементов, рандомными числами из промежутка (-9,9) включительно. 
// Найти сумму положительных и отрицательных элементов массива.

void FillArray(int[]collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index]=new Random().Next(-9,10); //new создаёт новый объект
    }
}

void PrintArray(int[]col)
{
    int count = col.Length;
    for (int position = 0;position<count;position++)
    {
        Console.Write(col[position]+" ");
    }
}

int[]array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int length = array.Length;
int sumPositive = 0;
int sumNegative = 0;
for (int i =0; i < length; i++)
{
    if (array[i] < 0)
    {
        sumNegative += array[i]; //sum=sum+col[i] тоже самое
    }
    else
    {
        sumPositive += array[i];
    }
}
Console.WriteLine($"Сумма положительных элементов массива = {sumPositive}");
Console.WriteLine($"Сумма отрецательных элементов массива = {sumNegative}");
*/

/*
// Задача № 32 Замена элемента массива: положительные элементы заменить на соответствующие 
// отрицательные, и наоборот.
// [-4,-8,8,2]>[4, 8.-8,-2]

void FillArray(int[]array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1); 
    }
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
} 

void ChangeSign (int []arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = arr[i]*-1; 
    } 
}

int[] array = new int[12];
FillArray(array,-10,10);
PrintArray(array);
ChangeSign(array);
PrintArray(array);
*/

/*
// Задача №33 
// Задать массив. Программа определяет, присутствует ли заданное число в массиве
 
void FillArray(int[]array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1); 
    }
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
} 

bool Poisk (int [] arr, int n)
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++ )
    {
        if (arr[i] == n) result = true;
    }
    return result;
}

int[] array = new int[12];
FillArray(array,1,100);
PrintArray(array);

Console.WriteLine("Введите число для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());

// if (Poisk(array,num) == true) Console.WriteLine($"В массиве присутствует цифра {num}");
// else Console.WriteLine($"В массиве нет цифры {num}");

string result = Poisk(array,num)? $"В массиве присутствует цифра {num}" : $"В массиве нет цифры {num}";
Console.WriteLine(result);
// эта форма записи возможна из-за того, что переменной result присваивается возращённое 
// значение метода булеего типа. Запись через ? через : перечисляется true , потом false

*/

/*

// Задача №35 
// Задать одномерный массив из 123 случайных чисел. Найти кол-во элементов массива,
// значения которых лежат в промежутке [10,99]

int[] array = new int[123];
FillArray(array,1,99);
PrintArray(array);

void FillArray(int[]array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1); 
    }
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
} 

int count=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    {
    count++;
    }
}
Console.WriteLine(count);
*/


/*
// Задача №37 
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считать первый и последний элемент, второй и предпоследний элемент.
// Результат записать в новом массиве.

int len = new Random().Next(5,10);
Console.WriteLine(len);
int [] array = new Int32[len];

double half = Math.Ceiling((Convert.ToDouble(len) / 2)); //это округление
Console.WriteLine(half); 
int [] newArray = new Int32[Convert.ToInt32(half)];


FillArray(array,1,len);
PrintArray(array);

void FillArray(int[]array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1); 
    }
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
} 

void Poisk (int [] arr)
{
    for (int i = 0; i < arr.Length/2; i++ )
    { 
        newArray[i] = arr[i]*arr[arr.Length-i-1];
    }
    if(arr.Length%2!=0)
    {
        newArray[arr.Length/2] = arr[arr.Length/2];
    }
}
Poisk(array);
PrintArray(newArray);
*/


/*
// Задача 39
// Программа переворачивает массив (последний элемент на первом месте, первый на последнем)


int [] array = new int [11];

void FillArray(int[]array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1); 
    }
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
} 

void ChangePlace (int [] arr1)
{
    for (int i = 0; i < arr1.Length/2; i++)
    {
        int t = arr1[i];
        arr1[i] = arr1[arr1.Length-1-i];
        arr1[arr1.Length-1-i] = t;
    }
}

FillArray(array,1,100);
PrintArray(array);
ChangePlace(array);
PrintArray(array);


*/


/*
// Задача №40
// Принимает на вход 3 числа и проверяет, может ли существовать треугольник со 
// сторонами такой длины. Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других.

Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a<b+c && b<a+c && c<a+b)
{
    Console.WriteLine($"Треугольник со сторонами: {a}, {b}, {c} может существовать ");
} 
else    
    Console.WriteLine($"Треугольник со сторонами: {a}, {b}, {c} не может существовать ");

*/


// Задача №42
// Программа, которая будет преобразовывать десятичное число в двоичное.

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int num = a;
// int reminder = 0;
// int result = 0;
//     for (int i = 1; num>0; i=i*10)
//     {
//         reminder = num%2;
//         num = num/2;
//         result += reminder*i;
//     }
// Console.WriteLine($"Число {a} в двоичной системе счисления = {result} ");

/*
// Другой вариант решения


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string count = null;
while (number !=0)
{
    count += number %2;
    number /=2; // number = number/2
}
for (int i = count.Length - 1; i >= 0; i--)
{
    Console.Write(count[i]);
}
*/

/*
// Задача 44: 
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Число Фибоначчи - каждое число - это сумма двух предыдущих
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int first = 0;
int second = 1;
int fib = 0;
if (number ==0) Console.WriteLine(first);
else if (number ==1) Console.WriteLine($"{first} , {second} ");
else 
{
    Console.Write($"{first} , {second} ");
    for(int i = 2; i < number; i++)
    {
        fib = first+second;
        first = second;
        second = fib;
        Console.Write($", {fib} ");
    } 
}

*/

/*
// Задача 45: 
// Напишите программу, которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.

void FillArray(int[]array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1); 
    }
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
} 

int [] array = new int [10];
int [] array2 = new int [10];

FillArray (array,1,10);
PrintArray (array);
CopyArray(array, array2);
PrintArray (array2);

void CopyArray (int [] arr, int [] arr2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i] = arr[i];
    }
}

// Так же можно было сделать:
// int [] ArrayCopy ( int [] array)
// {
//     int [] ResArr = new int [length];
//     for (int i=0; i < length; i++)
//     {
//         ResArr[] = array [i];
//     }
//     return ResArr;
// }

*/