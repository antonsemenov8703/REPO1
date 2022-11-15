// Задача 58: 
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

// Console.WriteLine("Введите высоту матрицы #1: ");
// int M1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину матрицы #1: ");
// int N1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите высоту матрицы #2: ");
// int M2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину матрицы #2: ");
// int N2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[,] { { 1, 4 }, { 3, 5 } };
int[,] array2 = new int[,] { { 3, 5 }, { 1, 2 } };


// int[,] array1 = new int[M1, N1];
// int[,] array2 = new int[M2,N2]; 
int[,] resultArray = new int[    2     ,     2    ]; 

// FillArray(array1);
// FillArray(array2);
Console.WriteLine("Матрица №1: ");
PrintArray(array1);
Console.WriteLine("");
Console.WriteLine("Матрица №2: ");
PrintArray(array2);
Console.WriteLine("Результирующая матрица:");
ArrayProduct(array1,array2);
PrintArray(resultArray);

void ArrayProduct(int[,] matr1,int[,]matr2)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                resultArray[i,j] +=  matr1[i,k] * matr2[k,j]; 
            }
        }
        
    }
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
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
