﻿// Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// А В
// 1 4 | 3 5
// 3 5 | 1 2

// Результирующая матрица будет:
// С
// 7 13
// 14 25

// Произведением двух матриц А и В называется матрица С, элемент которой, 
// находящийся на пересечении i-й строки и j-го столбца, равен сумме произведений 
// элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.

// С (0,0) = А(0,0) * B(0,0) + A(0,1) * B(1,0) = 1 · 3 + 4 · 1 = 3 + 4 = 7
// С (0,1) = А(0,0) * B(0,1) + A(0,1) * B(1,1) = 1 · 5 + 4 · 2 = 5 + 8 = 13
// С (1,0) = А(1,0) * B(0,0) + A(1,1) * B(1,0) = 3 · 3 + 5 · 1 = 9 + 5 = 14
// С (1,1) = А(1,0) * B(0,1) + A(1,1) * B(1,1) = 3 · 5 + 5 · 2 = 15 + 10 = 25
// Произведение двух матриц АВ имеет смысл только в том случае, 
// когда число столбцов матрицы А совпадает с числом строк матрицы В.

// В произведении матриц АВ число строк равно числу строк матрицы А , 
// а число столбцов равно числу столбцов матрицы В.

Console.WriteLine("Введите высоту матрицы: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину матрицы: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[M, N];
int[,] resultArray = new int[,]; //to correct
FillArray(array);
PrintArray(array);
PrintArray(resultArray);

int ArrayProduct(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

        }
    }
}


return 
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
