// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите высоту матрицы: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину матрицы: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[M, N];
FillArray(array);
PrintArray(array);
FindSmallerLine(array);

void FindSmallerLine(int[,] matr)
{
    int sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum += matr[0, j];
    }
    int min = sum;
    sum = 0;
    int line = 1;

    for (int i = 1; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        if (sum < min)
        {
            min = sum;
            sum = 0;
            line = i + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {line} строка");
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
