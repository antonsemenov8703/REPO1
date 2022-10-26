// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите высоту матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(new Random().Next(-100, 100) * 0.1, 2);
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            switch(Convert.ToString(array[i,j]).Length)
            {
                case 1:Console.Write($"   {array[i, j]} ");
                break;
                case 2:Console.Write($"  {array[i, j]} ");
                break;
                case 3:Console.Write($" {array[i, j]} ");
                break;
                case 4:Console.Write($"{array[i, j]} ");
                break;
            }
        }
        Console.WriteLine();
    }
}