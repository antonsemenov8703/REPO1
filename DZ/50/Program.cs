// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого элемента в массиве нет

Console.WriteLine("Введите высоту матрицы: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину матрицы: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер строки элемента, значение которого нужно найти: ");
int findM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента, значение которого нужно найти: ");
int findN = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[M, N];
FillArray(array);
PrintArray(array);

if (findM > M || findN > N)
{
    Console.WriteLine($"Элемента с позицией ({findM} : {findN}) нет в этой матрице");
}
else 
{
    Console.WriteLine($"Элемент ({findM} : {findN}) = {array[findM-1,findN-1]}");
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

