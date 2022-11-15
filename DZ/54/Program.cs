// Задача 54: 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите высоту матрицы: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину матрицы: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[M, N];
FillArray(array);
PrintArray(array);
Console.WriteLine("Отсортированная матрица: ");
//SortMinToMax(array);
SortMaxToMin(array);
PrintArray(array);

void SortMinToMax(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = matr.GetLength(1)-1; k > j; k--)
            {
                if (matr[i,j] > matr[i,k])
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temp;
                }                      
            }
        }
    }
}

void SortMaxToMin(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = matr.GetLength(1)-1; k > j; k--)
            {
                if (matr[i,j] < matr[i,k])
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temp;
                }                      
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
